using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class weixin_mas : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddata();
            }
        }



        public void loaddata()
        {
            Maticsoft.BLL.weixin wx_bll = new BLL.weixin();
            string open_id = "";
            if (Session["open_id"] == null)
            {
                string code = Request.QueryString["code"];
                if (code != null && code != "")
                {
                    open_id = wx_bll.get_openid(code);
                    if (open_id != null && open_id != "")
                    {
                        Session["open_id"] = open_id;
                        loadinfo(open_id);
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

               
            }else
            {
                open_id=Session["open_id"].ToString();
                loadinfo(open_id);
            }
        }

        public void loadinfo(string open_id)
        {
            Maticsoft.BLL.weixin wx_bll = new BLL.weixin();
            Maticsoft.Model.weixin_userinfo wx_mod = new Model.weixin_userinfo();
            wx_mod = wx_bll.get_userinfo(open_id, wx_bll.get_accesstoken())[0];
            Maticsoft.BLL.member mem_b = new BLL.member();
            string name = mem_b.get_name(open_id);
            if (name != null && name != "空")
            {
                huanyingci.Text = "您好，" + name + "(" + wx_mod.nickname + ")，欢迎进入温氏培训系统测试版";
                touxiang.ImageUrl = wx_mod.headimgurl;
            }
            else
            {
                Response.Write(@"<script>alert('无法获取您的培训信息，返回首页');window.location='m_weixin\index.aspx'</script>");
            }
        }
    }
}