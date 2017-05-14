using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_model.req
{
    public class ReqImageMessage: ReqBaseMessage
    {
        public String PicUrl { get; set; }

        public string MediaId { get; set; }
    }
}