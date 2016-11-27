# mcLauncher_remastered
Переработанная с нуля версия моего лаунчера

# Установка на сервере

* Убедитесь что ваш сервер поддерживает PHP и MySQL!

* Для начала извлеките все файлы из архива ```webpart.zip``` в какую-нибуть папку.

* Войдите на FTP сервер и создайте папку, например ```launcher```

* Закачайте все файлы на сервер

* Откройте ```configuration.php``` и отредактируйте его под ваши данные

Укажу ваше внимание на строку

```PHP
$launcher_root_directory = "/launcher/";
```

Здесь нужно указать имя созданной вами папки

---

Клиенты настраиваются в файле ```clients.php``` там все описано

---

* Создайте папку с именем клиента в папке ```clients```. Например если указан клиент ```MagicalClient```, то и папку нужно создавать ```MagicalClient```
* В созданной папке создайте папки ```bin, coremods, mods```
* Закачайте в папку bin: ```minecraft.jar, lwjgl.jar, lwjgl_util.jar, jinput.jar``` и архив с ```natives```
* Закачайте моды и моды изменяющие ядро соответственно в mods и coremods
* Создайте архив ```client.zip``` для нужных файлов и папок, например ```config, texturepacks, saves, options.txt, servers.dat```. Если ваш клиент версии 1.6.x и до 1.7.x то вам обязательно нужно добавить папку assets. Если ваш клиент версии 1.5.2 то архив можно оставить пустым
* Закачайте архив ```client.zip``` на сервер в папку клиента! Не в ```bin, mods, coremods``` именно в папку клиента. Путь должен получится похожим на ```\launcher\clients\{client_name}\client.zip```

# Настройка лаунчера
Для настройки лаунчера, откройте файл Core/LauncherSettings.cs

Там вы увидите такое содержание:
```C#
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
```

Меняем все в кавычках от ```public sealed class LauncherSettings``` до первой попавшейся ```}```

Тоесть вот эти переменные
```C#
        public const string           LauncherTitle = "Launcher";      // Заголовок лаунчера
        public const string           ClientsFolder = "launcher";      // Папка лаунчера. %AppData%\.папка

        public const string            ProjectTitle = "Launcher by craftersmine";     // Имя проекта. Для свойств компилированного EXE

        public const string      ConnectionProtocol = "http";      // Протокол соединения. Если есть SSL устанавливайте "https"
        public const string                  Domain = "yoursite.ru";      // Домен проекта
        public const string ServerLauncherDirectory = "launcher";      // Папка лаунчера на сервере

        public const string              UpdateLink = "http://yoursite.ru/updates.html";      // Ссылка на обновления. Т.к. из-за особенностей Windows исполняющиеся файлы нельзя изменять, лаунчер приходится перекачивать

        public const string         LauncherVersion = "1.0";        // Версия лаунчера. Только цифры через точку! Иначе файл не соберется или соберется с ошибками!
```

# Компиляция

Рекомендуем использовать Visual Studio 2015 и выше так как лаунчер разрабатывался именно не ней, однако его можно собрать и в других IDE, просто они не проверены

Выберите версию сборки ```Release``` т.к при ```Debug``` будут выплевываться трассировки стека при критической ошибке пользователю

# Обфускация

Хоть и кажется что ```EXE``` файл открыть нельзя чтобы посмотреть код нельзя, есть программы которые могут просматривать и извлекать код! Если хотите сохранить ваши данные в сохранности, рекомендуем обфусцировать ваш Исполняемый файл, однако обфускаторы платные. И все же нет безупречных обфускаторов все может быть деобфусцировано и декомпилировано, хоть и с ошибками

# Вопросы

Если у вас остались вопросы пишите на mr17012001@yandex.ru, только прошу не флудите)
