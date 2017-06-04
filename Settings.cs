using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ChatPluginxD
{
    [Obfuscation, XmlRoot]
    public class Settings
    {

        public Settings()
        {
            General = false;
            Region = false;
            Guild = false;
            World = false;
            Trade = false;
            Whispers = false;
            SoundNotif = false;
            EnableLogs = false;
            SkandiaChatNotif = false;
            MailNotification = false;
            Criterias = new BindingList<string>();
            Blacklist = new BindingList<string>();
            //Base Configuration
            RegionColor  = Color.FromArgb(0, 156, 255);
            TradingColor = Color.FromArgb(128, 255, 128);
            GuildColor  = Color.FromArgb(71, 155, 54);
            World2Color = Color.FromArgb(255, 174, 0);
            WhisperColor = Color.FromArgb(216, 3, 214);
        }


        //ChannelFilter
        public Boolean General { get; set; }
        public Boolean Region  { get; set; }
        public Boolean Guild   { get; set; }
        public Boolean World   { get; set; }
        public Boolean Trade   { get; set; }
        public Boolean Whispers { get; set; }
        public Boolean SoundNotif { get; set; }
        public Boolean EnableLogs { get; set; }
        public Boolean SkandiaChatNotif { get; set; }
        public Boolean MailNotification { get; set; }

        //ChannelType Colors
        [XmlElement(Type = typeof(ColorSerializer))]
        public Color RegionColor  { get; set; }

        [XmlElement(Type = typeof(ColorSerializer))]
        public Color TradingColor { get; set; }

        [XmlElement(Type = typeof(ColorSerializer))]
        public Color GuildColor   { get; set; }

        [XmlElement(Type = typeof(ColorSerializer))]
        public Color World2Color  { get; set; }

        [XmlElement(Type = typeof(ColorSerializer))]
        public Color WhisperColor { get; set; }



        //String Filters
        [XmlArray("Criterias")]
        [XmlArrayItem("Criteria")]
        public  BindingList<string> Criterias;
        [XmlArray("BlacklistedUsers")]
        [XmlArrayItem("Users")]
        public  BindingList<string> Blacklist;
       
    }
}
