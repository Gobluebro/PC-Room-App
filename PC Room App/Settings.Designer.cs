namespace PC_Room_App
{
    partial class formSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettings));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnWOW = new System.Windows.Forms.Button();
            this.btnOW = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.openProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWOW
            // 
            this.btnWOW.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWOW.Image = ((System.Drawing.Image)(resources.GetObject("btnWOW.Image")));
            this.btnWOW.Location = new System.Drawing.Point(58, 82);
            this.btnWOW.Name = "btnWOW";
            this.btnWOW.Size = new System.Drawing.Size(275, 266);
            this.btnWOW.TabIndex = 0;
            this.btnWOW.Text = "World of Warcraft";
            this.btnWOW.UseVisualStyleBackColor = false;
            this.btnWOW.Visible = false;
            this.btnWOW.Click += new System.EventHandler(this.btnWOW_Click);
            // 
            // btnOW
            // 
            this.btnOW.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOW.Image = ((System.Drawing.Image)(resources.GetObject("btnOW.Image")));
            this.btnOW.Location = new System.Drawing.Point(400, 82);
            this.btnOW.Name = "btnOW";
            this.btnOW.Size = new System.Drawing.Size(275, 266);
            this.btnOW.TabIndex = 1;
            this.btnOW.Text = "Overwatch";
            this.btnOW.UseVisualStyleBackColor = false;
            this.btnOW.Visible = false;
            this.btnOW.Click += new System.EventHandler(this.btnOW_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileMenu,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(738, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileMenu
            // 
            this.profileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfile,
            this.openProfile});
            this.profileMenu.Name = "profileMenu";
            this.profileMenu.Size = new System.Drawing.Size(74, 29);
            this.profileMenu.Text = "Profile";
            // 
            // newProfile
            // 
            this.newProfile.Name = "newProfile";
            this.newProfile.Size = new System.Drawing.Size(141, 30);
            this.newProfile.Text = "New";
            this.newProfile.Click += new System.EventHandler(this.newProfile_Click);
            // 
            // openProfile
            // 
            this.openProfile.Name = "openProfile";
            this.openProfile.Size = new System.Drawing.Size(141, 30);
            this.openProfile.Text = "Open";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.aboutDeveloperToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.aboutDeveloperToolStripMenuItem.Text = "About Developer";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(231, 386);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(269, 98);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Change settings";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(277, 494);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(171, 20);
            this.lblFiles.TabIndex = 4;
            this.lblFiles.Text = "Files have been copied";
            this.lblFiles.Visible = false;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(260, 515);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(212, 20);
            this.lblSettings.TabIndex = 5;
            this.lblSettings.Text = "Settings have been changed";
            this.lblSettings.Visible = false;
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 546);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnOW);
            this.Controls.Add(this.btnWOW);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(760, 602);
            this.MinimumSize = new System.Drawing.Size(760, 602);
            this.Name = "formSettings";
            this.Text = "Choose which settings to load";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnWOW;
        private System.Windows.Forms.Button btnOW;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileMenu;
        private System.Windows.Forms.ToolStripMenuItem newProfile;
        private System.Windows.Forms.ToolStripMenuItem openProfile;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblSettings;
    }
}

