using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatPluginxD
{
    public class Chat
    {
        public Chat(string messageString, string messageSender, String type, String price)
        {
            MessageString = messageString;
            MessageSender = messageSender;
            MessageType = type;
            MessageDate = DateTime.Now;
            /*MessagePrice = price;*/
        }
        public DateTime MessageDate { get; set; }
        public String MessageString { get; set; }
        public String MessageSender { get; set; }
        public String MessageType { get; set; }
       /* public String MessagePrice { get; set; }*/
    }
}
