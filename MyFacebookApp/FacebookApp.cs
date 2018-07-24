using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp
{
	public partial class FacebookApp : Form
	{
		private readonly FormLogin r_Login = new FormLogin();
		private User m_LoggedInUser;
		private string m_AccessToken;

		public FacebookApp()
		{
			InitializeComponent();
		}

		private void FacebookApp_Load(object sender, EventArgs e)
		{
			r_Login.ShowDialog();
			fetchUserInfo();
		}

		private void fetchUserInfo()
		{
			m_AccessToken = r_Login.AccessToken;
			m_LoggedInUser = r_Login.LoggedInUser;
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
			User selectedUser = listBoxFriends.SelectedItem as User;

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
}
