using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using MyFacebookApp.Model.Properties;
using MyFacebookApp.Model;
using System.Security.Permissions;

namespace MyFacebookApp.Model
{
    [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
    public partial class FacebookApp : Form
    {
        public AppSettings Settings { get; private set; }

        public User LoggedInUser { get; private set; }

        public User CurrentOverviewedFriend { get; private set; }

        public string AccessToken { get; private set; }

        public bool RememberUser { get; private set; }

        public int WallPostAgeInMonths { get; private set; } = 3;

      //  public AppDomain CurrentDomain { get; private set; } = AppDomain.CurrentDomain;


        // CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

        public FacebookApp()
        {
            InitializeComponent();

           // CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);

            // Set Icon
            setFacebookAppIcon();
        }

        //private void MyHandler(object sender, UnhandledExceptionEventArgs e)
        //{
        //    MessageBox.Show("There was an error factching data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        private void setFacebookAppIcon()
        {
            Bitmap bitIcon = Resources.FBicon;
            IntPtr pIcon = bitIcon.GetHicon();
            Icon iconFrom = Icon.FromHandle(pIcon);
            Icon = iconFrom;
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

            if (LoggedInUser.Cover?.SourceURL != null)
            {
                pictureBoxCover.LoadAsync(LoggedInUser.Cover.SourceURL);
            }
            else
            {
                pictureBoxCover.Image = Resources.facebookBanner;
            }

            populateFields();
        }

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
                    DataGridViewRecentWallPosts.Invoke(new Action(() => bindingSourceWallPosts.Add(wallPost)));
                }
            }
        }

        private void populateBirthdays()
        {
            foreach (User friend in LoggedInUser.Friends)
            {
                FacebookDateAdapter friendBirthday = new FacebookDateAdapter { Date = friend.Birthday };
                DateTime dateTimeBirthday = friendBirthday.ToDateTime();

                if (dateTimeBirthday != null && birthdayIsUpcoming(dateTimeBirthday))
                {
                    bindingSourceBirthdays.Add(friend);
                }
            }
        }

        private bool birthdayIsUpcoming(DateTime i_DateTimeBirthday)
        {
            i_DateTimeBirthday.AddYears(DateTime.Now.Year - i_DateTimeBirthday.Year);

            return i_DateTimeBirthday <= DateTime.Now.AddDays(7) && i_DateTimeBirthday >= DateTime.Now;
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
            // comboBoxWallPostAge.Invoke(new Action(populateWallPosts));
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

        // ----------------------------- Tab Friend Overview --------------------------------/

        private void populateTabFriendOverview()
        {
            UserFriendsExtension extendedLoggedInUser = new UserFriendsExtension { User = LoggedInUser };

            bindingSourceFriendOverview.DataSource = extendedLoggedInUser.Friends();

            comboBoxChooseAFriend.SelectedText = "Choose a friend to overview";
        }

        private void comboBoxChooseAFriend_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            CurrentOverviewedFriend = comboBoxChooseAFriend.SelectedItem as User;

            if (CurrentOverviewedFriend != null)
            {
                try
                {
                    populateTitles();
                    populateGeneralInfo();
                    populateMutualInfo();
                }

                catch (Exception)
                {
                    //throw new Exception("Error fatching data.");
                    MessageBox.Show("There was an error factching data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void populateMutualInfo()
        {
            UserFriendsExtension extendedLoggedInUser = new UserFriendsExtension { User = LoggedInUser };
            Exception ex = null;

            new Thread(() => SafeExecute(() => populateSubTabMutualEvents(extendedLoggedInUser), out ex)).Start();
            new Thread(() => SafeExecute(() => populateSubTabMutualCheckins(extendedLoggedInUser), out ex)).Start();
            new Thread(() => SafeExecute(() => populateSubTabPostsTaggedMe(extendedLoggedInUser), out ex)).Start();
            new Thread(() => SafeExecute(() => populateSubTabMutualGroups(extendedLoggedInUser), out ex)).Start();
            new Thread(() => SafeExecute(() => populateSubTabMutualPictures(extendedLoggedInUser), out ex)).Start();
        }

        private static void SafeExecute(Action i_Action, out Exception ex)
        {
            ex = null;

            try
            {
                i_Action.Invoke();
            }
            catch (Exception exception)
            {
                ex = exception;
            }
        }

        private void populateSubTabMutualGroups(UserFriendsExtension i_ExtendedLoggedInUser)
        {
            clearAndAttachBindingSource(bindingSourceFriendOverviewMutualGroups, i_ExtendedLoggedInUser.GetMutualGroups(CurrentOverviewedFriend));
        }

        private void populateSubTabPostsTaggedMe(UserFriendsExtension i_ExtendedLoggedInUser)
        {
            clearAndAttachBindingSource(bindingSourceFriendOverviewPostsTaggedMe, i_ExtendedLoggedInUser.GetPostsFriendTaggedUser(CurrentOverviewedFriend));
        }

        private void populateSubTabMutualCheckins(UserFriendsExtension i_ExtendedLoggedInUser)
        {
            try
            {
                dataGridViewMutualCheckins.Invoke(new Action(() => clearAndAttachBindingSource(bindingSourceFriendOverviewMutualCheckins, i_ExtendedLoggedInUser.GetMutualCheckins(CurrentOverviewedFriend))));
            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't fetch mutual checkins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateSubTabMutualEvents(UserFriendsExtension i_extendedLoggedInUser)
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

        private void populateSubTabMutualPictures(UserFriendsExtension i_ExtendedLoggedInUser)
        {
            try
            {
                clearAndAttachBindingSource(bindingSourceFriendOverviewMutualPictures, i_ExtendedLoggedInUser.GetMutualPictures(CurrentOverviewedFriend));
            }
            catch (Exception)
            {
                //throw new Exception("Error fatching data.");
                MessageBox.Show("There was an error factching data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //progressBarFriendshipStrength.Increment();
        }

        private void populatePersonalInfo()
        {
            try
            {
                panelFriendProfileData.Invoke(new Action(() => clearAndAttachBindingSource(bindingSourceFriendOverviewPersonalInfo, CurrentOverviewedFriend)));
                labelNumberOfFriends.Invoke(new Action(() => labelNumberOfFriends.Text = CurrentOverviewedFriend.Friends.Count.ToString()));
                labelRelationshipStatus.Invoke(new Action(() => labelRelationshipStatus.Text = CurrentOverviewedFriend.RelationshipStatus.ToString()));
                labelOnlineStatus.Invoke(new Action(() => labelOnlineStatus.Text = CurrentOverviewedFriend.OnlineStatus.ToString()));

            }
            catch (Exception)
            {
                //throw new Exception("Error fatching data.");
                MessageBox.Show("There was an error factching data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearAndAttachBindingSource(BindingSource i_BindingSource, object i_DataSource)
        {
            i_BindingSource.Clear();
            i_BindingSource.DataSource = i_DataSource;
        }

        private void populateSubTabFriendGroups()
        {
            try
            {
                dataGridViewFriendOverviewGroups.Invoke(new Action(() => clearAndAttachBindingSource(bindingSourceFriendOverviewGroups, CurrentOverviewedFriend.Groups)));
            }
            catch (Exception)
            {
                //throw new Exception("Error fatching data.");
                MessageBox.Show("There was an error factching data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateSubTabFriendPosts()
        {
            try
            {
                dataGridViewPostsTaggedMe.Invoke(new Action(() => clearAndAttachBindingSource(bindingSourceFriendOverviewPosts, CurrentOverviewedFriend.Posts)));
            }
            catch (Exception)
            {
                //  throw new Exception("Error fatching data.");
                MessageBox.Show("There was an error factching data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateSubTabFriendCheckins()
        {
            try
            {
                dataGridViewFriendOvervieCheckins.Invoke(new Action(() => clearAndAttachBindingSource(bindingSourceFriendOverviewCheckins, CurrentOverviewedFriend.Checkins)));
            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't fetch your friend checkins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateSubTabFriendEvents()
        {
            try
            {
                dataGridViewFriendOverviewEvents.Invoke(new Action(() => clearAndAttachBindingSource(bindingSourceFriendOverviewEvents, CurrentOverviewedFriend.Events)));
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
            User currentOverviewedFriend = comboBoxChooseAFriend.SelectedItem as User;
            // always will fail because publish_actions permissions doesnt work
            try
            {
                Post imageToUpload = LoggedInUser.PostPhoto(pictureBoxMutualPictureToUpload.ImageLocation, textBoxMutualPicToUploadTitle.Text);

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

        // ----------------------------- Tab Friend Overview --------------------------------/

        private void generateStatistics()
        {
            generateGeneralStatistics();
            new Thread(generatePhotoStatistics).Start();
            new Thread(generatePostStatistics).Start();
        }

        private void generatePostStatistics()
        {
            Dictionary<User, int> mostLikesBy = new Dictionary<User, int>();
            Dictionary<User, int> mostPostsWith = new Dictionary<User, int>();
            generateUserPostsData(mostLikesBy, out Post mostLikedPost, out int mostLikedCount, out int totalLikes);
            generateTaggedPostsData(mostPostsWith);
            findMaxCountAndUser(mostLikesBy, out User mostLikesByUser, out int mostLikesByCount);
            findMaxCountAndUser(mostPostsWith, out User maxMutualPostsUser, out int maxMutualPostsCount);
            // 
            panelStatisticsPosts.Invoke(new Action(() => updatePostStatistics(mostLikesByUser, mostLikesByCount, maxMutualPostsUser, maxMutualPostsCount, mostLikedPost, mostLikedCount, totalLikes)));
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

        private void generateUserPostsData(Dictionary<User, int> i_MostLikesBy, out Post o_MostLikedPost, out int io_MostLikedCount, out int o_TotalLikes)
        {
            o_MostLikedPost = null;
            io_MostLikedCount = 0;
            o_TotalLikes = 0;
            foreach (Post post in LoggedInUser.Posts)
            {
                o_TotalLikes += post.LikedBy.Count;
                addLikesForCurrentPost(i_MostLikesBy, post);
                if (post.LikedBy.Count > io_MostLikedCount)
                {
                    io_MostLikedCount = post.LikedBy.Count;
                    o_MostLikedPost = post;
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

            //labelStatisticsGeneralFriends.Invoke(new Action(() => labelStatisticsGeneralFriends.Text = LoggedInUser.Friends.Count.ToString()));
            //labelStatisticsGeneralCheckins.Invoke(new Action(() => labelStatisticsGeneralCheckins.Text = LoggedInUser.Checkins.Count.ToString()));
            //labelStatisticsGeneralPosts.Invoke(new Action(() => labelStatisticsGeneralPosts.Text = LoggedInUser.Posts.Count.ToString()));
        }

        private void generatePhotoStatistics()
        {
            Dictionary<User, int> mostLikesBy = new Dictionary<User, int>();
            Dictionary<User, int> mostPhotosWith = new Dictionary<User, int>();
            generatePhotoData(mostLikesBy, mostPhotosWith, out Photo mostLikedPhoto, out int totalLikes, out int mostLikes);
            findMaxCountAndUser(mostPhotosWith, out User maxMutualPhotosUser, out int maxMutualPhotosCount);
            findMaxCountAndUser(mostLikesBy, out User maxLikedByUser, out int maxLikedByCount);
            // invoke
            panelStatisticsPhotos.Invoke(new Action(() => updateLikeStatistics(totalLikes, mostLikes, mostLikedPhoto, maxMutualPhotosUser, maxMutualPhotosCount, maxLikedByUser, maxLikedByCount)));
        }

        private void generatePhotoData(Dictionary<User, int> i_MostLikesBy, Dictionary<User, int> i_MostPhotosWith, out Photo o_MostLikedPhoto, out int o_TotalLikes, out int io_MostLikes)
        {
            o_TotalLikes = 0;
            io_MostLikes = 0;
            o_MostLikedPhoto = null;
            foreach (Photo photo in LoggedInUser.PhotosTaggedIn)
            {
                o_TotalLikes += photo.LikedBy.Count;
                if (photo.LikedBy.Count > io_MostLikes)
                {
                    io_MostLikes = photo.LikedBy.Count;
                    o_MostLikedPhoto = photo;
                }

                addLikesForCurrentPhoto(i_MostLikesBy, photo);
                addMutualPictureCountForCurrentPhoto(i_MostPhotosWith, photo);
            }
        }
        // invokes
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

        private void findMaxCountAndUser(Dictionary<User, int> i_MostPhotosWith, out User o_User, out int io_MaxCount)
        {
            o_User = null;
            io_MaxCount = 0;
            foreach (KeyValuePair<User, int> keyValuePair in i_MostPhotosWith)
            {
                if (io_MaxCount < keyValuePair.Value)
                {
                    io_MaxCount = keyValuePair.Value;
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