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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.newProfile.Size = new System.Drawing.Size(211, 30);
            this.newProfile.Text = "New";
            this.newProfile.Click += new System.EventHandler(this.newProfile_Click);
            // 
            // openProfile
            // 
            this.openProfile.Name = "openProfile";
            this.openProfile.Size = new System.Drawing.Size(211, 30);
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
            this.btnEnter.Location = new System.Drawing.Point(235, 240);
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
            this.lblFiles.Location = new System.Drawing.Point(266, 388);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(171, 20);
            this.lblFiles.TabIndex = 4;
            this.lblFiles.Text = "Files have been copied";
            this.lblFiles.Visible = false;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(249, 409);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(212, 20);
            this.lblSettings.TabIndex = 5;
            this.lblSettings.Text = "Settings have been changed";
            this.lblSettings.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(221, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 82);
            this.label1.TabIndex = 6;
            this.label1.Text = "//TODO";
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.btnEnter);
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
        private System.Windows.Forms.Label label1;
    }
}

