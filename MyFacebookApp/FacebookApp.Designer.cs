namespace MyFacebookApp
{
	partial class FacebookApp
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
			this.tabControlGeneral = new System.Windows.Forms.TabControl();
			this.tabPageGeneral = new System.Windows.Forms.TabPage();
			this.buttonLogout = new System.Windows.Forms.Button();
			this.labelFriends = new System.Windows.Forms.Label();
			this.pictureBoxSelectedFriend = new System.Windows.Forms.PictureBox();
			this.listBoxFriends = new System.Windows.Forms.ListBox();
			this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
			this.tabPageBuisnesses = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControlGeneral.SuspendLayout();
			this.tabPageGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlGeneral
			// 
			this.tabControlGeneral.Controls.Add(this.tabPageGeneral);
			this.tabControlGeneral.Controls.Add(this.tabPageBuisnesses);
			this.tabControlGeneral.Controls.Add(this.tabPage2);
			this.tabControlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlGeneral.Location = new System.Drawing.Point(0, 0);
			this.tabControlGeneral.Name = "tabControlGeneral";
			this.tabControlGeneral.SelectedIndex = 0;
			this.tabControlGeneral.Size = new System.Drawing.Size(764, 516);
			this.tabControlGeneral.TabIndex = 0;
			// 
			// tabPageGeneral
			// 
			this.tabPageGeneral.Controls.Add(this.buttonLogout);
			this.tabPageGeneral.Controls.Add(this.labelFriends);
			this.tabPageGeneral.Controls.Add(this.pictureBoxSelectedFriend);
			this.tabPageGeneral.Controls.Add(this.listBoxFriends);
			this.tabPageGeneral.Controls.Add(this.pictureBoxProfilePicture);
			this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabPageGeneral.Name = "tabPageGeneral";
			this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGeneral.Size = new System.Drawing.Size(756, 490);
			this.tabPageGeneral.TabIndex = 0;
			this.tabPageGeneral.Text = "General";
			this.tabPageGeneral.UseVisualStyleBackColor = true;
			// 
			// buttonLogout
			// 
			this.buttonLogout.Location = new System.Drawing.Point(673, 459);
			this.buttonLogout.Name = "buttonLogout";
			this.buttonLogout.Size = new System.Drawing.Size(75, 23);
			this.buttonLogout.TabIndex = 4;
			this.buttonLogout.Text = "Logout";
			this.buttonLogout.UseVisualStyleBackColor = true;
			// 
			// labelFriends
			// 
			this.labelFriends.AutoSize = true;
			this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.labelFriends.Location = new System.Drawing.Point(8, 118);
			this.labelFriends.Name = "labelFriends";
			this.labelFriends.Size = new System.Drawing.Size(72, 13);
			this.labelFriends.TabIndex = 3;
			this.labelFriends.Text = "Friends List";
			// 
			// pictureBoxSelectedFriend
			// 
			this.pictureBoxSelectedFriend.Location = new System.Drawing.Point(156, 137);
			this.pictureBoxSelectedFriend.Name = "pictureBoxSelectedFriend";
			this.pictureBoxSelectedFriend.Size = new System.Drawing.Size(50, 50);
			this.pictureBoxSelectedFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxSelectedFriend.TabIndex = 2;
			this.pictureBoxSelectedFriend.TabStop = false;
			// 
			// listBoxFriends
			// 
			this.listBoxFriends.FormattingEnabled = true;
			this.listBoxFriends.Location = new System.Drawing.Point(7, 137);
			this.listBoxFriends.Name = "listBoxFriends";
			this.listBoxFriends.Size = new System.Drawing.Size(142, 160);
			this.listBoxFriends.TabIndex = 1;
			this.listBoxFriends.SelectedValueChanged += new System.EventHandler(this.listBoxFriends_SelectedValueChanged);
			// 
			// pictureBoxProfilePicture
			// 
			this.pictureBoxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxProfilePicture.Location = new System.Drawing.Point(8, 6);
			this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
			this.pictureBoxProfilePicture.Size = new System.Drawing.Size(100, 100);
			this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxProfilePicture.TabIndex = 0;
			this.pictureBoxProfilePicture.TabStop = false;
			// 
			// tabPageBuisnesses
			// 
			this.tabPageBuisnesses.Location = new System.Drawing.Point(4, 22);
			this.tabPageBuisnesses.Name = "tabPageBuisnesses";
			this.tabPageBuisnesses.Size = new System.Drawing.Size(756, 490);
			this.tabPageBuisnesses.TabIndex = 2;
			this.tabPageBuisnesses.Text = "Buisnesses";
			this.tabPageBuisnesses.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(756, 490);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// FacebookApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(764, 516);
			this.Controls.Add(this.tabControlGeneral);
			this.Location = new System.Drawing.Point(10, 10);
			this.Name = "FacebookApp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "FacebookApp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacebookApp_FormClosing);
			this.Load += new System.EventHandler(this.FacebookApp_Load);
			this.LocationChanged += new System.EventHandler(this.FacebookApp_LocationChanged);
			this.tabControlGeneral.ResumeLayout(false);
			this.tabPageGeneral.ResumeLayout(false);
			this.tabPageGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedFriend)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlGeneral;
		private System.Windows.Forms.TabPage tabPageGeneral;
		private System.Windows.Forms.TabPage tabPageBuisnesses;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
		private System.Windows.Forms.ListBox listBoxFriends;
		private System.Windows.Forms.Label labelFriends;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.BindingSource bindingSourceUser;
		private System.Windows.Forms.Label labelEvents;
		private System.Windows.Forms.Label birthdayLabel1;
		private System.Windows.Forms.Label emailLabel1;
		private System.Windows.Forms.PictureBox imageNormalPictureBox;
		private System.Windows.Forms.BindingSource bindingSourceEvents;
		private System.Windows.Forms.Label ownerLabel1;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.DateTimePicker endTimeDateTimePicker;
		private System.Windows.Forms.PictureBox eventImagePictureBox1;
		private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
		private System.Windows.Forms.ListBox listBoxEvents;
		private System.Windows.Forms.Label nameLabel2;
		private System.Windows.Forms.Label cityLabel1;
		private System.Windows.Forms.Label countryLabel1;
		private System.Windows.Forms.TabPage tabPageAlbums;
		private System.Windows.Forms.Label labelAlbums;
		private System.Windows.Forms.ComboBox comboBox1;
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
	}
}