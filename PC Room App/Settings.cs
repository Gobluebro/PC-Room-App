using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace PC_Room_App
{
    public partial class formSettings : Form
    {
        bool checkedWoW = false;
        bool checkedOW = false;
        public formSettings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            bool noProfile = true;
            if (noProfile)
            {
                openProfile.Text = "No Profile";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (checkedWoW)
            {
                string sourceDirName = @"C:\Users\Gobluebro\Downloads\Addons\";
                string destDirName = @"C:\Users\Gobluebro\Downloads\WoW"; 
                //if you wanted to give people the option of overriding or not through windows use UIOption.AllDialogs instead of true
                FileSystem.CopyDirectory(sourceDirName, destDirName, true);
                //TODO: look into fading in and out(timers)
                lblFiles.Visible = true;
            }
            if (checkedOW)
            {
                //TODO change OW settings
            }
        }

        #region button clicks
        private void newProfile_Click(object sender, EventArgs e)
        {
            formCreateNewProfile formCreateProfile = new formCreateNewProfile();
            formCreateProfile.Show();
            Visible = false;
        }

        //buttons function like checkboxs but I like the size of buttons better than regular checkboxes.
        //though I never checked if I could make checkboxes with images. oh well
        private void btnWOW_Click(object sender, EventArgs e)
        {
            if (!checkedWoW)
            {
                checkedWoW = true;
                btnWOW.BackColor = Color.Black;
            }
            else
            {
                checkedWoW = false;
                btnWOW.BackColor = Color.White;
            }
        }

        private void btnOW_Click(object sender, EventArgs e)
        {
            if (!checkedOW)
            {
                checkedOW = true;
                btnOW.BackColor = Color.Black;
            }
            else
            {
                checkedOW = false;
                btnOW.BackColor = Color.White;
            }
        }
        #endregion
    }
}
