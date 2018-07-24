namespace MyFacebookApp
{
	partial class FormLogin
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
			this.buttonLogin = new System.Windows.Forms.Button();
			this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(66, 55);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 0;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// checkBoxRememberUser
			// 
			this.checkBoxRememberUser.AutoSize = true;
			this.checkBoxRememberUser.Location = new System.Drawing.Point(66, 119);
			this.checkBoxRememberUser.Name = "checkBoxRememberUser";
			this.checkBoxRememberUser.Size = new System.Drawing.Size(95, 17);
			this.checkBoxRememberUser.TabIndex = 1;
			this.checkBoxRememberUser.Text = "Remember Me";
			this.checkBoxRememberUser.UseVisualStyleBackColor = true;
			this.checkBoxRememberUser.CheckedChanged += new System.EventHandler(this.checkBoxRememberUser_CheckedChanged);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(210, 160);
			this.Controls.Add(this.checkBoxRememberUser);
			this.Controls.Add(this.buttonLogin);
			this.Name = "FormLogin";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.CheckBox checkBoxRememberUser;
	}
}

