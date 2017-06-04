using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatPluginxD
{
    public class SkandiaPublish
    {

        public SkandiaPublish(string msg, string channel_idx, string pending, string user_idx, long created_atx)
        {

            message = msg;
            channel_id = channel_idx;
            pending_post_id = pending;
            user_id = user_idx;
            created_at = created_atx;
        }
        public string message { get; set; }
        public string channel_id { get; set; }
        public string pending_post_id { get; set; }
        public string user_id { get; set; }
        public long created_at { get; set; }
    }
}
