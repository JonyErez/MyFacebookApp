using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.Model
{
	public class AppDataFacade
	{
		public AppDataFacade()
		{
			AppData = new AppData();
		}

		private AppData AppData { get; set; }

		public User LoggedInUser
		{
			get
			{
				return AppData.LoggedInUser; 
			}
		}

		public bool RememberUser
		{
			get
			{
				return AppData.Settings.RememberUser;
			}

			set
			{
				AppData.Settings.RememberUser = value;
			}
		}

		public void Login()
		{
			AppData.Login(); 
		}

		public void AutoLogin()
		{
			AppData.AutoLogin();
		}

		public FacebookObjectCollection<Post> GetRecentWallPosts(int i_WallPostAgeInMonths)
		{
			FacebookObjectCollection<Post> recentWallPosts = new FacebookObjectCollection<Post>();

			try
			{
				foreach (Post wallPost in AppData.LoggedInUser.WallPosts)
				{
					if (wallPost.CreatedTime >= DateTime.Now.AddMonths(-Math.Abs(i_WallPostAgeInMonths)))
					{
						recentWallPosts.Add(wallPost);
					}
				}
			}
			catch (Exception)
			{
				throw;
			}

			return recentWallPosts;
		}

		public FacebookObjectCollection<User> GetUpcomingBirthdays()
		{
			FacebookObjectCollection<User> upcomingBirthdays = new FacebookObjectCollection<User>();

			foreach (User friend in AppData.LoggedInUser.Friends)
			{
				FacebookDateAdapter facebookDate = new FacebookDateAdapter();
				try
				{
					facebookDate.Date = friend.Birthday;
					DateTime birthday = facebookDate.ToDateTime();
					birthday.AddYears(DateTime.Now.Year - birthday.Year);

					if (birthday <= DateTime.Now.AddDays(7) && birthday >= DateTime.Now)
					{
						upcomingBirthdays.Add(friend);
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			return upcomingBirthdays;
		}

		public PostsStatistics GetPostsStatistics()
		{
			return AppData.PostsStatistics;
		}

		public PhotosStatistics GetPhotosStatistics()
		{
			return AppData.PhotosStatistics;
		}

		public AppSettings GetAppSettings()
		{
			return AppData.Settings;
		}
	}
}
