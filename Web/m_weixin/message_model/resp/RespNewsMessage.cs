using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_model.resp
{
    public class RespNewsMessage : RespBaseMessage
    {
        public int ArticleCount { get; set; }
        public List<RespArticle> Articles { get; set; }

    }
}