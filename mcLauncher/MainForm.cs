using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using craftersmine.MinecraftLauncher.Core;

namespace craftersmine.MinecraftLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Data.Log.Log("Initializing MainForm Components...", "INFO");
            InitializeComponent();
            Data.Log.Log("Components Initiated!", "FINE");
            Data.Log.Log("Applying settings...", "INFO");
            loginBox.Text = Data.SettingsMngr.Username;
            rememberPass.Checked = Data.SettingsMngr.RememberPassword;
            passwordBox.Text = Data.SettingsMngr.Password;
            launchTitle.Text = LauncherSettings.LauncherTitle;
            Text = LauncherSettings.LauncherTitle;
            Data.Log.Log("Settings applied!", "FINE");
            Data.Log.Log("Getting available clients...", "INFO");
            Data.GettedClients = Auth.GetAvailableClients();
            Data.Log.Log("Available clients requested from settings!", "FINE");
            Data.Log.Log("Adding clients names at combobox...", "INFO");
            foreach (var _clnt in Data.GettedClients)
            {
                clientsBox.Items.Add(_clnt.Key);
                Data.Log.Log("Added client: " + _clnt.Key + " Client version: " + _clnt.Value, "INFO");
            }
            Data.Log.Log("Successfully added!", "FINE");
            Data.Log.Log("Selecting client from settings...", "INFO");
            if (Data.SettingsMngr.SelectedClient != string.Empty && Data.SettingsMngr.SelectedClient != null)
            {
                clientsBox.SelectedItem = Data.SettingsMngr.SelectedClient;
                auth.Enabled = true;
            }
            else auth.Enabled = false;
            Data.Log.Log("Selected client: " + Data.SettingsMngr.SelectedClient, "INFO");
            Auth.OnAuthorize += Auth_OnAuthorize;
            Data.Log.Log("OnAuthorize event handled!", "DEBUG");
            Auth.OnAuthComplete += Auth_OnAuthComplete;
            Data.Log.Log("OnAuthComplete event handled!", "DEBUG");
            MinecraftDownloader.OnDownloadComplete += MinecraftDownloader_OnDownloadComplete;
            Data.Log.Log("OnDownloadComplete event handled!", "DEBUG");
            MinecraftDownloader.OnDownloadProgressChanged += MinecraftDownloader_OnDownloadProgressChanged;
            Data.Log.Log("OnDownloadProgressChanged event handled!", "DEBUG");
            verLnch.Text = LauncherSettings.ProjectTitle + " версия: " + LauncherSettings.LauncherVersion + " by craftersmine";
        }

        private void MinecraftDownloader_OnDownloadProgressChanged(object sender, DownloadFileProgressChangedEventArgs e)
        {
            status.Text = "Загружаем: " + e.CurrentFile;
            filecounter.Text = string.Format("{0}/{1}", e.Progress, Data.ClientFiles.Count + 1);
            filesizeLabel.Text = string.Format("{0:F2}/{1:F2} МБайт", e.DownloadedMB, e.FileSizeMB);
            double progres_ = ((double)e.Progress / (double)Data.ClientFiles.Count) * 100.0D;
            progress.Value = (int)progres_;
        }

        private void MinecraftDownloader_OnDownloadComplete(object sender, System.Net.DownloadDataCompletedEventArgs e)
        {
            status.Text = "Клиент запускается...";
            filecounter.Visible = false;
            filesizeLabel.Visible = false;
            progress.Visible = false;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Data.Log.Log("Showing settings form...", "INFO");
            new Settings().ShowDialog();
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Data.SettingsMngr.Username = loginBox.Text;
            Data.SettingsMngr.Save();
        }

        private void loginBox_Leave(object sender, EventArgs e)
        {
            Data.SettingsMngr.Username = loginBox.Text;
            Data.SettingsMngr.Save();
        }

        private void auth_Click(object sender, EventArgs e)
        {
            Data.Log.Log("Auth button clicked!", "DEBUG");
            Data.SettingsMngr.Username = loginBox.Text;
            Data.SettingsMngr.RememberPassword = rememberPass.Checked;
            Data.SettingsMngr.Save();
            if (rememberPass.Checked)
            {
                Data.Log.Log("Remembering password...", "INFO");
                Data.SettingsMngr.Password = passwordBox.Text;
            }
            else if (!rememberPass.Checked) Data.SettingsMngr.Password = "";
            Data.SettingsMngr.Save();
            Data.Log.Log("Password saved! Settings updated!", "FINE");
            
            if (loginBox.Text != string.Empty || passwordBox.Text != string.Empty)
                Auth.AuthOnServer(Data.SettingsMngr.Username, Data.SettingsMngr.Password, Data.SettingsMngr.SelectedClient);
            else
                MessageBox.Show("Не указан логин, пароль или оба поля");
        }

        private void Auth_OnAuthComplete(object sender, AuthCompleteEventArgs e)
        {
            Data.Log.Log("OnAuthComplete event called!", "DEBUG");
            if (!e.IsError)
            {
                Data.Log.Log("Seems like auth errors not exists!", "INFO");
                status.Text = "Успешная авторизация!";
                if (!e.IsUpdatable)
                {
                    Data.Log.Log("Launcher updates not found! Continuing load...", "INFO");
                    filesizeLabel.Visible = true;
                    filesizeLabel.Text = "";
                    filecounter.Visible = true;
                    filecounter.Text = "";
                    progress.Visible = true;
                    MinecraftDownloader.CheckClientInstallation(Data.SettingsMngr.SelectedClient);
                }
                else
                {
                    Data.Log.Log("Found launcher update!", "INFO");
                    status.Text = "Обнаружено обновление лаунчера! Для продолжения обновите лаунчер! Открыть страницу обновления?";
                    contBtn.Visible = true;
                    cancelBtn.Visible = true;
                }
            }
            else
            {
                Data.Log.Log("An error while auth exists!", "INFO");
                auth.Enabled = true;
                register.Enabled = true;
                loginBox.Enabled = true;
                rememberPass.Enabled = true;
                passwordBox.Enabled = true;
                settingsBtn.Enabled = true;
                clientsBox.Enabled = true;
                status.Text = e.Error;
            }
        }

        private void Auth_OnAuthorize(object sender, EventArgs e)
        {
            Data.Log.Log("OnAuthorize event called!", "DEBUG");
            auth.Enabled = false;
            register.Enabled = false;
            loginBox.Enabled = false;
            rememberPass.Enabled = false;
            passwordBox.Enabled = false;
            settingsBtn.Enabled = false;
            clientsBox.Enabled = false;
            status.Visible = true;
            status.Text = "Авторизируемся...";
        }

        private void clientsBox_SelectedValueChanged(object sender, EventArgs e)
        {
            auth.Enabled = true;
            Data.SettingsMngr.SelectedClient = clientsBox.SelectedItem.ToString();
            Data.SettingsMngr.Save();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void contBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(LauncherSettings.UpdateLink);
            Environment.Exit(0);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
