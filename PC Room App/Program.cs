using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace PC_Room_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool existingProfile = File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Cache.txt");
            if (!existingProfile)
            {
                MessageBox.Show("Please Create a Profile", "No Existing Profile.");
                FormNewProfile formCreateProfile = new FormNewProfile();
                formCreateProfile.Show();
            }
            else
            {
                FormSettings frmSettings = new FormSettings();
                frmSettings.Show();
            }
            Application.Run();
        }

    }
}
