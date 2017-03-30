﻿using System;
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
            Application.Run(new FormSettings());
        }

    }
}
