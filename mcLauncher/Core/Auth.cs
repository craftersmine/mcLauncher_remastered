using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.ComponentModel;

namespace craftersmine.MinecraftLauncher.Core
{
    public sealed class Auth
    {
        public delegate void AuthorizatingEventDelegate(object sender, EventArgs e);
        public static event AuthorizatingEventDelegate OnAuthorize;

        public delegate void AuthorizeCompleted(object sender, AuthCompleteEventArgs e);
        public static event AuthorizeCompleted OnAuthComplete;

        public static void AuthOnServer(string user, string passwd, string client)
        {
            Data.Log.Log("AuthComplete Event arguments instance created!", "INFO");
            AuthCompleteEventArgs _acea = new AuthCompleteEventArgs();
            try
            {
                Data.Log.Log("Trying authorize...", "INFO");
                Data.Log.Log("Calling OnAuthorize event", "DEBUG");
                OnAuthorize(null, null);
                Data.Log.Log("Building request...", "INFO");
                string _reqCtor = LauncherSettings.ConnectionProtocol + "://" + LauncherSettings.Domain + "/" + LauncherSettings.ServerLauncherDirectory + "/launcher.php?action=auth&user=" + user + "&pass=" + passwd + "&client=" + client;
                Data.Log.Log("Request address builded!", "INFO");
                Data.Log.Log("Initiating Web client instance...", "INFO");
                WebClient _clnt = new WebClient();
                Data.Log.Log("Creating request...", "INFO/SERVERREQ");
                string _resp = _clnt.DownloadString(_reqCtor);
                Data.Log.Log("Response got! Successful!", "INFO/SERVERRESP");
                string[] _resps = _resp.Split(':');

                if (!_resp.Contains("CONFIG_PROBLEM:AUTH_PASS_ENCRYPTION_DLE:MUST_BE_TRUE_OR_FALSE") || !_resp.Contains("MYSQL_CONNECT_ERROR") || !_resp.Contains("BAD_LOGIN") || !_resp.Contains("MYSQL_QUERY_ERROR:SESSION_UPDATE_ERROR"))
                {
                    Data.Log.Log("Seems like response have not error!", "INFO");
                    if (_resps.Length > 1)
                    {
                        Data.Log.Log("Another error check passed!", "FINE");
                        Data.Session = MD5Compute.ComputeSession(_resps[1]);

                        if (LauncherSettings.LauncherVersion != _resps[0])
                            _acea.IsUpdatable = true;
                        string[] _filelist = _resps[2].Split('|');

                        foreach (var _fl in _filelist)
                        {
                            Data.ClientFiles.Add(_fl);
                            Data.Log.Log("Client file: " + _fl + " added", "INFO/FILELIST");
                        }
                        Data.Log.Log("Calling OnAuthComplete event", "DEBUG");
                        OnAuthComplete(null, _acea);
                    }
                    else
                    {
                        Data.Log.Log("Error has occured! More info bellow", "ERROR");
                        _acea.IsError = true;
                        switch (_resp)
                        {
                            case "CONFIG_PROBLEM:AUTH_PASS_ENCRYPTION_DLE:MUST_BE_TRUE_OR_FALSE":
                                Data.Log.Log("Error ID: " + "CONFIG_PROBLEM:AUTH_PASS_ENCRYPTION_DLE:MUST_BE_TRUE_OR_FALSE", "ERROR");
                                _acea.Error = "Проблема настроек сервера! Переменная \"auth_pass_encrypting_dle\" должна быть \"true\" или \"false\"";
                                OnAuthComplete(null, _acea);
                                return;
                            case "MYSQL_CONNECT_ERROR":
                                Data.Log.Log("Error ID: " + "MYSQL_CONNECT_ERROR", "ERROR");
                                _acea.Error = "Проблема соединения с сервером MySQL! Ошибка: " + _resp.Split(':')[1];
                                OnAuthComplete(null, _acea);
                                return;
                            case "BAD_LOGIN":
                                Data.Log.Log("Error ID: " + "BAD_LOGIN", "ERROR");
                                _acea.Error = "Неверный пароль или имя пользователя";
                                OnAuthComplete(null, _acea);
                                return;
                            case "MYSQL_QUERY_ERROR:SESSION_UPDATE_ERROR":
                                Data.Log.Log("Error ID: " + "MYSQL_QUERY_ERROR:SESSION_UPDATE_ERROR", "ERROR");
                                _acea.Error = "Ошибка обновления сессии в базе данных! Попробуйте позже";
                                OnAuthComplete(null, _acea);
                                return;
                        }
                    }
                }
                else
                {
                    Data.Log.Log("Error has occured! More info bellow", "ERROR");
                    _acea.IsError = true;
                    switch (_resp)
                    {
                        case "CONFIG_PROBLEM:AUTH_PASS_ENCRYPTION_DLE:MUST_BE_TRUE_OR_FALSE":
                            Data.Log.Log("Error ID: " + "CONFIG_PROBLEM:AUTH_PASS_ENCRYPTION_DLE:MUST_BE_TRUE_OR_FALSE", "ERROR");
                            _acea.Error = "Проблема настроек сервера! Переменная \"auth_pass_encrypting_dle\" должна быть \"true\" или \"false\"";
                            OnAuthComplete(null, _acea);
                            return;
                        case "MYSQL_CONNECT_ERROR":
                            Data.Log.Log("Error ID: " + "MYSQL_CONNECT_ERROR", "ERROR");
                            _acea.Error = "Проблема соединения с сервером MySQL! Ошибка: " + _resp.Split(':')[1];
                            OnAuthComplete(null, _acea);
                            return;
                        case "BAD_LOGIN":
                            Data.Log.Log("Error ID: " + "BAD_LOGIN", "ERROR");
                            _acea.Error = "Неверный пароль или имя пользователя";
                            OnAuthComplete(null, _acea);
                            return;
                        case "MYSQL_QUERY_ERROR:SESSION_UPDATE_ERROR":
                            Data.Log.Log("Error ID: " + "MYSQL_QUERY_ERROR:SESSION_UPDATE_ERROR", "ERROR");
                            _acea.Error = "Ошибка обновления сессии в базе данных! Попробуйте позже";
                            OnAuthComplete(null, _acea);
                            return;
                    }
                }
            }
            catch (WebException ex)
            {
                Data.Log.Log("An exception has occured!", "SEVERE");
                Data.Log.Log("Message: " + ex.Message + "\r\nStack trace: \r\n" + ex.StackTrace + "\r\nInner Exception: " + ex.InnerException + "\r\nWeb Exception Response: " + ex.Response + "\r\nSource: " + ex.Source, "STACKTRACE");
                _acea.IsError = true;
                _acea.Error = "Ошибка подключения к серверу! Проверьте соединение и попробуйте позже";
                OnAuthComplete(null, _acea);
            }
        }

