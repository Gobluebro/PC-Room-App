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
using System.Reflection;
using System.Diagnostics;

namespace PC_Room_App
{
    public partial class FormSettings : Form
    {
        //the way to make dynamically created objects in c# and get them into an array like thing
        Dictionary<int, Profile> dictProfiles = new Dictionary<int, Profile>();
        int profileCounter = 0;
        Profile currentProfile = new Profile();

        private void LoadProfile()
        {
            string cachePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Cache.txt";
            string[] readText = File.ReadAllLines(cachePath);

            string testProfileName = "";
            bool testPrefProf = false;
            string testWoWPath = "";
            string testAddonPath = "";
            string testBnetAppPath = "";
            string testBnetAppLang = "";

            foreach (string lines in readText)
            {
                //read the cache file, split the strings for testing where they are
                if (lines != ";")
                {
                    string[] splitString = lines.Split('=');

                    switch (splitString[0])
                    {
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
                        case "Battle.net App Path":
                            testBnetAppPath = splitString[1];
                            break;
                        case "Battle.net App Language":
                            testBnetAppLang = splitString[1];
                            break;
                    }
                }
                else
                {
                    dictProfiles.Add(profileCounter, new Profile {
                        profileName = testProfileName,
                        preferredProfile = testPrefProf,
                        WoWPath = testWoWPath,
                        WoWAddonsPath = testAddonPath,
                        BnetAppPath = testBnetAppPath,
                        BnetAppLanguage = testBnetAppLang
                    });
                    if (dictProfiles[profileCounter].preferredProfile)
                    {
                        currentProfile = dictProfiles[profileCounter];
                        openProfile.Text = dictProfiles[profileCounter].profileName;
                    }
                    profileCounter++;
                }
            }
        }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void AddProfilesToMenu()
        {
            //adding the profiles to the menu so you can select which one you want
            int i;
            List<ToolStripMenuItem> listItems = new List<ToolStripMenuItem>();
            for (i = 0; i < profileCounter; i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item = new ToolStripMenuItem();
                item.Name = "profile" + i.ToString();
                item.Text = dictProfiles[i].profileName;
                item.Tag = i;
                item.Click += new EventHandler(MenuItemClickHandler);
                listItems.Add(item);
            }
            ToolStripMenuItem[] stringItems = listItems.ToArray();
            openProfile.DropDownItems.AddRange(stringItems);
        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            //not sure if this is the correct way to do this, first time I've done it and seems to work
            //gets everything from the item you clicked. that way I can know what they clicked since it's created dynamically 
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            int currentProfileNumber = Convert.ToInt32(clickedItem.Tag);
            currentProfile = dictProfiles[currentProfileNumber];
            openProfile.Text = currentProfile.profileName;
        }

        private void LaunchBattleNetApp()
        {        
            // Use ProcessStartInfo class.
            ProcessStartInfo startBattleNetApp = new ProcessStartInfo();
            startBattleNetApp.CreateNoWindow = true;
            startBattleNetApp.UseShellExecute = false;
            startBattleNetApp.FileName = @"C:\Program Files (x86)\Battle.net\Battle.net.exe";
            startBattleNetApp.WindowStyle = ProcessWindowStyle.Normal;
            string args = "";
            //only support two languages currently TODO: more languages
            if (currentProfile.BnetAppLanguage == "English")
            {
                //en = english US = USA
                args = " --setlanguage=enUS";
            }
            else if(currentProfile.BnetAppLanguage == "한국어")
            {
                //ko = korean kr = korea
                //kind of irrelevant since korean PCrooms would just have korean as the standard anyway
                args = " --setlanguage=koKR";
            }
            startBattleNetApp.Arguments = args;
            try
            {
                Process.Start(startBattleNetApp);
            }
            catch
            {
                MessageBox.Show("Program couldn't be started.");
            }
        }

        private void Settings_Load(object sender, EventArgs e)
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
                Application.Run(new formCreateNewProfile());
            }
            
        }

        private void BtnChangeSettings_Click(object sender, EventArgs e)
        {
            //taken from visualbasic because it's so good
            //if you wanted to give people the option of overriding or not through windows use UIOption.AllDialogs instead of true
            FileSystem.CopyDirectory(currentProfile.WoWAddonsPath, currentProfile.WoWPath, true);

            //TODO: look into fading in and out(timers)
            lblFiles.Text = "Addons -> WoW" + Environment.NewLine + "Files have been copied";
            lblFiles.Visible = true;

            LaunchBattleNetApp();
        }

        private void BtnSaveAddons_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you did not push the Change Settings button during your session then you may have some issues. A backup of your addons is recommended",
                "Are you want to override your Addons? ", MessageBoxButtons.YesNo);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    FileSystem.CopyDirectory(currentProfile.WoWPath, currentProfile.WoWAddonsPath, true);
                    lblFiles.Text = "WoW -> Addons" + Environment.NewLine + "Files have been copied";
                    lblFiles.Visible = true;
                    break;
                case DialogResult.No:
                    //nothing
                    break;
            }
            
        }

        private void NewProfile_Click(object sender, EventArgs e)
        {
            formCreateNewProfile formCreateProfile = new formCreateNewProfile();
            formCreateProfile.Show();
            Visible = false;
        }

        
    }
}
