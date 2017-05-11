using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Script.Serialization;
using System.Data;
using System.Text;
using System.IO;
using System.Xml;
using System.Web.Security;

namespace Maticsoft.Web
{
    public partial class wenxin_url : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal1.Text = Request.QueryString["code"] + "啊啊啊啊啊啊"+Request.QueryString["state"];
            string code = Request.QueryString["code"];
            WebClient requestClinet = new WebClient();
            string json = requestClinet.DownloadString("https://api.weixin.qq.com/sns/oauth2/access_token?appid=wxf76ceff5a9e8cc35&secret=337bc8c3c79a36e5ef0162c8d5eb8873&code="+code+"&grant_type=authorization_code");
            Label1.Text = json.ToString();
        }

        
    }
}