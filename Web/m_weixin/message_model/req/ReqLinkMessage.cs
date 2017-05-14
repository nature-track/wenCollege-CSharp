using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_model.req
{
    public class ReqLinkMessage : ReqBaseMessage
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public String Url { get; set; }

    }
}