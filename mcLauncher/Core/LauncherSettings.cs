using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace craftersmine.MinecraftLauncher.Core
{
    public sealed class LauncherSettings
    {
        public const string           LauncherTitle = "Launcher";      // Заголовок лаунчера
        public const string           ClientsFolder = "launcher";      // Папка лаунчера. %AppData%\.папка

        public const string            ProjectTitle = "Launcher by craftersmine";     // Имя проекта. Для свойств компилированного EXE

        public const string      ConnectionProtocol = "http";      // Протокол соединения. Если есть SSL устанавливайте "https"
        public const string                  Domain = "yoursite.ru";      // Домен проекта
        public const string ServerLauncherDirectory = "launcher";      // Папка лаунчера на сервере

        public const string              UpdateLink = "http://yoursite.ru/updates.html";      // Ссылка на обновления. Т.к. из-за особенностей Windows исполняющиеся файлы нельзя изменять, лаунчер приходится перекачивать

        public const string         LauncherVersion = "1.0";        // Версия лаунчера. Только цифры через точку! Иначе файл не соберется или соберется с ошибками!
        
    }
}
