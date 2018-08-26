using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.Model
{
	internal class AppData
	{
		public AppData()
		{
			Settings = AppSettings.LoadAppSettings();
		}

		public AppSettings Settings { get; private set; }

		public User LoggedInUser { get; private set; }

		private PostsStatistics m_PostsStatistics;

		public PostsStatistics PostsStatistics
		{
			get
			{
				if (m_PostsStatistics == null)
				{
					m_PostsStatistics = new PostsStatistics(LoggedInUser);
				}

				m_PostsStatistics.GenerateStatistics();

				return m_PostsStatistics;
			}

			private set { m_PostsStatistics = value; }
		}

		private PhotosStatistics m_PhotosStatistics;

		public PhotosStatistics PhotosStatistics
		{
			get
			{
				if (m_PhotosStatistics == null)
				{
					m_PhotosStatistics = new PhotosStatistics(LoggedInUser);
				}

				m_PhotosStatistics.GenerateStatistics();

				return m_PhotosStatistics;
			}

			private set { m_PhotosStatistics = value; }
		}

		public void Login()
		{
			LoginResult result = FacebookService.Login("419878648523017", "public_profile", "email", "user_friends", "user_photos", "user_birthday", "user_likes", "manage_pages", "user_events", "user_hometown", "user_posts", "user_tagged_places", "user_location");
			LoggedInUser = result.LoggedInUser;
			Settings.LastAccessToken = result.AccessToken;
		}

		public void AutoLogin()
		{
			LoginResult loginResult = FacebookService.Connect(Settings.LastAccessToken);
			LoggedInUser = loginResult.LoggedInUser;
		}
	}
}
