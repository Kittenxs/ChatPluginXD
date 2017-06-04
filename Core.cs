using PluginsCommon;
using Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Media;
using RestSharp;
using RestSharp.Authenticators;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using Newtonsoft.Json;

namespace ChatPluginxD
{
    public class Core : IPluginChat
    {


        //SendGridAPI Key: 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
        //MailGun API KEY: key-6f8941f5a6838ebb334a2341ba6a3070


        /**
         * ChatPluginXD
         * Thanks: namedrisk ( spending time on the API, helped me out a lot of time :D ), denverxxx ( for ideas )
         * For https://skandiabot.com/forum/index.php
         * By Kritters 
         * */
        private Wnd _gui;
        private Thread _guiManager;
        public static Boolean General, Region, Guild, World, Trade = false;
        public static bool SoundOff = true;
        public static bool BeepOn;
        public static string LogFile = string.Empty;
        public static string PlayerName = string.Empty;
        public static BindingList<Chat> Messages = new BindingList<Chat>();
        //public static Concure<Chat> Messages = new BindingList<Chat>();
        public static Settings Settings;


        public static string BeepDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.Combine(Directory.GetParent(Path.GetDirectoryName(path)).FullName, "profiles", "plugins", "beep.wav");
            }
        }

        public void Beep()
        {
            BeepOn = true;
            SoundPlayer Beep = new SoundPlayer(BeepDirectory);
            Beep.Play();
        }

        public void OnChatMessage(string message, uint type, bool isWhisper)
        {
            if (!Skandia.IsInGame || Skandia.Me == null)
            {
                return;
            }
           
            var channelType = (ChatMessageType)type;
            var MessageSender = message.Substring(0, message.IndexOf(':'));
            var MessageClean =  message.Substring(message.IndexOf(':') + 2, message.Length - (message.IndexOf(':') + 2));          
            if (channelType == ChatMessageType.Story || channelType == ChatMessageType.Recruitment || channelType == ChatMessageType.System) return;

            if (Settings.EnableLogs)
            {
                LogToFile(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean));
               // SendJSON(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean));
               // SendSimpleMessage(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean));
            }
            try
            {
                if (Settings.Blacklist.Count > 0 && Settings.Blacklist.Contains(MessageSender)) return;
                if (Settings.Criterias.Count > 0 && !Settings.Criterias.Any(MessageClean.Contains)) return;
               

                //SoundNotification
                if (Settings.SoundNotif)
                {
                    Beep();
                }

                if (channelType == ChatMessageType.Whisper && Settings.Whispers)
                {
                   /* if (Settings.SkandiaChatNotif)
                    {
                        SendJSON(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean));
                    }*/
                    Messages.Add(new Chat(MessageClean, MessageSender, channelType.ToString(), ""));
                }

                if (channelType == ChatMessageType.General && Settings.General)
                {
                    /*    if (Settings.SkandiaChatNotif)
         {
             Task.Factory.StartNew(() => SendJSON(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean)));
         }*/
                    Messages.Add(new Chat(MessageClean, MessageSender, channelType.ToString(), ""));
                }

                if (channelType == ChatMessageType.Trading && Settings.Trade)
                {
                /*    if (Settings.SkandiaChatNotif)
                    {
                        Task.Factory.StartNew(() => SendJSON(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean)));
                    }*/
                    Messages.Add(new Chat(MessageClean, MessageSender, channelType.ToString(), ""));
                }

                if (channelType == ChatMessageType.Guild && Settings.Guild)
                {
                    /*    if (Settings.SkandiaChatNotif)
       {
           Task.Factory.StartNew(() => SendJSON(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean)));
       }*/
                    Messages.Add(new Chat(MessageClean, MessageSender, channelType.ToString(), ""));
                }

                if (channelType == ChatMessageType.World2 && Settings.World)
                {
                    /*    if (Settings.SkandiaChatNotif)
      {
          Task.Factory.StartNew(() => SendJSON(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean)));
      }*/
                    Messages.Add(new Chat(MessageClean, MessageSender, channelType.ToString(), ""));
                }

                if (channelType == ChatMessageType.Region && Settings.Region)
                {
                    /*    if (Settings.SkandiaChatNotif)
         {
             Task.Factory.StartNew(() => SendJSON(string.Format("<{0}> {1} : {2}", channelType, MessageSender, MessageClean)));
         }*/
                    Messages.Add(new Chat(MessageClean, MessageSender, channelType.ToString(), ""));
                }

            }
            catch (Exception e)
            {
                Skandia.MessageLog("ChatPluginXD Exception: "+ e.StackTrace);
            }
        }

        public string Author
        {
            get { return "Kritters"; }
        }

        public string Description
        {
            get { return "Test pour Filtrer les channels"; }
        }

        public string Name
        {
            get { return "ChatPluginxD"; }
        }

        private void _guiManagement()
        {
            if (_gui == null)
            {
                _gui = new Wnd();
            }
            _gui.ShowDialog();
        }

        public void OnButtonClick()
        {
            if (_guiManager == null ||
                _guiManager.ThreadState == ThreadState.Unstarted ||
                _guiManager.ThreadState == ThreadState.Aborted ||
                _guiManager.ThreadState == ThreadState.Stopped)
            {
                _guiManager = new Thread(_guiManagement);
                _guiManager.SetApartmentState(ApartmentState.STA);
                _guiManager.Start();
            }
            else
            {
                if (_gui != null)
                {
                    if (_gui.Visible)
                    {
                        _gui.Hide();
                    }
                    else
                    {
                        _gui.ShowDialog();                      
                    }
                }
            }
        }


        public static void LogToFile(string format, params object[] param)
        {
            if (string.IsNullOrEmpty(LogFile))
            {
                return;
            }

            using (var file = new StreamWriter(LogFile, true))
            {
                file.WriteLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] "+ "[CharacterName: "+Skandia.Me.Name+"]" + format, param);
            }
        }

        public static string ProfilesDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.Combine(Directory.GetParent(Path.GetDirectoryName(path)).FullName, "profiles", "plugins", "ChatPluginxD");
            }
        }

        public static string LogsDirectory
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return Path.Combine(ProfilesDirectory,"logs");
            }
        }

        public void OnStart()
        {
            LogFile = Path.Combine(LogsDirectory, string.Format("ChatPluginXD-{0}.txt", System.Diagnostics.Process.GetCurrentProcess().Id));
            if (!Directory.Exists(ProfilesDirectory))
            {
                Directory.CreateDirectory(ProfilesDirectory);
            }
            //Generate Logs Folder
            if (!Directory.Exists(LogsDirectory))
            {
                Directory.CreateDirectory(LogsDirectory);
            }
            Settings = new Settings();
        }





        public static void SendJSON(string msg)
        {
            try
            {
                if (msg.Length == 0) return;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://ws.skandiabot.com/api/v3/teams/887736t1gfgcpjjjg7qwmeoedc/channels/75hytsmqhpgnze6skwzyqzrszr/posts/create");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                httpWebRequest.Headers["Cookie"] = "mybb[lastvisit]=1491706122; mybb[lastactive]=1491706150; loginattempts=1; mybbuser=1092_mefHwMLHOFOHeyLatViKZjORQVPpl3BPo46lKvhFjQ8EdRFkbQ; mybb[cookielaw]=1; sid=0de93aebcf0e71c9072cdf597269a41a; _ga=GA1.2.1344386101.1491706124; MMAUTHTOKEN=1keeuod3qfys9n3jqgefz34onc";
                httpWebRequest.Headers["X-Requested-With"] = "XMLHttpRequest";
                var Publish = new SkandiaPublish(msg, "75hytsmqhpgnze6skwzyqzrszr", "hobmgpbc6bf3mcqf87ce61nnsh:" + currentTimeStamp(), "hobmgpbc6bf3mcqf87ce61nnsh", (long)currentTimeStamp());
                var data = JsonSerialize(Publish);
               // httpWebRequest.ContentLength = data.Length;
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                    
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                Skandia.MessageLog("JSONRequest Sent !");
            }catch(WebException e)
            {
                Skandia.MessageLog("SendJSON ExceptionMessage: "+ e.Message);
                Skandia.MessageLog("SendJSON InnerException: " + e.InnerException);
                Skandia.MessageLog("SendJSON SourceException: " + e.Source);
                Skandia.MessageLog("SendJSON StackTrace: " + e.StackTrace);
            }
        }

        public static string JsonSerialize(SkandiaPublish data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public static double currentTimeStamp()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (double)(timeSpan.TotalSeconds * 1000);
        }

        public static RestResponse SendSimpleMessage(string Message)
        {
            RestClient client = new RestClient();
            System.Uri uri = new System.Uri("https://api.mailgun.net/v3");
            client.BaseUrl = uri;
            client.Authenticator =
            new HttpBasicAuthenticator("api",
                                      "key-6f8941f5a6838ebb334a2341ba6a3070");
            RestRequest request = new RestRequest();
            request.AddParameter("domain", "sandboxe3e2871446624921ade3ba6092061192.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Kritters ChatPluginXD <postmaster@sandboxe3e2871446624921ade3ba6092061192.mailgun.org>");
            request.AddParameter("to", "Kritters <mymail@xd.com>");
            request.AddParameter("subject", "Hello Noob");
            request.AddParameter("text", Message);
            request.Method = Method.POST;
            return (RestResponse)client.Execute(request);
        }

        public void OnStop(bool off)
        {
            if (_gui != null && !_gui.Disposing)
            {
                _gui.Close();
            }
        }

        public void Pulse()
        {
            Skandia.Update();
            if (!Skandia.IsInGame || Skandia.Me == null)
            {
                return;
            }
        }

        public Version Version
        {
            get { return new Version(1, 0, 0); }
        }
    }
}
