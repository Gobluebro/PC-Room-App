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

namespace PC_Room_App
{
    public partial class formSettings : Form
    {
        bool checkedWoW = false;
        bool checkedOW = false;
        //the way to make dynamically created objects in c# and know their name
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
            string testOWPath = "";
            string testOWLang = "";

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
                        case "Overwatch Path":
                            testOWPath = splitString[1];
                            break;
                        case "Overwatch Language":
                            testOWLang = splitString[1];
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
                        OWPath = testOWPath,
                        OWLanguage = testOWLang
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

        public formSettings()
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

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadProfile();

            AddProfilesToMenu();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (checkedWoW)
            {
                string addonsDirName = currentProfile.WoWAddonsPath;
                string wowDirName = currentProfile.WoWPath; 
                //if you wanted to give people the option of overriding or not through windows use UIOption.AllDialogs instead of true
                FileSystem.CopyDirectory(addonsDirName, wowDirName, true);
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
