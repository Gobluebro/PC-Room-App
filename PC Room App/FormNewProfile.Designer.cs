namespace PC_Room_App
{
    partial class formCreateNewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCreateNewProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtWoWPath = new System.Windows.Forms.TextBox();
            this.txtBNAppPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrowseWoW = new System.Windows.Forms.Button();
            this.btnBrowseOW = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkWOW = new System.Windows.Forms.CheckBox();
            this.chkBnetApp = new System.Windows.Forms.CheckBox();
            this.grpboxWOW = new System.Windows.Forms.GroupBox();
            this.btnWOWAddonsLoc = new System.Windows.Forms.Button();
            this.txtAddonsPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpboxOW = new System.Windows.Forms.GroupBox();
            this.cbnOWLang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOWError = new System.Windows.Forms.Label();
            this.lblWoWError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblChkboxError = new System.Windows.Forms.Label();
            this.chkPrefProf = new System.Windows.Forms.CheckBox();
            this.grpboxWOW.SuspendLayout();
            this.grpboxOW.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "World of Warcraft Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Battle.net App Path:";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(273, 25);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(279, 26);
            this.txtProfileName.TabIndex = 3;
            // 
            // txtWoWPath
            // 
            this.txtWoWPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWoWPath.Location = new System.Drawing.Point(239, 25);
            this.txtWoWPath.Name = "txtWoWPath";
            this.txtWoWPath.ReadOnly = true;
            this.txtWoWPath.Size = new System.Drawing.Size(279, 26);
            this.txtWoWPath.TabIndex = 4;
            // 
            // txtBNAppPath
            // 
            this.txtBNAppPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBNAppPath.Location = new System.Drawing.Point(239, 22);
            this.txtBNAppPath.Name = "txtBNAppPath";
            this.txtBNAppPath.ReadOnly = true;
            this.txtBNAppPath.Size = new System.Drawing.Size(279, 26);
            this.txtBNAppPath.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 86);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(373, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 86);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBrowseWoW
            // 
            this.btnBrowseWoW.Location = new System.Drawing.Point(524, 17);
            this.btnBrowseWoW.Name = "btnBrowseWoW";
            this.btnBrowseWoW.Size = new System.Drawing.Size(41, 34);
            this.btnBrowseWoW.TabIndex = 8;
            this.btnBrowseWoW.Text = "...";
            this.btnBrowseWoW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseWoW.UseVisualStyleBackColor = true;
            this.btnBrowseWoW.Click += new System.EventHandler(this.btnBrowseWoW_Click);
            // 
            // btnBrowseOW
            // 
            this.btnBrowseOW.Location = new System.Drawing.Point(524, 19);
            this.btnBrowseOW.Name = "btnBrowseOW";
            this.btnBrowseOW.Size = new System.Drawing.Size(41, 35);
            this.btnBrowseOW.TabIndex = 9;
            this.btnBrowseOW.Text = "...";
            this.btnBrowseOW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseOW.UseVisualStyleBackColor = true;
            this.btnBrowseOW.Click += new System.EventHandler(this.btnBrowseOW_Click);
            // 
            // chkWOW
            // 
            this.chkWOW.AutoSize = true;
            this.chkWOW.Location = new System.Drawing.Point(273, 63);
            this.chkWOW.Name = "chkWOW";
            this.chkWOW.Size = new System.Drawing.Size(159, 24);
            this.chkWOW.TabIndex = 10;
            this.chkWOW.Text = "World of Warcraft";
            this.chkWOW.UseVisualStyleBackColor = true;
            this.chkWOW.CheckedChanged += new System.EventHandler(this.chkWOW_CheckedChanged);
            // 
            // chkBnetApp
            // 
            this.chkBnetApp.AutoSize = true;
            this.chkBnetApp.Location = new System.Drawing.Point(442, 63);
            this.chkBnetApp.Name = "chkBnetApp";
            this.chkBnetApp.Size = new System.Drawing.Size(139, 24);
            this.chkBnetApp.TabIndex = 11;
            this.chkBnetApp.Text = "Battle.Net App";
            this.chkBnetApp.UseVisualStyleBackColor = true;
            this.chkBnetApp.CheckedChanged += new System.EventHandler(this.chkBnetApp_CheckedChanged);
            // 
            // grpboxWOW
            // 
            this.grpboxWOW.Controls.Add(this.btnWOWAddonsLoc);
            this.grpboxWOW.Controls.Add(this.txtAddonsPath);
            this.grpboxWOW.Controls.Add(this.label4);
            this.grpboxWOW.Controls.Add(this.label2);
            this.grpboxWOW.Controls.Add(this.txtWoWPath);
            this.grpboxWOW.Controls.Add(this.btnBrowseWoW);
            this.grpboxWOW.Location = new System.Drawing.Point(11, 91);
            this.grpboxWOW.Name = "grpboxWOW";
            this.grpboxWOW.Size = new System.Drawing.Size(575, 100);
            this.grpboxWOW.TabIndex = 12;
            this.grpboxWOW.TabStop = false;
            this.grpboxWOW.Text = "WoW Information";
            this.grpboxWOW.Visible = false;
            // 
            // btnWOWAddonsLoc
            // 
            this.btnWOWAddonsLoc.Location = new System.Drawing.Point(524, 53);
            this.btnWOWAddonsLoc.Name = "btnWOWAddonsLoc";
            this.btnWOWAddonsLoc.Size = new System.Drawing.Size(41, 35);
            this.btnWOWAddonsLoc.TabIndex = 11;
            this.btnWOWAddonsLoc.Text = "...";
            this.btnWOWAddonsLoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWOWAddonsLoc.UseVisualStyleBackColor = true;
            this.btnWOWAddonsLoc.Click += new System.EventHandler(this.btnWOWAddonsLoc_Click);
            // 
            // txtAddonsPath
            // 
            this.txtAddonsPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAddonsPath.Location = new System.Drawing.Point(239, 57);
            this.txtAddonsPath.Name = "txtAddonsPath";
            this.txtAddonsPath.ReadOnly = true;
            this.txtAddonsPath.Size = new System.Drawing.Size(279, 26);
            this.txtAddonsPath.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Addons Path:";
            // 
            // grpboxOW
            // 
            this.grpboxOW.Controls.Add(this.cbnOWLang);
            this.grpboxOW.Controls.Add(this.label5);
            this.grpboxOW.Controls.Add(this.btnBrowseOW);
            this.grpboxOW.Controls.Add(this.txtBNAppPath);
            this.grpboxOW.Controls.Add(this.label3);
            this.grpboxOW.Location = new System.Drawing.Point(12, 197);
            this.grpboxOW.Name = "grpboxOW";
            this.grpboxOW.Size = new System.Drawing.Size(575, 97);
            this.grpboxOW.TabIndex = 13;
            this.grpboxOW.TabStop = false;
            this.grpboxOW.Text = "Battle.net App Information";
            this.grpboxOW.Visible = false;
            // 
            // cbnOWLang
            // 
            this.cbnOWLang.FormattingEnabled = true;
            this.cbnOWLang.Items.AddRange(new object[] {
            "English",
            "한국어"});
            this.cbnOWLang.Location = new System.Drawing.Point(239, 54);
            this.cbnOWLang.Name = "cbnOWLang";
            this.cbnOWLang.Size = new System.Drawing.Size(279, 28);
            this.cbnOWLang.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Language:";
            // 
            // lblOWError
            // 
            this.lblOWError.AutoSize = true;
            this.lblOWError.ForeColor = System.Drawing.Color.Red;
            this.lblOWError.Location = new System.Drawing.Point(156, 350);
            this.lblOWError.Name = "lblOWError";
            this.lblOWError.Size = new System.Drawing.Size(316, 20);
            this.lblOWError.TabIndex = 12;
            this.lblOWError.Text = "Please fill in every textbox for Battle.net App";
            this.lblOWError.Visible = false;
            // 
            // lblWoWError
            // 
            this.lblWoWError.AutoSize = true;
            this.lblWoWError.ForeColor = System.Drawing.Color.Red;
            this.lblWoWError.Location = new System.Drawing.Point(144, 326);
            this.lblWoWError.Name = "lblWoWError";
            this.lblWoWError.Size = new System.Drawing.Size(338, 20);
            this.lblWoWError.TabIndex = 13;
            this.lblWoWError.Text = "Please fill in every textbox for World of Warcraft";
            this.lblWoWError.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(206, 371);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(201, 20);
            this.lblNameError.TabIndex = 14;
            this.lblNameError.Text = "Please fill in a Profille Name";
            this.lblNameError.Visible = false;
            // 
            // lblChkboxError
            // 
            this.lblChkboxError.AutoSize = true;
            this.lblChkboxError.ForeColor = System.Drawing.Color.Red;
            this.lblChkboxError.Location = new System.Drawing.Point(187, 305);
            this.lblChkboxError.Name = "lblChkboxError";
            this.lblChkboxError.Size = new System.Drawing.Size(261, 20);
            this.lblChkboxError.TabIndex = 15;
            this.lblChkboxError.Text = "Please check at least one checkbox";
            this.lblChkboxError.Visible = false;
            // 
            // chkPrefProf
            // 
            this.chkPrefProf.AutoSize = true;
            this.chkPrefProf.Location = new System.Drawing.Point(34, 61);
            this.chkPrefProf.Name = "chkPrefProf";
            this.chkPrefProf.Size = new System.Drawing.Size(149, 24);
            this.chkPrefProf.TabIndex = 16;
            this.chkPrefProf.Text = "Preferred Profile";
            this.chkPrefProf.UseVisualStyleBackColor = true;
            // 
            // formCreateNewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 497);
            this.Controls.Add(this.chkPrefProf);
            this.Controls.Add(this.lblChkboxError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.lblOWError);
            this.Controls.Add(this.lblWoWError);
            this.Controls.Add(this.grpboxOW);
            this.Controls.Add(this.grpboxWOW);
            this.Controls.Add(this.chkBnetApp);
            this.Controls.Add(this.chkWOW);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(610, 553);
            this.MinimumSize = new System.Drawing.Size(610, 553);
            this.Name = "formCreateNewProfile";
            this.Text = "Create a New Profile";
            this.Load += new System.EventHandler(this.formCreateNewProfile_Load);
            this.grpboxWOW.ResumeLayout(false);
            this.grpboxWOW.PerformLayout();
            this.grpboxOW.ResumeLayout(false);
            this.grpboxOW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.TextBox txtWoWPath;
        private System.Windows.Forms.TextBox txtBNAppPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBrowseWoW;
        private System.Windows.Forms.Button btnBrowseOW;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkWOW;
        private System.Windows.Forms.CheckBox chkBnetApp;
        private System.Windows.Forms.GroupBox grpboxWOW;
        private System.Windows.Forms.GroupBox grpboxOW;
        private System.Windows.Forms.Button btnWOWAddonsLoc;
        private System.Windows.Forms.TextBox txtAddonsPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbnOWLang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOWError;
        private System.Windows.Forms.Label lblWoWError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblChkboxError;
        private System.Windows.Forms.CheckBox chkPrefProf;
    }
}