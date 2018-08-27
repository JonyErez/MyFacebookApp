using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Security.Permissions;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using MyFacebookApp.Model.Properties;
using MyFacebookApp.Model;

namespace MyFacebookApp.View
{
    public partial class FacebookApp : Form
	{
		private readonly AppDataFacade r_AppData = new AppDataFacade();

		private User CurrentOverviewedFriend { get; set; }

		private int WallPostAgeInMonths { get; set; } = 3;

        public FacebookApp()
        {
            InitializeComponent();

            // Set Icon
            setFacebookAppIcon();
        }

		#region App Methods

		// ----------------------------- General --------------------------------/
		private void setFacebookAppIcon()
        {
            Bitmap bitIcon = Resources.FBicon;
            IntPtr pIcon = bitIcon.GetHicon();
            Icon iconFrom = Icon.FromHandle(pIcon);
            Icon = iconFrom;
        }

        private void facebookApp_Load(object i_Sender, EventArgs i_EventArgs)
		{
			AppSettings appSettings = r_AppData.GetAppSettings();
            Location = appSettings.Location;
			checkBoxRememberUser.Checked = appSettings.RememberUser;
        }

        private void fetchUserInfo()
		{
			this.Invoke(new Action(updateGeneralAppInterface));
			populateFields();
		}

		private void updateGeneralAppInterface()
		{
			labelWelcomeUser.Text = string.Format("Hello {0} !", r_AppData.LoggedInUser.Name);
			pictureBoxProfilePicture.LoadAsync(r_AppData.LoggedInUser.PictureNormalURL);

			if (r_AppData.LoggedInUser.Cover?.SourceURL != null)
			{
				pictureBoxCover.LoadAsync(r_AppData.LoggedInUser.Cover.SourceURL);
			}
			else
			{
				pictureBoxCover.Image = Resources.facebookBanner;
			}
		}

		private void facebookApp_FormClosing(object i_Sender, FormClosingEventArgs i_EventArgs)
		{
			AppSettings appSettings = r_AppData.GetAppSettings();
			appSettings.Location = Location;
			appSettings.LastAccessToken = r_AppData.RememberUser ? appSettings.LastAccessToken : string.Empty;
			appSettings.SaveAppSettings();
		}

		private void facebookApp_Shown(object i_Sender, EventArgs i_EventArgs)
		{
			AppSettings appSettings = r_AppData.GetAppSettings();

			if (!appSettings.RememberUser)
			{
				r_AppData.Login();
			}
			else
			{
				r_AppData.AutoLogin();
			}

			new Thread(fetchUserInfo).Start();
		}

		private void buttonQuit_Click(object i_Sender, EventArgs i_EventArgs)
		{
			DialogResult logout = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
			if (logout == DialogResult.Yes)
			{
				Close();
			}
		}

		#endregion

		#region General Tab

		// ----------------------------- Tab General --------------------------------/
		private void populateFields()
        {
            new Thread(populateAlbums).Start();
            new Thread(populateBirthdays).Start();
            new Thread(populateEventsList).Start();
            new Thread(populateWallPosts).Start();
            new Thread(populateFriendList).Start();
            new Thread(populateLikedPages).Start();
        }

		private void populateLikedPages()
		{
			dataGridViewLikedPages.Invoke(new Action(getLikedPages));
		}

