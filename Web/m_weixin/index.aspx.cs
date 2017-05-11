using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.weixin
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //loaddata();
            }
        }

        public void loaddata()
        {
            Maticsoft.BLL.weixin wx_bll = new BLL.weixin();
            string open_id = "";
            string code = Request.QueryString["code"];
            if (code != null && code != "")
            {
                open_id = wx_bll.get_openid(code);
                if (open_id != null && open_id != "")
                {
                    Session["open_id"] = open_id;
                }
                else
                {
                    Response.Write(@"<script>alert('无法获取您的微信信息，返回首页');window.location='m_weixin\index.aspx'</script>");
                }
            }
            else
            {
                Response.Write(@"<script>alert('无法获取您的微信信息，返回首页');window.location='m_weixin\index.aspx'</script>");
            }
        }



    }
}