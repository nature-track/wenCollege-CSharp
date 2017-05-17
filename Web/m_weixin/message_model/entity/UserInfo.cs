using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_model.entity
{
    public class UserInfo
    {
        public string openid { get; set; }
        public string nickname { get; set; }
        public string language { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public string headimagurl { get; set; }
        public string unionid { get; set; }
    }
}