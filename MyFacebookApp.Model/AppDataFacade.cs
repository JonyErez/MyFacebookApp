using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

		public Func<Photo, bool> TaggedInPhotoTest { get; set; }

		public int TaggedPhotoFilterAmmountParam { get; set; }

		public List<Func<Photo, bool>> StrategyList { get; private set; }

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
			AppSettings appSettings = AppSettings.LoadAppSettings();

			if (!appSettings.RememberUser)
			{
				AppData.Login();
			}
			else
			{
				AppData.AutoLogin();
			}
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

		public IEnumerable<Photo> GetTaggedInPhotos()
		{
			foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
			{
				if (TaggedInPhotoTest.Invoke(photo))
				{
					yield return photo;
				}
			}
		}

		public List<string> GetSearchStrategys()
		{
			StrategyList = new List<Func<Photo, bool>>();
			List<string> userInterfaceStrategyList = new List<string>();

			Type strategyMethods = typeof(AppDataFacade);
			foreach (MethodInfo methodInfo in strategyMethods.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance))
			{
				foreach (TaggedPhotoSearchStrategy customAttribute in methodInfo.GetCustomAttributes(typeof(TaggedPhotoSearchStrategy), false))
				{
					StrategyList.Add((Func<Photo, bool>)Delegate.CreateDelegate(typeof(Func<Photo, bool>), this, methodInfo, true));
					userInterfaceStrategyList.Add(customAttribute.DisplayName);
				}
			}

			return userInterfaceStrategyList;
		}

		// In order to add more strategys, methods must have TaggedPhotoSearchStrategy attribute, and add a display name.
		// Display order will be the order of methods.
		[TaggedPhotoSearchStrategy(DisplayName = "None")]
		private bool defaultFilter(Photo i_Photo)
		{
			return true;
		}

		[TaggedPhotoSearchStrategy(DisplayName = "By Likes")]
		private bool byLikes(Photo i_Photo)
		{
			return i_Photo.LikedBy.Count >= TaggedPhotoFilterAmmountParam;
		}

		[TaggedPhotoSearchStrategy(DisplayName = "By Age")]
		private bool byAge(Photo i_Photo)
		{
			return i_Photo.CreatedTime >= DateTime.Now.AddYears(-TaggedPhotoFilterAmmountParam);
		}

		[TaggedPhotoSearchStrategy(DisplayName = "By Tags")]
		private bool byTags(Photo i_Photo)
		{
			return i_Photo.Tags.Count >= TaggedPhotoFilterAmmountParam;
		}

		[AttributeUsage(AttributeTargets.Method)]
		public class TaggedPhotoSearchStrategy : Attribute
		{
			public string DisplayName { get; set; }
		}
	}
}
