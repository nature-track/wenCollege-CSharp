using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.dafen_jieguo
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.weixin_userinfo wx_user_mod = new Model.weixin_userinfo();
            wx_user_mod.openid = "qwerasdfzxcv123";
            wx_user_mod.nickname = "测试";
            wx_user_mod.remark = "测试用";
            Session["userinfo"] = wx_user_mod;
            Response.Redirect("start.aspx");
        }
    }
}