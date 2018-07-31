using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Exception = System.Exception;

namespace MyFacebookApp
{
    public partial class FacebookApp : Form
    {
        private AppSettings m_AppSettings;
        private User m_LoggedInUser;
        private string m_AccessToken;
        private bool m_RememberUser;
        private int m_WallPostAgeInMonths = 3;
        private User m_CurrentOverviewedFriend;

        public FacebookApp()
        {
            InitializeComponent();
        }

        private void FacebookApp_Load(object sender, EventArgs e)
        {
            m_AppSettings = AppSettings.LoadAppSettings();
            this.Location = m_AppSettings.Location;
            if (!m_AppSettings.RememberUser)
            {
                FormLogin login = new FormLogin();
                DialogResult loginResult = login.ShowDialog();

                if (loginResult == DialogResult.OK)
                {
                    m_RememberUser = false;
                    m_LoggedInUser = login.LoggedInUser;
                    m_AccessToken = login.AccessToken;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                m_AccessToken = m_AppSettings.LastAccessToken;
                LoginResult loginResult = FacebookService.Connect(m_AccessToken);
                m_LoggedInUser = loginResult.LoggedInUser;
                m_RememberUser = checkBoxRememberUser.Checked = m_AppSettings.RememberUser;
            }
        }

        private void fetchUserInfo()
        {
            Text = "FB Keep Up"; // App name
            labelWelcomeUser.Text = String.Format("Hello {0} !", m_LoggedInUser.Name);
            pictureBoxProfilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            pictureBoxProfilePicture.BringToFront();

            if (m_LoggedInUser.Cover?.SourceURL != null)
            {
                pictureBoxCover.LoadAsync(m_LoggedInUser.Cover.SourceURL);
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
                bindingSourceLikedPages.DataSource = m_LoggedInUser.LikedPages;
            }
            catch (Exception ex)
            {
                //Always throws Auth Error: requires Facebook Review in order to use
                MessageBox.Show("Couldn't fetch user liked pages!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateWallPosts()
        {
            foreach (Post wallPost in m_LoggedInUser.WallPosts)
            {
                if (wallPost.CreatedTime >= DateTime.Now.AddMonths(-m_WallPostAgeInMonths))
                {
                    bindingSourceWallPosts.Add(wallPost);
                }
            }
        }

        private void populateBirthdays()
        {
            foreach (User friend in m_LoggedInUser.Friends)
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
            bindingSourceAlbums.DataSource = m_LoggedInUser.Albums;
        }

        private void populateEventsList()
        {
            try
            {
                bindingSourceEvents.DataSource = m_LoggedInUser.Events;
            }
            catch (Exception ex)
            {
                //Always throws Auth Error: field 'location' has been depreciated since version 2.5 of the API
                MessageBox.Show("Couldn't fetch user events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateFriendList()
        {
            bindingSourceFriends.DataSource = m_LoggedInUser.Friends;
        }

        private void FacebookApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_AppSettings.Location = Location;
            m_AppSettings.RememberUser = m_RememberUser;
            m_AppSettings.LastAccessToken = m_RememberUser ? m_AccessToken : String.Empty;
            m_AppSettings.SaveAppSettings();
        }

        private void FacebookApp_Shown(object sender, EventArgs e)
        {
            fetchUserInfo();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?\nYour login details will be forgotten!", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (logout == DialogResult.Yes)
            {
                FacebookService.Logout(null);
                m_RememberUser = false;
                this.Close();
            }
        }

        private void bindingSourcePictures_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSourcePictures.Current != null)
            {
                labelPictureLikes.Text = (bindingSourcePictures.Current as Photo).LikedBy.Count.ToString();
                labelPictureName.Text = (bindingSourcePictures.Current as Photo).Name;
                labelPictureDate.Text = (bindingSourcePictures.Current as Photo).CreatedTime.ToString();
            }
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (logout == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBoxRememberUser_CheckedChanged(object sender, EventArgs e)
        {
            m_RememberUser = checkBoxRememberUser.Checked;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status statusResult = m_LoggedInUser.PostStatus(textBoxPost.Text);
                MessageBox.Show("Status posted successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error uploading your status!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxWallPostAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourceWallPosts.Clear();
            m_WallPostAgeInMonths = comboBoxWallPostAge.SelectedIndex + 1;
            populateWallPosts();
        }


        private void tabControlGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlGeneral.SelectedTab == tabControlGeneral.TabPages["tabPageFriendOverview"])
            {
                populateTabFriendOverview();
            }
        }

        private void populateTabFriendOverview()
        {
            bindingSourceFriendOverview.DataSource = m_LoggedInUser.Friends;
            comboBoxChooseAFriend.SelectedText = "Choose a friend to overview";
        }

        private void comboBoxChooseAFriend_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_CurrentOverviewedFriend = comboBoxChooseAFriend.SelectedItem as User;

            if (m_CurrentOverviewedFriend != null)
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
            String title = String.Format("{0} activity:", m_CurrentOverviewedFriend.Name);
            labelFriendActivity.Text = title;

            title = String.Format("Upload a picture with {0}!", m_CurrentOverviewedFriend.FirstName);
            labelUploadMutualPic.Text = title;

            title = String.Format("Pictures of you and {0}:", m_CurrentOverviewedFriend.FirstName);
            labelMutualPictures.Text = title;

            title = String.Format("Description: the picture you will choose{0}will automatically tag your {1}.", Environment.NewLine, m_CurrentOverviewedFriend.FirstName);
            labelUploadMutualPicDescription.Text = title;
        }

        private void populateMutualPictures()
        {
            bindingSourceFriendOverviewMutualPictures.Clear();

            foreach (Photo photo in m_CurrentOverviewedFriend.PhotosTaggedIn)
            {
                if (m_LoggedInUser.PhotosTaggedIn.Contains(photo))
                {
                    bindingSourceFriendOverviewMutualPictures.Add(photo);
                    progressBarFriendshipStrength.PerformStep();
                }
            }
        }

        private void populatePersonalInfo()
        {
            bindingSourceFriendOverviewPersonalInfo.Clear();
            bindingSourceFriendOverviewPersonalInfo.DataSource = m_CurrentOverviewedFriend;
            labelNumberOfFriends.Text = m_CurrentOverviewedFriend.Friends.Count.ToString();
            labelRelationshipStatus.Text = m_CurrentOverviewedFriend.RelationshipStatus.ToString();
            labelOnlineStatus.Text = m_CurrentOverviewedFriend.OnlineStatus.ToString();
        }

        private void populateSubTabFriendGroups()
        {
            bindingSourceFriendOverviewGroups.Clear();
            bindingSourceFriendOverviewGroups.DataSource = m_CurrentOverviewedFriend.Groups;
        }

        private void populateSubTabFriendPosts()
        {
            bindingSourceFriendOverviewPosts.Clear();
            bindingSourceFriendOverviewPosts.DataSource = m_CurrentOverviewedFriend.Posts;
        }

        private void populateSubTabFriendCheckins()
        {
            bindingSourceFriendOverviewCheckins.Clear();

            try
            {
                bindingSourceFriendOverviewCheckins.DataSource = m_CurrentOverviewedFriend.Checkins;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Coudn't fetch your friend checkins!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateSubTabFriendEvents()// TODO: messageBox pops only after exiting the program
        {
            bindingSourceFriendOverviewEvents.Clear();

            try
            {
                bindingSourceFriendOverviewEvents.DataSource = m_CurrentOverviewedFriend.Events;
            }
            catch (Exception ex)
            {
                //Always throws Auth Error: field 'location' has been depreciated since version 2.5 of the API
                MessageBox.Show("Couldn't fetch your friend events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TODO: not working yet
        private void comboBoxChooseAFriend_TextChanged(object sender, EventArgs e)
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

        private void buttonUplaodMutualPic_Click(object sender, EventArgs e)
        {// TODO: add a tag of both logged in and friend
            // always will fail because publish_actions permissions doesnt work
            try
            {
                Post imageToUpload = m_LoggedInUser.PostPhoto(pictureBoxMutualPictureToUpload.ImageLocation, textBoxMutualPicToUploadTitle.Text, null, null);
                imageToUpload.TaggedUsers.Add(m_CurrentOverviewedFriend);
                bindingSourceFriendOverviewMutualPictures.Add(pictureBoxMutualPictureToUpload);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't upload your picture :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBrowseAPicture_Click_1(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
