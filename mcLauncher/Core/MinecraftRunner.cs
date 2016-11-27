using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace craftersmine.MinecraftLauncher.Core
{
    public sealed class MinecraftRunner
    {
        public static void RunMinecraft(string name, Version version)
        {
            Data.Log.Log("Running Minecraft... " + name + " " + version.ToString(), "INFO");
            try
            {
                string javadir = Data.SettingsMngr.JavaBinDir;
                if (version.Major == 1 && version.Minor == 5 && version.Build == 2)
                {
                    string str = Data.Folder + @"\" + name + @"\";
                    string arguments = " -Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -cp \"" + str + @"bin\minecraft.jar;" + str + @"bin\lwjgl.jar;" + str + @"bin\lwjgl_util.jar;" + str + "bin\\jinput.jar\" -Djava.library.path=\"" + str + "bin\\natives\" -Xmx" + Data.SettingsMngr.Memory + "M -Xms" + Data.SettingsMngr.Memory + "M net.minecraft.client.Minecraft " + Data.SettingsMngr.Username + " " + Data.Session + "";
                    Process.Start(javadir + @"\javaw.exe", arguments);
                    Application.Exit();
                }
                else if (version.Major == 1 && version.Minor == 7 && version.Build == 2)
                {
                    string str3 = Data.Folder + @"\" + name + @"\";
                    string str4 = "-Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -Xmx" + Data.SettingsMngr.Memory + "M -Xms" + Data.SettingsMngr.Memory + "M -Djava.library.path=\"" + str3 + "natives\" -cp \"" + str3 + "bin\\optifine.jar\";\"" + str3 + "bin\\liteloader.jar\";\"" + str3 + "bin\\forge.jar\";\"" + str3 + "bin\\libs.jar\";\"" + str3 + "bin\\minecraft.jar\" net.minecraft.launchwrapper.Launch --version 1.7.2 --username " + Data.SettingsMngr.Username + " --uuid " + Data.SettingsMngr.Username + " --accessToken " + Data.Session + " --gameDir \"" + str3 + "saves\" --assetsDir \"" + str3 + "assets\" --tweakClass cpw.mods.fml.common.launcher.FMLTweaker";
                    Process.Start(javadir + @"\javaw.exe", str4);
                    Application.Exit();
                }
                else if (version.Major == 1 && version.Minor == 7 && version.Build == 10)
                {
                    string str5 = Data.Folder + @"\" + name + @"\";
                    string str6 = "-Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -XX:+UseConcMarkSweepGC -XX:+CMSIncrementalMode -XX:-UseAdaptiveSizePolicy -XX:MaxPermSize=256m -Xmx" + Data.SettingsMngr.Memory + "M -Xms" + Data.SettingsMngr.Memory + "M -Djava.library.path=\"" + str5 + "natives\" -cp \"" + str5 + "bin\\optifine.jar\";\"" + str5 + "bin\\liteloader.jar\";\"" + str5 + "bin\\forge.jar\";\"" + str5 + "bin\\libs.jar\";\"" + str5 + "bin\\minecraft.jar\" net.minecraft.launchwrapper.Launch --version 1.7.10 --username " + Data.SettingsMngr.Username + " --uuid " + Data.SettingsMngr.Username + " --accessToken " + Data.Session + " --gameDir \"" + str5 + "\\saves\" --assetsDir \"" + str5 + "\\assets\" --assetIndex 1.7.10 --userProperties {} --userType mojang --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker --tweakClass cpw.mods.fml.common.launcher.FMLTweaker";
                    Process.Start(javadir + @"\javaw.exe", str6);
                    Application.Exit();
                }
                else
                {
                    string str7 = Data.Folder + @"\" + name + @"\";
                    string str8 = "-Dfml.ignoreInvalidMinecraftCertificates=true -Dfml.ignorePatchDiscrepancies=true -Xmx" + Data.SettingsMngr.Memory + "M -Xms" + Data.SettingsMngr.Memory + "M -Djava.library.path=\"" + str7 + "natives\" -cp \"" + str7 + "bin\\optifine.jar\";\"" + str7 + "bin\\liteloader.jar\";\"" + str7 + "bin\\forge.jar\";\"" + str7 + "bin\\minecraft.jar\" net.minecraft.launchwrapper.Launch --username " + Data.SettingsMngr.Username + " --session " + Data.Session + " --version 1.6.4 --gameDir \"" + str7 + "saves\" --assetsDir \"" + str7 + "assets\" --tweakClass com.mumfrey.liteloader.launch.LiteLoaderTweaker --tweakClass cpw.mods.fml.common.launcher.FMLTweaker";
                    Process.Start(javadir + @"\javaw.exe", str8);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Data.Log.Log("Unable to launch Minecraft!", "ERROR");
                Data.Log.Log(ex.Message + "\r\n\r\nStacktrace:\r\n" + ex.StackTrace, "STACKTRACE");
                MailSender.SendLog();
                var dlg = MessageBox.Show("Невозможно запустить Minecraft! Убедитесь что Java установлена на вашем компьютере! Перейти на сайт загрузки Java", "Ошибка запуска!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                switch (dlg)
                {
                    case DialogResult.Yes:
                        Process.Start("http://java.com/ru/download/");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
