using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_model.req
{
    public class ReqLocationMessage : ReqBaseMessage
    {
        public String Location_X { get; set; }
        public String Location_Y { get; set; }
        public String Scale { get; set; }
        public String Label { get; set; }
    }
}