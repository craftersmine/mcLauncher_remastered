using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftersmine.MinecraftLauncher.Core
{
    public sealed class Logger
    {
        public string _loadTime;
        public string _file;

        public Logger(string name)
        {
            string directory = Path.Combine(ClientFolder.GetClientsFolder(), "Logs");
            //if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            System.Threading.Thread.Sleep(300);
            if (DateTime.Now.Hour.ToString().Length < 2)
                _loadTime = DateTime.Now.ToShortDateString() + "_0" + DateTime.Now.ToShortTimeString();
            else _loadTime = DateTime.Now.ToShortDateString() + "_" + DateTime.Now.ToShortTimeString();
            _file = Path.Combine(directory, name + "_" + _loadTime.Replace(':', '-') + ".log");
            File.WriteAllText(_file, "");
        }

        public void Log(string contents, string prefix)
        {
            string _date;
            if (DateTime.Now.Hour.ToString().Length < 2)
                _date = DateTime.Now.ToShortDateString() + " 0" + DateTime.Now.ToShortTimeString();
            else _date = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            File.AppendAllText(_file, _date + " [" + prefix + "]" + " " + contents + "\r\n");
            Console.Write(_date + " [" + prefix + "]" + " " + contents + "\r\n");
        }
    }
}
