using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.View
{
	public class PostsStatistics : Statistics
	{
		internal PostsStatistics(User i_LoggedInUser) : base(i_LoggedInUser)
		{
		}

		public override PostedItem MostLiked
		{
			get { return m_MostLiked as Post; }
			set
			{
				if (value is Post)
				{
					m_MostLiked = value;
				}
				else
				{
					throw new Exception("Item is not a Post!");
				}
			}
		}

		public User UserWithMostMutualPosts { get; set; }

		public int UserWithMostMutualPostsCount { get; set; }

		public override void GenerateStatistics()
		{
			base.GenerateStatistics();
			generateTaggedPostsData();
		}

		private void generateTaggedPostsData()
		{
			Dictionary<User, int> usersMutualPostsCounts = new Dictionary<User, int>();

			foreach (Post post in LoggedInUser.Posts)
			{
				addMutualPostCountForCurrentPost(usersMutualPostsCounts, post);
			}

			findUserWithMostMutualPosts(usersMutualPostsCounts);
		}

		private void findUserWithMostMutualPosts(Dictionary<User, int> i_UserMutualPostsCount)
		{
			UserWithMostMutualPostsCount = 0;

			foreach (KeyValuePair<User, int> keyValuePair in i_UserMutualPostsCount)
			{
				if (UserWithMostMutualPostsCount < keyValuePair.Value)
				{
					UserWithMostMutualPostsCount = keyValuePair.Value;
					UserWithMostMutualPosts = keyValuePair.Key;
				}
			}
		}

		private void addMutualPostCountForCurrentPost(Dictionary<User, int> i_MostPostsWith, Post i_Post)
		{
			foreach (User user in i_Post.TaggedUsers)
			{
				if (i_MostPostsWith.ContainsKey(user))
				{
					i_MostPostsWith[user]++;
				}
				else if (user.Id != LoggedInUser.Id)
				{
					i_MostPostsWith.Add(user, 1);
				}
			}
		}
	}
}
