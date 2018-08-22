using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.View
{
	public abstract class Statistics
	{
		internal Statistics(User i_LoggedInUser) { LoggedInUser = i_LoggedInUser; }

		protected PostedItem m_MostLiked;

		public User LoggedInUser { get; }

		public abstract PostedItem MostLiked { get; set; }

		public int TotalLikes { get; set; }

		public int MostLikedCount { get; set; }

		public int UserWithMostLikesCount { get; set; }

		public User UserWithMostLikes { get; set; }

		public Dictionary<User, int> UsersLikesCounts { get; set; }


		public virtual void GenerateStatistics()
		{
			generateUserLikeData();
		}

		private void generateUserLikeData()
		{
			UserWithMostLikesCount = 0;
			TotalLikes = 0;
			if (UsersLikesCounts == null)
			{
				UsersLikesCounts = new Dictionary<User, int>();
			}
			else
			{
				UsersLikesCounts.Clear();
			}

			foreach (Post post in LoggedInUser.Posts)
			{
				TotalLikes += post.LikedBy.Count;
				addLikesForCurrentItem(post);
				if (post.LikedBy.Count > MostLikedCount)
				{
					MostLikedCount = post.LikedBy.Count;
					MostLiked = post;
				}
			}
			findUserWithMostLikes();
		}

		private void addLikesForCurrentItem(PostedItem i_CurrentItem)
		{
			foreach (User user in i_CurrentItem.LikedBy)
			{
				if (UsersLikesCounts.ContainsKey(user))
				{
					UsersLikesCounts[user]++;
				}
				else if (user.Id != LoggedInUser.Id)
				{
					UsersLikesCounts.Add(user, 1);
				}
			}
		}

		private void findUserWithMostLikes()
		{
			UserWithMostLikesCount = 0;

			foreach (KeyValuePair<User, int> keyValuePair in UsersLikesCounts)
			{
				if (UserWithMostLikesCount < keyValuePair.Value)
				{
					UserWithMostLikesCount = keyValuePair.Value;
					UserWithMostLikes = keyValuePair.Key;
				}
			}
		}
	}
}
