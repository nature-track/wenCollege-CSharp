using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_model.resp
{
    public class RespBaseMessage
    {
        public String ToUserName { get; set; }
        public String FromUserName { get; set; }
        public long CreateTime { get; set; }
        public String MsgType { get; set; }
        public int FuncFlag { get; set; }
    }
}