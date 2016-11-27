using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace craftersmine.MinecraftLauncher.Core
{
    public sealed class MailSender
    {
        public static void SendLog()
        {
            SmtpClient client = GetSMTPClient();

            MailMessage mail = new MailMessage("blockslife.bugreporter@gmail.com", "bugreport@blockslife-server.hol.es");
            mail.Subject = "Bugreport from: "+ Data.SettingsMngr.Username;
            string body = "Windows Version: " + GetWinName() + "\r\nJavaPath: "+ Data.SettingsMngr.JavaBinDir + "\r\nClients Dir: " + Data.Folder + "\r\nClient Name: " + Data.SettingsMngr.SelectedClient + "\r\nAlloc Mem: " + Data.SettingsMngr.Memory + "\r\n\r\nSettings values:\r\n  Username: "+ Data.SettingsMngr.Username + "\r\n  Memory: " + Data.SettingsMngr.Memory + "\r\n  RedwnldClient: " + Data.SettingsMngr.RedownloadClient.ToString() + "\r\n\r\nLog: \r\n" + File.ReadAllText(Data.Log._file);
            mail.Body = body;
            if (false)
                try
                {
                    client.Send(mail);
                }
                catch { }
        }

        private static SmtpClient GetSMTPClient()
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("blockslife.bugreporter@gmail.com", "blockslifeerrorreporter");
            return client;
        }

        public static string GetWinName()
        {
            string key = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey(key))
            {
                if (regKey != null)
                {
                    try
                    {
                        string name = regKey.GetValue("ProductName").ToString();
                        return name;
                    }
                    catch (Exception ex)
                    {
                        return ex.Message;
                    }
                }
                else
                    return "Launcher not got winver!";
            }
        }
    }
}
