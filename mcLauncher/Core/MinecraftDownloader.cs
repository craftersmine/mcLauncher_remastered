using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Windows.Forms;

namespace craftersmine.MinecraftLauncher.Core
{
    public sealed class MinecraftDownloader
    {
        public delegate void DownloadProgressChangedEventDelegate(object sender, DownloadFileProgressChangedEventArgs e);
        public static event DownloadProgressChangedEventDelegate OnDownloadProgressChanged;

        public delegate void DownloadCompleteEventDelegate(object sender, DownloadDataCompletedEventArgs e);
        public static event DownloadCompleteEventDelegate OnDownloadComplete;

        private static DownloadFileProgressChangedEventArgs _dfpecea = new DownloadFileProgressChangedEventArgs();
        private static Version _clntVer;
        private static Version _mcVer;

        public static void CheckClientInstallation(string clientId)
        {
            Data.Log.Log("Checking Client installation", "INFO");
            string _fldrCtor = Path.Combine(ClientFolder.GetClientsFolder(), clientId);
            Data.Log.Log("Searching for client folder...", "INFO");
            if (Directory.Exists(_fldrCtor))
            {
                Data.Log.Log("Client folder found! Checking for version.build file...", "INFO");
                if (File.Exists(Path.Combine(_fldrCtor, "version.build")))
                {
                    Data.Log.Log("File found! Comparing versions...", "INFO");
                    string _vrs = File.ReadAllText(Path.Combine(_fldrCtor, "version.build"));
                    string[] _vrss = _vrs.Split('|');
                    string _latestVer = "";
                    Data.GettedClients.TryGetValue(clientId, out _latestVer);
                    string[] _latestVers = _latestVer.Split('|');
                    if (_vrss[1] != _latestVers[1])
                    {
                        Data.Log.Log("Found latest client update! Updating client...", "INFO");
                        RemoveOldFiles(clientId);
                        CreateFolderTree(clientId);
                        _clntVer = Version.Parse(_latestVers[1]);
                        _mcVer = Version.Parse(_latestVers[0]);
                        DownloadMinecraft(clientId);

                    }
                    else
                    {
                        _clntVer = Version.Parse(_vrss[1]);
                        _mcVer = Version.Parse(_vrss[0]);
                        RunMinecraft(clientId, _clntVer, _mcVer);
                    }
                }
                else
                {
                    Data.Log.Log("We not found version.build! That can say about installation corruption! We redownload client...", "WARN");
                    RemoveOldFiles(clientId);
                    CreateFolderTree(clientId);
                    string ver = "";
                    Data.GettedClients.TryGetValue(clientId, out ver);
                    string[] vers = ver.Split('|');
                    _clntVer = Version.Parse(vers[1]);
                    _mcVer = Version.Parse(vers[0]);
                    DownloadMinecraft(clientId);
                }
            }
            else
            {
                Data.Log.Log("We not found client folder! Downloading client...", "WARN");
                CreateFolderTree(clientId);
                string ver = "";
                Data.GettedClients.TryGetValue(clientId, out ver);
                string[] vers = ver.Split('|');
                _clntVer = Version.Parse(vers[1]);
                _mcVer = Version.Parse(vers[0]);
                DownloadMinecraft(clientId);
            }
        }

        public static void RunMinecraft(string clientId, Version clientVersion, Version mcVersion)
        {
            Data.Log.Log("Running Minecraft Client: " + clientId + " with client version: " + clientVersion.ToString() + " and MC version: " + mcVersion.ToString(), "INFO");
            MinecraftRunner.RunMinecraft(clientId, mcVersion);
        }

