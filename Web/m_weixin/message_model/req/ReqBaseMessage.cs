using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_model.req
{
    /// <summary>
    /// @author 
    /// @date 2017-5-13
    /// </summary>
    public class ReqBaseMessage
    {
        public String ToUserName {get; set;}
        public String FromUserName { get; set; }
        public String CreateTime { get; set; }
        public String MsgType { get; set; }
        public long MsgId { get; set; }

        
    }
}