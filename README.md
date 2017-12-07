## PC Room App
Quickly set the correct settings when going to a PC room in Korea. Saves time which saves money. 

## Motivation
I made this app as I was tired of doing the same routine everytime I got to a PC room. For those who don't know, a PC room charges you by the hour to use their gaming computers to play games. I would always waste my time switching my settings to the way I liked.  I thought I could automate this process and while keeping up my programming skills while in Korea.

## Build status
[comment]: # (When using IO shield, replace the link with your information)
[![GitHub release](https://img.shields.io/github/release/Gobluebro/PC-Room-App.svg)](https://github.com/Gobluebro/PC-Room-App/releases/latest) [![GitHub last commit](https://img.shields.io/github/last-commit/Gobluebro/PC-Room-App.svg)](https://github.com/Gobluebro/PC-Room-App/commits/master) [![GitHub repo size in bytes](https://img.shields.io/github/repo-size/Gobluebro/PC-Room-App.svg)]()

This program is no longer being worked on. 

I will be trying to deprecate this and replace it with [PC Room Quick Settings](https://github.com/Gobluebro/PC-Room-Quick-Settings) using WPF

## Screenshots
### Create a Profile Form
![Create a Profile Form](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_33_15-Create%20a%20New%20Profile.png?raw=true "Create a Profile Form")

If you do not have the cache file with a profile created then you will be prompted to create one and brought to this screen

### Example of filled out Profile Form
![Example of filled out Profile Form](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_41_30-Create%20a%20New%20Profile.png?raw=true "Example of filled out Profile Form")

- Set the name of your profile. Something you can remember like the name of the PC room
- Need the World of Warcraft Folder Location and Addons Folder Location to move the addons into the folder (and back to save them)
- Need the Overwatch Folder Location to be able to find the exe and run it with a different language (Only supports English / Korea at the moment)
- Need exe files you wish to run e.g. Mouse Drivers, etc

### Main Form
![Main Form](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_41_43-Choose%20which%20settings%20to%20load.png?raw=true "Main Form")

From this form you are able to change the settings with the button on the left and save addons with the button on the right.

### Profile Dropdown
![Profile Dropdown](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_42_59-Exes%20files.png?raw=true "Profile Dropdown") ![Help Dropdown](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_44_41-Exes%20files.png?raw=true "Help Dropdown")

From these dropdowns you can:
- Create a new profile
- Edit - **This does not work**
- Switch your current profile. The current profile will be the profile you marked as Preferred when you create a profile.
- Look at FAQs - **Currently none because no one has asked**
- About the Developer (Me)

#### When you add another profile it will show up in a dropdown inside of the first dropdown
![Second Profile Dropdown](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_50_29-Exes%20files.png?raw=true "Second Profile Dropdown")

### Error Testing
![Error Testing 1](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_46_22-Create%20a%20New%20Profile.png?raw=true "Error Testing 1") ![Error Testing 2](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_47_12-Create%20a%20New%20Profile.png?raw=true "Error Testing 2") ![Error Testing 3]( https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_47_36-Create%20a%20New%20Profile.png?raw=true "Error Testing 3")

This is the current tests for errors. In the future I would think to put all the errors at the same time. 

Not sure why I only outputted one at a time. I think I just didn't want to take up too much room with errors. This project is a good place to look back and reflect.

### Preferred Profile
![Preferred Profile](https://github.com/Gobluebro/PC-Room-App/blob/master/PC%20Room%20App/Images/Screenshots/2017-12-06%2022_50_07-Another%20Preferred%20Profile%20Exists.png?raw=true "Preferred Profile")

When you click the checkmark for the preferred profile it will prompt you if you are sure you want to make your newly created profile to be the preferred profile that will be configured at the start of the program from now on.

(You can still switch profiles when you start the app)

## Tech/framework used
<b>Built with</b>
- C#
- Winforms

## Installation
Simply download the [exe file here](https://github.com/Gobluebro/PC-Room-App/releases/latest) and run it. 
It will create a cache text file that you should hold on to. It will hold all of your profile presets that the program will read. 

**If you do not have it you will have to recreate your profiles.**

I recommend putting the exe on a usb drive or on a cloud backup you may have. 
I believe USB to be the fastest and the project is mainly about time. 
Keep your exe files and addons on the drive you use

## How to use?
1. Create a backup of your World of Warcraft Addons and Exe Files
   - To get your Addons go to your World of Warcraft folder and make a copy of the "Interface" folder
2. Go to a PC room and use the [latest exe file](https://github.com/Gobluebro/PC-Room-App/releases/latest).
3. Create your new profile by adding the correct folder locations and settings.
4. Click the "Change Settings" button and the program will change the settings for you. 
5. **This step is optional -** When you are done playing click the "Save WoW Adddons" button to save your WoW Addons.

In other cases like using multiple profiles:

Make sure you are on the correct profile by clicking the "Profile" button at the top and looking at "Current Profile:" option. 

If it's not correct then change it to the correct profile in the second dropdown. 

If you need to create a new profile just click new and you will be able to create a new profile. 

Sorry there is currently no interest in making the edit button work

## Code Example
```
public class Profile
  {
      public string ProfileName { get; set; }
      public bool PreferredProfile { get; set; }
      public string WoWPath { get; set; }
      public string WoWAddonsPath{ get; set; }
      public string BlizzAppPath { get; set; }
      public string BlizzAppServer { get; set; }
      public string BlizzAppLanguage { get; set; }
      public string[] ProgramFiles { get; set; }
  }
```

This is the profile class that is used to get their respected values. Every new profile uses this class.

```
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
```

Here is how the lines get saved into the program's cache. I add a semi-colon at the end of a profile so that when going through the lines I would know when it was the end.

Here is how the output will look like this:

```
Last Moved Time=
Profile Name=Hongdae PC Room
Preferred Profile=0
WoW Path=S:\Documents\Testing\Wow
WoW Addons Path=S:\Documents\Testing\Wow addons
Blizzard App Path=S:\Documents\Testing\Overwatch
Blizzard App Language=English
Program Files=S:\Documents\Testing\Exes files\dothisthing.exe
Program Files=S:\Documents\Testing\Exes files\test.exe
;
```

Last moved time is where I would write the time of when the addons were moved from your backup to the addons folder 
and then upon closing it would ask you if you wanted to move them back 
so that you could get the new data you had from after playing the game. 
This would be a failsafe for people who may forget to save their addon files.

## Credits
- [Akash Nimare for the Readme Guide](https://medium.com/@meakaakka/a-beginners-guide-to-writing-a-kickass-readme-7ac01da88ab3)
- The people who created the icons on free icon websites I took them from. I feel bad that I never wrote their addresses down

## License

[![license](https://img.shields.io/badge/License-BSD%203--Clause-blue.svg)](https://github.com/Gobluebro/PC-Room-App/blob/master/LICENSE.txt)

BSD 3 © [Griffin Strayer](https://github.com/Gobluebro/PC-Room-App/blob/master/LICENSE.txt)