        public static void DownloadMinecraft(string clientId)
        {
            string _latestVer = "";
            Data.GettedClients.TryGetValue(clientId, out _latestVer);
            string[] _latestVers = _latestVer.Split('|');
            Download();
            i = 0;
            Downloader.DownloadProgressChanged += (args, e) =>
            {
                _dfpecea.FileSizeMB = e.TotalBytesToReceive / 1024.0D / 1024.0D;
                _dfpecea.DownloadedMB = e.BytesReceived / 1024.0D / 1024.0D;
                OnDownloadProgressChanged(null, _dfpecea);
            };

            Downloader.DownloadFileCompleted += (args, e) =>
            {
                _dfpecea.Progress = i;
                OnDownloadProgressChanged(null, _dfpecea);
                if (++i < Data.ClientFiles.Count) { Download(); }
                else
                {
                    //TaskbarProgressChange(100);
                    //TaskbarProgressChangeState(TaskbarProgress.TaskbarStates.Indeterminate);

                    OnDownloadComplete(null, null);

                    try
                    {
                        Data.Log.Log("Extracting natives...", "INFO");
                        new FastZip().ExtractZip(ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\bin\\natives.zip", ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\bin\\natives", null);
                        if (File.Exists(ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\bin\\natives.zip"))
                            File.Delete(ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\bin\\natives.zip");
                        Data.Log.Log("Extracting natives... Done!", "FINE");
                        Data.Log.Log("Extracting package...", "INFO");
                        new FastZip().ExtractZip(ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\client.zip", ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\", null);
                        if (File.Exists(ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\client.zip"))
                            File.Delete(ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\client.zip");
                        Data.Log.Log("Extracting package... Done!", "FINE");
                        string ver = "";
                        Data.GettedClients.TryGetValue(clientId, out ver);
                        File.WriteAllText(ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + "\\version.build", ver);
                        Data.Log.Log("Running Minecraft...", "INFO");
                        Data.SettingsMngr.RedownloadClient = false;
                        Data.SettingsMngr.Save();
                        
                        RunMinecraft(Data.SettingsMngr.SelectedClient, _clntVer, _mcVer);
                        //TaskbarProgressEnd();
                    }
                    catch (Exception ex)
                    {
                        Data.Log.Log("Message: " + ex.Message + "\r\nStack trace: \r\n" + ex.StackTrace + "\r\nInner Exception: " + ex.InnerException + "\r\nWeb Exception Response: This is local error! That have not server response" + "\r\nSource: " + ex.Source, "STACKTRACE");
                        OnDownloadComplete(null, null);
                        _dfpecea.CurrentFile = "";
                        MessageBox.Show("Ошибка при распаковке архивов! Повторите загрузку или свяжитесь с администратором!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MailSender.SendLog();
                        //TaskbarProgressEnd();
                    }

                }
            };
        }

        public static void RemoveOldFiles(string clientId)
        {
            try
            {
                Data.Log.Log("Removing old files...", "INFO");
                string _fldrCtor = Path.Combine(ClientFolder.GetClientsFolder(), clientId);
                string _binCtor = Path.Combine(_fldrCtor, "bin");
                string _natCtor = Path.Combine(_binCtor, "natives");
                string _modsCtor = Path.Combine(_fldrCtor, "mods");
                string _cfgCtor = Path.Combine(_fldrCtor, "config");
                string _cmdsCtor = Path.Combine(_fldrCtor, "coremods");

                if (Directory.Exists(_natCtor))
                    Directory.Delete(_natCtor, true);
                if (Directory.Exists(_binCtor))
                    Directory.Delete(_binCtor, true);
                if (Directory.Exists(_modsCtor))
                    Directory.Delete(_modsCtor, true);
                if (Directory.Exists(_cmdsCtor))
                    Directory.Delete(_cmdsCtor, true);
                if (Directory.Exists(_cfgCtor))
                    Directory.Delete(_cfgCtor, true);
                Data.Log.Log("Removing old files... Done!", "FINE");
            }
            catch (Exception ex)
            {
                Data.Log.Log("Error with delete files!", "ERROR");
                Data.Log.Log("Message: " + ex.Message + "\r\nStack trace: \r\n" + ex.StackTrace + "\r\nInner Exception: " + ex.InnerException + "\r\nWeb Exception Response: This is local error! That have not server response" + "\r\nSource: " + ex.Source, "STACKTRACE");
            }
        }

        public static void CreateFolderTree(string clientId)
        {
            Data.Log.Log("Creating client folder tree...", "INFO");
            try
            {
                string _fldrCtor = Path.Combine(ClientFolder.GetClientsFolder(), clientId);
                string _binCtor = Path.Combine(_fldrCtor, "bin");
                string _modsCtor = Path.Combine(_fldrCtor, "mods");
                string _cfgCtor = Path.Combine(_fldrCtor, "config");
                string _cmdsCtor = Path.Combine(_fldrCtor, "coremods");

                if (!Directory.Exists(_fldrCtor))
                    Directory.CreateDirectory(_fldrCtor);
                if (!Directory.Exists(_binCtor))
                    Directory.CreateDirectory(_binCtor);
                if (!Directory.Exists(_modsCtor))
                    Directory.CreateDirectory(_modsCtor);
                if (!Directory.Exists(_cmdsCtor))
                    Directory.CreateDirectory(_cmdsCtor);
                if (!Directory.Exists(_cfgCtor))
                    Directory.CreateDirectory(_cfgCtor);
                Data.Log.Log("Creating folder tree... Done!", "FINE");
            }
            catch (Exception ex)
            {
                Data.Log.Log("Error with create folder tree!", "ERROR");
                Data.Log.Log("Message: " + ex.Message + "\r\nStack trace: \r\n" + ex.StackTrace + "\r\nInner Exception: " + ex.InnerException + "\r\nWeb Exception Response: This is local error! That have not server response" + "\r\nSource: " + ex.Source, "STACKTRACE");
            }
        }

        static int i, percent;
        static WebClient Downloader = new WebClient();

        static void Download()
        {
            if (Data.ClientFiles != null)
                try
                {
                    Data.Log.Log("Downloading " + Data.ClientFiles[i] + "...", "INFO");
                    _dfpecea.CurrentFile = Data.ClientFiles[i];
                    Downloader.DownloadFileAsync(new Uri(LauncherSettings.ConnectionProtocol + "://" + LauncherSettings.Domain + "/" + LauncherSettings.ServerLauncherDirectory + "/clients/" + Data.SettingsMngr.SelectedClient + Data.ClientFiles[i]), ClientFolder.GetClientsFolder() + "\\" + Data.SettingsMngr.SelectedClient + Data.ClientFiles[i].Replace("/", "\\"));
                }
                catch (Exception ex) { throw ex; }
        }

        public static void DownloadAssets(string clientId)
        {

        }
    }

    public class DownloadFileProgressChangedEventArgs : EventArgs
    {
        public string CurrentFile { get; set; }
        public int Progress { get; set; }
        public double FileSizeMB { get; set; }
        public double DownloadedMB { get; set; }
    }
}
