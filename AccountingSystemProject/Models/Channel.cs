using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountingSystemProject.Models
{
    public class Channel
    {
        public int ChannelID { get; set; }
        public string ChannelCode { get; set; }
        public string ChannelName { get; set; }
        public string ChannelNameEng { get; set; }
        public string Remark { get; set; }
    }
}