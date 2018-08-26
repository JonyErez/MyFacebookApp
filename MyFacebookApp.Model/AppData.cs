using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.Model
{
	internal class AppData
	{
		public AppSettings Settings { get; private set; }

		public User LoggedInUser { get; private set; }

		public string AccessToken { get; private set; }

		public bool RememberUser { get; private set; } = false;

		public PostsStatistics PostsStatistics { get; private set; }

		public PhotosStatistics PhotosStatistics { get; private set; }

		public void Login()
		{
			Settings = AppSettings.LoadAppSettings();

			if (Settings.RememberUser && !string.IsNullOrEmpty(Settings.LastAccessToken))
			{
				autoLogin();
			}
			else
			{
				LoginResult result = FacebookService.Login("419878648523017", "public_profile", "email", "user_friends", "user_photos", "user_birthday", "user_likes", "manage_pages", "user_events", "user_hometown", "user_posts", "user_tagged_places", "user_location");
				LoggedInUser = result.LoggedInUser;
				AccessToken = result.AccessToken;
			}
		}

		private void autoLogin()
		{
			AccessToken = Settings.LastAccessToken;
			LoginResult loginResult = FacebookService.Connect(AccessToken);
			LoggedInUser = loginResult.LoggedInUser;
			RememberUser = Settings.RememberUser;
		}

		public FacebookObjectCollection<User> GetUpcomingBirthdays()
		{
			FacebookObjectCollection<User> upcomingBirthdays = new FacebookObjectCollection<User>();

			foreach (User friend in LoggedInUser.Friends)
			{
				string formattedBirthday = friend.Birthday;

                if (formattedBirthday.Length <= 5)
				{
					formattedBirthday += "/" + DateTime.Now.Year;
				}

				DateTime.TryParseExact(formattedBirthday, "MM/dd/yyyy", new DateTimeFormatInfo(), DateTimeStyles.AdjustToUniversal, out DateTime birthday);

                if (birthday != null)
				{
					birthday.AddYears(DateTime.Now.Year - birthday.Year);

					if (birthday <= DateTime.Now.AddDays(7) && birthday >= DateTime.Now)
					{
						upcomingBirthdays.Add(friend);
					}
				}
			}

			return upcomingBirthdays;
		}

		public FacebookObjectCollection<Post> GetRecentWallPosts(int i_WallPostAge)
		{
			FacebookObjectCollection<Post> recentWallPosts = new FacebookObjectCollection<Post>();

			foreach (Post wallPost in LoggedInUser.WallPosts)
			{
				if (wallPost.CreatedTime >= DateTime.Now.AddMonths(-Math.Abs(i_WallPostAge)))
				{
					recentWallPosts.Add(wallPost);
				}
			}

			return recentWallPosts;
		}

		public PostsStatistics GetPostStatistics()
		{
			if (PostsStatistics == null)
			{
				PostsStatistics = new PostsStatistics(LoggedInUser);
			}

			PostsStatistics.GenerateStatistics();

			return PostsStatistics;
		}

		public PhotosStatistics GetPhotosStatistics()
		{
			if (PhotosStatistics == null)
			{
				PhotosStatistics = new PhotosStatistics(LoggedInUser);
			}

			PhotosStatistics.GenerateStatistics();

			return PhotosStatistics;
		}
    
		//private void generateGeneralStatistics()
		//{
		//	try
		//	{
		//		labelStatisticsGeneralEventsCreated.Text = LoggedInUser.EventsCreated.Count.ToString();
		//	}
		//	catch (Exception)
		//	{
		//		// Always throws Auth Error
		//		MessageBox.Show("Couldn't fetch your events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}

		//	try
		//	{
		//		labelStatisticsGeneralGroups.Text = LoggedInUser.Groups.Count.ToString();
		//	}
		//	catch (Exception)
		//	{
		//		// Always throws permissions error, however cannot request user_managed_groups permission (wont allow to login with it)
		//		MessageBox.Show("Couldn't fetch your groups!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}

		//	labelStatisticsGeneralFriends.Text = LoggedInUser.Friends.Count.ToString();
		//	labelStatisticsGeneralCheckins.Text = LoggedInUser.Checkins.Count.ToString();
		//	labelStatisticsGeneralPosts.Text = LoggedInUser.Posts.Count.ToString();

		//	//    labelStatisticsGeneralFriends.Invoke(new Action(() => labelStatisticsGeneralFriends.Text = LoggedInUser.Friends.Count.ToString()));
		//	//    labelStatisticsGeneralCheckins.Invoke(new Action(() => labelStatisticsGeneralCheckins.Text = LoggedInUser.Checkins.Count.ToString()));
		//	//    labelStatisticsGeneralPosts.Invoke(new Action(() => labelStatisticsGeneralPosts.Text = LoggedInUser.Posts.Count.ToString()));
		//}	
	}
}