		private void getLikedPages()
		{
			try
			{
				bindingSourceLikedPages.DataSource = r_AppData.LoggedInUser.LikedPages;
			}
			catch (Exception)
			{
				// Always throws Auth Error: requires Facebook Review in order to use
				MessageBox.Show("Couldn't fetch user liked pages!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateWallPosts()
		{
			DataGridViewRecentWallPosts.Invoke(new Action(getWallPosts));
		}

		private void getWallPosts()
		{
			try
			{
				bindingSourceWallPosts.DataSource = r_AppData.GetRecentWallPosts(WallPostAgeInMonths);
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't fetch your recent wall posts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateBirthdays()
		{
			dataGridViewUpcomingBirthdays.Invoke(new Action(getUpcomingBirthdays));
		}

		private void getUpcomingBirthdays()
		{
			try
			{
				bindingSourceBirthdays.DataSource = r_AppData.GetUpcomingBirthdays();
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't fetch your upcoming friends birthdays!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateAlbums()
		{
			comboBoxAlbums.Invoke(new Action(() => bindingSourceAlbums.DataSource = r_AppData.LoggedInUser.Albums));
		}

		private void populateEventsList()
		{
			listBoxEvents.Invoke(new Action(getEvents));
		}

		private void getEvents()
		{
			try
			{
				bindingSourceEvents.DataSource = r_AppData.LoggedInUser.Events;
			}
			catch (Exception)
			{
				// Always throws Auth Error: field 'location' has been depreciated since version 2.5 of the API
				MessageBox.Show("Couldn't fetch user events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateFriendList()
        {
            listBoxFriends.Invoke(new Action(() => bindingSourceFriends.DataSource = r_AppData.LoggedInUser.Friends));
            labelGeneralFriendBirthday.Invoke(new Action(() => customBirthday(labelGeneralFriendBirthday)));
        }

        private void customBirthday(Label i_facebookBirthdayLabel)
        {
            FacebookDateAdapter birthday = new FacebookDateAdapter { Date = i_facebookBirthdayLabel.Text };

            birthday.ToDateTime();
            i_facebookBirthdayLabel.Text = birthday.Date;
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_EventArgs)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?\nYour login details will be forgotten!", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (logout == DialogResult.Yes)
            {
                FacebookService.Logout(null);
                r_AppData.GetAppSettings().RememberUser = false;
                Close();
            }
        }

        private void checkBoxRememberUser_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            r_AppData.RememberUser = checkBoxRememberUser.Checked;
        }

        private void buttonPost_Click(object i_Sender, EventArgs i_EventArgs)
        {
            try
            {
				r_AppData.LoggedInUser.PostStatus(textBoxPost.Text);
                MessageBox.Show("Status posted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error uploading your post!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxWallPostAge_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            bindingSourceWallPosts.Clear();
            WallPostAgeInMonths = comboBoxWallPostAge.SelectedIndex + 1;
			new Thread(populateWallPosts).Start();
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

		#endregion

		#region Friend Overview Tab

		// ----------------------------- Tab Friend Overview --------------------------------/
		private void populateTabFriendOverview()
        {
            UserFriendExtension extendedLoggedInUser = new UserFriendExtension { User = r_AppData.LoggedInUser };

            bindingSourceFriendOverview.DataSource = extendedLoggedInUser.Friends();

            comboBoxChooseAFriend.SelectedText = "Choose a friend to overview";
        }

        private void comboBoxChooseAFriend_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            CurrentOverviewedFriend = comboBoxChooseAFriend.SelectedItem as User;

			if (CurrentOverviewedFriend != null)
			{
				populateTitles();
				populateGeneralInfo();
				populateMutualInfo();
			}
		}

        private void populateMutualInfo()
        {
            UserFriendExtension extendedLoggedInUser = new UserFriendExtension { User = r_AppData.LoggedInUser };

            new Thread(() => populateSubTabMutualEvents(extendedLoggedInUser)).Start();
            new Thread(() => populateSubTabMutualCheckins(extendedLoggedInUser)).Start();
            new Thread(() => populateSubTabPostsTaggedMe(extendedLoggedInUser)).Start();
            new Thread(() => populateSubTabMutualGroups(extendedLoggedInUser)).Start();
            new Thread(() => populateSubTabMutualPictures(extendedLoggedInUser)).Start();
        }

        private void populateSubTabMutualGroups(UserFriendExtension i_ExtendedLoggedInUser)
        {
            clearAndAttachBindingSource(bindingSourceFriendOverviewMutualGroups, i_ExtendedLoggedInUser.GetMutualGroups(CurrentOverviewedFriend));
        }

        private void populateSubTabPostsTaggedMe(UserFriendExtension i_ExtendedLoggedInUser)
        {
            clearAndAttachBindingSource(bindingSourceFriendOverviewPostsTaggedMe, i_ExtendedLoggedInUser.GetPostsFriendTaggedUser(CurrentOverviewedFriend));
        }

        private void populateSubTabMutualCheckins(UserFriendExtension i_ExtendedLoggedInUser)
        {
			dataGridViewMutualCheckins.Invoke(new Action(() => getMutualCheckins(i_ExtendedLoggedInUser)));
        }

		private void getMutualCheckins(UserFriendExtension i_ExtendedLoggedInUser)
		{
			try
			{
				clearAndAttachBindingSource(bindingSourceFriendOverviewMutualCheckins, i_ExtendedLoggedInUser.GetMutualCheckins(CurrentOverviewedFriend));
			}
			catch (Exception)
			{
				MessageBox.Show("Coudn't fetch mutual checkins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateSubTabMutualEvents(UserFriendExtension i_extendedLoggedInUser)
        {
            try
            {
                dataGridViewMutualEvents.Invoke(new Action(() => clearAndAttachBindingSource(bindingSourceFriendOverviewMutualEvents, i_extendedLoggedInUser.GetMutualEvents(CurrentOverviewedFriend))));
            }
            catch (Exception)
            {
                // Always throws Auth Error: field 'location' has been depreciated since version 2.5 of the API
                MessageBox.Show("Couldn't fetch mutual events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateGeneralInfo()
        {
            new Thread(populatePersonalInfo).Start();
            new Thread(populateSubTabFriendEvents).Start();
            new Thread(populateSubTabFriendCheckins).Start();
            new Thread(populateSubTabFriendPosts).Start();
            new Thread(populateSubTabFriendGroups).Start();
        }

        private void populateTitles()
        {
            string title = string.Format("Upload a picture with {0}!", CurrentOverviewedFriend.FirstName);
            labelUploadMutualPic.Text = title;
            title = string.Format("Description: the picture you will choose{0}will automatically tag {1}.", Environment.NewLine, CurrentOverviewedFriend.FirstName);
            labelUploadMutualPicDescription.Text = title;
            title = string.Format("Information about {0}", CurrentOverviewedFriend.Name);
            labelGeneralFriendInfo.Text = title;
            title = string.Format("Check out your mutuals with {0}", CurrentOverviewedFriend.FirstName);
            labelMutualInfo.Text = title;
        }

		private void populateSubTabMutualPictures(UserFriendExtension i_ExtendedLoggedInUser)
		{
			clearAndAttachBindingSource(bindingSourceFriendOverviewMutualPictures, i_ExtendedLoggedInUser.GetMutualPictures(CurrentOverviewedFriend));
		}

		private void populatePersonalInfo()
		{
			panelFriendProfileData.Invoke(new Action(() => clearAndAttachBindingSource(bindingSourceFriendOverviewPersonalInfo, CurrentOverviewedFriend)));
			labelNumberOfFriends.Invoke(new Action(() => labelNumberOfFriends.Text = CurrentOverviewedFriend.Friends.Count.ToString()));
			labelRelationshipStatus.Invoke(new Action(() => labelRelationshipStatus.Text = CurrentOverviewedFriend.RelationshipStatus.ToString()));
			labelOnlineStatus.Invoke(new Action(() => labelOnlineStatus.Text = CurrentOverviewedFriend.OnlineStatus.ToString()));
            labelFriendOverviewBirthday.Invoke(new Action(() => customBirthday(labelFriendOverviewBirthday)));
        }

		private void clearAndAttachBindingSource(BindingSource i_BindingSource, object i_DataSource)
        {
            i_BindingSource.Clear();
            i_BindingSource.DataSource = i_DataSource;
        }

		private void populateSubTabFriendGroups()
		{
			dataGridViewFriendOverviewGroups.Invoke(new Action(getFriendsGroups));
		}

		private void getFriendsGroups()
		{
			try
			{
				clearAndAttachBindingSource(bindingSourceFriendOverviewGroups, CurrentOverviewedFriend.Groups);
			}
			catch (Exception)
			{
				MessageBox.Show("There was an error fetching data. (375)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateSubTabFriendPosts()
		{
			dataGridViewPostsTaggedMe.Invoke(new Action(getFriendsPosts));
		}

		private void getFriendsPosts()
		{
			try
			{
				clearAndAttachBindingSource(bindingSourceFriendOverviewPosts, CurrentOverviewedFriend.Posts);
			}
			catch (Exception)
			{
				MessageBox.Show("There was an error fetching data. (392)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateSubTabFriendCheckins()
		{
			dataGridViewFriendOvervieCheckins.Invoke(new Action(getFriendsCheckins));
		}

		private void getFriendsCheckins()
		{
			try
			{
				clearAndAttachBindingSource(bindingSourceFriendOverviewCheckins, CurrentOverviewedFriend.Checkins);
			}
			catch (Exception)
			{
				MessageBox.Show("Coudn't fetch your friend checkins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void populateSubTabFriendEvents()
        {
			dataGridViewFriendOverviewEvents.Invoke(new Action(getFriendsEvents));
        }

		private void getFriendsEvents()
		{
			try
			{
				clearAndAttachBindingSource(bindingSourceFriendOverviewEvents, CurrentOverviewedFriend.Events);
			}
			catch (Exception)
			{
				// Always throws Auth Error: field 'location' has been depreciated since version 2.5 of the API
				MessageBox.Show("Couldn't fetch your friend events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void comboBoxChooseAFriend_TextChanged(object i_Sender, EventArgs i_EventArgs)
		{
			comboBoxChooseAFriend.Text = comboBoxChooseAFriend.SelectedIndex < 0 ? "Choose a friend to overview" : comboBoxChooseAFriend.SelectedText;
		}

        private void buttonUplaodMutualPic_Click(object i_Sender, EventArgs i_EventArgs)
        {
            User currentOverviewedFriend = comboBoxChooseAFriend.SelectedItem as User;

            // Always will fail because publish_actions permissions doesnt work
            try
            {
                Post imageToUpload = r_AppData.LoggedInUser.PostPhoto(pictureBoxMutualPictureToUpload.ImageLocation, textBoxMutualPicToUploadTitle.Text);

                imageToUpload.TaggedUsers.Add(currentOverviewedFriend);
                bindingSourceFriendOverviewMutualPictures.Add(pictureBoxMutualPictureToUpload);

                MessageBox.Show("Image uploaded successfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("Couldn't upload your picture :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBrowseAPicture_Click(object i_Sender, EventArgs i_EventArgs)
        {
            OpenFileDialog pictureBrowse = new OpenFileDialog
            {
                Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png"
            };
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

		#endregion

		#region Statistics Tab

		// ----------------------------- Statistics --------------------------------/
		private void generateStatistics()
        {
            new Thread(generatePhotoStatistics).Start();
            new Thread(generatePostStatistics).Start();
			generateGeneralStatistics();
		}

		private void generateGeneralStatistics()
		{
			try
			{
				labelStatisticsGeneralEventsCreated.Text = r_AppData.LoggedInUser.EventsCreated.Count.ToString();
			}
			catch (Exception)
			{
				// Always throws Auth Error
				MessageBox.Show("Couldn't fetch your events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
			{
				labelStatisticsGeneralGroups.Text = r_AppData.LoggedInUser.Groups.Count.ToString();
			}
			catch (Exception)
			{
				// Always throws permissions error, however cannot request user_managed_groups permission (wont allow to login with it)
				MessageBox.Show("Couldn't fetch your groups!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
			{
				labelStatisticsGeneralFriends.Text = r_AppData.LoggedInUser.Friends.Count.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't fetch your friends!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
			{
				labelStatisticsGeneralCheckins.Text = r_AppData.LoggedInUser.Checkins.Count.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't fetch your checkins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			try
			{
				labelStatisticsGeneralPosts.Text = r_AppData.LoggedInUser.Posts.Count.ToString();
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't fetch your posts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void generatePostStatistics()
		{
			try
			{
				PostsStatistics postsStatistics = r_AppData.GetPostsStatistics();
				panelStatisticsPosts.Invoke(new Action(() => updatePostStatistics(postsStatistics)));
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't fetch your posts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void updatePostStatistics(PostsStatistics i_PostsStatistics)
        {
            labelStatisticsPostsTotal.Text = r_AppData.LoggedInUser.Posts.Count.ToString();
            labelStatisticsPostsPostsTaggedIn.Text = r_AppData.LoggedInUser.PostsTaggedIn.Count.ToString();
            labelStatisticsPostsMostLikes.Text = i_PostsStatistics.MostLikedCount.ToString();
            labelStatisticsPostsMostLikesByUserCount.Text = i_PostsStatistics.UserWithMostLikesCount.ToString();
            labelStatisticsPostsMostLikesByUserName.Text = i_PostsStatistics.UserWithMostLikes?.Name;
            labelStatisticsPostsMostPostsWithCount.Text = i_PostsStatistics.UserWithMostMutualPostsCount.ToString();
            labelStatisticsPostsMostPostsWithName.Text = i_PostsStatistics.UserWithMostMutualPosts?.Name;
            labelStatisticsPostsTotalLikes.Text = i_PostsStatistics.TotalLikes.ToString();
            richTextBoxMostLikedPost.Text = i_PostsStatistics.MostLiked?.Message;
        }

        private void generatePhotoStatistics()
		{
			try
			{
				PhotosStatistics photosStatistics = r_AppData.GetPhotosStatistics();
				panelStatisticsPhotos.Invoke(new Action(() => updatePhotoStatistics(photosStatistics)));
			}
			catch (Exception)
			{
				MessageBox.Show("Couldn't fetch your photos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

        private void updatePhotoStatistics(PhotosStatistics i_PhotosStatistics)
        {
            labelMostMutualPhotosWithCount.Text = i_PhotosStatistics.UserWithMostMutualPhotosCount.ToString();
            labelMostMutualPhotosWithName.Text = i_PhotosStatistics.UserWithMostMutualPhotos?.Name;
            labelMostLikesByUserCount.Text = i_PhotosStatistics.UserWithMostLikesCount.ToString();
            labelMostLikesByUserName.Text = i_PhotosStatistics.UserWithMostLikes?.Name;
            labelPhotosTaggedIn.Text = r_AppData.LoggedInUser.PhotosTaggedIn.Count.ToString();
            labelMostLikedPhotoLikes.Text = i_PhotosStatistics.MostLikedCount.ToString();
            labelTotalLikes.Text = i_PhotosStatistics.TotalLikes.ToString();
            pictureBoxMostLikedPhoto.Image = (i_PhotosStatistics.MostLiked as Photo)?.ImageNormal;
            labelStatisticsUploadedAlbums.Text = r_AppData.LoggedInUser.Albums.Count.ToString();
        }

        private void buttonCalculateStatistics_Click(object i_Sender, EventArgs i_EventArgs)
        {
            generateStatistics();
        }

		#endregion

		#region Albums Tab

		private void bindingSourcePictures_CurrentChanged(object i_Sender, EventArgs i_EventArgs)
		{
			if (bindingSourcePictures.Current != null)
			{
				labelPictureLikes.Text = (bindingSourcePictures.Current as Photo)?.LikedBy.Count.ToString();
				labelPictureName.Text = (bindingSourcePictures.Current as Photo)?.Name;
				labelPictureDate.Text = (bindingSourcePictures.Current as Photo)?.CreatedTime.ToString();
			}
		}

		#endregion
	}
}