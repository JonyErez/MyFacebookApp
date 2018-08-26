using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using MyFacebookApp.Model.Properties;

namespace MyFacebookApp.Model
{
	public partial class FormLogin : Form
	{
		public LoginResult Result { get; private set; }

		public User LoggedInUser
		{
			get { return Result.LoggedInUser; }
		}

		public string AccessToken
		{
			get { return Result.AccessToken; }
		}

		public FormLogin()
		{
			InitializeComponent();
            setFacebookAppIcon();
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_EventArgs)
		{
			onButtonLoginClicked();
		}

		private void onButtonLoginClicked()
		{
			Result = FacebookService.Login("419878648523017", "public_profile", "email", "user_friends", "user_photos", "user_birthday", "user_likes", "manage_pages", "user_events", "user_hometown", "user_posts", "user_tagged_places", "user_location");
			if (!string.IsNullOrEmpty(Result.AccessToken))
			{
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show(Result.ErrorMessage);
			}
		}

        private void setFacebookAppIcon()
        {
            Bitmap bitIcon = Resources.FBicon;
            IntPtr pIcon = bitIcon.GetHicon();
            Icon iconFrom = Icon.FromHandle(pIcon);
            Icon = iconFrom;
        }
    }
}