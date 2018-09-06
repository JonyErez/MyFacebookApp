namespace MyFacebookApp.View
{
	public partial class FacebookApp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label labelFriendEmailTitle;
			System.Windows.Forms.Label descriptionLabel;
			System.Windows.Forms.Label endTimeLabel;
			System.Windows.Forms.Label startTimeLabel;
			System.Windows.Forms.Label countLabel;
			System.Windows.Forms.Label createdTimeLabel;
			System.Windows.Forms.Label descriptionLabel1;
			System.Windows.Forms.Label labelFriendBirthdayTitle;
			System.Windows.Forms.Label birthdayLabel2;
			System.Windows.Forms.Label emailLabel2;
			System.Windows.Forms.Label createdTimeLabel1;
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label linkLabel;
			System.Windows.Forms.Label positionInAlbumLabel;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label7;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookApp));
			this.tabControlGeneral = new System.Windows.Forms.TabControl();
			this.tabPageGeneral = new System.Windows.Forms.TabPage();
			this.dataGridViewLikedPages = new System.Windows.Forms.DataGridView();
			this.imageSmallDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.likesCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceLikedPages = new System.Windows.Forms.BindingSource(this.components);
			this.DataGridViewRecentWallPosts = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceWallPosts = new System.Windows.Forms.BindingSource(this.components);
			this.buttonPost = new System.Windows.Forms.Button();
			this.textBoxPost = new System.Windows.Forms.TextBox();
			this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.labelGeneralFriendBirthday = new System.Windows.Forms.Label();
			this.bindingSourceFriends = new System.Windows.Forms.BindingSource(this.components);
			this.labelBirthdays = new System.Windows.Forms.Label();
			this.dataGridViewUpcomingBirthdays = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageSmallDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.bindingSourceBirthdays = new System.Windows.Forms.BindingSource(this.components);
			this.TextBoxEventDescription = new System.Windows.Forms.TextBox();
			this.bindingSourceEvents = new System.Windows.Forms.BindingSource(this.components);
			this.DateTimePickerEventEndTime = new System.Windows.Forms.DateTimePicker();
			this.PictureBoxGeneralEventImage = new System.Windows.Forms.PictureBox();
			this.DateTimePickerEventStartTime = new System.Windows.Forms.DateTimePicker();
			this.listBoxEvents = new System.Windows.Forms.ListBox();
			this.labelGeneralFriendEmail = new System.Windows.Forms.Label();
			this.PictureBoxGeneralSelectedFriend = new System.Windows.Forms.PictureBox();
			this.labelEvents = new System.Windows.Forms.Label();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.labelFriends = new System.Windows.Forms.Label();
			this.listBoxFriends = new System.Windows.Forms.ListBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.labelWelcomeUser = new System.Windows.Forms.Label();
			this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
			this.pictureBoxCover = new System.Windows.Forms.PictureBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.labelWallPosts = new System.Windows.Forms.Label();
			this.comboBoxWallPostAge = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.labelPost = new System.Windows.Forms.Label();
			this.tabPageFriendOverview = new System.Windows.Forms.TabPage();
			this.panel14 = new System.Windows.Forms.Panel();
			this.labelGeneralFriendInfo = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tabControlSubFriendOverview = new System.Windows.Forms.TabControl();
			this.tabPagePersonalInfo = new System.Windows.Forms.TabPage();
			this.panelFriendProfileData = new System.Windows.Forms.Panel();
			this.labelOnlineStatus = new System.Windows.Forms.Label();
			this.bindingSourceFriendOverviewPersonalInfo = new System.Windows.Forms.BindingSource(this.components);
			this.labelRelationshipStatus = new System.Windows.Forms.Label();
			this.labelNumberOfFriends = new System.Windows.Forms.Label();
			this.labelFriendOverviewBirthday = new System.Windows.Forms.Label();
			this.emailLabel3 = new System.Windows.Forms.Label();
			this.tabPageEvents = new System.Windows.Forms.TabPage();
			this.dataGridViewFriendOverviewEvents = new System.Windows.Forms.DataGridView();
			this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.venueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.privacyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.updateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.linkToFacebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.updateTimeStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.picturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureSmallURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureNormalURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureLargeURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureSqaureURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageSmallDataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
			this.imageNormalDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.imageLargeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.imageSqaureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageCheckins = new System.Windows.Forms.TabPage();
			this.dataGridViewFriendOvervieCheckins = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendOverviewCheckins = new System.Windows.Forms.BindingSource(this.components);
			this.tabPagePosts = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendOverviewPosts = new System.Windows.Forms.BindingSource(this.components);
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.dataGridViewFriendOverviewGroups = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.privacyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ownerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendOverviewGroups = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.progressBarFriendshipStrength = new System.Windows.Forms.ProgressBar();
			this.labelUploadMutualPicDescription = new System.Windows.Forms.Label();
			this.buttonBrowseAPicture = new System.Windows.Forms.Button();
			this.pictureBoxMutualPictureToUpload = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.buttonUplaodMutualPic = new System.Windows.Forms.Button();
			this.textBoxMutualPicToUploadTitle = new System.Windows.Forms.TextBox();
			this.panel12 = new System.Windows.Forms.Panel();
			this.labelUploadMutualPic = new System.Windows.Forms.Label();
			this.panel13 = new System.Windows.Forms.Panel();
			this.labelMutualInfo = new System.Windows.Forms.Label();
			this.tabControlMutualInfo = new System.Windows.Forms.TabControl();
			this.tabPageMutualEvents = new System.Windows.Forms.TabPage();
			this.dataGridViewMutualEvents = new System.Windows.Forms.DataGridView();
			this.ownerDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.locationDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.venueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.placeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.privacyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.updateTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.linkToFacebookDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeStringDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.updateTimeStringDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.picturesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureSmallURLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureNormalURLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureLargeURLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureSqaureURLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.imageSmallDataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
			this.imageNormalDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.imageLargeDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.imageSqaureDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendOverviewMutualEvents = new System.Windows.Forms.BindingSource(this.components);
			this.tabPageMutualCheckins = new System.Windows.Forms.TabPage();
			this.dataGridViewMutualCheckins = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendOverviewMutualCheckins = new System.Windows.Forms.BindingSource(this.components);
			this.tabPagePostsTaggedMe = new System.Windows.Forms.TabPage();
			this.dataGridViewPostsTaggedMe = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendOverviewPostsTaggedMe = new System.Windows.Forms.BindingSource(this.components);
			this.tabPageMutualGroups = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSourceFriendOverviewMutualGroups = new System.Windows.Forms.BindingSource(this.components);
			this.tabPageMutualPics = new System.Windows.Forms.TabPage();
			this.pictureBoxMutualPictures = new System.Windows.Forms.PictureBox();
			this.bindingSourceFriendOverviewMutualPictures = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.positionInAlbumTextBox = new System.Windows.Forms.TextBox();
			this.linkTextBox = new System.Windows.Forms.TextBox();
			this.createdTimeDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.bindingNavigatorMutualPic = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxChooseAFriend = new System.Windows.Forms.ComboBox();
			this.bindingSourceFriendOverview = new System.Windows.Forms.BindingSource(this.components);
			this.PictureBoxFriendOverviewSelectedFriend = new System.Windows.Forms.PictureBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.tabPageStatistics = new System.Windows.Forms.TabPage();
			this.panelStatisticsPosts = new System.Windows.Forms.Panel();
			this.labelStatisticsPostsMostLikes = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.richTextBoxMostLikedPost = new System.Windows.Forms.RichTextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.labelStatisticsPostsMostLikesByUserCount = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.labelStatisticsPostsMostLikesByUserName = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.labelStatisticsPostsMostPostsWithCount = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.labelStatisticsPostsMostPostsWithName = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.labelStatisticsPostsTotalLikes = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.labelStatisticsPostsPostsTaggedIn = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.labelStatisticsPostsTotal = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.panelStatisticsGeneral = new System.Windows.Forms.Panel();
			this.labelStatisticsGeneralPosts = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.labelStatisticsGeneralGroups = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.labelStatisticsGeneralCheckins = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.labelStatisticsGeneralEventsCreated = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.labelStatisticsGeneralFriends = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panelStatisticsPhotos = new System.Windows.Forms.Panel();
			this.labelStatisticsUploadedAlbums = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.labelMostMutualPhotosWithCount = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.labelMostLikesByUserCount = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.labelMostLikesByUserName = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.labelMostMutualPhotosWithName = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.labelMostLikedPhotoLikes = new System.Windows.Forms.Label();
			this.labelTotalLikes = new System.Windows.Forms.Label();
			this.labelPhotosTaggedIn = new System.Windows.Forms.Label();
			this.labelMostLikedPictureLikesTitle = new System.Windows.Forms.Label();
			this.pictureBoxMostLikedPhoto = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.labelTotalLikesTitle = new System.Windows.Forms.Label();
			this.labelTopLikedPictures = new System.Windows.Forms.Label();
			this.labelPhotosTaggedInTitle = new System.Windows.Forms.Label();
			this.buttonCalculateStatistics = new System.Windows.Forms.Button();
			this.tabPageAlbums = new System.Windows.Forms.TabPage();
			this.labelPictureDate = new System.Windows.Forms.Label();
			this.labelPictureDateTitle = new System.Windows.Forms.Label();
			this.labelCurrentPicture = new System.Windows.Forms.Label();
			this.labelPictureName = new System.Windows.Forms.Label();
			this.labelPictureNameTitle = new System.Windows.Forms.Label();
			this.labelPictureLikesTitle = new System.Windows.Forms.Label();
			this.labelPictureLikes = new System.Windows.Forms.Label();
			this.labelPictures = new System.Windows.Forms.Label();
			this.bindingNavigatorPictures = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingSourcePictures = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSourceAlbums = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.countLabel1 = new System.Windows.Forms.Label();
			this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
			this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
			this.labelAlbums = new System.Windows.Forms.Label();
			this.comboBoxAlbums = new System.Windows.Forms.ComboBox();
			this.panel15 = new System.Windows.Forms.Panel();
			this.panel16 = new System.Windows.Forms.Panel();
			this.panel17 = new System.Windows.Forms.Panel();
			this.tabPageTaggedPhotos = new System.Windows.Forms.TabPage();
			this.pictureBoxTaggedPhotos = new System.Windows.Forms.PictureBox();
			this.bindingSourceTaggedPhotos = new System.Windows.Forms.BindingSource(this.components);
			this.bindingNavigatorTaggedPhotos = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonGetTaggedPhotos = new System.Windows.Forms.Button();
			this.textBoxAmmounts = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.comboBoxTaggedPhotoSelectStrategys = new System.Windows.Forms.ComboBox();
			this.bindingSourceFriendOverviewEvents = new System.Windows.Forms.BindingSource(this.components);
			this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSourceLikedBy = new System.Windows.Forms.BindingSource(this.components);
			this.bindingSourceTaggedPhotosSearchStrategys = new System.Windows.Forms.BindingSource(this.components);
			labelFriendEmailTitle = new System.Windows.Forms.Label();
			descriptionLabel = new System.Windows.Forms.Label();
			endTimeLabel = new System.Windows.Forms.Label();
			startTimeLabel = new System.Windows.Forms.Label();
			countLabel = new System.Windows.Forms.Label();
			createdTimeLabel = new System.Windows.Forms.Label();
			descriptionLabel1 = new System.Windows.Forms.Label();
			labelFriendBirthdayTitle = new System.Windows.Forms.Label();
			birthdayLabel2 = new System.Windows.Forms.Label();
			emailLabel2 = new System.Windows.Forms.Label();
			createdTimeLabel1 = new System.Windows.Forms.Label();
			nameLabel = new System.Windows.Forms.Label();
			linkLabel = new System.Windows.Forms.Label();
			positionInAlbumLabel = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			this.tabControlGeneral.SuspendLayout();
			this.tabPageGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikedPages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceLikedPages)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewRecentWallPosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceWallPosts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriends)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingBirthdays)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceBirthdays)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxGeneralEventImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxGeneralSelectedFriend)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
			this.panel9.SuspendLayout();
			this.panel10.SuspendLayout();
			this.tabPageFriendOverview.SuspendLayout();
			this.panel14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.tabControlSubFriendOverview.SuspendLayout();
			this.tabPagePersonalInfo.SuspendLayout();
			this.panelFriendProfileData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewPersonalInfo)).BeginInit();
			this.tabPageEvents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendOverviewEvents)).BeginInit();
			this.tabPageCheckins.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendOvervieCheckins)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewCheckins)).BeginInit();
			this.tabPagePosts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewPosts)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendOverviewGroups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewGroups)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMutualPictureToUpload)).BeginInit();
			this.panel12.SuspendLayout();
			this.panel13.SuspendLayout();
			this.tabControlMutualInfo.SuspendLayout();
			this.tabPageMutualEvents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMutualEvents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewMutualEvents)).BeginInit();
			this.tabPageMutualCheckins.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMutualCheckins)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewMutualCheckins)).BeginInit();
			this.tabPagePostsTaggedMe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostsTaggedMe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewPostsTaggedMe)).BeginInit();
			this.tabPageMutualGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewMutualGroups)).BeginInit();
			this.tabPageMutualPics.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMutualPictures)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewMutualPictures)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMutualPic)).BeginInit();
			this.bindingNavigatorMutualPic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriendOverviewSelectedFriend)).BeginInit();
			this.tabPageStatistics.SuspendLayout();
			this.panelStatisticsPosts.SuspendLayout();
			this.panelStatisticsGeneral.SuspendLayout();
			this.panelStatisticsPhotos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).BeginInit();
			this.tabPageAlbums.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPictures)).BeginInit();
			this.bindingNavigatorPictures.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourcePictures)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlbums)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
			this.tabPageTaggedPhotos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaggedPhotos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaggedPhotos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTaggedPhotos)).BeginInit();
			this.bindingNavigatorTaggedPhotos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewEvents)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceLikedBy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaggedPhotosSearchStrategys)).BeginInit();
			this.SuspendLayout();
			// 
			// labelFriendEmailTitle
			// 
			labelFriendEmailTitle.AutoSize = true;
			labelFriendEmailTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			labelFriendEmailTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelFriendEmailTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
			labelFriendEmailTitle.Location = new System.Drawing.Point(209, 299);
			labelFriendEmailTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			labelFriendEmailTitle.Name = "labelFriendEmailTitle";
			labelFriendEmailTitle.Size = new System.Drawing.Size(67, 23);
			labelFriendEmailTitle.TabIndex = 12;
			labelFriendEmailTitle.Text = "Email:";
			// 
			// descriptionLabel
			// 
			descriptionLabel.AutoSize = true;
			descriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			descriptionLabel.ForeColor = System.Drawing.SystemColors.Info;
			descriptionLabel.Location = new System.Drawing.Point(199, 526);
			descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			descriptionLabel.Name = "descriptionLabel";
			descriptionLabel.Size = new System.Drawing.Size(122, 23);
			descriptionLabel.TabIndex = 19;
			descriptionLabel.Text = "Description:";
			// 
			// endTimeLabel
			// 
			endTimeLabel.AutoSize = true;
			endTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			endTimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			endTimeLabel.ForeColor = System.Drawing.SystemColors.Info;
			endTimeLabel.Location = new System.Drawing.Point(205, 713);
			endTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			endTimeLabel.Name = "endTimeLabel";
			endTimeLabel.Size = new System.Drawing.Size(101, 23);
			endTimeLabel.TabIndex = 21;
			endTimeLabel.Text = "End Time:";
			// 
			// startTimeLabel
			// 
			startTimeLabel.AutoSize = true;
			startTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			startTimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			startTimeLabel.ForeColor = System.Drawing.SystemColors.Info;
			startTimeLabel.Location = new System.Drawing.Point(199, 676);
			startTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			startTimeLabel.Name = "startTimeLabel";
			startTimeLabel.Size = new System.Drawing.Size(108, 23);
			startTimeLabel.TabIndex = 27;
			startTimeLabel.Text = "Start Time:";
			// 
			// countLabel
			// 
			countLabel.AutoSize = true;
			countLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			countLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			countLabel.ForeColor = System.Drawing.Color.Snow;
			countLabel.Location = new System.Drawing.Point(16, 50);
			countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			countLabel.Name = "countLabel";
			countLabel.Size = new System.Drawing.Size(183, 30);
			countLabel.TabIndex = 2;
			countLabel.Text = "Picture Count:";
			// 
			// createdTimeLabel
			// 
			createdTimeLabel.AutoSize = true;
			createdTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			createdTimeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			createdTimeLabel.ForeColor = System.Drawing.Color.Snow;
			createdTimeLabel.Location = new System.Drawing.Point(12, 90);
			createdTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			createdTimeLabel.Name = "createdTimeLabel";
			createdTimeLabel.Size = new System.Drawing.Size(188, 30);
			createdTimeLabel.TabIndex = 4;
			createdTimeLabel.Text = "Creation Time:";
			// 
			// descriptionLabel1
			// 
			descriptionLabel1.AutoSize = true;
			descriptionLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			descriptionLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			descriptionLabel1.ForeColor = System.Drawing.Color.Snow;
			descriptionLabel1.Location = new System.Drawing.Point(19, 133);
			descriptionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			descriptionLabel1.Name = "descriptionLabel1";
			descriptionLabel1.Size = new System.Drawing.Size(154, 30);
			descriptionLabel1.TabIndex = 6;
			descriptionLabel1.Text = "Description:";
			// 
			// labelFriendBirthdayTitle
			// 
			labelFriendBirthdayTitle.AutoSize = true;
			labelFriendBirthdayTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			labelFriendBirthdayTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelFriendBirthdayTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
			labelFriendBirthdayTitle.Location = new System.Drawing.Point(209, 348);
			labelFriendBirthdayTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			labelFriendBirthdayTitle.Name = "labelFriendBirthdayTitle";
			labelFriendBirthdayTitle.Size = new System.Drawing.Size(93, 23);
			labelFriendBirthdayTitle.TabIndex = 35;
			labelFriendBirthdayTitle.Text = "Birthday:";
			// 
			// birthdayLabel2
			// 
			birthdayLabel2.AutoSize = true;
			birthdayLabel2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			birthdayLabel2.ForeColor = System.Drawing.Color.Snow;
			birthdayLabel2.Location = new System.Drawing.Point(5, 17);
			birthdayLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			birthdayLabel2.Name = "birthdayLabel2";
			birthdayLabel2.Size = new System.Drawing.Size(89, 23);
			birthdayLabel2.TabIndex = 2;
			birthdayLabel2.Text = "Birthday:";
			// 
			// emailLabel2
			// 
			emailLabel2.AutoSize = true;
			emailLabel2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			emailLabel2.ForeColor = System.Drawing.Color.Snow;
			emailLabel2.Location = new System.Drawing.Point(4, 54);
			emailLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			emailLabel2.Name = "emailLabel2";
			emailLabel2.Size = new System.Drawing.Size(64, 23);
			emailLabel2.TabIndex = 4;
			emailLabel2.Text = "Email:";
			// 
			// createdTimeLabel1
			// 
			createdTimeLabel1.AutoSize = true;
			createdTimeLabel1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			createdTimeLabel1.Location = new System.Drawing.Point(51, 30);
			createdTimeLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			createdTimeLabel1.Name = "createdTimeLabel1";
			createdTimeLabel1.Size = new System.Drawing.Size(130, 23);
			createdTimeLabel1.TabIndex = 0;
			createdTimeLabel1.Text = "Created Time:";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			nameLabel.Location = new System.Drawing.Point(116, 76);
			nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(67, 23);
			nameLabel.TabIndex = 2;
			nameLabel.Text = "Name:";
			// 
			// linkLabel
			// 
			linkLabel.AutoSize = true;
			linkLabel.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			linkLabel.Location = new System.Drawing.Point(121, 130);
			linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			linkLabel.Name = "linkLabel";
			linkLabel.Size = new System.Drawing.Size(54, 23);
			linkLabel.TabIndex = 39;
			linkLabel.Text = "Link:";
			// 
			// positionInAlbumLabel
			// 
			positionInAlbumLabel.AutoSize = true;
			positionInAlbumLabel.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			positionInAlbumLabel.Location = new System.Drawing.Point(8, 178);
			positionInAlbumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			positionInAlbumLabel.Name = "positionInAlbumLabel";
			positionInAlbumLabel.Size = new System.Drawing.Size(172, 23);
			positionInAlbumLabel.TabIndex = 40;
			positionInAlbumLabel.Text = "Position In Album:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label4.ForeColor = System.Drawing.Color.Snow;
			label4.Location = new System.Drawing.Point(4, 170);
			label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(171, 23);
			label4.TabIndex = 8;
			label4.Text = "Number of friends:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label6.ForeColor = System.Drawing.Color.Snow;
			label6.Location = new System.Drawing.Point(5, 133);
			label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(174, 23);
			label6.TabIndex = 10;
			label6.Text = "Relationship status:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label7.ForeColor = System.Drawing.Color.Snow;
			label7.Location = new System.Drawing.Point(5, 95);
			label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(127, 23);
			label7.TabIndex = 12;
			label7.Text = "Online status:";
			// 
			// tabControlGeneral
			// 
			this.tabControlGeneral.Controls.Add(this.tabPageGeneral);
			this.tabControlGeneral.Controls.Add(this.tabPageFriendOverview);
			this.tabControlGeneral.Controls.Add(this.tabPageStatistics);
			this.tabControlGeneral.Controls.Add(this.tabPageAlbums);
			this.tabControlGeneral.Controls.Add(this.tabPageTaggedPhotos);
			this.tabControlGeneral.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabControlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlGeneral.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControlGeneral.Location = new System.Drawing.Point(0, 0);
			this.tabControlGeneral.Margin = new System.Windows.Forms.Padding(4);
			this.tabControlGeneral.Multiline = true;
			this.tabControlGeneral.Name = "tabControlGeneral";
			this.tabControlGeneral.Padding = new System.Drawing.Point(3, 3);
			this.tabControlGeneral.SelectedIndex = 0;
			this.tabControlGeneral.Size = new System.Drawing.Size(1413, 873);
			this.tabControlGeneral.TabIndex = 0;
			this.tabControlGeneral.SelectedIndexChanged += new System.EventHandler(this.tabControlGeneral_SelectedIndexChanged);
			// 
			// tabPageGeneral
			// 
			this.tabPageGeneral.AutoScroll = true;
			this.tabPageGeneral.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPageGeneral.Controls.Add(this.dataGridViewLikedPages);
			this.tabPageGeneral.Controls.Add(this.DataGridViewRecentWallPosts);
			this.tabPageGeneral.Controls.Add(this.buttonPost);
			this.tabPageGeneral.Controls.Add(this.textBoxPost);
			this.tabPageGeneral.Controls.Add(this.checkBoxRememberUser);
			this.tabPageGeneral.Controls.Add(this.buttonQuit);
			this.tabPageGeneral.Controls.Add(labelFriendBirthdayTitle);
			this.tabPageGeneral.Controls.Add(this.labelGeneralFriendBirthday);
			this.tabPageGeneral.Controls.Add(this.labelBirthdays);
			this.tabPageGeneral.Controls.Add(this.dataGridViewUpcomingBirthdays);
			this.tabPageGeneral.Controls.Add(descriptionLabel);
			this.tabPageGeneral.Controls.Add(this.TextBoxEventDescription);
			this.tabPageGeneral.Controls.Add(endTimeLabel);
			this.tabPageGeneral.Controls.Add(this.DateTimePickerEventEndTime);
			this.tabPageGeneral.Controls.Add(this.PictureBoxGeneralEventImage);
			this.tabPageGeneral.Controls.Add(startTimeLabel);
			this.tabPageGeneral.Controls.Add(this.DateTimePickerEventStartTime);
			this.tabPageGeneral.Controls.Add(this.listBoxEvents);
			this.tabPageGeneral.Controls.Add(labelFriendEmailTitle);
			this.tabPageGeneral.Controls.Add(this.labelGeneralFriendEmail);
			this.tabPageGeneral.Controls.Add(this.PictureBoxGeneralSelectedFriend);
			this.tabPageGeneral.Controls.Add(this.labelEvents);
			this.tabPageGeneral.Controls.Add(this.buttonLogout);
			this.tabPageGeneral.Controls.Add(this.labelFriends);
			this.tabPageGeneral.Controls.Add(this.listBoxFriends);
			this.tabPageGeneral.Controls.Add(this.panel3);
			this.tabPageGeneral.Controls.Add(this.panel4);
			this.tabPageGeneral.Controls.Add(this.panel5);
			this.tabPageGeneral.Controls.Add(this.panel6);
			this.tabPageGeneral.Controls.Add(this.panel2);
			this.tabPageGeneral.Controls.Add(this.panel7);
			this.tabPageGeneral.Controls.Add(this.panel8);
			this.tabPageGeneral.Controls.Add(this.panel9);
			this.tabPageGeneral.Controls.Add(this.panel10);
			this.tabPageGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.tabPageGeneral.Location = new System.Drawing.Point(4, 27);
			this.tabPageGeneral.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageGeneral.Name = "tabPageGeneral";
			this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageGeneral.Size = new System.Drawing.Size(1405, 842);
			this.tabPageGeneral.TabIndex = 0;
			this.tabPageGeneral.Text = "General";
			// 
			// dataGridViewLikedPages
			// 
			this.dataGridViewLikedPages.AllowUserToAddRows = false;
			this.dataGridViewLikedPages.AllowUserToDeleteRows = false;
			this.dataGridViewLikedPages.AutoGenerateColumns = false;
			this.dataGridViewLikedPages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewLikedPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLikedPages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageSmallDataGridViewImageColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.likesCountDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
			this.dataGridViewLikedPages.DataSource = this.bindingSourceLikedPages;
			this.dataGridViewLikedPages.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridViewLikedPages.Location = new System.Drawing.Point(417, 207);
			this.dataGridViewLikedPages.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewLikedPages.Name = "dataGridViewLikedPages";
			this.dataGridViewLikedPages.ReadOnly = true;
			this.dataGridViewLikedPages.Size = new System.Drawing.Size(476, 199);
			this.dataGridViewLikedPages.TabIndex = 48;
			// 
			// imageSmallDataGridViewImageColumn1
			// 
			this.imageSmallDataGridViewImageColumn1.DataPropertyName = "ImageSmall";
			this.imageSmallDataGridViewImageColumn1.HeaderText = "Page Picture";
			this.imageSmallDataGridViewImageColumn1.Name = "imageSmallDataGridViewImageColumn1";
			this.imageSmallDataGridViewImageColumn1.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// likesCountDataGridViewTextBoxColumn
			// 
			this.likesCountDataGridViewTextBoxColumn.DataPropertyName = "LikesCount";
			this.likesCountDataGridViewTextBoxColumn.HeaderText = "LikesCount";
			this.likesCountDataGridViewTextBoxColumn.Name = "likesCountDataGridViewTextBoxColumn";
			this.likesCountDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// locationDataGridViewTextBoxColumn
			// 
			this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
			this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
			this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
			this.locationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bindingSourceLikedPages
			// 
			this.bindingSourceLikedPages.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
			// 
			// DataGridViewRecentWallPosts
			// 
			this.DataGridViewRecentWallPosts.AllowUserToAddRows = false;
			this.DataGridViewRecentWallPosts.AllowUserToDeleteRows = false;
			this.DataGridViewRecentWallPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridViewRecentWallPosts.AutoGenerateColumns = false;
			this.DataGridViewRecentWallPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DataGridViewRecentWallPosts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.DataGridViewRecentWallPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridViewRecentWallPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Link,
            this.dataGridViewTextBoxColumn14});
			this.DataGridViewRecentWallPosts.DataSource = this.bindingSourceWallPosts;
			this.DataGridViewRecentWallPosts.GridColor = System.Drawing.SystemColors.Control;
			this.DataGridViewRecentWallPosts.Location = new System.Drawing.Point(615, 450);
			this.DataGridViewRecentWallPosts.Margin = new System.Windows.Forms.Padding(4);
			this.DataGridViewRecentWallPosts.Name = "DataGridViewRecentWallPosts";
			this.DataGridViewRecentWallPosts.ReadOnly = true;
			this.DataGridViewRecentWallPosts.RowHeadersWidth = 40;
			this.DataGridViewRecentWallPosts.Size = new System.Drawing.Size(777, 273);
			this.DataGridViewRecentWallPosts.TabIndex = 44;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Message";
			this.dataGridViewTextBoxColumn1.HeaderText = "Message";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 94;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn4.HeaderText = "Name";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 74;
			// 
			// Link
			// 
			this.Link.DataPropertyName = "Link";
			this.Link.HeaderText = "Link";
			this.Link.Name = "Link";
			this.Link.ReadOnly = true;
			this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Link.Width = 63;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.DataPropertyName = "CreatedTime";
			this.dataGridViewTextBoxColumn14.HeaderText = "CreatedTime";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Width = 118;
			// 
			// bindingSourceWallPosts
			// 
			this.bindingSourceWallPosts.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
			// 
			// buttonPost
			// 
			this.buttonPost.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPost.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonPost.Location = new System.Drawing.Point(1249, 750);
			this.buttonPost.Margin = new System.Windows.Forms.Padding(4);
			this.buttonPost.Name = "buttonPost";
			this.buttonPost.Size = new System.Drawing.Size(133, 31);
			this.buttonPost.TabIndex = 43;
			this.buttonPost.Text = "Post";
			this.buttonPost.UseVisualStyleBackColor = false;
			this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
			// 
			// textBoxPost
			// 
			this.textBoxPost.Location = new System.Drawing.Point(791, 750);
			this.textBoxPost.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxPost.Name = "textBoxPost";
			this.textBoxPost.Size = new System.Drawing.Size(449, 23);
			this.textBoxPost.TabIndex = 42;
			// 
			// checkBoxRememberUser
			// 
			this.checkBoxRememberUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxRememberUser.AutoSize = true;
			this.checkBoxRememberUser.BackColor = System.Drawing.Color.LimeGreen;
			this.checkBoxRememberUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBoxRememberUser.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBoxRememberUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.checkBoxRememberUser.Location = new System.Drawing.Point(969, 814);
			this.checkBoxRememberUser.Margin = new System.Windows.Forms.Padding(4);
			this.checkBoxRememberUser.Name = "checkBoxRememberUser";
			this.checkBoxRememberUser.Size = new System.Drawing.Size(138, 21);
			this.checkBoxRememberUser.TabIndex = 39;
			this.checkBoxRememberUser.Text = "Remember me?";
			this.checkBoxRememberUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxRememberUser.UseVisualStyleBackColor = false;
			this.checkBoxRememberUser.CheckedChanged += new System.EventHandler(this.checkBoxRememberUser_CheckedChanged);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonQuit.BackColor = System.Drawing.Color.Silver;
			this.buttonQuit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonQuit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonQuit.Location = new System.Drawing.Point(1248, 806);
			this.buttonQuit.Margin = new System.Windows.Forms.Padding(4);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(137, 28);
			this.buttonQuit.TabIndex = 38;
			this.buttonQuit.Text = "Quit";
			this.buttonQuit.UseVisualStyleBackColor = false;
			this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
			// 
			// labelGeneralFriendBirthday
			// 
			this.labelGeneralFriendBirthday.AutoSize = true;
			this.labelGeneralFriendBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelGeneralFriendBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriends, "Birthday", true));
			this.labelGeneralFriendBirthday.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGeneralFriendBirthday.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.labelGeneralFriendBirthday.Location = new System.Drawing.Point(211, 372);
			this.labelGeneralFriendBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelGeneralFriendBirthday.Name = "labelGeneralFriendBirthday";
			this.labelGeneralFriendBirthday.Size = new System.Drawing.Size(60, 21);
			this.labelGeneralFriendBirthday.TabIndex = 36;
			this.labelGeneralFriendBirthday.Text = "label1";
			// 
			// bindingSourceFriends
			// 
			this.bindingSourceFriends.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// labelBirthdays
			// 
			this.labelBirthdays.AutoSize = true;
			this.labelBirthdays.BackColor = System.Drawing.Color.DarkOrange;
			this.labelBirthdays.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBirthdays.Location = new System.Drawing.Point(904, 172);
			this.labelBirthdays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelBirthdays.Name = "labelBirthdays";
			this.labelBirthdays.Size = new System.Drawing.Size(283, 33);
			this.labelBirthdays.TabIndex = 35;
			this.labelBirthdays.Text = "Upcoming Birthdays:\r\n";
			// 
			// dataGridViewUpcomingBirthdays
			// 
			this.dataGridViewUpcomingBirthdays.AllowUserToAddRows = false;
			this.dataGridViewUpcomingBirthdays.AllowUserToDeleteRows = false;
			this.dataGridViewUpcomingBirthdays.AllowUserToResizeColumns = false;
			this.dataGridViewUpcomingBirthdays.AllowUserToResizeRows = false;
			this.dataGridViewUpcomingBirthdays.AutoGenerateColumns = false;
			this.dataGridViewUpcomingBirthdays.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dataGridViewUpcomingBirthdays.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewUpcomingBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUpcomingBirthdays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.imageSmallDataGridViewImageColumn});
			this.dataGridViewUpcomingBirthdays.DataSource = this.bindingSourceBirthdays;
			this.dataGridViewUpcomingBirthdays.Location = new System.Drawing.Point(901, 207);
			this.dataGridViewUpcomingBirthdays.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewUpcomingBirthdays.Name = "dataGridViewUpcomingBirthdays";
			this.dataGridViewUpcomingBirthdays.Size = new System.Drawing.Size(491, 199);
			this.dataGridViewUpcomingBirthdays.TabIndex = 34;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// birthdayDataGridViewTextBoxColumn
			// 
			this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
			this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday (mm/dd/yyyy)";
			this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
			this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
			this.birthdayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// imageSmallDataGridViewImageColumn
			// 
			this.imageSmallDataGridViewImageColumn.DataPropertyName = "ImageSmall";
			this.imageSmallDataGridViewImageColumn.HeaderText = "Profile Picture";
			this.imageSmallDataGridViewImageColumn.Name = "imageSmallDataGridViewImageColumn";
			this.imageSmallDataGridViewImageColumn.ReadOnly = true;
			// 
			// bindingSourceBirthdays
			// 
			this.bindingSourceBirthdays.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// TextBoxEventDescription
			// 
			this.TextBoxEventDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceEvents, "Description", true));
			this.TextBoxEventDescription.Enabled = false;
			this.TextBoxEventDescription.Location = new System.Drawing.Point(333, 527);
			this.TextBoxEventDescription.Margin = new System.Windows.Forms.Padding(4);
			this.TextBoxEventDescription.Multiline = true;
			this.TextBoxEventDescription.Name = "TextBoxEventDescription";
			this.TextBoxEventDescription.Size = new System.Drawing.Size(265, 127);
			this.TextBoxEventDescription.TabIndex = 20;
			// 
			// bindingSourceEvents
			// 
			this.bindingSourceEvents.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
			// 
			// DateTimePickerEventEndTime
			// 
			this.DateTimePickerEventEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceEvents, "EndTime", true));
			this.DateTimePickerEventEndTime.Enabled = false;
			this.DateTimePickerEventEndTime.Location = new System.Drawing.Point(333, 710);
			this.DateTimePickerEventEndTime.Margin = new System.Windows.Forms.Padding(4);
			this.DateTimePickerEventEndTime.Name = "DateTimePickerEventEndTime";
			this.DateTimePickerEventEndTime.Size = new System.Drawing.Size(265, 23);
			this.DateTimePickerEventEndTime.TabIndex = 22;
			// 
			// PictureBoxGeneralEventImage
			// 
			this.PictureBoxGeneralEventImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBoxGeneralEventImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceEvents, "ImageNormal", true));
			this.PictureBoxGeneralEventImage.Location = new System.Drawing.Point(211, 449);
			this.PictureBoxGeneralEventImage.Margin = new System.Windows.Forms.Padding(4);
			this.PictureBoxGeneralEventImage.Name = "PictureBoxGeneralEventImage";
			this.PictureBoxGeneralEventImage.Size = new System.Drawing.Size(79, 73);
			this.PictureBoxGeneralEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxGeneralEventImage.TabIndex = 24;
			this.PictureBoxGeneralEventImage.TabStop = false;
			// 
			// DateTimePickerEventStartTime
			// 
			this.DateTimePickerEventStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceEvents, "StartTime", true));
			this.DateTimePickerEventStartTime.Enabled = false;
			this.DateTimePickerEventStartTime.Location = new System.Drawing.Point(333, 673);
			this.DateTimePickerEventStartTime.Margin = new System.Windows.Forms.Padding(4);
			this.DateTimePickerEventStartTime.Name = "DateTimePickerEventStartTime";
			this.DateTimePickerEventStartTime.Size = new System.Drawing.Size(265, 23);
			this.DateTimePickerEventStartTime.TabIndex = 28;
			// 
			// listBoxEvents
			// 
			this.listBoxEvents.DataSource = this.bindingSourceEvents;
			this.listBoxEvents.DisplayMember = "Name";
			this.listBoxEvents.FormattingEnabled = true;
			this.listBoxEvents.ItemHeight = 17;
			this.listBoxEvents.Location = new System.Drawing.Point(9, 449);
			this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxEvents.Name = "listBoxEvents";
			this.listBoxEvents.Size = new System.Drawing.Size(188, 361);
			this.listBoxEvents.TabIndex = 19;
			// 
			// labelGeneralFriendEmail
			// 
			this.labelGeneralFriendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelGeneralFriendEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriends, "Email", true));
			this.labelGeneralFriendEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGeneralFriendEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.labelGeneralFriendEmail.Location = new System.Drawing.Point(211, 325);
			this.labelGeneralFriendEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelGeneralFriendEmail.Name = "labelGeneralFriendEmail";
			this.labelGeneralFriendEmail.Size = new System.Drawing.Size(199, 23);
			this.labelGeneralFriendEmail.TabIndex = 13;
			this.labelGeneralFriendEmail.Text = "label1";
			// 
			// PictureBoxGeneralSelectedFriend
			// 
			this.PictureBoxGeneralSelectedFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBoxGeneralSelectedFriend.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceFriends, "ImageNormal", true));
			this.PictureBoxGeneralSelectedFriend.Location = new System.Drawing.Point(212, 209);
			this.PictureBoxGeneralSelectedFriend.Margin = new System.Windows.Forms.Padding(4);
			this.PictureBoxGeneralSelectedFriend.Name = "PictureBoxGeneralSelectedFriend";
			this.PictureBoxGeneralSelectedFriend.Size = new System.Drawing.Size(101, 80);
			this.PictureBoxGeneralSelectedFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBoxGeneralSelectedFriend.TabIndex = 15;
			this.PictureBoxGeneralSelectedFriend.TabStop = false;
			// 
			// labelEvents
			// 
			this.labelEvents.AutoSize = true;
			this.labelEvents.BackColor = System.Drawing.Color.DarkOrange;
			this.labelEvents.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelEvents.Location = new System.Drawing.Point(11, 417);
			this.labelEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelEvents.Name = "labelEvents";
			this.labelEvents.Size = new System.Drawing.Size(140, 30);
			this.labelEvents.TabIndex = 10;
			this.labelEvents.Text = "My Events:";
			// 
			// buttonLogout
			// 
			this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLogout.BackColor = System.Drawing.Color.Silver;
			this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonLogout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonLogout.Location = new System.Drawing.Point(1115, 806);
			this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(125, 28);
			this.buttonLogout.TabIndex = 4;
			this.buttonLogout.Text = "Logout";
			this.buttonLogout.UseVisualStyleBackColor = false;
			this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
			// 
			// labelFriends
			// 
			this.labelFriends.AutoSize = true;
			this.labelFriends.BackColor = System.Drawing.Color.DarkOrange;
			this.labelFriends.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFriends.Location = new System.Drawing.Point(4, 172);
			this.labelFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelFriends.Name = "labelFriends";
			this.labelFriends.Size = new System.Drawing.Size(141, 30);
			this.labelFriends.TabIndex = 3;
			this.labelFriends.Text = "My friends:";
			// 
			// listBoxFriends
			// 
			this.listBoxFriends.DataSource = this.bindingSourceFriends;
			this.listBoxFriends.DisplayMember = "Name";
			this.listBoxFriends.FormattingEnabled = true;
			this.listBoxFriends.ItemHeight = 17;
			this.listBoxFriends.Location = new System.Drawing.Point(7, 202);
			this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
			this.listBoxFriends.Name = "listBoxFriends";
			this.listBoxFriends.Size = new System.Drawing.Size(188, 191);
			this.listBoxFriends.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel3.Location = new System.Drawing.Point(7, 202);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(403, 204);
			this.panel3.TabIndex = 52;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkOrange;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Location = new System.Drawing.Point(7, 171);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(402, 40);
			this.panel4.TabIndex = 53;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.DarkOrange;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.label2);
			this.panel5.Location = new System.Drawing.Point(417, 171);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(475, 40);
			this.panel5.TabIndex = 54;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.DarkOrange;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(1, 1);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 33);
			this.label2.TabIndex = 47;
			this.label2.Text = "Liked Pages: ";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.DarkOrange;
			this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel6.Location = new System.Drawing.Point(900, 171);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(491, 36);
			this.panel6.TabIndex = 55;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.labelWelcomeUser);
			this.panel2.Controls.Add(this.pictureBoxProfilePicture);
			this.panel2.Controls.Add(this.pictureBoxCover);
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1399, 164);
			this.panel2.TabIndex = 51;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(945, 22);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(425, 42);
			this.label8.TabIndex = 50;
			this.label8.Text = "Keep Up with everything that is going on with you,\r\nyour friends and get like and" +
    " comments analyzed.";
			// 
			// labelWelcomeUser
			// 
			this.labelWelcomeUser.AutoSize = true;
			this.labelWelcomeUser.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWelcomeUser.Location = new System.Drawing.Point(171, 16);
			this.labelWelcomeUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelWelcomeUser.Name = "labelWelcomeUser";
			this.labelWelcomeUser.Size = new System.Drawing.Size(286, 44);
			this.labelWelcomeUser.TabIndex = 49;
			this.labelWelcomeUser.Text = "Welcome User!";
			// 
			// pictureBoxProfilePicture
			// 
			this.pictureBoxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxProfilePicture.Location = new System.Drawing.Point(23, 34);
			this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
			this.pictureBoxProfilePicture.Size = new System.Drawing.Size(133, 123);
			this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxProfilePicture.TabIndex = 0;
			this.pictureBoxProfilePicture.TabStop = false;
			// 
			// pictureBoxCover
			// 
			this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxCover.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCover.InitialImage")));
			this.pictureBoxCover.Location = new System.Drawing.Point(165, 62);
			this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxCover.Name = "pictureBoxCover";
			this.pictureBoxCover.Size = new System.Drawing.Size(1233, 102);
			this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxCover.TabIndex = 40;
			this.pictureBoxCover.TabStop = false;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.DarkOrange;
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Location = new System.Drawing.Point(7, 414);
			this.panel7.Margin = new System.Windows.Forms.Padding(4);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(599, 36);
			this.panel7.TabIndex = 54;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel8.Location = new System.Drawing.Point(7, 448);
			this.panel8.Margin = new System.Windows.Forms.Padding(4);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(600, 383);
			this.panel8.TabIndex = 53;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.DarkOrange;
			this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel9.Controls.Add(this.labelWallPosts);
			this.panel9.Controls.Add(this.comboBoxWallPostAge);
			this.panel9.Controls.Add(this.label1);
			this.panel9.Location = new System.Drawing.Point(615, 414);
			this.panel9.Margin = new System.Windows.Forms.Padding(4);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(777, 36);
			this.panel9.TabIndex = 55;
			// 
			// labelWallPosts
			// 
			this.labelWallPosts.AutoSize = true;
			this.labelWallPosts.BackColor = System.Drawing.Color.DarkOrange;
			this.labelWallPosts.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelWallPosts.Location = new System.Drawing.Point(5, 0);
			this.labelWallPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelWallPosts.Name = "labelWallPosts";
			this.labelWallPosts.Size = new System.Drawing.Size(268, 37);
			this.labelWallPosts.TabIndex = 44;
			this.labelWallPosts.Text = "Recent Wall Posts";
			// 
			// comboBoxWallPostAge
			// 
			this.comboBoxWallPostAge.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxWallPostAge.FormattingEnabled = true;
			this.comboBoxWallPostAge.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.comboBoxWallPostAge.Location = new System.Drawing.Point(508, 4);
			this.comboBoxWallPostAge.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxWallPostAge.MaxDropDownItems = 12;
			this.comboBoxWallPostAge.Name = "comboBoxWallPostAge";
			this.comboBoxWallPostAge.Size = new System.Drawing.Size(100, 27);
			this.comboBoxWallPostAge.TabIndex = 45;
			this.comboBoxWallPostAge.SelectedIndexChanged += new System.EventHandler(this.comboBoxWallPostAge_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.DarkOrange;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(303, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 20);
			this.label1.TabIndex = 46;
			this.label1.Text = "Wall Posts Age (Months):";
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.White;
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel10.Controls.Add(this.labelPost);
			this.panel10.Location = new System.Drawing.Point(615, 731);
			this.panel10.Margin = new System.Windows.Forms.Padding(4);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(777, 67);
			this.panel10.TabIndex = 55;
			// 
			// labelPost
			// 
			this.labelPost.AutoSize = true;
			this.labelPost.BackColor = System.Drawing.Color.White;
			this.labelPost.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPost.Location = new System.Drawing.Point(7, 18);
			this.labelPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPost.Name = "labelPost";
			this.labelPost.Size = new System.Drawing.Size(160, 33);
			this.labelPost.TabIndex = 41;
			this.labelPost.Text = "Post Status:";
			// 
			// tabPageFriendOverview
			// 
			this.tabPageFriendOverview.AutoScroll = true;
			this.tabPageFriendOverview.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPageFriendOverview.Controls.Add(this.panel14);
			this.tabPageFriendOverview.Controls.Add(this.splitContainer1);
			this.tabPageFriendOverview.Controls.Add(this.label3);
			this.tabPageFriendOverview.Controls.Add(this.comboBoxChooseAFriend);
			this.tabPageFriendOverview.Controls.Add(this.PictureBoxFriendOverviewSelectedFriend);
			this.tabPageFriendOverview.Controls.Add(this.panel11);
			this.tabPageFriendOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.tabPageFriendOverview.Location = new System.Drawing.Point(4, 27);
			this.tabPageFriendOverview.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageFriendOverview.Name = "tabPageFriendOverview";
			this.tabPageFriendOverview.Size = new System.Drawing.Size(1405, 842);
			this.tabPageFriendOverview.TabIndex = 2;
			this.tabPageFriendOverview.Text = "Friend Overview";
			// 
			// panel14
			// 
			this.panel14.BackColor = System.Drawing.Color.DarkOrange;
			this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel14.Controls.Add(this.labelGeneralFriendInfo);
			this.panel14.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.panel14.Location = new System.Drawing.Point(11, 135);
			this.panel14.Margin = new System.Windows.Forms.Padding(4);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(723, 45);
			this.panel14.TabIndex = 41;
			// 
			// labelGeneralFriendInfo
			// 
			this.labelGeneralFriendInfo.AutoSize = true;
			this.labelGeneralFriendInfo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelGeneralFriendInfo.Location = new System.Drawing.Point(8, 6);
			this.labelGeneralFriendInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelGeneralFriendInfo.Name = "labelGeneralFriendInfo";
			this.labelGeneralFriendInfo.Size = new System.Drawing.Size(398, 33);
			this.labelGeneralFriendInfo.TabIndex = 37;
			this.labelGeneralFriendInfo.Text = "Information about your friend";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(11, 135);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel13);
			this.splitContainer1.Panel2.Controls.Add(this.tabControlMutualInfo);
			this.splitContainer1.Size = new System.Drawing.Size(1392, 694);
			this.splitContainer1.SplitterDistance = 383;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 40;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tabControlSubFriendOverview);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.splitContainer2.Panel2.Controls.Add(this.label5);
			this.splitContainer2.Panel2.Controls.Add(this.progressBarFriendshipStrength);
			this.splitContainer2.Panel2.Controls.Add(this.labelUploadMutualPicDescription);
			this.splitContainer2.Panel2.Controls.Add(this.buttonBrowseAPicture);
			this.splitContainer2.Panel2.Controls.Add(this.pictureBoxMutualPictureToUpload);
			this.splitContainer2.Panel2.Controls.Add(this.label12);
			this.splitContainer2.Panel2.Controls.Add(this.buttonUplaodMutualPic);
			this.splitContainer2.Panel2.Controls.Add(this.textBoxMutualPicToUploadTitle);
			this.splitContainer2.Panel2.Controls.Add(this.panel12);
			this.splitContainer2.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.splitContainer2.Size = new System.Drawing.Size(1392, 383);
			this.splitContainer2.SplitterDistance = 729;
			this.splitContainer2.SplitterWidth = 5;
			this.splitContainer2.TabIndex = 0;
			// 
			// tabControlSubFriendOverview
			// 
			this.tabControlSubFriendOverview.Controls.Add(this.tabPagePersonalInfo);
			this.tabControlSubFriendOverview.Controls.Add(this.tabPageEvents);
			this.tabControlSubFriendOverview.Controls.Add(this.tabPageCheckins);
			this.tabControlSubFriendOverview.Controls.Add(this.tabPagePosts);
			this.tabControlSubFriendOverview.Controls.Add(this.tabPageGroups);
			this.tabControlSubFriendOverview.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabControlSubFriendOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.tabControlSubFriendOverview.Location = new System.Drawing.Point(0, 42);
			this.tabControlSubFriendOverview.Margin = new System.Windows.Forms.Padding(4);
			this.tabControlSubFriendOverview.Multiline = true;
			this.tabControlSubFriendOverview.Name = "tabControlSubFriendOverview";
			this.tabControlSubFriendOverview.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabControlSubFriendOverview.SelectedIndex = 0;
			this.tabControlSubFriendOverview.Size = new System.Drawing.Size(729, 342);
			this.tabControlSubFriendOverview.TabIndex = 2;
			// 
			// tabPagePersonalInfo
			// 
			this.tabPagePersonalInfo.Controls.Add(this.panelFriendProfileData);
			this.tabPagePersonalInfo.Location = new System.Drawing.Point(4, 27);
			this.tabPagePersonalInfo.Margin = new System.Windows.Forms.Padding(4);
			this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
			this.tabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(4);
			this.tabPagePersonalInfo.Size = new System.Drawing.Size(721, 311);
			this.tabPagePersonalInfo.TabIndex = 4;
			this.tabPagePersonalInfo.Text = "Personal Info";
			this.tabPagePersonalInfo.UseVisualStyleBackColor = true;
			// 
			// panelFriendProfileData
			// 
			this.panelFriendProfileData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelFriendProfileData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelFriendProfileData.Controls.Add(this.labelOnlineStatus);
			this.panelFriendProfileData.Controls.Add(label7);
			this.panelFriendProfileData.Controls.Add(this.labelRelationshipStatus);
			this.panelFriendProfileData.Controls.Add(label6);
			this.panelFriendProfileData.Controls.Add(this.labelNumberOfFriends);
			this.panelFriendProfileData.Controls.Add(label4);
			this.panelFriendProfileData.Controls.Add(birthdayLabel2);
			this.panelFriendProfileData.Controls.Add(this.labelFriendOverviewBirthday);
			this.panelFriendProfileData.Controls.Add(emailLabel2);
			this.panelFriendProfileData.Controls.Add(this.emailLabel3);
			this.panelFriendProfileData.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.panelFriendProfileData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelFriendProfileData.Location = new System.Drawing.Point(4, 4);
			this.panelFriendProfileData.Margin = new System.Windows.Forms.Padding(4);
			this.panelFriendProfileData.Name = "panelFriendProfileData";
			this.panelFriendProfileData.Size = new System.Drawing.Size(713, 303);
			this.panelFriendProfileData.TabIndex = 3;
			// 
			// labelOnlineStatus
			// 
			this.labelOnlineStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriendOverviewPersonalInfo, "Email", true));
			this.labelOnlineStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOnlineStatus.ForeColor = System.Drawing.Color.Snow;
			this.labelOnlineStatus.Location = new System.Drawing.Point(145, 95);
			this.labelOnlineStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelOnlineStatus.Name = "labelOnlineStatus";
			this.labelOnlineStatus.Size = new System.Drawing.Size(133, 28);
			this.labelOnlineStatus.TabIndex = 13;
			this.labelOnlineStatus.Text = "label4";
			// 
			// bindingSourceFriendOverviewPersonalInfo
			// 
			this.bindingSourceFriendOverviewPersonalInfo.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// labelRelationshipStatus
			// 
			this.labelRelationshipStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriendOverviewPersonalInfo, "Email", true));
			this.labelRelationshipStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRelationshipStatus.ForeColor = System.Drawing.Color.Snow;
			this.labelRelationshipStatus.Location = new System.Drawing.Point(193, 133);
			this.labelRelationshipStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRelationshipStatus.Name = "labelRelationshipStatus";
			this.labelRelationshipStatus.Size = new System.Drawing.Size(133, 28);
			this.labelRelationshipStatus.TabIndex = 11;
			this.labelRelationshipStatus.Text = "label4";
			// 
			// labelNumberOfFriends
			// 
			this.labelNumberOfFriends.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriendOverviewPersonalInfo, "Email", true));
			this.labelNumberOfFriends.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumberOfFriends.ForeColor = System.Drawing.Color.Snow;
			this.labelNumberOfFriends.Location = new System.Drawing.Point(193, 170);
			this.labelNumberOfFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelNumberOfFriends.Name = "labelNumberOfFriends";
			this.labelNumberOfFriends.Size = new System.Drawing.Size(133, 28);
			this.labelNumberOfFriends.TabIndex = 9;
			this.labelNumberOfFriends.Text = "label4";
			// 
			// labelFriendOverviewBirthday
			// 
			this.labelFriendOverviewBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriendOverviewPersonalInfo, "Birthday", true));
			this.labelFriendOverviewBirthday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFriendOverviewBirthday.ForeColor = System.Drawing.Color.Snow;
			this.labelFriendOverviewBirthday.Location = new System.Drawing.Point(113, 17);
			this.labelFriendOverviewBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelFriendOverviewBirthday.Name = "labelFriendOverviewBirthday";
			this.labelFriendOverviewBirthday.Size = new System.Drawing.Size(133, 28);
			this.labelFriendOverviewBirthday.TabIndex = 3;
			this.labelFriendOverviewBirthday.Text = "label4";
			// 
			// emailLabel3
			// 
			this.emailLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriendOverviewPersonalInfo, "Email", true));
			this.emailLabel3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel3.ForeColor = System.Drawing.Color.Snow;
			this.emailLabel3.Location = new System.Drawing.Point(112, 54);
			this.emailLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.emailLabel3.Name = "emailLabel3";
			this.emailLabel3.Size = new System.Drawing.Size(133, 28);
			this.emailLabel3.TabIndex = 5;
			this.emailLabel3.Text = "label4";
			// 
			// tabPageEvents
			// 
			this.tabPageEvents.Controls.Add(this.dataGridViewFriendOverviewEvents);
			this.tabPageEvents.Location = new System.Drawing.Point(4, 27);
			this.tabPageEvents.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageEvents.Name = "tabPageEvents";
			this.tabPageEvents.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageEvents.Size = new System.Drawing.Size(721, 311);
			this.tabPageEvents.TabIndex = 0;
			this.tabPageEvents.Text = "Events";
			this.tabPageEvents.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFriendOverviewEvents
			// 
			this.dataGridViewFriendOverviewEvents.AllowUserToAddRows = false;
			this.dataGridViewFriendOverviewEvents.AllowUserToDeleteRows = false;
			this.dataGridViewFriendOverviewEvents.AutoGenerateColumns = false;
			this.dataGridViewFriendOverviewEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewFriendOverviewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFriendOverviewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn1,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn1,
            this.venueDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.privacyDataGridViewTextBoxColumn1,
            this.updateTimeDataGridViewTextBoxColumn,
            this.linkToFacebookDataGridViewTextBoxColumn,
            this.timeStringDataGridViewTextBoxColumn,
            this.updateTimeStringDataGridViewTextBoxColumn,
            this.picturesDataGridViewTextBoxColumn,
            this.pictureSmallURLDataGridViewTextBoxColumn,
            this.pictureNormalURLDataGridViewTextBoxColumn,
            this.pictureLargeURLDataGridViewTextBoxColumn,
            this.pictureSqaureURLDataGridViewTextBoxColumn,
            this.imageSmallDataGridViewImageColumn2,
            this.imageNormalDataGridViewImageColumn,
            this.imageLargeDataGridViewImageColumn,
            this.imageSqaureDataGridViewImageColumn,
            this.idDataGridViewTextBoxColumn});
			this.dataGridViewFriendOverviewEvents.DataSource = this.bindingSourceEvents;
			this.dataGridViewFriendOverviewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewFriendOverviewEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewFriendOverviewEvents.Location = new System.Drawing.Point(4, 4);
			this.dataGridViewFriendOverviewEvents.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewFriendOverviewEvents.Name = "dataGridViewFriendOverviewEvents";
			this.dataGridViewFriendOverviewEvents.ReadOnly = true;
			this.dataGridViewFriendOverviewEvents.Size = new System.Drawing.Size(713, 303);
			this.dataGridViewFriendOverviewEvents.TabIndex = 0;
			// 
			// ownerDataGridViewTextBoxColumn
			// 
			this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
			this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
			this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
			this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn2
			// 
			this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
			this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn1
			// 
			this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
			this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// startTimeDataGridViewTextBoxColumn
			// 
			this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
			this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
			this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
			this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// endTimeDataGridViewTextBoxColumn
			// 
			this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
			this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
			this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
			this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// locationDataGridViewTextBoxColumn1
			// 
			this.locationDataGridViewTextBoxColumn1.DataPropertyName = "Location";
			this.locationDataGridViewTextBoxColumn1.HeaderText = "Location";
			this.locationDataGridViewTextBoxColumn1.Name = "locationDataGridViewTextBoxColumn1";
			this.locationDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// venueDataGridViewTextBoxColumn
			// 
			this.venueDataGridViewTextBoxColumn.DataPropertyName = "Venue";
			this.venueDataGridViewTextBoxColumn.HeaderText = "Venue";
			this.venueDataGridViewTextBoxColumn.Name = "venueDataGridViewTextBoxColumn";
			this.venueDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// placeDataGridViewTextBoxColumn
			// 
			this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
			this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
			this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
			this.placeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// privacyDataGridViewTextBoxColumn1
			// 
			this.privacyDataGridViewTextBoxColumn1.DataPropertyName = "Privacy";
			this.privacyDataGridViewTextBoxColumn1.HeaderText = "Privacy";
			this.privacyDataGridViewTextBoxColumn1.Name = "privacyDataGridViewTextBoxColumn1";
			this.privacyDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// updateTimeDataGridViewTextBoxColumn
			// 
			this.updateTimeDataGridViewTextBoxColumn.DataPropertyName = "UpdateTime";
			this.updateTimeDataGridViewTextBoxColumn.HeaderText = "UpdateTime";
			this.updateTimeDataGridViewTextBoxColumn.Name = "updateTimeDataGridViewTextBoxColumn";
			this.updateTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// linkToFacebookDataGridViewTextBoxColumn
			// 
			this.linkToFacebookDataGridViewTextBoxColumn.DataPropertyName = "LinkToFacebook";
			this.linkToFacebookDataGridViewTextBoxColumn.HeaderText = "LinkToFacebook";
			this.linkToFacebookDataGridViewTextBoxColumn.Name = "linkToFacebookDataGridViewTextBoxColumn";
			this.linkToFacebookDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// timeStringDataGridViewTextBoxColumn
			// 
			this.timeStringDataGridViewTextBoxColumn.DataPropertyName = "TimeString";
			this.timeStringDataGridViewTextBoxColumn.HeaderText = "TimeString";
			this.timeStringDataGridViewTextBoxColumn.Name = "timeStringDataGridViewTextBoxColumn";
			this.timeStringDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// updateTimeStringDataGridViewTextBoxColumn
			// 
			this.updateTimeStringDataGridViewTextBoxColumn.DataPropertyName = "UpdateTimeString";
			this.updateTimeStringDataGridViewTextBoxColumn.HeaderText = "UpdateTimeString";
			this.updateTimeStringDataGridViewTextBoxColumn.Name = "updateTimeStringDataGridViewTextBoxColumn";
			this.updateTimeStringDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// picturesDataGridViewTextBoxColumn
			// 
			this.picturesDataGridViewTextBoxColumn.DataPropertyName = "Pictures";
			this.picturesDataGridViewTextBoxColumn.HeaderText = "Pictures";
			this.picturesDataGridViewTextBoxColumn.Name = "picturesDataGridViewTextBoxColumn";
			this.picturesDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pictureSmallURLDataGridViewTextBoxColumn
			// 
			this.pictureSmallURLDataGridViewTextBoxColumn.DataPropertyName = "PictureSmallURL";
			this.pictureSmallURLDataGridViewTextBoxColumn.HeaderText = "PictureSmallURL";
			this.pictureSmallURLDataGridViewTextBoxColumn.Name = "pictureSmallURLDataGridViewTextBoxColumn";
			this.pictureSmallURLDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pictureNormalURLDataGridViewTextBoxColumn
			// 
			this.pictureNormalURLDataGridViewTextBoxColumn.DataPropertyName = "PictureNormalURL";
			this.pictureNormalURLDataGridViewTextBoxColumn.HeaderText = "PictureNormalURL";
			this.pictureNormalURLDataGridViewTextBoxColumn.Name = "pictureNormalURLDataGridViewTextBoxColumn";
			this.pictureNormalURLDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pictureLargeURLDataGridViewTextBoxColumn
			// 
			this.pictureLargeURLDataGridViewTextBoxColumn.DataPropertyName = "PictureLargeURL";
			this.pictureLargeURLDataGridViewTextBoxColumn.HeaderText = "PictureLargeURL";
			this.pictureLargeURLDataGridViewTextBoxColumn.Name = "pictureLargeURLDataGridViewTextBoxColumn";
			this.pictureLargeURLDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pictureSqaureURLDataGridViewTextBoxColumn
			// 
			this.pictureSqaureURLDataGridViewTextBoxColumn.DataPropertyName = "PictureSqaureURL";
			this.pictureSqaureURLDataGridViewTextBoxColumn.HeaderText = "PictureSqaureURL";
			this.pictureSqaureURLDataGridViewTextBoxColumn.Name = "pictureSqaureURLDataGridViewTextBoxColumn";
			this.pictureSqaureURLDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// imageSmallDataGridViewImageColumn2
			// 
			this.imageSmallDataGridViewImageColumn2.DataPropertyName = "ImageSmall";
			this.imageSmallDataGridViewImageColumn2.HeaderText = "ImageSmall";
			this.imageSmallDataGridViewImageColumn2.Name = "imageSmallDataGridViewImageColumn2";
			this.imageSmallDataGridViewImageColumn2.ReadOnly = true;
			// 
			// imageNormalDataGridViewImageColumn
			// 
			this.imageNormalDataGridViewImageColumn.DataPropertyName = "ImageNormal";
			this.imageNormalDataGridViewImageColumn.HeaderText = "ImageNormal";
			this.imageNormalDataGridViewImageColumn.Name = "imageNormalDataGridViewImageColumn";
			this.imageNormalDataGridViewImageColumn.ReadOnly = true;
			// 
			// imageLargeDataGridViewImageColumn
			// 
			this.imageLargeDataGridViewImageColumn.DataPropertyName = "ImageLarge";
			this.imageLargeDataGridViewImageColumn.HeaderText = "ImageLarge";
			this.imageLargeDataGridViewImageColumn.Name = "imageLargeDataGridViewImageColumn";
			this.imageLargeDataGridViewImageColumn.ReadOnly = true;
			// 
			// imageSqaureDataGridViewImageColumn
			// 
			this.imageSqaureDataGridViewImageColumn.DataPropertyName = "ImageSqaure";
			this.imageSqaureDataGridViewImageColumn.HeaderText = "ImageSqaure";
			this.imageSqaureDataGridViewImageColumn.Name = "imageSqaureDataGridViewImageColumn";
			this.imageSqaureDataGridViewImageColumn.ReadOnly = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tabPageCheckins
			// 
			this.tabPageCheckins.Controls.Add(this.dataGridViewFriendOvervieCheckins);
			this.tabPageCheckins.Location = new System.Drawing.Point(4, 27);
			this.tabPageCheckins.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageCheckins.Name = "tabPageCheckins";
			this.tabPageCheckins.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageCheckins.Size = new System.Drawing.Size(721, 311);
			this.tabPageCheckins.TabIndex = 1;
			this.tabPageCheckins.Text = "Checkins";
			this.tabPageCheckins.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFriendOvervieCheckins
			// 
			this.dataGridViewFriendOvervieCheckins.AllowUserToAddRows = false;
			this.dataGridViewFriendOvervieCheckins.AllowUserToDeleteRows = false;
			this.dataGridViewFriendOvervieCheckins.AutoGenerateColumns = false;
			this.dataGridViewFriendOvervieCheckins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewFriendOvervieCheckins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFriendOvervieCheckins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn3,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.createdTimeDataGridViewTextBoxColumn});
			this.dataGridViewFriendOvervieCheckins.DataSource = this.bindingSourceFriendOverviewCheckins;
			this.dataGridViewFriendOvervieCheckins.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewFriendOvervieCheckins.Location = new System.Drawing.Point(4, 4);
			this.dataGridViewFriendOvervieCheckins.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewFriendOvervieCheckins.Name = "dataGridViewFriendOvervieCheckins";
			this.dataGridViewFriendOvervieCheckins.ReadOnly = true;
			this.dataGridViewFriendOvervieCheckins.Size = new System.Drawing.Size(713, 303);
			this.dataGridViewFriendOvervieCheckins.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn3
			// 
			this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn3.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
			this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Message";
			this.Column1.HeaderText = "Message";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Link";
			this.dataGridViewTextBoxColumn3.HeaderText = "Link";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// createdTimeDataGridViewTextBoxColumn
			// 
			this.createdTimeDataGridViewTextBoxColumn.DataPropertyName = "CreatedTime";
			this.createdTimeDataGridViewTextBoxColumn.HeaderText = "CreatedTime";
			this.createdTimeDataGridViewTextBoxColumn.Name = "createdTimeDataGridViewTextBoxColumn";
			this.createdTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bindingSourceFriendOverviewCheckins
			// 
			this.bindingSourceFriendOverviewCheckins.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
			// 
			// tabPagePosts
			// 
			this.tabPagePosts.Controls.Add(this.dataGridView3);
			this.tabPagePosts.Location = new System.Drawing.Point(4, 27);
			this.tabPagePosts.Margin = new System.Windows.Forms.Padding(4);
			this.tabPagePosts.Name = "tabPagePosts";
			this.tabPagePosts.Size = new System.Drawing.Size(721, 311);
			this.tabPagePosts.TabIndex = 2;
			this.tabPagePosts.Text = "Posts";
			this.tabPagePosts.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
			this.dataGridView3.AutoGenerateColumns = false;
			this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn4,
            this.Message,
            this.dataGridViewTextBoxColumn2,
            this.createdTimeDataGridViewTextBoxColumn1});
			this.dataGridView3.DataSource = this.bindingSourceFriendOverviewPosts;
			this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView3.Location = new System.Drawing.Point(0, 0);
			this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.Size = new System.Drawing.Size(721, 311);
			this.dataGridView3.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn4
			// 
			this.nameDataGridViewTextBoxColumn4.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
			this.nameDataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// Message
			// 
			this.Message.DataPropertyName = "Message";
			this.Message.HeaderText = "Message";
			this.Message.Name = "Message";
			this.Message.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Link";
			this.dataGridViewTextBoxColumn2.HeaderText = "Link";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// createdTimeDataGridViewTextBoxColumn1
			// 
			this.createdTimeDataGridViewTextBoxColumn1.DataPropertyName = "CreatedTime";
			this.createdTimeDataGridViewTextBoxColumn1.HeaderText = "CreatedTime";
			this.createdTimeDataGridViewTextBoxColumn1.Name = "createdTimeDataGridViewTextBoxColumn1";
			this.createdTimeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// bindingSourceFriendOverviewPosts
			// 
			this.bindingSourceFriendOverviewPosts.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.dataGridViewFriendOverviewGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 27);
			this.tabPageGroups.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Size = new System.Drawing.Size(721, 311);
			this.tabPageGroups.TabIndex = 3;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// dataGridViewFriendOverviewGroups
			// 
			this.dataGridViewFriendOverviewGroups.AllowUserToAddRows = false;
			this.dataGridViewFriendOverviewGroups.AllowUserToDeleteRows = false;
			this.dataGridViewFriendOverviewGroups.AutoGenerateColumns = false;
			this.dataGridViewFriendOverviewGroups.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewFriendOverviewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFriendOverviewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn5,
            this.descriptionDataGridViewTextBoxColumn4,
            this.privacyDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn1});
			this.dataGridViewFriendOverviewGroups.DataSource = this.bindingSourceFriendOverviewGroups;
			this.dataGridViewFriendOverviewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewFriendOverviewGroups.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewFriendOverviewGroups.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewFriendOverviewGroups.Name = "dataGridViewFriendOverviewGroups";
			this.dataGridViewFriendOverviewGroups.ReadOnly = true;
			this.dataGridViewFriendOverviewGroups.Size = new System.Drawing.Size(721, 311);
			this.dataGridViewFriendOverviewGroups.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn5
			// 
			this.nameDataGridViewTextBoxColumn5.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn5.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn5.Name = "nameDataGridViewTextBoxColumn5";
			this.nameDataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn4
			// 
			this.descriptionDataGridViewTextBoxColumn4.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn4.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn4.Name = "descriptionDataGridViewTextBoxColumn4";
			this.descriptionDataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// privacyDataGridViewTextBoxColumn
			// 
			this.privacyDataGridViewTextBoxColumn.DataPropertyName = "Privacy";
			this.privacyDataGridViewTextBoxColumn.HeaderText = "Privacy";
			this.privacyDataGridViewTextBoxColumn.Name = "privacyDataGridViewTextBoxColumn";
			this.privacyDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// ownerDataGridViewTextBoxColumn1
			// 
			this.ownerDataGridViewTextBoxColumn1.DataPropertyName = "Owner";
			this.ownerDataGridViewTextBoxColumn1.HeaderText = "Owner";
			this.ownerDataGridViewTextBoxColumn1.Name = "ownerDataGridViewTextBoxColumn1";
			this.ownerDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// bindingSourceFriendOverviewGroups
			// 
			this.bindingSourceFriendOverviewGroups.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(265, 295);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(157, 25);
			this.label5.TabIndex = 36;
			this.label5.Text = "Friendship meter";
			// 
			// progressBarFriendshipStrength
			// 
			this.progressBarFriendshipStrength.Location = new System.Drawing.Point(140, 324);
			this.progressBarFriendshipStrength.Margin = new System.Windows.Forms.Padding(4);
			this.progressBarFriendshipStrength.Minimum = 10;
			this.progressBarFriendshipStrength.Name = "progressBarFriendshipStrength";
			this.progressBarFriendshipStrength.Size = new System.Drawing.Size(424, 28);
			this.progressBarFriendshipStrength.Step = 5;
			this.progressBarFriendshipStrength.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBarFriendshipStrength.TabIndex = 34;
			this.progressBarFriendshipStrength.Value = 15;
			// 
			// labelUploadMutualPicDescription
			// 
			this.labelUploadMutualPicDescription.AutoSize = true;
			this.labelUploadMutualPicDescription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUploadMutualPicDescription.ForeColor = System.Drawing.Color.Snow;
			this.labelUploadMutualPicDescription.Location = new System.Drawing.Point(21, 59);
			this.labelUploadMutualPicDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelUploadMutualPicDescription.Name = "labelUploadMutualPicDescription";
			this.labelUploadMutualPicDescription.Size = new System.Drawing.Size(202, 84);
			this.labelUploadMutualPicDescription.TabIndex = 39;
			this.labelUploadMutualPicDescription.Text = "Description: \r\nthe picture you choose\r\nwill automatically\r\ntag your friend.";
			// 
			// buttonBrowseAPicture
			// 
			this.buttonBrowseAPicture.BackColor = System.Drawing.Color.Silver;
			this.buttonBrowseAPicture.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonBrowseAPicture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonBrowseAPicture.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonBrowseAPicture.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBrowseAPicture.Location = new System.Drawing.Point(91, 206);
			this.buttonBrowseAPicture.Margin = new System.Windows.Forms.Padding(4);
			this.buttonBrowseAPicture.Name = "buttonBrowseAPicture";
			this.buttonBrowseAPicture.Size = new System.Drawing.Size(187, 28);
			this.buttonBrowseAPicture.TabIndex = 27;
			this.buttonBrowseAPicture.Text = "Browse a picture";
			this.buttonBrowseAPicture.UseVisualStyleBackColor = false;
			this.buttonBrowseAPicture.Click += new System.EventHandler(this.buttonBrowseAPicture_Click);
			// 
			// pictureBoxMutualPictureToUpload
			// 
			this.pictureBoxMutualPictureToUpload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxMutualPictureToUpload.Location = new System.Drawing.Point(297, 79);
			this.pictureBoxMutualPictureToUpload.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxMutualPictureToUpload.Name = "pictureBoxMutualPictureToUpload";
			this.pictureBoxMutualPictureToUpload.Size = new System.Drawing.Size(185, 154);
			this.pictureBoxMutualPictureToUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxMutualPictureToUpload.TabIndex = 28;
			this.pictureBoxMutualPictureToUpload.TabStop = false;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Cursor = System.Windows.Forms.Cursors.Default;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Snow;
			this.label12.Location = new System.Drawing.Point(29, 166);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 22);
			this.label12.TabIndex = 29;
			this.label12.Text = "Title:";
			// 
			// buttonUplaodMutualPic
			// 
			this.buttonUplaodMutualPic.BackColor = System.Drawing.Color.Silver;
			this.buttonUplaodMutualPic.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonUplaodMutualPic.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonUplaodMutualPic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonUplaodMutualPic.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUplaodMutualPic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonUplaodMutualPic.Location = new System.Drawing.Point(511, 203);
			this.buttonUplaodMutualPic.Margin = new System.Windows.Forms.Padding(4);
			this.buttonUplaodMutualPic.Name = "buttonUplaodMutualPic";
			this.buttonUplaodMutualPic.Size = new System.Drawing.Size(99, 31);
			this.buttonUplaodMutualPic.TabIndex = 32;
			this.buttonUplaodMutualPic.Text = "Upload";
			this.buttonUplaodMutualPic.UseVisualStyleBackColor = false;
			this.buttonUplaodMutualPic.Click += new System.EventHandler(this.buttonUplaodMutualPic_Click);
			// 
			// textBoxMutualPicToUploadTitle
			// 
			this.textBoxMutualPicToUploadTitle.Location = new System.Drawing.Point(91, 164);
			this.textBoxMutualPicToUploadTitle.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxMutualPicToUploadTitle.Name = "textBoxMutualPicToUploadTitle";
			this.textBoxMutualPicToUploadTitle.Size = new System.Drawing.Size(185, 23);
			this.textBoxMutualPicToUploadTitle.TabIndex = 31;
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.Color.DarkOrange;
			this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel12.Controls.Add(this.labelUploadMutualPic);
			this.panel12.Location = new System.Drawing.Point(-3, 0);
			this.panel12.Margin = new System.Windows.Forms.Padding(4);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(659, 45);
			this.panel12.TabIndex = 40;
			// 
			// labelUploadMutualPic
			// 
			this.labelUploadMutualPic.AutoSize = true;
			this.labelUploadMutualPic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUploadMutualPic.Location = new System.Drawing.Point(8, 6);
			this.labelUploadMutualPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelUploadMutualPic.Name = "labelUploadMutualPic";
			this.labelUploadMutualPic.Size = new System.Drawing.Size(454, 33);
			this.labelUploadMutualPic.TabIndex = 37;
			this.labelUploadMutualPic.Text = "Upload a picture with your friend!";
			// 
			// panel13
			// 
			this.panel13.BackColor = System.Drawing.Color.DarkOrange;
			this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel13.Controls.Add(this.labelMutualInfo);
			this.panel13.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.panel13.Location = new System.Drawing.Point(9, 2);
			this.panel13.Margin = new System.Windows.Forms.Padding(4);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(1382, 45);
			this.panel13.TabIndex = 41;
			// 
			// labelMutualInfo
			// 
			this.labelMutualInfo.AutoSize = true;
			this.labelMutualInfo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMutualInfo.Location = new System.Drawing.Point(8, 6);
			this.labelMutualInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMutualInfo.Name = "labelMutualInfo";
			this.labelMutualInfo.Size = new System.Drawing.Size(535, 33);
			this.labelMutualInfo.TabIndex = 37;
			this.labelMutualInfo.Text = "Check out your mutuals with your friend";
			// 
			// tabControlMutualInfo
			// 
			this.tabControlMutualInfo.Controls.Add(this.tabPageMutualEvents);
			this.tabControlMutualInfo.Controls.Add(this.tabPageMutualCheckins);
			this.tabControlMutualInfo.Controls.Add(this.tabPagePostsTaggedMe);
			this.tabControlMutualInfo.Controls.Add(this.tabPageMutualGroups);
			this.tabControlMutualInfo.Controls.Add(this.tabPageMutualPics);
			this.tabControlMutualInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.tabControlMutualInfo.Location = new System.Drawing.Point(9, 43);
			this.tabControlMutualInfo.Margin = new System.Windows.Forms.Padding(4);
			this.tabControlMutualInfo.Multiline = true;
			this.tabControlMutualInfo.Name = "tabControlMutualInfo";
			this.tabControlMutualInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tabControlMutualInfo.SelectedIndex = 0;
			this.tabControlMutualInfo.Size = new System.Drawing.Size(1388, 268);
			this.tabControlMutualInfo.TabIndex = 3;
			// 
			// tabPageMutualEvents
			// 
			this.tabPageMutualEvents.BackColor = System.Drawing.Color.Transparent;
			this.tabPageMutualEvents.Controls.Add(this.dataGridViewMutualEvents);
			this.tabPageMutualEvents.Location = new System.Drawing.Point(4, 27);
			this.tabPageMutualEvents.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageMutualEvents.Name = "tabPageMutualEvents";
			this.tabPageMutualEvents.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageMutualEvents.Size = new System.Drawing.Size(1380, 237);
			this.tabPageMutualEvents.TabIndex = 4;
			this.tabPageMutualEvents.Text = "Mutual Events";
			// 
			// dataGridViewMutualEvents
			// 
			this.dataGridViewMutualEvents.AllowUserToAddRows = false;
			this.dataGridViewMutualEvents.AllowUserToDeleteRows = false;
			this.dataGridViewMutualEvents.AutoGenerateColumns = false;
			this.dataGridViewMutualEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewMutualEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMutualEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ownerDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn6,
            this.descriptionDataGridViewTextBoxColumn2,
            this.startTimeDataGridViewTextBoxColumn1,
            this.endTimeDataGridViewTextBoxColumn1,
            this.locationDataGridViewTextBoxColumn2,
            this.venueDataGridViewTextBoxColumn1,
            this.placeDataGridViewTextBoxColumn1,
            this.privacyDataGridViewTextBoxColumn2,
            this.updateTimeDataGridViewTextBoxColumn1,
            this.linkToFacebookDataGridViewTextBoxColumn1,
            this.timeStringDataGridViewTextBoxColumn1,
            this.updateTimeStringDataGridViewTextBoxColumn1,
            this.picturesDataGridViewTextBoxColumn1,
            this.pictureSmallURLDataGridViewTextBoxColumn1,
            this.pictureNormalURLDataGridViewTextBoxColumn1,
            this.pictureLargeURLDataGridViewTextBoxColumn1,
            this.pictureSqaureURLDataGridViewTextBoxColumn1,
            this.imageSmallDataGridViewImageColumn3,
            this.imageNormalDataGridViewImageColumn1,
            this.imageLargeDataGridViewImageColumn1,
            this.imageSqaureDataGridViewImageColumn1,
            this.idDataGridViewTextBoxColumn1});
			this.dataGridViewMutualEvents.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.dataGridViewMutualEvents.DataSource = this.bindingSourceFriendOverviewMutualEvents;
			this.dataGridViewMutualEvents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewMutualEvents.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridViewMutualEvents.Location = new System.Drawing.Point(4, 4);
			this.dataGridViewMutualEvents.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewMutualEvents.Name = "dataGridViewMutualEvents";
			this.dataGridViewMutualEvents.ReadOnly = true;
			this.dataGridViewMutualEvents.Size = new System.Drawing.Size(1372, 229);
			this.dataGridViewMutualEvents.TabIndex = 1;
			// 
			// ownerDataGridViewTextBoxColumn2
			// 
			this.ownerDataGridViewTextBoxColumn2.DataPropertyName = "Owner";
			this.ownerDataGridViewTextBoxColumn2.HeaderText = "Owner";
			this.ownerDataGridViewTextBoxColumn2.Name = "ownerDataGridViewTextBoxColumn2";
			this.ownerDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn6
			// 
			this.nameDataGridViewTextBoxColumn6.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn6.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn6.Name = "nameDataGridViewTextBoxColumn6";
			this.nameDataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn2
			// 
			this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
			this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// startTimeDataGridViewTextBoxColumn1
			// 
			this.startTimeDataGridViewTextBoxColumn1.DataPropertyName = "StartTime";
			this.startTimeDataGridViewTextBoxColumn1.HeaderText = "StartTime";
			this.startTimeDataGridViewTextBoxColumn1.Name = "startTimeDataGridViewTextBoxColumn1";
			this.startTimeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// endTimeDataGridViewTextBoxColumn1
			// 
			this.endTimeDataGridViewTextBoxColumn1.DataPropertyName = "EndTime";
			this.endTimeDataGridViewTextBoxColumn1.HeaderText = "EndTime";
			this.endTimeDataGridViewTextBoxColumn1.Name = "endTimeDataGridViewTextBoxColumn1";
			this.endTimeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// locationDataGridViewTextBoxColumn2
			// 
			this.locationDataGridViewTextBoxColumn2.DataPropertyName = "Location";
			this.locationDataGridViewTextBoxColumn2.HeaderText = "Location";
			this.locationDataGridViewTextBoxColumn2.Name = "locationDataGridViewTextBoxColumn2";
			this.locationDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// venueDataGridViewTextBoxColumn1
			// 
			this.venueDataGridViewTextBoxColumn1.DataPropertyName = "Venue";
			this.venueDataGridViewTextBoxColumn1.HeaderText = "Venue";
			this.venueDataGridViewTextBoxColumn1.Name = "venueDataGridViewTextBoxColumn1";
			this.venueDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// placeDataGridViewTextBoxColumn1
			// 
			this.placeDataGridViewTextBoxColumn1.DataPropertyName = "Place";
			this.placeDataGridViewTextBoxColumn1.HeaderText = "Place";
			this.placeDataGridViewTextBoxColumn1.Name = "placeDataGridViewTextBoxColumn1";
			this.placeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// privacyDataGridViewTextBoxColumn2
			// 
			this.privacyDataGridViewTextBoxColumn2.DataPropertyName = "Privacy";
			this.privacyDataGridViewTextBoxColumn2.HeaderText = "Privacy";
			this.privacyDataGridViewTextBoxColumn2.Name = "privacyDataGridViewTextBoxColumn2";
			this.privacyDataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// updateTimeDataGridViewTextBoxColumn1
			// 
			this.updateTimeDataGridViewTextBoxColumn1.DataPropertyName = "UpdateTime";
			this.updateTimeDataGridViewTextBoxColumn1.HeaderText = "UpdateTime";
			this.updateTimeDataGridViewTextBoxColumn1.Name = "updateTimeDataGridViewTextBoxColumn1";
			this.updateTimeDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// linkToFacebookDataGridViewTextBoxColumn1
			// 
			this.linkToFacebookDataGridViewTextBoxColumn1.DataPropertyName = "LinkToFacebook";
			this.linkToFacebookDataGridViewTextBoxColumn1.HeaderText = "LinkToFacebook";
			this.linkToFacebookDataGridViewTextBoxColumn1.Name = "linkToFacebookDataGridViewTextBoxColumn1";
			this.linkToFacebookDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// timeStringDataGridViewTextBoxColumn1
			// 
			this.timeStringDataGridViewTextBoxColumn1.DataPropertyName = "TimeString";
			this.timeStringDataGridViewTextBoxColumn1.HeaderText = "TimeString";
			this.timeStringDataGridViewTextBoxColumn1.Name = "timeStringDataGridViewTextBoxColumn1";
			this.timeStringDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// updateTimeStringDataGridViewTextBoxColumn1
			// 
			this.updateTimeStringDataGridViewTextBoxColumn1.DataPropertyName = "UpdateTimeString";
			this.updateTimeStringDataGridViewTextBoxColumn1.HeaderText = "UpdateTimeString";
			this.updateTimeStringDataGridViewTextBoxColumn1.Name = "updateTimeStringDataGridViewTextBoxColumn1";
			this.updateTimeStringDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// picturesDataGridViewTextBoxColumn1
			// 
			this.picturesDataGridViewTextBoxColumn1.DataPropertyName = "Pictures";
			this.picturesDataGridViewTextBoxColumn1.HeaderText = "Pictures";
			this.picturesDataGridViewTextBoxColumn1.Name = "picturesDataGridViewTextBoxColumn1";
			this.picturesDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// pictureSmallURLDataGridViewTextBoxColumn1
			// 
			this.pictureSmallURLDataGridViewTextBoxColumn1.DataPropertyName = "PictureSmallURL";
			this.pictureSmallURLDataGridViewTextBoxColumn1.HeaderText = "PictureSmallURL";
			this.pictureSmallURLDataGridViewTextBoxColumn1.Name = "pictureSmallURLDataGridViewTextBoxColumn1";
			this.pictureSmallURLDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// pictureNormalURLDataGridViewTextBoxColumn1
			// 
			this.pictureNormalURLDataGridViewTextBoxColumn1.DataPropertyName = "PictureNormalURL";
			this.pictureNormalURLDataGridViewTextBoxColumn1.HeaderText = "PictureNormalURL";
			this.pictureNormalURLDataGridViewTextBoxColumn1.Name = "pictureNormalURLDataGridViewTextBoxColumn1";
			this.pictureNormalURLDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// pictureLargeURLDataGridViewTextBoxColumn1
			// 
			this.pictureLargeURLDataGridViewTextBoxColumn1.DataPropertyName = "PictureLargeURL";
			this.pictureLargeURLDataGridViewTextBoxColumn1.HeaderText = "PictureLargeURL";
			this.pictureLargeURLDataGridViewTextBoxColumn1.Name = "pictureLargeURLDataGridViewTextBoxColumn1";
			this.pictureLargeURLDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// pictureSqaureURLDataGridViewTextBoxColumn1
			// 
			this.pictureSqaureURLDataGridViewTextBoxColumn1.DataPropertyName = "PictureSqaureURL";
			this.pictureSqaureURLDataGridViewTextBoxColumn1.HeaderText = "PictureSqaureURL";
			this.pictureSqaureURLDataGridViewTextBoxColumn1.Name = "pictureSqaureURLDataGridViewTextBoxColumn1";
			this.pictureSqaureURLDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// imageSmallDataGridViewImageColumn3
			// 
			this.imageSmallDataGridViewImageColumn3.DataPropertyName = "ImageSmall";
			this.imageSmallDataGridViewImageColumn3.HeaderText = "ImageSmall";
			this.imageSmallDataGridViewImageColumn3.Name = "imageSmallDataGridViewImageColumn3";
			this.imageSmallDataGridViewImageColumn3.ReadOnly = true;
			// 
			// imageNormalDataGridViewImageColumn1
			// 
			this.imageNormalDataGridViewImageColumn1.DataPropertyName = "ImageNormal";
			this.imageNormalDataGridViewImageColumn1.HeaderText = "ImageNormal";
			this.imageNormalDataGridViewImageColumn1.Name = "imageNormalDataGridViewImageColumn1";
			this.imageNormalDataGridViewImageColumn1.ReadOnly = true;
			// 
			// imageLargeDataGridViewImageColumn1
			// 
			this.imageLargeDataGridViewImageColumn1.DataPropertyName = "ImageLarge";
			this.imageLargeDataGridViewImageColumn1.HeaderText = "ImageLarge";
			this.imageLargeDataGridViewImageColumn1.Name = "imageLargeDataGridViewImageColumn1";
			this.imageLargeDataGridViewImageColumn1.ReadOnly = true;
			// 
			// imageSqaureDataGridViewImageColumn1
			// 
			this.imageSqaureDataGridViewImageColumn1.DataPropertyName = "ImageSqaure";
			this.imageSqaureDataGridViewImageColumn1.HeaderText = "ImageSqaure";
			this.imageSqaureDataGridViewImageColumn1.Name = "imageSqaureDataGridViewImageColumn1";
			this.imageSqaureDataGridViewImageColumn1.ReadOnly = true;
			// 
			// idDataGridViewTextBoxColumn1
			// 
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// bindingSourceFriendOverviewMutualEvents
			// 
			this.bindingSourceFriendOverviewMutualEvents.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
			// 
			// tabPageMutualCheckins
			// 
			this.tabPageMutualCheckins.Controls.Add(this.dataGridViewMutualCheckins);
			this.tabPageMutualCheckins.Location = new System.Drawing.Point(4, 27);
			this.tabPageMutualCheckins.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageMutualCheckins.Name = "tabPageMutualCheckins";
			this.tabPageMutualCheckins.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageMutualCheckins.Size = new System.Drawing.Size(1380, 237);
			this.tabPageMutualCheckins.TabIndex = 0;
			this.tabPageMutualCheckins.Text = "Mutual Checkins";
			this.tabPageMutualCheckins.UseVisualStyleBackColor = true;
			// 
			// dataGridViewMutualCheckins
			// 
			this.dataGridViewMutualCheckins.AllowUserToAddRows = false;
			this.dataGridViewMutualCheckins.AllowUserToDeleteRows = false;
			this.dataGridViewMutualCheckins.AutoGenerateColumns = false;
			this.dataGridViewMutualCheckins.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewMutualCheckins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMutualCheckins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
			this.dataGridViewMutualCheckins.DataSource = this.bindingSourceFriendOverviewMutualCheckins;
			this.dataGridViewMutualCheckins.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewMutualCheckins.Location = new System.Drawing.Point(4, 4);
			this.dataGridViewMutualCheckins.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewMutualCheckins.Name = "dataGridViewMutualCheckins";
			this.dataGridViewMutualCheckins.ReadOnly = true;
			this.dataGridViewMutualCheckins.Size = new System.Drawing.Size(1372, 229);
			this.dataGridViewMutualCheckins.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn25
			// 
			this.dataGridViewTextBoxColumn25.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn25.HeaderText = "Name";
			this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn25.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn26
			// 
			this.dataGridViewTextBoxColumn26.DataPropertyName = "Message";
			this.dataGridViewTextBoxColumn26.HeaderText = "Message";
			this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
			this.dataGridViewTextBoxColumn26.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn27
			// 
			this.dataGridViewTextBoxColumn27.DataPropertyName = "Link";
			this.dataGridViewTextBoxColumn27.HeaderText = "Link";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			this.dataGridViewTextBoxColumn27.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn28
			// 
			this.dataGridViewTextBoxColumn28.DataPropertyName = "CreatedTime";
			this.dataGridViewTextBoxColumn28.HeaderText = "CreatedTime";
			this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
			this.dataGridViewTextBoxColumn28.ReadOnly = true;
			// 
			// bindingSourceFriendOverviewMutualCheckins
			// 
			this.bindingSourceFriendOverviewMutualCheckins.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
			// 
			// tabPagePostsTaggedMe
			// 
			this.tabPagePostsTaggedMe.Controls.Add(this.dataGridViewPostsTaggedMe);
			this.tabPagePostsTaggedMe.Location = new System.Drawing.Point(4, 27);
			this.tabPagePostsTaggedMe.Margin = new System.Windows.Forms.Padding(4);
			this.tabPagePostsTaggedMe.Name = "tabPagePostsTaggedMe";
			this.tabPagePostsTaggedMe.Padding = new System.Windows.Forms.Padding(4);
			this.tabPagePostsTaggedMe.Size = new System.Drawing.Size(1380, 237);
			this.tabPagePostsTaggedMe.TabIndex = 1;
			this.tabPagePostsTaggedMe.Text = "Posts Tagged Me";
			this.tabPagePostsTaggedMe.UseVisualStyleBackColor = true;
			// 
			// dataGridViewPostsTaggedMe
			// 
			this.dataGridViewPostsTaggedMe.AllowUserToAddRows = false;
			this.dataGridViewPostsTaggedMe.AllowUserToDeleteRows = false;
			this.dataGridViewPostsTaggedMe.AutoGenerateColumns = false;
			this.dataGridViewPostsTaggedMe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridViewPostsTaggedMe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPostsTaggedMe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32});
			this.dataGridViewPostsTaggedMe.DataSource = this.bindingSourceFriendOverviewPostsTaggedMe;
			this.dataGridViewPostsTaggedMe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewPostsTaggedMe.Location = new System.Drawing.Point(4, 4);
			this.dataGridViewPostsTaggedMe.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewPostsTaggedMe.Name = "dataGridViewPostsTaggedMe";
			this.dataGridViewPostsTaggedMe.ReadOnly = true;
			this.dataGridViewPostsTaggedMe.Size = new System.Drawing.Size(1372, 229);
			this.dataGridViewPostsTaggedMe.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn29
			// 
			this.dataGridViewTextBoxColumn29.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn29.HeaderText = "Name";
			this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
			this.dataGridViewTextBoxColumn29.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn30
			// 
			this.dataGridViewTextBoxColumn30.DataPropertyName = "Message";
			this.dataGridViewTextBoxColumn30.HeaderText = "Message";
			this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
			this.dataGridViewTextBoxColumn30.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn31
			// 
			this.dataGridViewTextBoxColumn31.DataPropertyName = "Link";
			this.dataGridViewTextBoxColumn31.HeaderText = "Link";
			this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
			this.dataGridViewTextBoxColumn31.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn32
			// 
			this.dataGridViewTextBoxColumn32.DataPropertyName = "CreatedTime";
			this.dataGridViewTextBoxColumn32.HeaderText = "CreatedTime";
			this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
			this.dataGridViewTextBoxColumn32.ReadOnly = true;
			// 
			// bindingSourceFriendOverviewPostsTaggedMe
			// 
			this.bindingSourceFriendOverviewPostsTaggedMe.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
			// 
			// tabPageMutualGroups
			// 
			this.tabPageMutualGroups.Controls.Add(this.dataGridView1);
			this.tabPageMutualGroups.Location = new System.Drawing.Point(4, 27);
			this.tabPageMutualGroups.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageMutualGroups.Name = "tabPageMutualGroups";
			this.tabPageMutualGroups.Size = new System.Drawing.Size(1380, 237);
			this.tabPageMutualGroups.TabIndex = 2;
			this.tabPageMutualGroups.Text = "Mutual Groups";
			this.tabPageMutualGroups.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.dataGridView1.DataSource = this.bindingSourceFriendOverviewMutualGroups;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1380, 237);
			this.dataGridView1.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn5.HeaderText = "Name";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
			this.dataGridViewTextBoxColumn6.HeaderText = "Description";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Privacy";
			this.dataGridViewTextBoxColumn7.HeaderText = "Privacy";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Owner";
			this.dataGridViewTextBoxColumn8.HeaderText = "Owner";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// bindingSourceFriendOverviewMutualGroups
			// 
			this.bindingSourceFriendOverviewMutualGroups.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
			// 
			// tabPageMutualPics
			// 
			this.tabPageMutualPics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tabPageMutualPics.Controls.Add(this.pictureBoxMutualPictures);
			this.tabPageMutualPics.Controls.Add(this.panel1);
			this.tabPageMutualPics.Controls.Add(this.bindingNavigatorMutualPic);
			this.tabPageMutualPics.Location = new System.Drawing.Point(4, 27);
			this.tabPageMutualPics.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageMutualPics.Name = "tabPageMutualPics";
			this.tabPageMutualPics.Size = new System.Drawing.Size(1380, 237);
			this.tabPageMutualPics.TabIndex = 3;
			this.tabPageMutualPics.Text = "Mutual Pictures";
			// 
			// pictureBoxMutualPictures
			// 
			this.pictureBoxMutualPictures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxMutualPictures.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceFriendOverviewMutualPictures, "ImageNormal", true));
			this.pictureBoxMutualPictures.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMutualPictures.Image")));
			this.pictureBoxMutualPictures.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMutualPictures.InitialImage")));
			this.pictureBoxMutualPictures.Location = new System.Drawing.Point(533, 22);
			this.pictureBoxMutualPictures.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxMutualPictures.Name = "pictureBoxMutualPictures";
			this.pictureBoxMutualPictures.Size = new System.Drawing.Size(254, 185);
			this.pictureBoxMutualPictures.TabIndex = 36;
			this.pictureBoxMutualPictures.TabStop = false;
			// 
			// bindingSourceFriendOverviewMutualPictures
			// 
			this.bindingSourceFriendOverviewMutualPictures.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(positionInAlbumLabel);
			this.panel1.Controls.Add(this.positionInAlbumTextBox);
			this.panel1.Controls.Add(linkLabel);
			this.panel1.Controls.Add(this.linkTextBox);
			this.panel1.Controls.Add(createdTimeLabel1);
			this.panel1.Controls.Add(this.createdTimeDateTimePicker1);
			this.panel1.Controls.Add(nameLabel);
			this.panel1.Controls.Add(this.nameTextBox);
			this.panel1.Location = new System.Drawing.Point(16, 22);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(479, 264);
			this.panel1.TabIndex = 35;
			// 
			// positionInAlbumTextBox
			// 
			this.positionInAlbumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriendOverviewMutualPictures, "PositionInAlbum", true));
			this.positionInAlbumTextBox.Enabled = false;
			this.positionInAlbumTextBox.Location = new System.Drawing.Point(199, 177);
			this.positionInAlbumTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.positionInAlbumTextBox.Name = "positionInAlbumTextBox";
			this.positionInAlbumTextBox.ReadOnly = true;
			this.positionInAlbumTextBox.Size = new System.Drawing.Size(265, 24);
			this.positionInAlbumTextBox.TabIndex = 41;
			// 
			// linkTextBox
			// 
			this.linkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriendOverviewMutualPictures, "Link", true));
			this.linkTextBox.Enabled = false;
			this.linkTextBox.Location = new System.Drawing.Point(199, 132);
			this.linkTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.linkTextBox.Name = "linkTextBox";
			this.linkTextBox.ReadOnly = true;
			this.linkTextBox.Size = new System.Drawing.Size(265, 24);
			this.linkTextBox.TabIndex = 40;
			// 
			// createdTimeDateTimePicker1
			// 
			this.createdTimeDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceFriendOverviewMutualPictures, "CreatedTime", true));
			this.createdTimeDateTimePicker1.Enabled = false;
			this.createdTimeDateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createdTimeDateTimePicker1.Location = new System.Drawing.Point(199, 21);
			this.createdTimeDateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
			this.createdTimeDateTimePicker1.Name = "createdTimeDateTimePicker1";
			this.createdTimeDateTimePicker1.Size = new System.Drawing.Size(265, 27);
			this.createdTimeDateTimePicker1.TabIndex = 1;
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceFriendOverviewMutualPictures, "Name", true));
			this.nameTextBox.Enabled = false;
			this.nameTextBox.Location = new System.Drawing.Point(199, 78);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.ReadOnly = true;
			this.nameTextBox.Size = new System.Drawing.Size(265, 24);
			this.nameTextBox.TabIndex = 3;
			// 
			// bindingNavigatorMutualPic
			// 
			this.bindingNavigatorMutualPic.AddNewItem = null;
			this.bindingNavigatorMutualPic.CountItem = this.bindingNavigatorCountItem1;
			this.bindingNavigatorMutualPic.DeleteItem = null;
			this.bindingNavigatorMutualPic.Dock = System.Windows.Forms.DockStyle.None;
			this.bindingNavigatorMutualPic.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.bindingNavigatorMutualPic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
			this.bindingNavigatorMutualPic.Location = new System.Drawing.Point(500, 229);
			this.bindingNavigatorMutualPic.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
			this.bindingNavigatorMutualPic.MoveLastItem = this.bindingNavigatorMoveLastItem1;
			this.bindingNavigatorMutualPic.MoveNextItem = this.bindingNavigatorMoveNextItem1;
			this.bindingNavigatorMutualPic.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
			this.bindingNavigatorMutualPic.Name = "bindingNavigatorMutualPic";
			this.bindingNavigatorMutualPic.PositionItem = this.bindingNavigatorPositionItem1;
			this.bindingNavigatorMutualPic.Size = new System.Drawing.Size(238, 27);
			this.bindingNavigatorMutualPic.TabIndex = 39;
			this.bindingNavigatorMutualPic.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem1
			// 
			this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
			this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(45, 24);
			this.bindingNavigatorCountItem1.Text = "of {0}";
			this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem1
			// 
			this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
			this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
			this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveFirstItem1.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem1
			// 
			this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
			this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
			this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
			// 
			// bindingNavigatorSeparator3
			// 
			this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
			this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorPositionItem1
			// 
			this.bindingNavigatorPositionItem1.AccessibleName = "Position";
			this.bindingNavigatorPositionItem1.AutoSize = false;
			this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
			this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(65, 27);
			this.bindingNavigatorPositionItem1.Text = "0";
			this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator4
			// 
			this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
			this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorMoveNextItem1
			// 
			this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
			this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
			this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem1.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem1
			// 
			this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
			this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
			this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem1.Text = "Move last";
			// 
			// bindingNavigatorSeparator5
			// 
			this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
			this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Silver;
			this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 15);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(359, 44);
			this.label3.TabIndex = 1;
			this.label3.Text = "Friend to overview:";
			// 
			// comboBoxChooseAFriend
			// 
			this.comboBoxChooseAFriend.DataSource = this.bindingSourceFriendOverview;
			this.comboBoxChooseAFriend.DisplayMember = "Name";
			this.comboBoxChooseAFriend.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxChooseAFriend.FormattingEnabled = true;
			this.comboBoxChooseAFriend.Location = new System.Drawing.Point(20, 60);
			this.comboBoxChooseAFriend.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxChooseAFriend.Name = "comboBoxChooseAFriend";
			this.comboBoxChooseAFriend.Size = new System.Drawing.Size(364, 32);
			this.comboBoxChooseAFriend.TabIndex = 0;
			this.comboBoxChooseAFriend.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseAFriend_SelectedIndexChanged);
			this.comboBoxChooseAFriend.TextChanged += new System.EventHandler(this.comboBoxChooseAFriend_TextChanged);
			// 
			// bindingSourceFriendOverview
			// 
			this.bindingSourceFriendOverview.DataSource = typeof(FacebookWrapper.ObjectModel.User);
			// 
			// PictureBoxFriendOverviewSelectedFriend
			// 
			this.PictureBoxFriendOverviewSelectedFriend.BackColor = System.Drawing.Color.Silver;
			this.PictureBoxFriendOverviewSelectedFriend.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.PictureBoxFriendOverviewSelectedFriend.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceFriendOverviewPersonalInfo, "ImageNormal", true));
			this.PictureBoxFriendOverviewSelectedFriend.Location = new System.Drawing.Point(393, 2);
			this.PictureBoxFriendOverviewSelectedFriend.Margin = new System.Windows.Forms.Padding(4);
			this.PictureBoxFriendOverviewSelectedFriend.Name = "PictureBoxFriendOverviewSelectedFriend";
			this.PictureBoxFriendOverviewSelectedFriend.Size = new System.Drawing.Size(133, 123);
			this.PictureBoxFriendOverviewSelectedFriend.TabIndex = 7;
			this.PictureBoxFriendOverviewSelectedFriend.TabStop = false;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.Silver;
			this.panel11.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.panel11.Location = new System.Drawing.Point(11, 0);
			this.panel11.Margin = new System.Windows.Forms.Padding(4);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(1392, 128);
			this.panel11.TabIndex = 41;
			// 
			// tabPageStatistics
			// 
			this.tabPageStatistics.Controls.Add(this.panelStatisticsPosts);
			this.tabPageStatistics.Controls.Add(this.panelStatisticsGeneral);
			this.tabPageStatistics.Controls.Add(this.panelStatisticsPhotos);
			this.tabPageStatistics.Controls.Add(this.buttonCalculateStatistics);
			this.tabPageStatistics.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageStatistics.Location = new System.Drawing.Point(4, 27);
			this.tabPageStatistics.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageStatistics.Name = "tabPageStatistics";
			this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageStatistics.Size = new System.Drawing.Size(1405, 842);
			this.tabPageStatistics.TabIndex = 1;
			this.tabPageStatistics.Text = "Statistics";
			this.tabPageStatistics.UseVisualStyleBackColor = true;
			// 
			// panelStatisticsPosts
			// 
			this.panelStatisticsPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelStatisticsPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelStatisticsPosts.Controls.Add(this.labelStatisticsPostsMostLikes);
			this.panelStatisticsPosts.Controls.Add(this.label39);
			this.panelStatisticsPosts.Controls.Add(this.richTextBoxMostLikedPost);
			this.panelStatisticsPosts.Controls.Add(this.label37);
			this.panelStatisticsPosts.Controls.Add(this.labelStatisticsPostsMostLikesByUserCount);
			this.panelStatisticsPosts.Controls.Add(this.label36);
			this.panelStatisticsPosts.Controls.Add(this.labelStatisticsPostsMostLikesByUserName);
			this.panelStatisticsPosts.Controls.Add(this.label34);
			this.panelStatisticsPosts.Controls.Add(this.labelStatisticsPostsMostPostsWithCount);
			this.panelStatisticsPosts.Controls.Add(this.label32);
			this.panelStatisticsPosts.Controls.Add(this.labelStatisticsPostsMostPostsWithName);
			this.panelStatisticsPosts.Controls.Add(this.label30);
			this.panelStatisticsPosts.Controls.Add(this.labelStatisticsPostsTotalLikes);
			this.panelStatisticsPosts.Controls.Add(this.label28);
			this.panelStatisticsPosts.Controls.Add(this.labelStatisticsPostsPostsTaggedIn);
			this.panelStatisticsPosts.Controls.Add(this.label25);
			this.panelStatisticsPosts.Controls.Add(this.labelStatisticsPostsTotal);
			this.panelStatisticsPosts.Controls.Add(this.label20);
			this.panelStatisticsPosts.Controls.Add(this.label16);
			this.panelStatisticsPosts.ForeColor = System.Drawing.Color.Snow;
			this.panelStatisticsPosts.Location = new System.Drawing.Point(928, 39);
			this.panelStatisticsPosts.Margin = new System.Windows.Forms.Padding(4);
			this.panelStatisticsPosts.Name = "panelStatisticsPosts";
			this.panelStatisticsPosts.Size = new System.Drawing.Size(463, 790);
			this.panelStatisticsPosts.TabIndex = 51;
			// 
			// labelStatisticsPostsMostLikes
			// 
			this.labelStatisticsPostsMostLikes.AutoSize = true;
			this.labelStatisticsPostsMostLikes.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsPostsMostLikes.Location = new System.Drawing.Point(243, 689);
			this.labelStatisticsPostsMostLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsPostsMostLikes.Name = "labelStatisticsPostsMostLikes";
			this.labelStatisticsPostsMostLikes.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsPostsMostLikes.TabIndex = 79;
			this.labelStatisticsPostsMostLikes.Text = "-";
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(19, 689);
			this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(58, 23);
			this.label39.TabIndex = 78;
			this.label39.Text = "Likes:";
			// 
			// richTextBoxMostLikedPost
			// 
			this.richTextBoxMostLikedPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBoxMostLikedPost.Location = new System.Drawing.Point(24, 514);
			this.richTextBoxMostLikedPost.Margin = new System.Windows.Forms.Padding(4);
			this.richTextBoxMostLikedPost.Name = "richTextBoxMostLikedPost";
			this.richTextBoxMostLikedPost.Size = new System.Drawing.Size(411, 147);
			this.richTextBoxMostLikedPost.TabIndex = 77;
			this.richTextBoxMostLikedPost.Text = "";
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label37.Location = new System.Drawing.Point(19, 486);
			this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(165, 23);
			this.label37.TabIndex = 64;
			this.label37.Text = "Most Liked Post:";
			// 
			// labelStatisticsPostsMostLikesByUserCount
			// 
			this.labelStatisticsPostsMostLikesByUserCount.AutoSize = true;
			this.labelStatisticsPostsMostLikesByUserCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsPostsMostLikesByUserCount.Location = new System.Drawing.Point(243, 368);
			this.labelStatisticsPostsMostLikesByUserCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsPostsMostLikesByUserCount.Name = "labelStatisticsPostsMostLikesByUserCount";
			this.labelStatisticsPostsMostLikesByUserCount.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsPostsMostLikesByUserCount.TabIndex = 76;
			this.labelStatisticsPostsMostLikesByUserCount.Text = "-";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(19, 368);
			this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(124, 23);
			this.label36.TabIndex = 75;
			this.label36.Text = "Likes Count:";
			// 
			// labelStatisticsPostsMostLikesByUserName
			// 
			this.labelStatisticsPostsMostLikesByUserName.AutoSize = true;
			this.labelStatisticsPostsMostLikesByUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsPostsMostLikesByUserName.Location = new System.Drawing.Point(243, 308);
			this.labelStatisticsPostsMostLikesByUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsPostsMostLikesByUserName.Name = "labelStatisticsPostsMostLikesByUserName";
			this.labelStatisticsPostsMostLikesByUserName.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsPostsMostLikesByUserName.TabIndex = 74;
			this.labelStatisticsPostsMostLikesByUserName.Text = "-";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(19, 308);
			this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(183, 23);
			this.label34.TabIndex = 73;
			this.label34.Text = "Most Likes By User:";
			// 
			// labelStatisticsPostsMostPostsWithCount
			// 
			this.labelStatisticsPostsMostPostsWithCount.AutoSize = true;
			this.labelStatisticsPostsMostPostsWithCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsPostsMostPostsWithCount.Location = new System.Drawing.Point(243, 249);
			this.labelStatisticsPostsMostPostsWithCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsPostsMostPostsWithCount.Name = "labelStatisticsPostsMostPostsWithCount";
			this.labelStatisticsPostsMostPostsWithCount.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsPostsMostPostsWithCount.TabIndex = 72;
			this.labelStatisticsPostsMostPostsWithCount.Text = "-";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(19, 249);
			this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(121, 23);
			this.label32.TabIndex = 71;
			this.label32.Text = "Post Count:";
			// 
			// labelStatisticsPostsMostPostsWithName
			// 
			this.labelStatisticsPostsMostPostsWithName.AutoSize = true;
			this.labelStatisticsPostsMostPostsWithName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsPostsMostPostsWithName.Location = new System.Drawing.Point(243, 199);
			this.labelStatisticsPostsMostPostsWithName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsPostsMostPostsWithName.Name = "labelStatisticsPostsMostPostsWithName";
			this.labelStatisticsPostsMostPostsWithName.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsPostsMostPostsWithName.TabIndex = 70;
			this.labelStatisticsPostsMostPostsWithName.Text = "-";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(19, 199);
			this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(159, 23);
			this.label30.TabIndex = 69;
			this.label30.Text = "Most Posts With:";
			// 
			// labelStatisticsPostsTotalLikes
			// 
			this.labelStatisticsPostsTotalLikes.AutoSize = true;
			this.labelStatisticsPostsTotalLikes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsPostsTotalLikes.Location = new System.Drawing.Point(243, 151);
			this.labelStatisticsPostsTotalLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsPostsTotalLikes.Name = "labelStatisticsPostsTotalLikes";
			this.labelStatisticsPostsTotalLikes.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsPostsTotalLikes.TabIndex = 68;
			this.labelStatisticsPostsTotalLikes.Text = "-";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(19, 151);
			this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(111, 23);
			this.label28.TabIndex = 67;
			this.label28.Text = "Total Likes:";
			// 
			// labelStatisticsPostsPostsTaggedIn
			// 
			this.labelStatisticsPostsPostsTaggedIn.AutoSize = true;
			this.labelStatisticsPostsPostsTaggedIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsPostsPostsTaggedIn.Location = new System.Drawing.Point(243, 105);
			this.labelStatisticsPostsPostsTaggedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsPostsPostsTaggedIn.Name = "labelStatisticsPostsPostsTaggedIn";
			this.labelStatisticsPostsPostsTaggedIn.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsPostsPostsTaggedIn.TabIndex = 66;
			this.labelStatisticsPostsPostsTaggedIn.Text = "-";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(19, 105);
			this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(167, 23);
			this.label25.TabIndex = 65;
			this.label25.Text = "Posts Tagged In:";
			// 
			// labelStatisticsPostsTotal
			// 
			this.labelStatisticsPostsTotal.AutoSize = true;
			this.labelStatisticsPostsTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsPostsTotal.Location = new System.Drawing.Point(243, 59);
			this.labelStatisticsPostsTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsPostsTotal.Name = "labelStatisticsPostsTotal";
			this.labelStatisticsPostsTotal.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsPostsTotal.TabIndex = 64;
			this.labelStatisticsPostsTotal.Text = "-";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(19, 59);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(135, 23);
			this.label20.TabIndex = 63;
			this.label20.Text = "Posts By You:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(19, 15);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(79, 33);
			this.label16.TabIndex = 62;
			this.label16.Text = "Posts";
			// 
			// panelStatisticsGeneral
			// 
			this.panelStatisticsGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelStatisticsGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelStatisticsGeneral.Controls.Add(this.labelStatisticsGeneralPosts);
			this.panelStatisticsGeneral.Controls.Add(this.label26);
			this.panelStatisticsGeneral.Controls.Add(this.labelStatisticsGeneralGroups);
			this.panelStatisticsGeneral.Controls.Add(this.label24);
			this.panelStatisticsGeneral.Controls.Add(this.labelStatisticsGeneralCheckins);
			this.panelStatisticsGeneral.Controls.Add(this.label22);
			this.panelStatisticsGeneral.Controls.Add(this.labelStatisticsGeneralEventsCreated);
			this.panelStatisticsGeneral.Controls.Add(this.label19);
			this.panelStatisticsGeneral.Controls.Add(this.labelStatisticsGeneralFriends);
			this.panelStatisticsGeneral.Controls.Add(this.label17);
			this.panelStatisticsGeneral.Controls.Add(this.label9);
			this.panelStatisticsGeneral.ForeColor = System.Drawing.Color.Snow;
			this.panelStatisticsGeneral.Location = new System.Drawing.Point(4, 39);
			this.panelStatisticsGeneral.Margin = new System.Windows.Forms.Padding(4);
			this.panelStatisticsGeneral.Name = "panelStatisticsGeneral";
			this.panelStatisticsGeneral.Size = new System.Drawing.Size(915, 302);
			this.panelStatisticsGeneral.TabIndex = 50;
			// 
			// labelStatisticsGeneralPosts
			// 
			this.labelStatisticsGeneralPosts.AutoSize = true;
			this.labelStatisticsGeneralPosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsGeneralPosts.Location = new System.Drawing.Point(307, 249);
			this.labelStatisticsGeneralPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsGeneralPosts.Name = "labelStatisticsGeneralPosts";
			this.labelStatisticsGeneralPosts.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsGeneralPosts.TabIndex = 61;
			this.labelStatisticsGeneralPosts.Text = "-";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(15, 249);
			this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(63, 23);
			this.label26.TabIndex = 60;
			this.label26.Text = "Posts:";
			// 
			// labelStatisticsGeneralGroups
			// 
			this.labelStatisticsGeneralGroups.AutoSize = true;
			this.labelStatisticsGeneralGroups.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsGeneralGroups.Location = new System.Drawing.Point(307, 199);
			this.labelStatisticsGeneralGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsGeneralGroups.Name = "labelStatisticsGeneralGroups";
			this.labelStatisticsGeneralGroups.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsGeneralGroups.TabIndex = 59;
			this.labelStatisticsGeneralGroups.Text = "-";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(15, 199);
			this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(85, 23);
			this.label24.TabIndex = 58;
			this.label24.Text = "Groups:";
			// 
			// labelStatisticsGeneralCheckins
			// 
			this.labelStatisticsGeneralCheckins.AutoSize = true;
			this.labelStatisticsGeneralCheckins.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsGeneralCheckins.Location = new System.Drawing.Point(307, 151);
			this.labelStatisticsGeneralCheckins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsGeneralCheckins.Name = "labelStatisticsGeneralCheckins";
			this.labelStatisticsGeneralCheckins.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsGeneralCheckins.TabIndex = 57;
			this.labelStatisticsGeneralCheckins.Text = "-";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(15, 151);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(102, 23);
			this.label22.TabIndex = 56;
			this.label22.Text = "Checkins:";
			// 
			// labelStatisticsGeneralEventsCreated
			// 
			this.labelStatisticsGeneralEventsCreated.AutoSize = true;
			this.labelStatisticsGeneralEventsCreated.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsGeneralEventsCreated.Location = new System.Drawing.Point(307, 105);
			this.labelStatisticsGeneralEventsCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsGeneralEventsCreated.Name = "labelStatisticsGeneralEventsCreated";
			this.labelStatisticsGeneralEventsCreated.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsGeneralEventsCreated.TabIndex = 55;
			this.labelStatisticsGeneralEventsCreated.Text = "-";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(15, 105);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(168, 23);
			this.label19.TabIndex = 54;
			this.label19.Text = "Events Created:";
			// 
			// labelStatisticsGeneralFriends
			// 
			this.labelStatisticsGeneralFriends.AutoSize = true;
			this.labelStatisticsGeneralFriends.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsGeneralFriends.Location = new System.Drawing.Point(307, 59);
			this.labelStatisticsGeneralFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsGeneralFriends.Name = "labelStatisticsGeneralFriends";
			this.labelStatisticsGeneralFriends.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsGeneralFriends.TabIndex = 53;
			this.labelStatisticsGeneralFriends.Text = "-";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(15, 59);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(81, 23);
			this.label17.TabIndex = 52;
			this.label17.Text = "Friends:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(15, 15);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(280, 33);
			this.label9.TabIndex = 48;
			this.label9.Text = "General Information";
			// 
			// panelStatisticsPhotos
			// 
			this.panelStatisticsPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelStatisticsPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelStatisticsPhotos.Controls.Add(this.labelStatisticsUploadedAlbums);
			this.panelStatisticsPhotos.Controls.Add(this.label21);
			this.panelStatisticsPhotos.Controls.Add(this.labelMostMutualPhotosWithCount);
			this.panelStatisticsPhotos.Controls.Add(this.label15);
			this.panelStatisticsPhotos.Controls.Add(this.labelMostLikesByUserCount);
			this.panelStatisticsPhotos.Controls.Add(this.label14);
			this.panelStatisticsPhotos.Controls.Add(this.labelMostLikesByUserName);
			this.panelStatisticsPhotos.Controls.Add(this.label13);
			this.panelStatisticsPhotos.Controls.Add(this.labelMostMutualPhotosWithName);
			this.panelStatisticsPhotos.Controls.Add(this.label11);
			this.panelStatisticsPhotos.Controls.Add(this.labelMostLikedPhotoLikes);
			this.panelStatisticsPhotos.Controls.Add(this.labelTotalLikes);
			this.panelStatisticsPhotos.Controls.Add(this.labelPhotosTaggedIn);
			this.panelStatisticsPhotos.Controls.Add(this.labelMostLikedPictureLikesTitle);
			this.panelStatisticsPhotos.Controls.Add(this.pictureBoxMostLikedPhoto);
			this.panelStatisticsPhotos.Controls.Add(this.label10);
			this.panelStatisticsPhotos.Controls.Add(this.labelTotalLikesTitle);
			this.panelStatisticsPhotos.Controls.Add(this.labelTopLikedPictures);
			this.panelStatisticsPhotos.Controls.Add(this.labelPhotosTaggedInTitle);
			this.panelStatisticsPhotos.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelStatisticsPhotos.ForeColor = System.Drawing.Color.Snow;
			this.panelStatisticsPhotos.Location = new System.Drawing.Point(4, 350);
			this.panelStatisticsPhotos.Margin = new System.Windows.Forms.Padding(4);
			this.panelStatisticsPhotos.Name = "panelStatisticsPhotos";
			this.panelStatisticsPhotos.Size = new System.Drawing.Size(915, 480);
			this.panelStatisticsPhotos.TabIndex = 49;
			// 
			// labelStatisticsUploadedAlbums
			// 
			this.labelStatisticsUploadedAlbums.AutoSize = true;
			this.labelStatisticsUploadedAlbums.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStatisticsUploadedAlbums.Location = new System.Drawing.Point(307, 58);
			this.labelStatisticsUploadedAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatisticsUploadedAlbums.Name = "labelStatisticsUploadedAlbums";
			this.labelStatisticsUploadedAlbums.Size = new System.Drawing.Size(17, 23);
			this.labelStatisticsUploadedAlbums.TabIndex = 63;
			this.labelStatisticsUploadedAlbums.Text = "-";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(15, 58);
			this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(194, 23);
			this.label21.TabIndex = 62;
			this.label21.Text = "Uploaded Albums:";
			// 
			// labelMostMutualPhotosWithCount
			// 
			this.labelMostMutualPhotosWithCount.AutoSize = true;
			this.labelMostMutualPhotosWithCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMostMutualPhotosWithCount.Location = new System.Drawing.Point(307, 256);
			this.labelMostMutualPhotosWithCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMostMutualPhotosWithCount.Name = "labelMostMutualPhotosWithCount";
			this.labelMostMutualPhotosWithCount.Size = new System.Drawing.Size(17, 23);
			this.labelMostMutualPhotosWithCount.TabIndex = 61;
			this.labelMostMutualPhotosWithCount.Text = "-";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(15, 256);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(146, 23);
			this.label15.TabIndex = 60;
			this.label15.Text = "Photos Count:";
			// 
			// labelMostLikesByUserCount
			// 
			this.labelMostLikesByUserCount.AutoSize = true;
			this.labelMostLikesByUserCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMostLikesByUserCount.Location = new System.Drawing.Point(307, 342);
			this.labelMostLikesByUserCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMostLikesByUserCount.Name = "labelMostLikesByUserCount";
			this.labelMostLikesByUserCount.Size = new System.Drawing.Size(17, 23);
			this.labelMostLikesByUserCount.TabIndex = 59;
			this.labelMostLikesByUserCount.Text = "-";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(15, 342);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(124, 23);
			this.label14.TabIndex = 58;
			this.label14.Text = "Likes Count:";
			// 
			// labelMostLikesByUserName
			// 
			this.labelMostLikesByUserName.AutoSize = true;
			this.labelMostLikesByUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMostLikesByUserName.Location = new System.Drawing.Point(307, 300);
			this.labelMostLikesByUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMostLikesByUserName.Name = "labelMostLikesByUserName";
			this.labelMostLikesByUserName.Size = new System.Drawing.Size(17, 23);
			this.labelMostLikesByUserName.TabIndex = 57;
			this.labelMostLikesByUserName.Text = "-";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(15, 300);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(183, 23);
			this.label13.TabIndex = 56;
			this.label13.Text = "Most Likes By User:";
			// 
			// labelMostMutualPhotosWithName
			// 
			this.labelMostMutualPhotosWithName.AutoSize = true;
			this.labelMostMutualPhotosWithName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMostMutualPhotosWithName.Location = new System.Drawing.Point(307, 214);
			this.labelMostMutualPhotosWithName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMostMutualPhotosWithName.Name = "labelMostMutualPhotosWithName";
			this.labelMostMutualPhotosWithName.Size = new System.Drawing.Size(17, 23);
			this.labelMostMutualPhotosWithName.TabIndex = 55;
			this.labelMostMutualPhotosWithName.Text = "-";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(15, 214);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(176, 23);
			this.label11.TabIndex = 54;
			this.label11.Text = "Most Photos With:";
			// 
			// labelMostLikedPhotoLikes
			// 
			this.labelMostLikedPhotoLikes.AutoSize = true;
			this.labelMostLikedPhotoLikes.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMostLikedPhotoLikes.Location = new System.Drawing.Point(672, 406);
			this.labelMostLikedPhotoLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMostLikedPhotoLikes.Name = "labelMostLikedPhotoLikes";
			this.labelMostLikedPhotoLikes.Size = new System.Drawing.Size(17, 23);
			this.labelMostLikedPhotoLikes.TabIndex = 53;
			this.labelMostLikedPhotoLikes.Text = "-";
			// 
			// labelTotalLikes
			// 
			this.labelTotalLikes.AutoSize = true;
			this.labelTotalLikes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalLikes.Location = new System.Drawing.Point(307, 160);
			this.labelTotalLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTotalLikes.Name = "labelTotalLikes";
			this.labelTotalLikes.Size = new System.Drawing.Size(17, 23);
			this.labelTotalLikes.TabIndex = 52;
			this.labelTotalLikes.Text = "-";
			// 
			// labelPhotosTaggedIn
			// 
			this.labelPhotosTaggedIn.AutoSize = true;
			this.labelPhotosTaggedIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPhotosTaggedIn.Location = new System.Drawing.Point(307, 108);
			this.labelPhotosTaggedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPhotosTaggedIn.Name = "labelPhotosTaggedIn";
			this.labelPhotosTaggedIn.Size = new System.Drawing.Size(17, 23);
			this.labelPhotosTaggedIn.TabIndex = 51;
			this.labelPhotosTaggedIn.Text = "-";
			// 
			// labelMostLikedPictureLikesTitle
			// 
			this.labelMostLikedPictureLikesTitle.AutoSize = true;
			this.labelMostLikedPictureLikesTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMostLikedPictureLikesTitle.Location = new System.Drawing.Point(511, 406);
			this.labelMostLikedPictureLikesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMostLikedPictureLikesTitle.Name = "labelMostLikedPictureLikesTitle";
			this.labelMostLikedPictureLikesTitle.Size = new System.Drawing.Size(58, 23);
			this.labelMostLikedPictureLikesTitle.TabIndex = 50;
			this.labelMostLikedPictureLikesTitle.Text = "Likes:";
			// 
			// pictureBoxMostLikedPhoto
			// 
			this.pictureBoxMostLikedPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxMostLikedPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxMostLikedPhoto.Location = new System.Drawing.Point(515, 58);
			this.pictureBoxMostLikedPhoto.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBoxMostLikedPhoto.Name = "pictureBoxMostLikedPhoto";
			this.pictureBoxMostLikedPhoto.Size = new System.Drawing.Size(372, 344);
			this.pictureBoxMostLikedPhoto.TabIndex = 49;
			this.pictureBoxMostLikedPhoto.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(15, 12);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(103, 33);
			this.label10.TabIndex = 47;
			this.label10.Text = "Photos";
			// 
			// labelTotalLikesTitle
			// 
			this.labelTotalLikesTitle.AutoSize = true;
			this.labelTotalLikesTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalLikesTitle.Location = new System.Drawing.Point(15, 160);
			this.labelTotalLikesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTotalLikesTitle.Name = "labelTotalLikesTitle";
			this.labelTotalLikesTitle.Size = new System.Drawing.Size(111, 23);
			this.labelTotalLikesTitle.TabIndex = 48;
			this.labelTotalLikesTitle.Text = "Total Likes:";
			// 
			// labelTopLikedPictures
			// 
			this.labelTopLikedPictures.AutoSize = true;
			this.labelTopLikedPictures.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTopLikedPictures.Location = new System.Drawing.Point(511, 31);
			this.labelTopLikedPictures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTopLikedPictures.Name = "labelTopLikedPictures";
			this.labelTopLikedPictures.Size = new System.Drawing.Size(181, 23);
			this.labelTopLikedPictures.TabIndex = 45;
			this.labelTopLikedPictures.Text = "Most Liked Photo:";
			// 
			// labelPhotosTaggedInTitle
			// 
			this.labelPhotosTaggedInTitle.AutoSize = true;
			this.labelPhotosTaggedInTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPhotosTaggedInTitle.Location = new System.Drawing.Point(15, 108);
			this.labelPhotosTaggedInTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPhotosTaggedInTitle.Name = "labelPhotosTaggedInTitle";
			this.labelPhotosTaggedInTitle.Size = new System.Drawing.Size(190, 23);
			this.labelPhotosTaggedInTitle.TabIndex = 46;
			this.labelPhotosTaggedInTitle.Text = "Photos Tagged In: ";
			// 
			// buttonCalculateStatistics
			// 
			this.buttonCalculateStatistics.BackColor = System.Drawing.Color.DarkOrange;
			this.buttonCalculateStatistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonCalculateStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCalculateStatistics.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonCalculateStatistics.FlatAppearance.BorderSize = 0;
			this.buttonCalculateStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCalculateStatistics.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCalculateStatistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonCalculateStatistics.Location = new System.Drawing.Point(4, 4);
			this.buttonCalculateStatistics.Margin = new System.Windows.Forms.Padding(4);
			this.buttonCalculateStatistics.Name = "buttonCalculateStatistics";
			this.buttonCalculateStatistics.Size = new System.Drawing.Size(1397, 28);
			this.buttonCalculateStatistics.TabIndex = 44;
			this.buttonCalculateStatistics.Text = "Calculate Statistics";
			this.buttonCalculateStatistics.UseVisualStyleBackColor = false;
			this.buttonCalculateStatistics.Click += new System.EventHandler(this.buttonCalculateStatistics_Click);
			// 
			// tabPageAlbums
			// 
			this.tabPageAlbums.BackColor = System.Drawing.Color.Silver;
			this.tabPageAlbums.Controls.Add(this.labelPictureDate);
			this.tabPageAlbums.Controls.Add(this.labelPictureDateTitle);
			this.tabPageAlbums.Controls.Add(this.labelCurrentPicture);
			this.tabPageAlbums.Controls.Add(this.labelPictureName);
			this.tabPageAlbums.Controls.Add(this.labelPictureNameTitle);
			this.tabPageAlbums.Controls.Add(this.labelPictureLikesTitle);
			this.tabPageAlbums.Controls.Add(this.labelPictureLikes);
			this.tabPageAlbums.Controls.Add(this.labelPictures);
			this.tabPageAlbums.Controls.Add(this.bindingNavigatorPictures);
			this.tabPageAlbums.Controls.Add(this.pictureBox1);
			this.tabPageAlbums.Controls.Add(countLabel);
			this.tabPageAlbums.Controls.Add(this.countLabel1);
			this.tabPageAlbums.Controls.Add(createdTimeLabel);
			this.tabPageAlbums.Controls.Add(this.createdTimeDateTimePicker);
			this.tabPageAlbums.Controls.Add(descriptionLabel1);
			this.tabPageAlbums.Controls.Add(this.descriptionTextBox1);
			this.tabPageAlbums.Controls.Add(this.imageAlbumPictureBox);
			this.tabPageAlbums.Controls.Add(this.labelAlbums);
			this.tabPageAlbums.Controls.Add(this.comboBoxAlbums);
			this.tabPageAlbums.Controls.Add(this.panel15);
			this.tabPageAlbums.Controls.Add(this.panel16);
			this.tabPageAlbums.Controls.Add(this.panel17);
			this.tabPageAlbums.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabPageAlbums.Location = new System.Drawing.Point(4, 27);
			this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageAlbums.Name = "tabPageAlbums";
			this.tabPageAlbums.Size = new System.Drawing.Size(1405, 842);
			this.tabPageAlbums.TabIndex = 3;
			this.tabPageAlbums.Text = "Albums";
			// 
			// labelPictureDate
			// 
			this.labelPictureDate.AutoSize = true;
			this.labelPictureDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPictureDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPictureDate.ForeColor = System.Drawing.Color.Snow;
			this.labelPictureDate.Location = new System.Drawing.Point(979, 202);
			this.labelPictureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPictureDate.Name = "labelPictureDate";
			this.labelPictureDate.Size = new System.Drawing.Size(16, 22);
			this.labelPictureDate.TabIndex = 19;
			this.labelPictureDate.Text = "-";
			// 
			// labelPictureDateTitle
			// 
			this.labelPictureDateTitle.AutoSize = true;
			this.labelPictureDateTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPictureDateTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPictureDateTitle.ForeColor = System.Drawing.Color.Snow;
			this.labelPictureDateTitle.Location = new System.Drawing.Point(828, 198);
			this.labelPictureDateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPictureDateTitle.Name = "labelPictureDateTitle";
			this.labelPictureDateTitle.Size = new System.Drawing.Size(103, 22);
			this.labelPictureDateTitle.TabIndex = 18;
			this.labelPictureDateTitle.Text = "Post Date:";
			// 
			// labelCurrentPicture
			// 
			this.labelCurrentPicture.AutoSize = true;
			this.labelCurrentPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelCurrentPicture.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCurrentPicture.ForeColor = System.Drawing.Color.Snow;
			this.labelCurrentPicture.Location = new System.Drawing.Point(828, 18);
			this.labelCurrentPicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCurrentPicture.Name = "labelCurrentPicture";
			this.labelCurrentPicture.Size = new System.Drawing.Size(284, 30);
			this.labelCurrentPicture.TabIndex = 17;
			this.labelCurrentPicture.Text = "Current Picture Details:";
			// 
			// labelPictureName
			// 
			this.labelPictureName.AutoEllipsis = true;
			this.labelPictureName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPictureName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPictureName.ForeColor = System.Drawing.Color.Snow;
			this.labelPictureName.Location = new System.Drawing.Point(979, 73);
			this.labelPictureName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPictureName.Name = "labelPictureName";
			this.labelPictureName.Size = new System.Drawing.Size(183, 64);
			this.labelPictureName.TabIndex = 16;
			this.labelPictureName.Text = "-";
			// 
			// labelPictureNameTitle
			// 
			this.labelPictureNameTitle.AutoSize = true;
			this.labelPictureNameTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPictureNameTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPictureNameTitle.ForeColor = System.Drawing.Color.Snow;
			this.labelPictureNameTitle.Location = new System.Drawing.Point(828, 69);
			this.labelPictureNameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPictureNameTitle.Name = "labelPictureNameTitle";
			this.labelPictureNameTitle.Size = new System.Drawing.Size(139, 22);
			this.labelPictureNameTitle.TabIndex = 15;
			this.labelPictureNameTitle.Text = "Picture Name:";
			// 
			// labelPictureLikesTitle
			// 
			this.labelPictureLikesTitle.AutoSize = true;
			this.labelPictureLikesTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPictureLikesTitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPictureLikesTitle.ForeColor = System.Drawing.Color.Snow;
			this.labelPictureLikesTitle.Location = new System.Drawing.Point(828, 153);
			this.labelPictureLikesTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPictureLikesTitle.Name = "labelPictureLikesTitle";
			this.labelPictureLikesTitle.Size = new System.Drawing.Size(56, 22);
			this.labelPictureLikesTitle.TabIndex = 14;
			this.labelPictureLikesTitle.Text = "Likes:";
			// 
			// labelPictureLikes
			// 
			this.labelPictureLikes.AutoSize = true;
			this.labelPictureLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelPictureLikes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPictureLikes.ForeColor = System.Drawing.Color.Snow;
			this.labelPictureLikes.Location = new System.Drawing.Point(979, 156);
			this.labelPictureLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPictureLikes.Name = "labelPictureLikes";
			this.labelPictureLikes.Size = new System.Drawing.Size(16, 22);
			this.labelPictureLikes.TabIndex = 13;
			this.labelPictureLikes.Text = "-";
			// 
			// labelPictures
			// 
			this.labelPictures.AutoSize = true;
			this.labelPictures.BackColor = System.Drawing.Color.DarkOrange;
			this.labelPictures.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPictures.Location = new System.Drawing.Point(16, 247);
			this.labelPictures.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPictures.Name = "labelPictures";
			this.labelPictures.Size = new System.Drawing.Size(153, 40);
			this.labelPictures.TabIndex = 12;
			this.labelPictures.Text = "Pictures:";
			// 
			// bindingNavigatorPictures
			// 
			this.bindingNavigatorPictures.AddNewItem = null;
			this.bindingNavigatorPictures.BindingSource = this.bindingSourcePictures;
			this.bindingNavigatorPictures.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigatorPictures.DeleteItem = null;
			this.bindingNavigatorPictures.Dock = System.Windows.Forms.DockStyle.None;
			this.bindingNavigatorPictures.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.bindingNavigatorPictures.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.bindingNavigatorPictures.Location = new System.Drawing.Point(23, 800);
			this.bindingNavigatorPictures.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigatorPictures.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigatorPictures.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigatorPictures.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigatorPictures.Name = "bindingNavigatorPictures";
			this.bindingNavigatorPictures.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigatorPictures.Size = new System.Drawing.Size(238, 27);
			this.bindingNavigatorPictures.TabIndex = 11;
			this.bindingNavigatorPictures.Text = "bindingNavigatorPictures";
			// 
			// bindingSourcePictures
			// 
			this.bindingSourcePictures.DataMember = "Photos";
			this.bindingSourcePictures.DataSource = this.bindingSourceAlbums;
			this.bindingSourcePictures.CurrentChanged += new System.EventHandler(this.bindingSourcePictures_CurrentChanged);
			// 
			// bindingSourceAlbums
			// 
			this.bindingSourceAlbums.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourcePictures, "ImageNormal", true));
			this.pictureBox1.Location = new System.Drawing.Point(11, 288);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1380, 507);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// countLabel1
			// 
			this.countLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAlbums, "Count", true));
			this.countLabel1.ForeColor = System.Drawing.Color.Snow;
			this.countLabel1.Location = new System.Drawing.Point(232, 60);
			this.countLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.countLabel1.Name = "countLabel1";
			this.countLabel1.Size = new System.Drawing.Size(267, 28);
			this.countLabel1.TabIndex = 3;
			this.countLabel1.Text = "label1";
			// 
			// createdTimeDateTimePicker
			// 
			this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSourceAlbums, "CreatedTime", true));
			this.createdTimeDateTimePicker.Enabled = false;
			this.createdTimeDateTimePicker.Location = new System.Drawing.Point(232, 92);
			this.createdTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
			this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
			this.createdTimeDateTimePicker.Size = new System.Drawing.Size(265, 26);
			this.createdTimeDateTimePicker.TabIndex = 5;
			// 
			// descriptionTextBox1
			// 
			this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceAlbums, "Description", true));
			this.descriptionTextBox1.Enabled = false;
			this.descriptionTextBox1.Location = new System.Drawing.Point(232, 139);
			this.descriptionTextBox1.Margin = new System.Windows.Forms.Padding(4);
			this.descriptionTextBox1.Multiline = true;
			this.descriptionTextBox1.Name = "descriptionTextBox1";
			this.descriptionTextBox1.Size = new System.Drawing.Size(265, 104);
			this.descriptionTextBox1.TabIndex = 7;
			// 
			// imageAlbumPictureBox
			// 
			this.imageAlbumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceAlbums, "ImageAlbum", true));
			this.imageAlbumPictureBox.Location = new System.Drawing.Point(553, 11);
			this.imageAlbumPictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
			this.imageAlbumPictureBox.Size = new System.Drawing.Size(265, 235);
			this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imageAlbumPictureBox.TabIndex = 9;
			this.imageAlbumPictureBox.TabStop = false;
			// 
			// labelAlbums
			// 
			this.labelAlbums.AutoSize = true;
			this.labelAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelAlbums.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAlbums.ForeColor = System.Drawing.Color.Snow;
			this.labelAlbums.Location = new System.Drawing.Point(19, 11);
			this.labelAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelAlbums.Name = "labelAlbums";
			this.labelAlbums.Size = new System.Drawing.Size(108, 30);
			this.labelAlbums.TabIndex = 1;
			this.labelAlbums.Text = "Albums:";
			// 
			// comboBoxAlbums
			// 
			this.comboBoxAlbums.DataSource = this.bindingSourceAlbums;
			this.comboBoxAlbums.DisplayMember = "Name";
			this.comboBoxAlbums.FormattingEnabled = true;
			this.comboBoxAlbums.Location = new System.Drawing.Point(232, 17);
			this.comboBoxAlbums.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxAlbums.Name = "comboBoxAlbums";
			this.comboBoxAlbums.Size = new System.Drawing.Size(160, 26);
			this.comboBoxAlbums.TabIndex = 0;
			// 
			// panel15
			// 
			this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel15.Location = new System.Drawing.Point(823, 11);
			this.panel15.Margin = new System.Windows.Forms.Padding(4);
			this.panel15.Name = "panel15";
			this.panel15.Size = new System.Drawing.Size(367, 236);
			this.panel15.TabIndex = 20;
			// 
			// panel16
			// 
			this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel16.Location = new System.Drawing.Point(11, 11);
			this.panel16.Margin = new System.Windows.Forms.Padding(4);
			this.panel16.Name = "panel16";
			this.panel16.Size = new System.Drawing.Size(519, 236);
			this.panel16.TabIndex = 21;
			// 
			// panel17
			// 
			this.panel17.BackColor = System.Drawing.Color.DarkOrange;
			this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel17.Location = new System.Drawing.Point(12, 247);
			this.panel17.Margin = new System.Windows.Forms.Padding(4);
			this.panel17.Name = "panel17";
			this.panel17.Size = new System.Drawing.Size(1377, 40);
			this.panel17.TabIndex = 22;
			// 
			// tabPageTaggedPhotos
			// 
			this.tabPageTaggedPhotos.Controls.Add(this.pictureBoxTaggedPhotos);
			this.tabPageTaggedPhotos.Controls.Add(this.bindingNavigatorTaggedPhotos);
			this.tabPageTaggedPhotos.Controls.Add(this.buttonGetTaggedPhotos);
			this.tabPageTaggedPhotos.Controls.Add(this.textBoxAmmounts);
			this.tabPageTaggedPhotos.Controls.Add(this.label23);
			this.tabPageTaggedPhotos.Controls.Add(this.label18);
			this.tabPageTaggedPhotos.Controls.Add(this.comboBoxTaggedPhotoSelectStrategys);
			this.tabPageTaggedPhotos.Location = new System.Drawing.Point(4, 27);
			this.tabPageTaggedPhotos.Name = "tabPageTaggedPhotos";
			this.tabPageTaggedPhotos.Size = new System.Drawing.Size(1405, 842);
			this.tabPageTaggedPhotos.TabIndex = 4;
			this.tabPageTaggedPhotos.Text = "Tagged Photos";
			this.tabPageTaggedPhotos.UseVisualStyleBackColor = true;
			// 
			// pictureBoxTaggedPhotos
			// 
			this.pictureBoxTaggedPhotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxTaggedPhotos.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSourceTaggedPhotos, "ImageNormal", true));
			this.pictureBoxTaggedPhotos.Location = new System.Drawing.Point(32, 70);
			this.pictureBoxTaggedPhotos.Name = "pictureBoxTaggedPhotos";
			this.pictureBoxTaggedPhotos.Size = new System.Drawing.Size(1365, 712);
			this.pictureBoxTaggedPhotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxTaggedPhotos.TabIndex = 7;
			this.pictureBoxTaggedPhotos.TabStop = false;
			// 
			// bindingSourceTaggedPhotos
			// 
			this.bindingSourceTaggedPhotos.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
			// 
			// bindingNavigatorTaggedPhotos
			// 
			this.bindingNavigatorTaggedPhotos.AddNewItem = null;
			this.bindingNavigatorTaggedPhotos.BindingSource = this.bindingSourceTaggedPhotos;
			this.bindingNavigatorTaggedPhotos.CountItem = this.bindingNavigatorCountItem2;
			this.bindingNavigatorTaggedPhotos.DeleteItem = null;
			this.bindingNavigatorTaggedPhotos.Dock = System.Windows.Forms.DockStyle.None;
			this.bindingNavigatorTaggedPhotos.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.bindingNavigatorTaggedPhotos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8});
			this.bindingNavigatorTaggedPhotos.Location = new System.Drawing.Point(623, 785);
			this.bindingNavigatorTaggedPhotos.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
			this.bindingNavigatorTaggedPhotos.MoveLastItem = this.bindingNavigatorMoveLastItem2;
			this.bindingNavigatorTaggedPhotos.MoveNextItem = this.bindingNavigatorMoveNextItem2;
			this.bindingNavigatorTaggedPhotos.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
			this.bindingNavigatorTaggedPhotos.Name = "bindingNavigatorTaggedPhotos";
			this.bindingNavigatorTaggedPhotos.PositionItem = this.bindingNavigatorPositionItem2;
			this.bindingNavigatorTaggedPhotos.Size = new System.Drawing.Size(223, 27);
			this.bindingNavigatorTaggedPhotos.TabIndex = 6;
			this.bindingNavigatorTaggedPhotos.Text = "bindingNavigator1";
			// 
			// bindingNavigatorCountItem2
			// 
			this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
			this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(45, 24);
			this.bindingNavigatorCountItem2.Text = "of {0}";
			this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorMoveFirstItem2
			// 
			this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
			this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
			this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveFirstItem2.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem2
			// 
			this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
			this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
			this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
			// 
			// bindingNavigatorSeparator6
			// 
			this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
			this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorPositionItem2
			// 
			this.bindingNavigatorPositionItem2.AccessibleName = "Position";
			this.bindingNavigatorPositionItem2.AutoSize = false;
			this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
			this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 27);
			this.bindingNavigatorPositionItem2.Text = "0";
			this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator7
			// 
			this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
			this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 27);
			// 
			// bindingNavigatorMoveNextItem2
			// 
			this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
			this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
			this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveNextItem2.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem2
			// 
			this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
			this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
			this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(24, 24);
			this.bindingNavigatorMoveLastItem2.Text = "Move last";
			// 
			// bindingNavigatorSeparator8
			// 
			this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
			this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 27);
			// 
			// buttonGetTaggedPhotos
			// 
			this.buttonGetTaggedPhotos.Location = new System.Drawing.Point(566, 26);
			this.buttonGetTaggedPhotos.Name = "buttonGetTaggedPhotos";
			this.buttonGetTaggedPhotos.Size = new System.Drawing.Size(831, 31);
			this.buttonGetTaggedPhotos.TabIndex = 4;
			this.buttonGetTaggedPhotos.Text = "Get Tagged Photos";
			this.buttonGetTaggedPhotos.UseVisualStyleBackColor = true;
			this.buttonGetTaggedPhotos.Click += new System.EventHandler(this.buttonGetTaggedPhotos_Click);
			// 
			// textBoxAmmounts
			// 
			this.textBoxAmmounts.Enabled = false;
			this.textBoxAmmounts.Location = new System.Drawing.Point(434, 29);
			this.textBoxAmmounts.Name = "textBoxAmmounts";
			this.textBoxAmmounts.Size = new System.Drawing.Size(100, 26);
			this.textBoxAmmounts.TabIndex = 3;
			this.textBoxAmmounts.TextChanged += new System.EventHandler(this.textBoxAmmounts_TextChanged);
			this.textBoxAmmounts.Leave += new System.EventHandler(this.textBoxAmmounts_Leave);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(332, 32);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(86, 18);
			this.label23.TabIndex = 2;
			this.label23.Text = "Ammount :";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(29, 32);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(58, 18);
			this.label18.TabIndex = 1;
			this.label18.Text = "Filter :";
			// 
			// comboBoxTaggedPhotoSelectStrategys
			// 
			this.comboBoxTaggedPhotoSelectStrategys.FormattingEnabled = true;
			this.comboBoxTaggedPhotoSelectStrategys.Location = new System.Drawing.Point(93, 29);
			this.comboBoxTaggedPhotoSelectStrategys.Name = "comboBoxTaggedPhotoSelectStrategys";
			this.comboBoxTaggedPhotoSelectStrategys.Size = new System.Drawing.Size(188, 26);
			this.comboBoxTaggedPhotoSelectStrategys.TabIndex = 0;
			this.comboBoxTaggedPhotoSelectStrategys.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaggedPhotoSelectStrategys_SelectedIndexChanged);
			// 
			// bindingSourceFriendOverviewEvents
			// 
			this.bindingSourceFriendOverviewEvents.DataMember = "InvitedUsers";
			this.bindingSourceFriendOverviewEvents.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
			// 
			// commentsBindingSource
			// 
			this.commentsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Comment);
			// 
			// bindingSourceLikedBy
			// 
			this.bindingSourceLikedBy.DataMember = "LikedBy";
			this.bindingSourceLikedBy.DataSource = this.bindingSourcePictures;
			// 
			// FacebookApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1413, 873);
			this.Controls.Add(this.tabControlGeneral);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Location = new System.Drawing.Point(10, 10);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FacebookApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "FB Keep Up!";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.facebookApp_FormClosing);
			this.Load += new System.EventHandler(this.facebookApp_Load);
			this.Shown += new System.EventHandler(this.facebookApp_Shown);
			this.tabControlGeneral.ResumeLayout(false);
			this.tabPageGeneral.ResumeLayout(false);
			this.tabPageGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikedPages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceLikedPages)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridViewRecentWallPosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceWallPosts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriends)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomingBirthdays)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceBirthdays)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxGeneralEventImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxGeneralSelectedFriend)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.tabPageFriendOverview.ResumeLayout(false);
			this.tabPageFriendOverview.PerformLayout();
			this.panel14.ResumeLayout(false);
			this.panel14.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.tabControlSubFriendOverview.ResumeLayout(false);
			this.tabPagePersonalInfo.ResumeLayout(false);
			this.panelFriendProfileData.ResumeLayout(false);
			this.panelFriendProfileData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewPersonalInfo)).EndInit();
			this.tabPageEvents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendOverviewEvents)).EndInit();
			this.tabPageCheckins.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendOvervieCheckins)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewCheckins)).EndInit();
			this.tabPagePosts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewPosts)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFriendOverviewGroups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewGroups)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMutualPictureToUpload)).EndInit();
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.panel13.ResumeLayout(false);
			this.panel13.PerformLayout();
			this.tabControlMutualInfo.ResumeLayout(false);
			this.tabPageMutualEvents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMutualEvents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewMutualEvents)).EndInit();
			this.tabPageMutualCheckins.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMutualCheckins)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewMutualCheckins)).EndInit();
			this.tabPagePostsTaggedMe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPostsTaggedMe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewPostsTaggedMe)).EndInit();
			this.tabPageMutualGroups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewMutualGroups)).EndInit();
			this.tabPageMutualPics.ResumeLayout(false);
			this.tabPageMutualPics.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMutualPictures)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewMutualPictures)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMutualPic)).EndInit();
			this.bindingNavigatorMutualPic.ResumeLayout(false);
			this.bindingNavigatorMutualPic.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBoxFriendOverviewSelectedFriend)).EndInit();
			this.tabPageStatistics.ResumeLayout(false);
			this.panelStatisticsPosts.ResumeLayout(false);
			this.panelStatisticsPosts.PerformLayout();
			this.panelStatisticsGeneral.ResumeLayout(false);
			this.panelStatisticsGeneral.PerformLayout();
			this.panelStatisticsPhotos.ResumeLayout(false);
			this.panelStatisticsPhotos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostLikedPhoto)).EndInit();
			this.tabPageAlbums.ResumeLayout(false);
			this.tabPageAlbums.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPictures)).EndInit();
			this.bindingNavigatorPictures.ResumeLayout(false);
			this.bindingNavigatorPictures.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourcePictures)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlbums)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
			this.tabPageTaggedPhotos.ResumeLayout(false);
			this.tabPageTaggedPhotos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaggedPhotos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaggedPhotos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTaggedPhotos)).EndInit();
			this.bindingNavigatorTaggedPhotos.ResumeLayout(false);
			this.bindingNavigatorTaggedPhotos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceFriendOverviewEvents)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceLikedBy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSourceTaggedPhotosSearchStrategys)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlGeneral;
		private System.Windows.Forms.TabPage tabPageGeneral;
		private System.Windows.Forms.TabPage tabPageFriendOverview;
		private System.Windows.Forms.TabPage tabPageStatistics;
		private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
		private System.Windows.Forms.ListBox listBoxFriends;
		private System.Windows.Forms.Label labelFriends;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.BindingSource bindingSourceFriends;
		private System.Windows.Forms.Label labelEvents;
		private System.Windows.Forms.Label labelGeneralFriendEmail;
		private System.Windows.Forms.PictureBox PictureBoxGeneralSelectedFriend;
		private System.Windows.Forms.BindingSource bindingSourceEvents;
		private System.Windows.Forms.TextBox TextBoxEventDescription;
		private System.Windows.Forms.DateTimePicker DateTimePickerEventEndTime;
		private System.Windows.Forms.PictureBox PictureBoxGeneralEventImage;
		private System.Windows.Forms.DateTimePicker DateTimePickerEventStartTime;
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.TabPage tabPageAlbums;
		private System.Windows.Forms.Label labelAlbums;
		private System.Windows.Forms.BindingSource bindingSourceAlbums;
		private System.Windows.Forms.Label countLabel1;
		private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
		private System.Windows.Forms.TextBox descriptionTextBox1;
		private System.Windows.Forms.PictureBox imageAlbumPictureBox;
		private System.Windows.Forms.BindingNavigator bindingNavigatorPictures;
		private System.Windows.Forms.BindingSource bindingSourcePictures;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelPictures;
		private System.Windows.Forms.Label labelBirthdays;
		private System.Windows.Forms.DataGridView dataGridViewUpcomingBirthdays;
		private System.Windows.Forms.BindingSource bindingSourceBirthdays;
		private System.Windows.Forms.Label labelGeneralFriendBirthday;
		private System.Windows.Forms.Label labelPictureLikes;
		private System.Windows.Forms.Label labelPictureLikesTitle;
		private System.Windows.Forms.Label labelPictureName;
		private System.Windows.Forms.Label labelPictureNameTitle;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.CheckBox checkBoxRememberUser;
		private System.Windows.Forms.PictureBox pictureBoxCover;
		private System.Windows.Forms.Button buttonPost;
		private System.Windows.Forms.TextBox textBoxPost;
		private System.Windows.Forms.Label labelPost;
		private System.Windows.Forms.Label labelPictureDateTitle;
		private System.Windows.Forms.Label labelCurrentPicture;
		private System.Windows.Forms.Label labelPictureDate;
		private System.Windows.Forms.Label labelWallPosts;
		private System.Windows.Forms.DataGridView DataGridViewRecentWallPosts;
		private System.Windows.Forms.BindingSource bindingSourceWallPosts;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewLinkColumn Link;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxWallPostAge;
		private System.Windows.Forms.BindingSource bindingSourceLikedPages;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewLikedPages;
		private System.Windows.Forms.DataGridViewImageColumn imageSmallDataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn likesCountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn imageSmallDataGridViewImageColumn;
        private System.Windows.Forms.Panel panelFriendProfileData;
        private System.Windows.Forms.TabControl tabControlSubFriendOverview;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TabPage tabPageCheckins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverview;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewEvents;
        private System.Windows.Forms.DataGridView dataGridViewFriendOverviewEvents;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewCheckins;
        private System.Windows.Forms.DataGridView dataGridViewFriendOvervieCheckins;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewPosts;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewGroups;
        private System.Windows.Forms.DataGridView dataGridViewFriendOverviewGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn privacyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewPersonalInfo;
        private System.Windows.Forms.Label labelFriendOverviewBirthday;
        private System.Windows.Forms.Label emailLabel3;
        private System.Windows.Forms.PictureBox PictureBoxFriendOverviewSelectedFriend;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewMutualPictures;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBoxChooseAFriend;
        private System.Windows.Forms.Button buttonBrowseAPicture;
        private System.Windows.Forms.PictureBox pictureBoxMutualPictureToUpload;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxMutualPicToUploadTitle;
        private System.Windows.Forms.Button buttonUplaodMutualPic;
        private System.Windows.Forms.ProgressBar progressBarFriendshipStrength;
        private System.Windows.Forms.BindingSource bindingSourceLikedBy;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUploadMutualPic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigatorMutualPic;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Label labelUploadMutualPicDescription;
        private System.Windows.Forms.TextBox positionInAlbumTextBox;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Label labelNumberOfFriends;
        private System.Windows.Forms.Label labelRelationshipStatus;
        private System.Windows.Forms.Label labelOnlineStatus;
        private System.Windows.Forms.Label labelWelcomeUser;
        private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label labelTopLikedPictures;
		private System.Windows.Forms.Button buttonCalculateStatistics;
		private System.Windows.Forms.Panel panelStatisticsPhotos;
		private System.Windows.Forms.Label labelMostLikedPhotoLikes;
		private System.Windows.Forms.Label labelTotalLikes;
		private System.Windows.Forms.Label labelPhotosTaggedIn;
		private System.Windows.Forms.Label labelMostLikedPictureLikesTitle;
		private System.Windows.Forms.PictureBox pictureBoxMostLikedPhoto;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label labelTotalLikesTitle;
		private System.Windows.Forms.Label labelPhotosTaggedInTitle;
		private System.Windows.Forms.Label labelMostMutualPhotosWithName;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label labelMostLikesByUserCount;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label labelMostLikesByUserName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label labelMostMutualPhotosWithCount;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Panel panelStatisticsPosts;
		private System.Windows.Forms.Panel panelStatisticsGeneral;
		private System.Windows.Forms.Label labelStatisticsGeneralEventsCreated;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label labelStatisticsGeneralFriends;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label labelStatisticsUploadedAlbums;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label labelStatisticsGeneralCheckins;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label labelStatisticsGeneralGroups;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label labelStatisticsGeneralPosts;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label labelStatisticsPostsTotal;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label labelStatisticsPostsMostLikes;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.RichTextBox richTextBoxMostLikedPost;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label labelStatisticsPostsMostLikesByUserCount;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label labelStatisticsPostsMostLikesByUserName;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label labelStatisticsPostsMostPostsWithCount;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label labelStatisticsPostsMostPostsWithName;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label labelStatisticsPostsTotalLikes;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label labelStatisticsPostsPostsTaggedIn;
		private System.Windows.Forms.Label label25;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPagePersonalInfo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControlMutualInfo;
        private System.Windows.Forms.TabPage tabPageMutualEvents;
        private System.Windows.Forms.TabPage tabPageMutualCheckins;
        private System.Windows.Forms.TabPage tabPagePostsTaggedMe;
        private System.Windows.Forms.TabPage tabPageMutualGroups;
        private System.Windows.Forms.TabPage tabPageMutualPics;
        private System.Windows.Forms.PictureBox pictureBoxMutualPictures;
        private System.Windows.Forms.DataGridView dataGridViewMutualEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privacyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkToFacebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureSmallURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureNormalURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureLargeURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureSqaureURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageSmallDataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn imageNormalDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageLargeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageSqaureDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewMutualEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn venueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn privacyDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkToFacebookDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStringDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTimeStringDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureSmallURLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureNormalURLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureLargeURLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureSqaureURLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imageSmallDataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn imageNormalDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imageLargeDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imageSqaureDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridViewMutualCheckins;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewMutualCheckins;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewPostsTaggedMe;
        private System.Windows.Forms.DataGridView dataGridViewPostsTaggedMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource bindingSourceFriendOverviewMutualGroups;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label labelMutualInfo;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label labelGeneralFriendInfo;
        private System.Windows.Forms.ComboBox comboBoxAlbums;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
		private System.Windows.Forms.TabPage tabPageTaggedPhotos;
		private System.Windows.Forms.ComboBox comboBoxTaggedPhotoSelectStrategys;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBoxAmmounts;
		private System.Windows.Forms.PictureBox pictureBoxTaggedPhotos;
		private System.Windows.Forms.BindingSource bindingSourceTaggedPhotos;
		private System.Windows.Forms.BindingNavigator bindingNavigatorTaggedPhotos;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
		private System.Windows.Forms.Button buttonGetTaggedPhotos;
		private System.Windows.Forms.BindingSource bindingSourceTaggedPhotosSearchStrategys;
	}
}