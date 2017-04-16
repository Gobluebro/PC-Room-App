using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Reflection;
using System.Diagnostics;
using System.Linq;

namespace PC_Room_App
{
    public partial class FormSettings : Form
    {
        //the way to make dynamically created objects in c# and get them into an array like thing
        Dictionary<int, Profile> dictProfiles = new Dictionary<int, Profile>();
        int profileCounter = 0;
        Profile currentProfile = new Profile();
        List<string> testProgramFile = new List<string> { };
        string testProfileName = "";
        bool testPrefProf = false;
        string testWoWPath = "";
        string testAddonPath = "";
        string testBlizzAppPath = "";
        string testBlizzAppLang = "";
        string lastMovedAddonsTime = "";

        public FormSettings()
        {
            InitializeComponent();
        }

        #region On Form load
        private void LoadProfile()
        {
            
            //need to reset for reload
            profileCounter = 0;
            dictProfiles.Clear();

            string cachePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Cache.txt";
            if (File.Exists(cachePath))
            {
                string[] readText = File.ReadAllLines(cachePath);

                foreach (string lines in readText)
                {
                    //read the cache file, split the strings for testing where they are
                    if (lines != ";")
                    {
                        string[] splitString = lines.Split('=');

                        switch (splitString[0])
                        {
                            case "Last Moved Time":
                                lastMovedAddonsTime = splitString[1];
                                break;
                            case "Profile Name":
                                testProfileName = splitString[1];
                                break;
                            case "Preferred Profile":
                                int testBinBool = Int32.Parse(splitString[1]);
                                testPrefProf = testBinBool == 1 ? true : false;
                                break;
                            case "WoW Path":
                                testWoWPath = splitString[1];
                                break;
                            case "WoW Addons Path":
                                testAddonPath = splitString[1];
                                break;
                            case "Blizzard App Path":
                                testBlizzAppPath = splitString[1];
                                break;
                            case "Blizzard App Language":
                                testBlizzAppLang = splitString[1];
                                break;
                            case "Program Files":
                                testProgramFile.Add(splitString[1]);
                                break;
                        }
                    }
                    else
                    {
                        dictProfiles.Add(profileCounter, new Profile
                        {
                            ProfileName = testProfileName,
                            PreferredProfile = testPrefProf,
                            WoWPath = testWoWPath,
                            WoWAddonsPath = testAddonPath,
                            BlizzAppPath = testBlizzAppPath,
                            BlizzAppLanguage = testBlizzAppLang,
                            ProgramFiles = testProgramFile.ToArray()
                        });
                        if (dictProfiles[profileCounter].PreferredProfile)
                        {
                            currentProfile = dictProfiles[profileCounter];
                            openProfile.Text = "Current Profile: " + dictProfiles[profileCounter].ProfileName;
                        }
                        //needed to clear testProgramFile for sure, just clearing the rest anyway
                        testProfileName = "";
                        testPrefProf = false;
                        testWoWPath = "";
                        testAddonPath = "";
                        testBlizzAppPath = "";
                        testBlizzAppLang = "";
                        testProgramFile.Clear();
                        profileCounter++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Cache doesn't exist", "File Not Found");
            }
        }

        private void AddProfilesToMenu()
        {
            //adding the profiles to the menu so you can select which one you want
            int i;
            List<ToolStripMenuItem> listItems = new List<ToolStripMenuItem>();
            for (i = 0; i < profileCounter; i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem()
                {
                    Name = "profile" + i.ToString(),
                    Text = dictProfiles[i].ProfileName,
                    Tag = i
                };
                item.Click += new EventHandler(MenuItemClickHandler);
                listItems.Add(item);
            }
            ToolStripMenuItem[] stringItems = listItems.ToArray();
            openProfile.DropDownItems.Clear();
            openProfile.DropDownItems.AddRange(stringItems);
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            //not sure if this is the correct way to do this, first time I've done it and seems to work
            //gets everything from the item you clicked. that way I can know what they clicked since it's created dynamically 
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int currentProfileNumber = Convert.ToInt32(clickedItem.Tag);
            currentProfile = dictProfiles[currentProfileNumber];
            openProfile.Text = "Current Profile: " + currentProfile.ProfileName;
        }

        private void RefreshForm()
        {
            bool existingProfile = File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Cache.txt");
            if (existingProfile)
            {
                LoadProfile();
                AddProfilesToMenu();
            }
            else
            {
                MessageBox.Show("Please Create a Profile", "No Existing Profile.");
                Hide();
                using (FormNewProfile formCreateProfile = new FormNewProfile())
                {
                    formCreateProfile.ShowDialog();
                }
                Show();
                LoadProfile();
                AddProfilesToMenu();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
        #endregion

        private void LaunchBattleNetApp()
        {
            string args = "";
            //only support two languages currently TODO: more languages
            if (currentProfile.BlizzAppLanguage == "English")
            {
                //en = english US = USA
                args = " --setlanguage=enUS";
            }
            else if (currentProfile.BlizzAppLanguage == "한국어")
            {
                //ko = korean kr = korea
                //kind of irrelevant since korean PCrooms would just have korean as the standard anyway
                args = " --setlanguage=koKR";
            }

            // Use ProcessStartInfo class.
            ProcessStartInfo startBlizzApp = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = @"C:\Program Files (x86)\Battle.net\Battle.net.exe",
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = args
            };
            try
            {
                Process.Start(startBlizzApp);
            }
            catch
            {
                MessageBox.Show("Blizzard App couldn't be started.");
            }
        }

        private void BtnChangeSettings_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(currentProfile.ProfileName)))
            {
                if (string.IsNullOrEmpty(currentProfile.WoWPath) == false && string.IsNullOrEmpty(currentProfile.WoWAddonsPath) == false)
                {
                    //taken from visualbasic because it's so good
                    //if you wanted to give people the option of overriding or not through windows use UIOption.AllDialogs instead of true
                    FileSystem.CopyDirectory(currentProfile.WoWAddonsPath, currentProfile.WoWPath, true);
                    //TODO: look into fading in and out(timers)
                    lblConfirmation.Text = "Addons -> WoW" + Environment.NewLine + "Files have been copied";
                    lblConfirmation.Visible = true;
                    lastMovedAddonsTime = DateTime.Now.ToString();
                }

                //only launch it if blizz app is not open already
                Process[] blizzApp = Process.GetProcessesByName("battle.net");
                if (blizzApp.Length == 0)
                {
                    LaunchBattleNetApp();
                }
                if (!(currentProfile.ProgramFiles[0] == ""))
                {
                    for (int i = 0; i < currentProfile.ProgramFiles.Length; i++)
                    {
                        try
                        {
                            using (Process exeProcess = Process.Start(currentProfile.ProgramFiles[i]))
                            {
                                exeProcess.WaitForExit();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("An error occured when trying to run " + currentProfile.ProgramFiles[i].Split('\\').Last() + ".");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Profile is currently selected", "No Profile Error");
            }
        }

        private void BtnSaveAddons_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(currentProfile.ProfileName)))
            {
                if (string.IsNullOrEmpty(currentProfile.WoWPath) == false && string.IsNullOrEmpty(currentProfile.WoWAddonsPath) == false && string.IsNullOrEmpty(lastMovedAddonsTime) == false)
                {
                    try
                    {
                        //have to create my own message box if want better message box formating
                        DialogResult dialogResult = MessageBox.Show("The last time you saved was " +
                            lastMovedAddonsTime + "." +
                            Environment.NewLine +
                            "If you did not push the Change Settings button during your session then you may have some issues." +
                            Environment.NewLine +
                            "A backup of your addons is recommended",
                        "Are you sure want to override your Addons? ", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            FileSystem.CopyDirectory(currentProfile.WoWPath + @"\WTF", currentProfile.WoWAddonsPath + @"\WTF", true);
                            FileSystem.CopyDirectory(currentProfile.WoWPath + @"\Interface", currentProfile.WoWAddonsPath + @"\Interface", true);
                            lblConfirmation.Text = "WoW -> Addons" + Environment.NewLine + "Files have been copied";
                            lblConfirmation.Visible = true;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("WoW folder was set improperly or Addons were never moved", "Error when trasfering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Profile is currently selected", "No Profile Error");
            }
        }

        private void NewProfile_Click(object sender, EventArgs e)
        {
            Hide();
            using (FormNewProfile formCreateProfile = new FormNewProfile())
            {
                formCreateProfile.ShowDialog();
            }
            Show();
            RefreshForm();
        }

        private void FAQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFAQ newFormFAQ = new FormFAQ()
            {
                //center the new form in the middle of the old one
                StartPosition = FormStartPosition.CenterParent
            };
            newFormFAQ.ShowDialog();
        }

        private void AboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutDev newFormAboutDev = new FormAboutDev()
            {
                //center the new form in the middle of the old one
                StartPosition = FormStartPosition.CenterParent
            };
            newFormAboutDev.ShowDialog();
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("Cache.txt"))
            {
                string[] lines = File.ReadAllLines("Cache.txt");
                using (StreamWriter replacer = new StreamWriter("Cache.txt"))
                {
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (i == 0)
                        {
                            lines[0] = "Last Moved Time=" + lastMovedAddonsTime.ToString();
                            replacer.WriteLine(lines[0]);
                        }
                        else
                        {
                            replacer.WriteLine(lines[i]);
                        }
                    }
                }
            }
            Application.Exit();
        }
    }
}
