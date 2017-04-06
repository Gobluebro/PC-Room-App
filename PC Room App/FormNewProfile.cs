using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace PC_Room_App
{
    public partial class FormNewProfile : Form
    {
        string[] programFiles = new string[] { };
        #region multiple calls methods
        private void FormChange()
        {
            Close();
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

        public FormNewProfile()
        {
            InitializeComponent();
        }

        private bool CacheExists()
        {
            return File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Cache.txt");
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
                lblShowError.Text = "Please fill in a Profille Name";
                lblShowError.Visible = true;
            }
            else if (!chkWOW.Checked && !chkBlizzApp.Checked && !chkProgramFile.Checked)
            {
                //because what's the point of just saving a profile with only a name
                lblShowError.Text = "Please check at least one checkbox";
                lblShowError.Visible = true;
            }
            else if (chkWOW.Checked && (txtWoWPath.Text == "" || txtAddonsPath.Text == ""))
            {
                //error checking if boxes are filled in for WoW
                //hide the checkbox error since we obviously have a boxed checked
                lblShowError.Text = "Please fillout everything for World of Warcraft section";
                lblShowError.Visible = true;
            }
            else if (chkBlizzApp.Checked && (txtBlizzAppPath.Text == "" || cbnBlizzAppLang.Text == ""))
            {
                //error checking if boxes are filled in for blizzard app
                //hide the checkbox error since we obviously have a boxed checked
                lblShowError.Text = "Please fillout everything for Blizzard App section";
                lblShowError.Visible = true;
            }
            else if (chkProgramFile.Checked && txtProgramFileLocation.Text == "")
            {
                //error checking if boxes are filled in for programs to run
                //hide the checkbox error since we obviously have a boxed checked
                lblShowError.Text = "Please select a program";
                lblShowError.Visible = true;
            }
            #endregion
            else
            {
                string temp = "";
                lblShowError.Visible = false;
                
                //check if cache exists, then in the cache look if I have a prefferred profile
                if (CacheExists() && chkPrefProf.Checked)
                {
                    string[] lines = File.ReadAllLines("Cache.txt");
                    using (StreamWriter replacer = new StreamWriter("Cache.txt"))
                    {
                        for(int i = 0; i< lines.Length; i++)
                        {
                            if (lines[i] == "Preferred Profile=1")
                            {
                                DialogResult dialogResult = MessageBox.Show("Do you want this profile to be preferred over \"" + lines[i - 1].Split('=')[1] + "\"?",
                                    "Another Preferred Profile Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    replacer.WriteLine("Preferred Profile=0");
                                }
                            }
                            else
                            {
                                replacer.WriteLine(lines[i]);
                            } 
                        }
                    }
                }

                if (!(CacheExists()))
                {
                    temp = "Last Moved Time=";
                }

                //the opens the cache file and the bool allows me to append to the file (false would be to overwrite)
                //in the case of the first time creates the file, in the case of the second time it appends (thank you whoever wrote this nice constructor)
                using (StreamWriter writer = new StreamWriter("Cache.txt",true))
                {
                    if (!(string.IsNullOrEmpty(temp)))
                    {
                        writer.WriteLine(temp);
                    }
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
                        writer.WriteLine("WoW Path=");
                        writer.WriteLine("WoW Addons Path=");
                    }
                    if (chkBlizzApp.Checked)
                    {
                        writer.WriteLine("Blizzard App Path=" + txtBlizzAppPath.Text);
                        writer.WriteLine("Blizzard App Language=" + cbnBlizzAppLang.Text);
                    }
                    else
                    {
                        writer.WriteLine("Blizzard App Path=");
                        writer.WriteLine("Blizzard App Language=");
                    }
                    if (chkProgramFile.Checked)
                    {
                        for (int i = 0; i < programFiles.Length; i++)
                        {
                            writer.WriteLine("Program Files=" + programFiles[i]);
                        }
                        
                    }
                    else
                    {
                        writer.WriteLine("Program Files=");
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
        private void BtnBrowseProgramFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executables (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Program File Browser";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                programFiles = openFileDialog1.FileNames;
                for(int i = 0; i< programFiles.Length; i++)
                {
                    string temp = "";
                    if(i == 0)
                    {
                        temp = programFiles[i].Split('\\').Last();
                    }
                    else
                    {
                        temp = Environment.NewLine + programFiles[i].Split('\\').Last();
                    }
                    txtProgramFileLocation.AppendText(temp);
                }
            }
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

        private void ChkProgramFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProgramFile.Checked)
            {
                grpboxProgram.Visible = true;
            }
            else
            {
                grpboxProgram.Visible = false;
            }
        }

        private void FormNewProfile_Load(object sender, EventArgs e)
        {
            //profile will always be preferred if it's the only one 
            if (CacheExists())
            {
                chkPrefProf.Checked = false;
                chkPrefProf.Enabled = true;
            }
            else
            {
                chkPrefProf.Checked = true;
                chkPrefProf.Enabled = false;
            }
        }
    }
}
