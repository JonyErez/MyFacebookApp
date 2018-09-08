using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp.Model
{
	public class PhotosStatistics : Statistics
	{
		internal PhotosStatistics(User i_LoggedInUser) : base(i_LoggedInUser)
		{
		}

		public override PostedItem MostLiked
		{
			get { return m_MostLiked as Photo; }
			set
			{
				if (value is Photo)
				{
					m_MostLiked = value;
				}
				else
				{
					throw new Exception("Item is not a Photo!");
				}
			}
		}

		public User UserWithMostMutualPhotos { get; set; }

		public int UserWithMostMutualPhotosCount { get; set; }

		public override void GenerateStatistics()
		{
			base.GenerateStatistics();
			generateMutualPhotoData();
		}

		private void generateMutualPhotoData()
		{
			Dictionary<User, int> mostPhotosWith = new Dictionary<User, int>();

			foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
			{
				addMutualPictureCountForCurrentPhoto(mostPhotosWith, photo);
			}

			findMaxCountAndUser(mostPhotosWith);
		}

		private void findMaxCountAndUser(Dictionary<User, int> i_MostPhotosWith)
		{
			UserWithMostMutualPhotosCount = 0;
			foreach (KeyValuePair<User, int> keyValuePair in i_MostPhotosWith)
			{
				if (UserWithMostMutualPhotosCount < keyValuePair.Value)
				{
					UserWithMostMutualPhotosCount = keyValuePair.Value;
					UserWithMostMutualPhotos = keyValuePair.Key;
				}
			}
		}

		private void addMutualPictureCountForCurrentPhoto(Dictionary<User, int> i_MostPhotosWith, Photo i_Photo)
		{
			foreach (PhotoTag photoTag in i_Photo.Tags)
			{
				if (i_MostPhotosWith.ContainsKey(photoTag.User))
				{
					i_MostPhotosWith[photoTag.User]++;
				}
				else if (photoTag.User.Id != LoggedInUser.Id)
				{
					i_MostPhotosWith.Add(photoTag.User, 1);
				}
			}
		}
	}
}
