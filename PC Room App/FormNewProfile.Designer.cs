namespace PC_Room_App
{
    partial class FormNewProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewProfile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtWoWPath = new System.Windows.Forms.TextBox();
            this.txtBlizzAppPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBrowseWoW = new System.Windows.Forms.Button();
            this.btnBrowseBlizzApp = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkWOW = new System.Windows.Forms.CheckBox();
            this.chkBlizzApp = new System.Windows.Forms.CheckBox();
            this.grpboxWOW = new System.Windows.Forms.GroupBox();
            this.btnWOWAddonsLoc = new System.Windows.Forms.Button();
            this.txtAddonsPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpboxBlizzApp = new System.Windows.Forms.GroupBox();
            this.cbnBlizzAppLang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShowError = new System.Windows.Forms.Label();
            this.chkPrefProf = new System.Windows.Forms.CheckBox();
            this.grpboxProgram = new System.Windows.Forms.GroupBox();
            this.btnBrowseProgramFile = new System.Windows.Forms.Button();
            this.txtProgramFileLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkProgramFile = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.grpboxWOW.SuspendLayout();
            this.grpboxBlizzApp.SuspendLayout();
            this.grpboxProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 25);
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
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blizzard App Path:";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(312, 25);
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
            // txtBlizzAppPath
            // 
            this.txtBlizzAppPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBlizzAppPath.Location = new System.Drawing.Point(239, 22);
            this.txtBlizzAppPath.Name = "txtBlizzAppPath";
            this.txtBlizzAppPath.ReadOnly = true;
            this.txtBlizzAppPath.Size = new System.Drawing.Size(279, 26);
            this.txtBlizzAppPath.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 86);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(417, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 86);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.btnBrowseWoW.Click += new System.EventHandler(this.BtnBrowseWoW_Click);
            // 
            // btnBrowseBlizzApp
            // 
            this.btnBrowseBlizzApp.Location = new System.Drawing.Point(524, 19);
            this.btnBrowseBlizzApp.Name = "btnBrowseBlizzApp";
            this.btnBrowseBlizzApp.Size = new System.Drawing.Size(41, 35);
            this.btnBrowseBlizzApp.TabIndex = 9;
            this.btnBrowseBlizzApp.Text = "...";
            this.btnBrowseBlizzApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseBlizzApp.UseVisualStyleBackColor = true;
            this.btnBrowseBlizzApp.Click += new System.EventHandler(this.BtnBrowseOW_Click);
            // 
            // chkWOW
            // 
            this.chkWOW.AutoSize = true;
            this.chkWOW.Location = new System.Drawing.Point(192, 62);
            this.chkWOW.Name = "chkWOW";
            this.chkWOW.Size = new System.Drawing.Size(159, 24);
            this.chkWOW.TabIndex = 10;
            this.chkWOW.Text = "World of Warcraft";
            this.chkWOW.UseVisualStyleBackColor = true;
            this.chkWOW.CheckedChanged += new System.EventHandler(this.ChkWOW_CheckedChanged);
            // 
            // chkBlizzApp
            // 
            this.chkBlizzApp.AutoSize = true;
            this.chkBlizzApp.Location = new System.Drawing.Point(357, 62);
            this.chkBlizzApp.Name = "chkBlizzApp";
            this.chkBlizzApp.Size = new System.Drawing.Size(124, 24);
            this.chkBlizzApp.TabIndex = 11;
            this.chkBlizzApp.Text = "Blizzard App";
            this.chkBlizzApp.UseVisualStyleBackColor = true;
            this.chkBlizzApp.CheckedChanged += new System.EventHandler(this.ChkBlizzApp_CheckedChanged);
            // 
            // grpboxWOW
            // 
            this.grpboxWOW.Controls.Add(this.btnWOWAddonsLoc);
            this.grpboxWOW.Controls.Add(this.txtAddonsPath);
            this.grpboxWOW.Controls.Add(this.label4);
            this.grpboxWOW.Controls.Add(this.label2);
            this.grpboxWOW.Controls.Add(this.txtWoWPath);
            this.grpboxWOW.Controls.Add(this.btnBrowseWoW);
            this.grpboxWOW.Location = new System.Drawing.Point(50, 91);
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
            this.btnWOWAddonsLoc.Click += new System.EventHandler(this.BtnWOWAddonsLoc_Click);
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
            // grpboxBlizzApp
            // 
            this.grpboxBlizzApp.Controls.Add(this.cbnBlizzAppLang);
            this.grpboxBlizzApp.Controls.Add(this.label5);
            this.grpboxBlizzApp.Controls.Add(this.btnBrowseBlizzApp);
            this.grpboxBlizzApp.Controls.Add(this.txtBlizzAppPath);
            this.grpboxBlizzApp.Controls.Add(this.label3);
            this.grpboxBlizzApp.Location = new System.Drawing.Point(51, 197);
            this.grpboxBlizzApp.Name = "grpboxBlizzApp";
            this.grpboxBlizzApp.Size = new System.Drawing.Size(575, 97);
            this.grpboxBlizzApp.TabIndex = 13;
            this.grpboxBlizzApp.TabStop = false;
            this.grpboxBlizzApp.Text = "Blizzard App Information";
            this.grpboxBlizzApp.Visible = false;
            // 
            // cbnBlizzAppLang
            // 
            this.cbnBlizzAppLang.FormattingEnabled = true;
            this.cbnBlizzAppLang.Items.AddRange(new object[] {
            "English",
            "한국어"});
            this.cbnBlizzAppLang.Location = new System.Drawing.Point(239, 54);
            this.cbnBlizzAppLang.Name = "cbnBlizzAppLang";
            this.cbnBlizzAppLang.Size = new System.Drawing.Size(279, 28);
            this.cbnBlizzAppLang.TabIndex = 11;
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
            // lblShowError
            // 
            this.lblShowError.AutoSize = true;
            this.lblShowError.ForeColor = System.Drawing.Color.Red;
            this.lblShowError.Location = new System.Drawing.Point(188, 380);
            this.lblShowError.Name = "lblShowError";
            this.lblShowError.Size = new System.Drawing.Size(261, 20);
            this.lblShowError.TabIndex = 15;
            this.lblShowError.Text = "Please check at least one checkbox";
            this.lblShowError.Visible = false;
            // 
            // chkPrefProf
            // 
            this.chkPrefProf.AutoSize = true;
            this.chkPrefProf.Location = new System.Drawing.Point(33, 62);
            this.chkPrefProf.Name = "chkPrefProf";
            this.chkPrefProf.Size = new System.Drawing.Size(149, 24);
            this.chkPrefProf.TabIndex = 16;
            this.chkPrefProf.Text = "Preferred Profile";
            this.chkPrefProf.UseVisualStyleBackColor = true;
            // 
            // grpboxProgram
            // 
            this.grpboxProgram.Controls.Add(this.label7);
            this.grpboxProgram.Controls.Add(this.btnBrowseProgramFile);
            this.grpboxProgram.Controls.Add(this.txtProgramFileLocation);
            this.grpboxProgram.Controls.Add(this.label6);
            this.grpboxProgram.Location = new System.Drawing.Point(51, 296);
            this.grpboxProgram.Name = "grpboxProgram";
            this.grpboxProgram.Size = new System.Drawing.Size(575, 81);
            this.grpboxProgram.TabIndex = 17;
            this.grpboxProgram.TabStop = false;
            this.grpboxProgram.Text = "Programs to Run";
            this.grpboxProgram.Visible = false;
            // 
            // btnBrowseProgramFile
            // 
            this.btnBrowseProgramFile.Location = new System.Drawing.Point(524, 26);
            this.btnBrowseProgramFile.Name = "btnBrowseProgramFile";
            this.btnBrowseProgramFile.Size = new System.Drawing.Size(41, 35);
            this.btnBrowseProgramFile.TabIndex = 10;
            this.btnBrowseProgramFile.Text = "...";
            this.btnBrowseProgramFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseProgramFile.UseVisualStyleBackColor = true;
            this.btnBrowseProgramFile.Click += new System.EventHandler(this.BtnBrowseProgramFile_Click);
            // 
            // txtProgramFileLocation
            // 
            this.txtProgramFileLocation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProgramFileLocation.Location = new System.Drawing.Point(238, 22);
            this.txtProgramFileLocation.Multiline = true;
            this.txtProgramFileLocation.Name = "txtProgramFileLocation";
            this.txtProgramFileLocation.ReadOnly = true;
            this.txtProgramFileLocation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProgramFileLocation.Size = new System.Drawing.Size(280, 42);
            this.txtProgramFileLocation.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Program File Location: ";
            // 
            // chkProgramFile
            // 
            this.chkProgramFile.AutoSize = true;
            this.chkProgramFile.Location = new System.Drawing.Point(488, 62);
            this.chkProgramFile.Name = "chkProgramFile";
            this.chkProgramFile.Size = new System.Drawing.Size(155, 24);
            this.chkProgramFile.TabIndex = 18;
            this.chkProgramFile.Text = "Programs to Run";
            this.chkProgramFile.UseVisualStyleBackColor = true;
            this.chkProgramFile.CheckedChanged += new System.EventHandler(this.ChkProgramFile_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(44, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "**Can Select More Than One";
            // 
            // FormNewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 544);
            this.Controls.Add(this.chkProgramFile);
            this.Controls.Add(this.grpboxProgram);
            this.Controls.Add(this.chkPrefProf);
            this.Controls.Add(this.lblShowError);
            this.Controls.Add(this.grpboxBlizzApp);
            this.Controls.Add(this.grpboxWOW);
            this.Controls.Add(this.chkBlizzApp);
            this.Controls.Add(this.chkWOW);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProfileName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNewProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a New Profile";
            this.Load += new System.EventHandler(this.FormNewProfile_Load);
            this.grpboxWOW.ResumeLayout(false);
            this.grpboxWOW.PerformLayout();
            this.grpboxBlizzApp.ResumeLayout(false);
            this.grpboxBlizzApp.PerformLayout();
            this.grpboxProgram.ResumeLayout(false);
            this.grpboxProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.TextBox txtWoWPath;
        private System.Windows.Forms.TextBox txtBlizzAppPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBrowseWoW;
        private System.Windows.Forms.Button btnBrowseBlizzApp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkWOW;
        private System.Windows.Forms.CheckBox chkBlizzApp;
        private System.Windows.Forms.GroupBox grpboxWOW;
        private System.Windows.Forms.GroupBox grpboxBlizzApp;
        private System.Windows.Forms.Button btnWOWAddonsLoc;
        private System.Windows.Forms.TextBox txtAddonsPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbnBlizzAppLang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblShowError;
        private System.Windows.Forms.CheckBox chkPrefProf;
        private System.Windows.Forms.GroupBox grpboxProgram;
        private System.Windows.Forms.Button btnBrowseProgramFile;
        private System.Windows.Forms.TextBox txtProgramFileLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkProgramFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
    }
}