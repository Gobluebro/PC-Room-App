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

namespace PC_Room_App
{
    public partial class formNewProfile : Form
    {
        #region multiple calls methods
        private void FormChange()
        {
            formSettings frm = new formSettings();
            frm.Show();
            Visible = false;
        }
        private void FolderLocate(string location)
        {
            if (location == "WoW")
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtWoWLoc.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else if(location == "AddOn")
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtAddons.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else 
            {
                //location should be "OW"
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtOWLoc.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }
        #endregion

        public formNewProfile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormChange();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region error checking
            if (txtProfileName.Text == "")
            {
                //pretty skeptical on only this because users could just write spaces
                lblNameError.Visible = true;
            }
            else if (!chkWOW.Checked && !chkOW.Checked)
            {
                //because what's the point of just saving a profile with only a name
                lblChkboxError.Visible = true;
            }
            else if (chkWOW.Checked && (txtWoWLoc.Text == "" || txtAddons.Text == ""))
            {
                //error checking if boxes are filled in for WoW
                //hide the checkbox error since we obviously have a boxed checked
                lblChkboxError.Visible = false;
                lblWoWError.Visible = true;
            }
            else if (chkOW.Checked && (txtOWLoc.Text == "" || cbnOWLang.SelectedText == ""))
            {
                //error checking if boxes are filled in for overwatch
                //hide the checkbox error since we obviously have a boxed checked
                lblChkboxError.Visible = false;
                lblOWError.Visible = true;
            }
            #endregion
            else
            {
                //since no errors create the profile
                //Profile createdNewProfile = new Profile();
                //createdNewProfile.profileName = txtProfileName.Text;
                //TODO: Save profile to file

                //the opens the cache file and the bool allows me to append to the file (false would be to overwrite)
                //in the case of the first time creates the file, in the case of the second time it appends (thank you whoever wrote this nice constructor)
                using (StreamWriter writer = new StreamWriter("Cache.txt",true))
                {
                    writer.WriteLine("Profile Name: " + txtProfileName.Text);
                    if (chkWOW.Checked)
                    {
                        //createdNewProfile.WoWLocation = txtWoWLoc.Text;
                        //createdNewProfile.WoWAddonsLocation = txtAddons.Text;
                        writer.WriteLine("WoW Location: " + txtWoWLoc.Text);
                        writer.WriteLine("WoW Addons Location: " + txtAddons.Text);
                    }
                    if (chkOW.Checked)
                    {
                        //createdNewProfile.OWLocation = txtOWLoc.Text;
                        //createdNewProfile.OWLanguage = cbnOWLang.SelectedText;
                        writer.WriteLine("Overwatch Location: " + txtOWLoc.Text);
                        writer.WriteLine("Overwatch Language: " + cbnOWLang.Text);
                    }
                    writer.WriteLine(";");
                }
                
            }

            FormChange();
        }

        #region file system browse calls
        private void btnBrowseWoW_Click(object sender, EventArgs e)
        {
            FolderLocate("WoW");
        }
        private void btnWOWAddonsLoc_Click(object sender, EventArgs e)
        {
            FolderLocate("AddOn");
        }
        private void btnBrowseOW_Click(object sender, EventArgs e)
        {
            FolderLocate("OW");
        }
        #endregion

        private void chkWOW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWOW.Checked)
            {
                grpboxWOW.Visible = true;
            }
            else
            {
                grpboxWOW.Visible = false;
            }
        }

        private void chkOW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOW.Checked)
            {
                grpboxOW.Visible = true;
            }
            else
            {
                grpboxOW.Visible = false;
            }
        }

        private void formNewProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
