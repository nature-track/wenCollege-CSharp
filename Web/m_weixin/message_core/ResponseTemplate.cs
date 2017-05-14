using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_core
{
    public static class ResponseTemplate
    {
        private static String resp_msg_template_text = @"<xml>
                                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                                    <CreateTime>{2}</CreateTime>
                                                    <MsgType><![CDATA[text]]></MsgType>
                                                    <Content><![CDATA[{3}]]></Content>
                                                    </xml>";

        //private static String 
    }
}