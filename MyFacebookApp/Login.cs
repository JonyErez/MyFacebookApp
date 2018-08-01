using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp
{
	public partial class FormLogin : Form
	{
		private LoginResult m_LoginResult;

		public User LoggedInUser
		{
			get { return m_LoginResult.LoggedInUser; }
		}

		public string AccessToken
		{
			get { return m_LoginResult.AccessToken; }
		}

		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object i_Sender, EventArgs i_EventArgs)
		{
			onButtonLoginClicked();
		}

		private void onButtonLoginClicked()
		{
			m_LoginResult = FacebookService.Login("419878648523017", "public_profile", "email", "user_friends", "user_photos", "user_birthday", "user_likes", "manage_pages", "user_events", "user_hometown", "user_posts", "user_tagged_places", "user_location");
			if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
			{
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show(m_LoginResult.ErrorMessage);
			}
		}
	}
}