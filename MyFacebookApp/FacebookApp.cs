using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp
{
	public partial class FacebookApp : Form
	{
		private AppSettings m_AppSettings;
		private User m_LoggedInUser;
		private string m_AccessToken;
		private bool m_RememberUser;

		public FacebookApp()
		{
			InitializeComponent();
		}

		private void FacebookApp_Load(object sender, EventArgs e)
		{
			m_AppSettings = AppSettings.LoadAppSettings();
			Location = m_AppSettings.Location;
			if (!m_AppSettings.RememberUser)
			{
				FormLogin login = new FormLogin();
				login.ShowDialog();
				m_RememberUser = login.RememberUser;
				m_LoggedInUser = login.LoggedInUser;
				m_AccessToken = login.AccessToken;
			}
			else
			{
				m_AccessToken = m_AppSettings.LastAccessToken;
				LoginResult loginResult = FacebookService.Connect(m_AccessToken);
				m_LoggedInUser = loginResult.LoggedInUser;
				m_RememberUser = m_AppSettings.RememberUser;
			}
		}

		private void fetchUserInfo()
		{

			populateFields();
		}

		private void populateFields()
		{
			Text = "Welcome " + m_LoggedInUser.FirstName + " " + m_LoggedInUser.LastName + "!";
			pictureBoxProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
			populateFriendList();
			populateEventsList();
			populateAlbums();
		}

		private void populateAlbums()
		{
			bindingSourceAlbums.DataSource = m_LoggedInUser.Albums;
		}

		private void populateEventsList()
		{
			try
			{
				bindingSourceEvents.DataSource = m_LoggedInUser.Events;
			}
			catch (Exception ex)
			{
				//Throws Auth Error: field 'location' has been depreciated since version 2.5 of the API
				MessageBox.Show("Couldn't fetch user events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateFriendList()
		{
			bindingSourceUser.DataSource = m_LoggedInUser.Friends;
		}

		private void FacebookApp_FormClosing(object sender, FormClosingEventArgs e)
		{
			m_AppSettings.LastAccessToken = m_RememberUser ? m_AccessToken : String.Empty;
			m_AppSettings.SaveAppSettings();
		}

		private void FacebookApp_LocationChanged(object sender, EventArgs e)
		{
			if (m_AppSettings != null)
			{
				m_AppSettings.Location = Location;
			}
		}

		private void FacebookApp_Shown(object sender, EventArgs e)
		{
			fetchUserInfo();
		}

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //loginByForm();
            //this.Visible = true;
        }
    }
}
