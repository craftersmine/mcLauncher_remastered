using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace craftersmine.MinecraftLauncher.Core
{
    public sealed class Data
    {
        public static Logger Log { get; set; }
        public static string Folder { get { return ClientFolder.GetClientsFolder(); } }
        internal static Properties.Settings SettingsMngr { get; set; }
        public static string Session { get; set; }
        public static List<string> ClientFiles { get; set; } = new List<string>();
        public static Dictionary<string, string> GettedClients { get; set; } = new Dictionary<string, string>();
    }
}
