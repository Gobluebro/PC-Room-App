using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Room_App
{
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
}
