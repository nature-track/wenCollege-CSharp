
using Maticsoft.Web.m_weixin.message_core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.m_weixin
{
    public partial class WechatTest001 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string uriTemplate = "https://api.weixin.qq.com/cgi-bin/menu/get?access_token={0}";
            string uriTemplate = "https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang=zh_CN";
            string access_token = TokenUtils.getAccessToken();
            label1.Text = access_token;
            string uri = String.Format(uriTemplate, access_token, "oPFZYwanSioNrWovMwut_W_cy0h8");

            WebClient requestClient = new WebClient();
            string json = requestClient.DownloadString(uri);
            label2.Text = json;
        }
    }
}