        public static Dictionary<string, string> GetAvailableClients()
        {
            Data.Log.Log("Gathering info about available clients...", "INFO");
            Data.Log.Log("AuthComplete event arguments instance created!", "INFO");
            AuthCompleteEventArgs _acea = new AuthCompleteEventArgs();
            try
            {
                Data.Log.Log("Constructing request...", "INFO");
                string _launcherphpCtor = LauncherSettings.ConnectionProtocol + "://" + LauncherSettings.Domain + "/" + LauncherSettings.ServerLauncherDirectory + "/launcher.php?action=getclients";
                Data.Log.Log("Request builded!", "INFO");
                Data.Log.Log("Creating web client instance...", "INFO");
                WebClient _clnt = new WebClient();
                Data.Log.Log("Web client instance created!", "INFO");
                Data.Log.Log("Sending request...", "INFO/SERVERREQ");
                string _resp = _clnt.DownloadString(_launcherphpCtor);
                Data.Log.Log("Response got! Working with response...", "INFO/SERVERRESP");
                string[] _clients = _resp.Split(new string[] { "<br/>" }, StringSplitOptions.RemoveEmptyEntries);
                Dictionary<string, string> _clnts = new Dictionary<string, string>();
                foreach (var _clntA in _clients)
                {
                    string[] _clntASplt = _clntA.Split(':');
                    _clnts.Add(_clntASplt[0], _clntASplt[1]);
                    Data.Log.Log("Found client " + _clntASplt[0] + " version: " + _clntASplt[1], "INFO/SERVERRESP");
                }
                return _clnts;
            }
            catch (WebException ex)
            {
                Data.Log.Log("Message: " + ex.Message + "\r\nStack trace: \r\n" + ex.StackTrace + "\r\nInner Exception: " + ex.InnerException + "\r\nWeb Exception Response: " + ex.Response + "\r\nSource: " + ex.Source, "STACKTRACE");
                System.Windows.Forms.MessageBox.Show("Ошибка подключения к серверу! Проверьте соединение и попробуйте позже", "Ошибка!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                Environment.Exit(0);
                return null;
            }
        }
    }

    public sealed class AuthCompleteEventArgs : EventArgs
    {
        public string Error { get; set; } 

        [DefaultValue(false)]
        public bool IsError { get; set; }

        [DefaultValue(false)]
        public bool IsUpdatable { get; set; }
    }
}
