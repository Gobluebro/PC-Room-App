using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Room_App
{
    public partial class formCreateNewProfile : Form
    {
        #region multiple calls methods
        private void FormChange()
        {
            FormSettings frmSettings = new FormSettings();
            frmSettings.Show();
            Visible = false;
        }
        private void FolderLocate(string location)
        {
            if (location == "WoW")
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtWoWPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else if(location == "AddOn")
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtAddonsPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            else 
            {
                //location should be "Blizz"
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtBlizzAppPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }
        #endregion

        public formCreateNewProfile()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            FormChange();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            #region error checking
            if (txtProfileName.Text == "")
            {
                //pretty skeptical on only this because users could just write spaces
                lblNameError.Visible = true;
            }
            else if (!chkWOW.Checked && !chkBlizzApp.Checked)
            {
                //because what's the point of just saving a profile with only a name
                lblChkboxError.Visible = true;
            }
            else if (chkWOW.Checked && (txtWoWPath.Text == "" || txtAddonsPath.Text == ""))
            {
                //error checking if boxes are filled in for WoW
                //hide the checkbox error since we obviously have a boxed checked
                lblChkboxError.Visible = false;
                lblWoWError.Visible = true;
            }
            else if (chkBlizzApp.Checked && (txtBlizzAppPath.Text == "" || cbnBlizzAppLang.Text == ""))
            {
                //error checking if boxes are filled in for overwatch
                //hide the checkbox error since we obviously have a boxed checked
                lblChkboxError.Visible = false;
                lblBlizzAppError.Visible = true;
            }
            #endregion
            else
            {
                //originally wanted to save this to a new profile but I won't use it so it's not needed.

                //the opens the cache file and the bool allows me to append to the file (false would be to overwrite)
                //in the case of the first time creates the file, in the case of the second time it appends (thank you whoever wrote this nice constructor)
                using (StreamWriter writer = new StreamWriter("Cache.txt",true))
                {
                    writer.WriteLine("Profile Name=" + txtProfileName.Text);
                    if (chkPrefProf.Checked)
                    {
                        writer.WriteLine("Preferred Profile=1");
                    }
                    else
                    {
                        writer.WriteLine("Preferred Profile=0");
                    }
                    if (chkWOW.Checked)
                    {
                        writer.WriteLine("WoW Path=" + txtWoWPath.Text);
                        writer.WriteLine("WoW Addons Path=" + txtAddonsPath.Text);
                    }
                    else
                    {
                        writer.WriteLine("WoW Path= ");
                        writer.WriteLine("WoW Addons Path= ");
                    }
                    if (chkBlizzApp.Checked)
                    {
                        writer.WriteLine("Blizzard App Path=" + txtBlizzAppPath.Text);
                        writer.WriteLine("Blizzard App Language=" + cbnBlizzAppLang.Text);
                    }
                    else
                    {
                        writer.WriteLine("Blizzard App Path= ");
                        writer.WriteLine("Blizzard App Language= ");
                    }
                    writer.WriteLine(";");
                }
                FormChange();
            }
        }

        #region file system browse calls
        private void BtnBrowseWoW_Click(object sender, EventArgs e)
        {
            FolderLocate("WoW");
        }
        private void BtnWOWAddonsLoc_Click(object sender, EventArgs e)
        {
            FolderLocate("AddOn");
        }
        private void BtnBrowseOW_Click(object sender, EventArgs e)
        {
            FolderLocate("Blizz");
        }
        #endregion

        private void ChkWOW_CheckedChanged(object sender, EventArgs e)
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

        private void ChkBlizzApp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlizzApp.Checked)
            {
                grpboxBlizzApp.Visible = true;
            }
            else
            {
                grpboxBlizzApp.Visible = false;
            }
        }

        private void FormCreateNewProfile_Load(object sender, EventArgs e)
        {
            //if cache file doesn't exist.
            if (!(File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Cache.txt"))){
                chkPrefProf.Checked = true;
                chkPrefProf.Enabled = false;
            }
        }
    }
}
