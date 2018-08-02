using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace MyFacebookApp
{
	public partial class FacebookApp : Form
	{
		public AppSettings Settings { get; private set; }

		public User LoggedInUser { get; private set; }

		public string AccessToken { get; private set; }

		public bool RememberUser { get; private set; }

		public int WallPostAgeInMonths { get; private set; } = 3;

		public User CurrentOverviewedFriend { get; private set; }

		public FacebookApp()
		{
			InitializeComponent();
		}

		private void facebookApp_Load(object i_Sender, EventArgs i_EventArgs)
		{
			Settings = AppSettings.LoadAppSettings();
			Location = Settings.Location;
			if (!Settings.RememberUser)
			{
				FormLogin login = new FormLogin();
				DialogResult loginResult = login.ShowDialog();
				if (loginResult == DialogResult.OK)
				{
					RememberUser = false;
					LoggedInUser = login.LoggedInUser;
					AccessToken = login.AccessToken;
				}
				else
				{
					Close();
				}
			}
			else
			{
				AccessToken = Settings.LastAccessToken;
				LoginResult loginResult = FacebookService.Connect(AccessToken);
				LoggedInUser = loginResult.LoggedInUser;
				RememberUser = checkBoxRememberUser.Checked = Settings.RememberUser;
			}
		}

		private void fetchUserInfo()
		{
			labelWelcomeUser.Text = string.Format("Hello {0} !", LoggedInUser.Name);
			pictureBoxProfilePicture.LoadAsync(LoggedInUser.PictureNormalURL);
			pictureBoxProfilePicture.BringToFront();
			if (LoggedInUser.Cover?.SourceURL != null)
			{
				pictureBoxCover.LoadAsync(LoggedInUser.Cover.SourceURL);
			}
			else
			{
				pictureBoxCover.Image = Properties.Resources.facebookBanner;
			}

			populateFields();
		}

		private void populateFields()
		{
			populateAlbums();
			populateBirthdays();
			populateEventsList();
			populateWallPosts();
			populateFriendList();
			populateLikedPages();
		}

		private void populateLikedPages()
		{
			try
			{
				bindingSourceLikedPages.DataSource = LoggedInUser.LikedPages;
			}
			catch (Exception)
			{
				// Always throws Auth Error: requires Facebook Review in order to use
				MessageBox.Show("Couldn't fetch user liked pages!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateWallPosts()
		{
			foreach (Post wallPost in LoggedInUser.WallPosts)
			{
				if (wallPost.CreatedTime >= DateTime.Now.AddMonths(-WallPostAgeInMonths))
				{
					bindingSourceWallPosts.Add(wallPost);
				}
			}
		}

		private void populateBirthdays()
		{
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
						bindingSourceBirthdays.Add(friend);
					}
				}
			}
		}

		private void populateAlbums()
		{
			bindingSourceAlbums.DataSource = LoggedInUser.Albums;
		}

		private void populateEventsList()
		{
			try
			{
				bindingSourceEvents.DataSource = LoggedInUser.Events;
			}
			catch (Exception)
			{
				// Always throws Auth Error: field 'location' has been depreciated since version 2.5 of the API
				MessageBox.Show("Couldn't fetch user events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateFriendList()
		{
			bindingSourceFriends.DataSource = LoggedInUser.Friends;
		}

		private void facebookApp_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs)
		{
			Settings.Location = Location;
			Settings.RememberUser = RememberUser;
			Settings.LastAccessToken = RememberUser ? AccessToken : string.Empty;
			Settings.SaveAppSettings();
		}

		private void facebookApp_Shown(object i_Sender, EventArgs i_EventArgs)
		{
			fetchUserInfo();
		}

		private void buttonLogout_Click(object i_Sender, EventArgs i_EventArgs)
		{
			DialogResult logout = MessageBox.Show("Are you sure you want to logout?\nYour login details will be forgotten!", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			if (logout == DialogResult.Yes)
			{
				FacebookService.Logout(null);
				RememberUser = false;
				Close();
			}
		}

		private void bindingSourcePictures_CurrentChanged(object i_Sender, EventArgs i_EventArgs)
		{
			if (bindingSourcePictures.Current != null)
			{
				labelPictureLikes.Text = (bindingSourcePictures.Current as Photo)?.LikedBy.Count.ToString();
				labelPictureName.Text = (bindingSourcePictures.Current as Photo)?.Name;
				labelPictureDate.Text = (bindingSourcePictures.Current as Photo)?.CreatedTime.ToString();
			}
		}

		private void buttonQuit_Click(object i_Sender, EventArgs i_EventArgs)
		{
			DialogResult logout = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			if (logout == DialogResult.Yes)
			{
				Close();
			}
		}

		private void checkBoxRememberUser_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
		{
			RememberUser = checkBoxRememberUser.Checked;
		}

		private void buttonPost_Click(object i_Sender, EventArgs i_EventArgs)
		{
			try
			{
				LoggedInUser.PostStatus(textBoxPost.Text);
				MessageBox.Show("Status posted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception)
			{
				MessageBox.Show("There was an error uploading your status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void comboBoxWallPostAge_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
		{
			bindingSourceWallPosts.Clear();
			WallPostAgeInMonths = comboBoxWallPostAge.SelectedIndex + 1;
			populateWallPosts();
		}

		private void tabControlGeneral_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
		{
			if (i_Sender == null)
			{
				throw new ArgumentNullException(nameof(i_Sender));
			}

			if (tabControlGeneral.SelectedTab == tabControlGeneral.TabPages["tabPageFriendOverview"])
			{
				populateTabFriendOverview();
			}
		}

		private void populateTabFriendOverview()
		{
			bindingSourceFriendOverview.DataSource = LoggedInUser.Friends;
			comboBoxChooseAFriend.SelectedText = "Choose a friend to overview";
		}

		private void comboBoxChooseAFriend_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
		{
			CurrentOverviewedFriend = comboBoxChooseAFriend.SelectedItem as User;
			if (CurrentOverviewedFriend != null)
			{
				populateTitles();
				populatePersonalInfo();
				populateMutualPictures();
				populateSubTabFriendEvents();
				populateSubTabFriendCheckins();
				populateSubTabFriendPosts();
				populateSubTabFriendGroups();
			}
		}

		private void populateTitles()
		{
			string title = string.Format("{0}s activity:", CurrentOverviewedFriend.Name);
			labelFriendActivity.Text = title;
			title = string.Format("Upload a picture with {0}!", CurrentOverviewedFriend.FirstName);
			labelUploadMutualPic.Text = title;
			title = string.Format("Pictures of you and {0}:", CurrentOverviewedFriend.FirstName);
			labelMutualPictures.Text = title;
			title = string.Format("Description: the picture you will choose{0}will automatically tag {1}.", Environment.NewLine, CurrentOverviewedFriend.FirstName);
			labelUploadMutualPicDescription.Text = title;
		}

		private void populateMutualPictures()
		{
			bindingSourceFriendOverviewMutualPictures.Clear();
			foreach (Photo photo in CurrentOverviewedFriend.PhotosTaggedIn)
			{
				if (LoggedInUser.PhotosTaggedIn.Contains(photo))
				{
					bindingSourceFriendOverviewMutualPictures.Add(photo);
					progressBarFriendshipStrength.PerformStep();
				}
			}
		}

		private void populatePersonalInfo()
		{
			bindingSourceFriendOverviewPersonalInfo.Clear();
			bindingSourceFriendOverviewPersonalInfo.DataSource = CurrentOverviewedFriend;
			labelNumberOfFriends.Text = CurrentOverviewedFriend.Friends.Count.ToString();
			labelRelationshipStatus.Text = CurrentOverviewedFriend.RelationshipStatus.ToString();
			labelOnlineStatus.Text = CurrentOverviewedFriend.OnlineStatus.ToString();
		}

		private void populateSubTabFriendGroups()
		{
			bindingSourceFriendOverviewGroups.Clear();
			bindingSourceFriendOverviewGroups.DataSource = CurrentOverviewedFriend.Groups;
		}

		private void populateSubTabFriendPosts()
		{
			bindingSourceFriendOverviewPosts.Clear();
			bindingSourceFriendOverviewPosts.DataSource = CurrentOverviewedFriend.Posts;
		}

		private void populateSubTabFriendCheckins()
		{
			bindingSourceFriendOverviewCheckins.Clear();
			try
			{
				bindingSourceFriendOverviewCheckins.DataSource = CurrentOverviewedFriend.Checkins;
			}
			catch (Exception)
			{
				MessageBox.Show("Coudn't fetch your friend checkins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateSubTabFriendEvents()
		{
			bindingSourceFriendOverviewEvents.Clear();
			try
			{
				bindingSourceFriendOverviewEvents.DataSource = CurrentOverviewedFriend.Events;
			}
			catch (Exception)
			{
				// Always throws Auth Error: field 'location' has been depreciated since version 2.5 of the API
				MessageBox.Show("Couldn't fetch your friend events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void comboBoxChooseAFriend_TextChanged(object i_Sender, EventArgs i_EventArgs)
		{
			if (comboBoxChooseAFriend.SelectedIndex < 0)
			{
				comboBoxChooseAFriend.Text = "Choose a friend to overview";
			}
			else
			{
				comboBoxChooseAFriend.Text = comboBoxChooseAFriend.SelectedText;
			}
		}

		private void buttonUplaodMutualPic_Click(object i_Sender, EventArgs i_EventArgs)
		{
			// always will fail because publish_actions permissions doesnt work
			try
			{
				Post imageToUpload = LoggedInUser.PostPhoto(pictureBoxMutualPictureToUpload.ImageLocation, textBoxMutualPicToUploadTitle.Text);
				imageToUpload.TaggedUsers.Add(CurrentOverviewedFriend);
				bindingSourceFriendOverviewMutualPictures.Add(pictureBoxMutualPictureToUpload);
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't upload your picture :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonBrowseAPicture_Click_1(object i_Sender, EventArgs i_EventArgs)
		{
			OpenFileDialog pictureBrowse = new OpenFileDialog();
			pictureBrowse.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";
			try
			{
				if (pictureBrowse.ShowDialog() == DialogResult.OK)
				{
					string picturePath = pictureBrowse.FileName;
					pictureBoxMutualPictureToUpload.ImageLocation = picturePath;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't load image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void generateStatistics()
		{
			generateGeneralStatistics();
			generatePhotoStatistics();
			generatePostStatistics();
		}

		private void generatePostStatistics()
		{
			Dictionary<User, int> mostLikesBy = new Dictionary<User, int>();
			Dictionary<User, int> mostPostsWith = new Dictionary<User, int>();
			generateUserPostsData(mostLikesBy, out Post mostLikedPost, out int mostLikedCount, out int totalLikes);
			generateTaggedPostsData(mostPostsWith);
			findMaxCountAndUser(mostLikesBy, out User mostLikesByUser, out int mostLikesByCount);
			findMaxCountAndUser(mostPostsWith, out User maxMutualPostsUser, out int maxMutualPostsCount);
			updatePostStatistics(mostLikesByUser, mostLikesByCount, maxMutualPostsUser, maxMutualPostsCount, mostLikedPost, mostLikedCount, totalLikes);
		}

		private void updatePostStatistics(User i_MostLikesByUser, int i_MostLikesByCount, User i_MaxMutualPostsUser, int i_MaxMutualPostsCount, Post i_MostLikedPost, int i_MostLikedCount, int i_TotalLikes)
		{
			labelStatisticsPostsTotal.Text = LoggedInUser.Posts.Count.ToString();
			labelStatisticsPostsPostsTaggedIn.Text = LoggedInUser.PostsTaggedIn.Count.ToString();
			labelStatisticsPostsMostLikes.Text = i_MostLikedCount.ToString();
			labelStatisticsPostsMostLikesByUserCount.Text = i_MostLikesByCount.ToString();
			labelStatisticsPostsMostLikesByUserName.Text = i_MostLikesByUser?.Name;
			labelStatisticsPostsMostPostsWithCount.Text = i_MaxMutualPostsCount.ToString();
			labelStatisticsPostsMostPostsWithName.Text = i_MaxMutualPostsUser?.Name;
			labelStatisticsPostsTotalLikes.Text = i_TotalLikes.ToString();
			richTextBoxMostLikedPost.Text = i_MostLikedPost?.Message;
		}

		private void generateTaggedPostsData(Dictionary<User, int> i_MostPostsWith)
		{
			foreach (Post post in LoggedInUser.Posts)
			{
				addMutualPostCountForCurrentPost(i_MostPostsWith, post);
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

		private void generateUserPostsData(Dictionary<User, int> i_MostLikesBy, out Post i_MostLikedPost, out int i_MostLikedCount, out int i_TotalLikes)
		{
			i_MostLikedPost = null;
			i_MostLikedCount = 0;
			i_TotalLikes = 0;
			foreach (Post post in LoggedInUser.Posts)
			{
				i_TotalLikes += post.LikedBy.Count;
				addLikesForCurrentPost(i_MostLikesBy, post);
				if (post.LikedBy.Count > i_MostLikedCount)
				{
					i_MostLikedCount = post.LikedBy.Count;
					i_MostLikedPost = post;
				}
			}
		}

		private void addLikesForCurrentPost(Dictionary<User, int> i_MostLikesBy, Post i_Post)
		{
			foreach (User user in i_Post.LikedBy)
			{
				if (i_MostLikesBy.ContainsKey(user))
				{
					i_MostLikesBy[user]++;
				}
				else if (user.Id != LoggedInUser.Id)
				{
					i_MostLikesBy.Add(user, 1);
				}
			}
		}

		private void generateGeneralStatistics()
		{
			try
			{
				labelStatisticsGeneralEventsCreated.Text = LoggedInUser.EventsCreated.Count.ToString();
			}
			catch (Exception)
			{
				// Always throws Auth Error
				MessageBox.Show("Couldn't fetch your events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
			{
				labelStatisticsGeneralGroups.Text = LoggedInUser.Groups.Count.ToString();
			}
			catch (Exception)
			{
				// Always throws permissions error, however cannot request user_managed_groups permission (wont allow to login with it)
				MessageBox.Show("Couldn't fetch your groups!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			labelStatisticsGeneralFriends.Text = LoggedInUser.Friends.Count.ToString();
			labelStatisticsGeneralCheckins.Text = LoggedInUser.Checkins.Count.ToString();
			labelStatisticsGeneralPosts.Text = LoggedInUser.Posts.Count.ToString();
		}

		private void generatePhotoStatistics()
		{
			Dictionary<User, int> mostLikesBy = new Dictionary<User, int>();
			Dictionary<User, int> mostPhotosWith = new Dictionary<User, int>();
			generatePhotoData(mostLikesBy, mostPhotosWith, out Photo mostLikedPhoto, out int totalLikes, out int mostLikes);
			findMaxCountAndUser(mostPhotosWith, out User maxMutualPhotosUser, out int maxMutualPhotosCount);
			findMaxCountAndUser(mostLikesBy, out User maxLikedByUser, out int maxLikedByCount);
			updateLikeStatistics(totalLikes, mostLikes, mostLikedPhoto, maxMutualPhotosUser, maxMutualPhotosCount, maxLikedByUser, maxLikedByCount);
		}

		private void generatePhotoData(Dictionary<User, int> i_MostLikesBy, Dictionary<User, int> i_MostPhotosWith, out Photo i_MostLikedPhoto, out int i_TotalLikes, out int i_MostLikes)
		{
			i_TotalLikes = 0;
			i_MostLikes = 0;
			i_MostLikedPhoto = null;
			foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
			{
				i_TotalLikes += photo.LikedBy.Count;
				if (photo.LikedBy.Count > i_MostLikes)
				{
					i_MostLikes = photo.LikedBy.Count;
					i_MostLikedPhoto = photo;
				}

				addLikesForCurrentPhoto(i_MostLikesBy, photo);
				addMutualPictureCountForCurrentPhoto(i_MostPhotosWith, photo);
			}
		}

		private void updateLikeStatistics(int i_TotalLikes, int i_MostLikes, Photo i_MostLikedPhoto, User i_MaxMutualPhotosUser, int i_MaxMutualPhotosCount, User i_MaxLikedByUser, int i_MaxLikedByCount)
		{
			labelMostMutualPhotosWithCount.Text = i_MaxMutualPhotosCount.ToString();
			labelMostMutualPhotosWithName.Text = i_MaxMutualPhotosUser?.Name;
			labelMostLikesByUserCount.Text = i_MaxLikedByCount.ToString();
			labelMostLikesByUserName.Text = i_MaxLikedByUser?.Name;
			labelPhotosTaggedIn.Text = LoggedInUser.PhotosTaggedIn.Count.ToString();
			labelMostLikedPhotoLikes.Text = i_MostLikes.ToString();
			labelTotalLikes.Text = i_TotalLikes.ToString();
			pictureBoxMostLikedPhoto.Image = i_MostLikedPhoto?.ImageNormal;
			labelStatisticsUploadedAlbums.Text = LoggedInUser.Albums.Count.ToString();
		}

		private void findMaxCountAndUser(Dictionary<User, int> i_MostPhotosWith, out User o_User, out int o_MaxCount)
		{
			o_User = null;
			o_MaxCount = 0;
			foreach (KeyValuePair<User, int> keyValuePair in i_MostPhotosWith)
			{
				if (o_MaxCount < keyValuePair.Value)
				{
					o_MaxCount = keyValuePair.Value;
					o_User = keyValuePair.Key;
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

		private void addLikesForCurrentPhoto(Dictionary<User, int> i_MostLikesBy, Photo i_Photo)
		{
			foreach (User user in i_Photo.LikedBy)
			{
				if (i_MostLikesBy.ContainsKey(user))
				{
					i_MostLikesBy[user]++;
				}
				else if (user.Id != LoggedInUser.Id)
				{
					i_MostLikesBy.Add(user, 1);
				}
			}
		}

		private void buttonCalculateStatistics_Click(object i_Sender, EventArgs i_EventArgs)
		{
			generateStatistics();
		}
	}
}