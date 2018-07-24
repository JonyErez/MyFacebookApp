using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			fetchUserInfo();
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
		}

		private void populateFriendList()
		{
			listBoxFriends.Items.Clear();
			listBoxFriends.DisplayMember = "Name";

			foreach (User friend in m_LoggedInUser.Friends)
			{
				listBoxFriends.Items.Add(friend);
			}
		}

		private void listBoxFriends_SelectedValueChanged(object sender, EventArgs e)
		{
			if (listBoxFriends.SelectedItem is User selectedUser)
			{
				if (selectedUser.PictureNormalURL != null)
				{
					pictureBoxSelectedFriend.LoadAsync(selectedUser.PictureNormalURL);
				}
				else
				{
					pictureBoxSelectedFriend.Image = pictureBoxSelectedFriend.ErrorImage;
				}
			}
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
	}
}
