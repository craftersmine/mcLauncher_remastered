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
    public partial class Settings : Form
    {
        private bool _isTextApplyed = false;
        private string _applyText;

        public Settings()
        {
            InitializeComponent();
            memory.Text = Data.SettingsMngr.Memory;
            javaPath.Text = Data.SettingsMngr.JavaBinDir;
            redownloadClient.Checked = Data.SettingsMngr.RedownloadClient;
            sendData.Checked = Data.SettingsMngr.SendDiagData;
            _applyText = apply.Text;
        }

        private void showTemplate_Click(object sender, EventArgs e)
        {
            new DataSendTemplate().ShowDialog();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            ApplySettings();
            
            _isTextApplyed = true;
            apply.Text = "Настройки применены!";
            textChangerTimer.Start();
        }

        private void ApplySettings()
        {
            Data.SettingsMngr.SendDiagData = sendData.Checked;
            Data.SettingsMngr.RedownloadClient = redownloadClient.Checked;
            Data.SettingsMngr.JavaBinDir = javaPath.Text;
            Data.SettingsMngr.Memory = memory.Text;
            Data.SettingsMngr.Save();
        }

        private void textChangerTimer_Tick(object sender, EventArgs e)
        {
            if (_isTextApplyed)
                apply.Text = _applyText;
            textChangerTimer.Stop();
        }

        private void applyAndBack_Click(object sender, EventArgs e)
        {
            ApplySettings();
            this.Close();
        }
    }
}
