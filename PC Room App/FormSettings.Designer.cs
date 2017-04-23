namespace PC_Room_App
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangeSettings = new System.Windows.Forms.Button();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAddons = new System.Windows.Forms.Button();
            this.backgroundWorkerAddonsToWoW = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerWoWToAddons = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(578, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileMenu
            // 
            this.profileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfile,
            this.editToolStripMenuItem,
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
            this.newProfile.Click += new System.EventHandler(this.NewProfile_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 30);
            this.editToolStripMenuItem.Text = "Edit";
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
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.FAQToolStripMenuItem_Click);
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(233, 30);
            this.aboutDeveloperToolStripMenuItem.Text = "About Developer";
            this.aboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.AboutDeveloperToolStripMenuItem_Click);
            // 
            // btnChangeSettings
            // 
            this.btnChangeSettings.Location = new System.Drawing.Point(12, 206);
            this.btnChangeSettings.Name = "btnChangeSettings";
            this.btnChangeSettings.Size = new System.Drawing.Size(269, 98);
            this.btnChangeSettings.TabIndex = 3;
            this.btnChangeSettings.Text = "Change Settings";
            this.btnChangeSettings.UseVisualStyleBackColor = true;
            this.btnChangeSettings.Click += new System.EventHandler(this.BtnChangeSettings_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(208, 348);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(171, 20);
            this.lblConfirmation.TabIndex = 4;
            this.lblConfirmation.Text = "Files have been copied";
            this.lblConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblConfirmation.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(147, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 82);
            this.label1.TabIndex = 6;
            this.label1.Text = "//TODO";
            // 
            // btnSaveAddons
            // 
            this.btnSaveAddons.Location = new System.Drawing.Point(297, 206);
            this.btnSaveAddons.Name = "btnSaveAddons";
            this.btnSaveAddons.Size = new System.Drawing.Size(269, 98);
            this.btnSaveAddons.TabIndex = 7;
            this.btnSaveAddons.Text = "Save WoW Addons";
            this.btnSaveAddons.UseVisualStyleBackColor = true;
            this.btnSaveAddons.Click += new System.EventHandler(this.BtnSaveAddons_Click);
            // 
            // backgroundWorkerAddonsToWoW
            // 
            this.backgroundWorkerAddonsToWoW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerAddonsToWoW_DoWork);
            this.backgroundWorkerAddonsToWoW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerAddonsToWoW_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(212, 310);
            this.progressBar1.MarqueeAnimationSpeed = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(167, 26);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // backgroundWorkerWoWToAddons
            // 
            this.backgroundWorkerWoWToAddons.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerWoWToAddons_DoWork);
            this.backgroundWorkerWoWToAddons.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerWoWToAddons_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // FormSettings
            // 
            this.AcceptButton = this.btnChangeSettings;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSaveAddons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.btnChangeSettings);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose which settings to load";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
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
        private System.Windows.Forms.Button btnChangeSettings;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveAddons;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAddonsToWoW;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWoWToAddons;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

