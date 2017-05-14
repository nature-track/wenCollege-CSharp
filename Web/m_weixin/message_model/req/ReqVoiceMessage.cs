using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_model.req
{
    public class ReqVoiceMessage : ReqBaseMessage
    {
        public String MediaId { get; set; }
        public String Format { get; set; }
    }
}