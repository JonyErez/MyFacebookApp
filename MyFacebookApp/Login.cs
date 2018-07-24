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
	public partial class FormLogin : Form
	{
		private LoginResult m_LoginResult;
		private bool m_RememberUser = false;

		public User LoggedInUser
		{
			get { return m_LoginResult.LoggedInUser; }
		}

		public string AccessToken
		{
			get { return m_LoginResult.AccessToken; }
		}

		public bool RememberUser
		{
			get { return m_RememberUser; }
		}

		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			loginAndInit();
		}

		private void loginAndInit()
		{
			m_LoginResult = FacebookService.Login("419878648523017", "public_profile", "email", "user_friends", "user_photos", "user_birthday", "user_likes");

			if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
			{
				Close();
			}
			else
			{
				MessageBox.Show(m_LoginResult.ErrorMessage);
			}
		}

		private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
		{
			m_RememberUser = !m_RememberUser;
		}
	}
}
