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
        private FormLogin r_login;
        private AppSettings m_AppSettings;
		private User m_LoggedInUser;
        // i used the values that we have in AppSettings because otherwise we need to synch between all of the members
        // of them both and thats why we use desirialize ->
		//private string m_AccessToken; 
		//private bool m_RememberUser;

		public FacebookApp()
		{
			InitializeComponent();
		}

		private void FacebookApp_Load(object sender, EventArgs e)
		{
			m_AppSettings = AppSettings.LoadAppSettings();
			Location = m_AppSettings.Location;
            r_login = new FormLogin();          

            if (!m_AppSettings.RememberUser)
            {              
                r_login.ShowDialog();
            }
            else
			{
				LoginResult loginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);

                m_LoggedInUser = loginResult.LoggedInUser;
            }
            fetchUserInfo();
		}

        private void onLoginEvent()
        {
            m_AppSettings.RememberUser = r_login.RememberUser;
            m_LoggedInUser = r_login.LoggedInUser;
            m_AppSettings.LastAccessToken = r_login.AccessToken;
        }

        private void loginFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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
			m_AppSettings.LastAccessToken = m_AppSettings.RememberUser ? m_AppSettings.LastAccessToken : String.Empty;
			m_AppSettings.SaveAppSettings();
		}

		private void FacebookApp_LocationChanged(object sender, EventArgs e)
		{
			if (m_AppSettings != null)
			{
				m_AppSettings.Location = Location;
			}
		}

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            //loginByForm();
            //this.Visible = true;
        }
    }
}
