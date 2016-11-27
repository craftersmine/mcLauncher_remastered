using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using craftersmine.MinecraftLauncher.Core;

namespace craftersmine.MinecraftLauncher
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (System.IO.Directory.Exists(System.IO.Path.Combine(ClientFolder.GetClientsFolder(), "Logs")))
                System.IO.Directory.Delete(System.IO.Path.Combine(ClientFolder.GetClientsFolder(), "Logs"), true);
            Data.Log = new Logger("LauncherTempLog");
            string sysbits = "x86";
            if (Environment.Is64BitOperatingSystem)
                sysbits = "amd64 / x64";
            Data.Log.Log("Launcher running on " + MailSender.GetWinName() + " " + sysbits, "INFO");
            Data.Log.Log("Logger initiated!", "INFO");
            Data.Log.Log("Starting bootstrap...", "INFO");
            Data.Log.Log("Loading settings...", "INFO");
            Data.SettingsMngr = new Properties.Settings();
            Data.Log.Log("Settings instance created!", "FINE");
            if (Data.SettingsMngr.Username == string.Empty)
            {
                Data.Log.Log("Looks like first start... Trying restore settings..", "INFO");
                Data.SettingsMngr.Upgrade();
                Data.Log.Log("Settings migrate complete!", "FINE");
            }
            if (Data.SettingsMngr.JavaBinDir == string.Empty)
            {
                Data.Log.Log("We cannot be load Java Binary Path from settings! Getting default Java Binary Path...", "INFO");
                try
                {
                    Data.SettingsMngr.JavaBinDir = JavaPath.GetJavaBinaryPath();
                }
                catch
                {
                    Data.Log.Log("We cannot find Java Binary Path in registry!", "ERROR");
                    MessageBox.Show("Мы не смогли найти путь к файлам Java! Если она установлена то укажите свой путь в настройках", "Java не найдена!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Data.Log.Log("Updating Java Binary Path in Application Settings...", "INFO");
                Data.SettingsMngr.Save();
                Data.Log.Log("Java Binary Path Updated! JavaPath currently is " + Data.SettingsMngr.JavaBinDir, "FINE");
            }
            Data.Log.Log("Enabling system visual styles...", "INFO");
            Application.EnableVisualStyles();
            Data.Log.Log("Setting compatible text rendering to false", "INFO");
            Application.SetCompatibleTextRenderingDefault(false);
            Data.Log.Log("Running MainForm...", "INFO");
            Application.Run(new MainForm());
        }
    }
}
