using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.m_weixin
{
    public partial class dis_que : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               loaddata();
            }
        }
        static string open_id="";
        static string name;
        static int sk_id;

        protected void loaddata()
        {
            if (Request.QueryString["sk_id"] == null)
            {
                Response.Redirect("dis_index.aspx");
            }
            else
            {
                sk_id = Convert.ToInt16(Request.QueryString["sk_id"]);
            }
            
            if (Session["open_id"] != null)
            {
                open_id = Session["open_id"].ToString();
            }
            if (Session["name"] != null)
            {
                name = Session["name"].ToString();
            }
            else
            {
                name = "匿名";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                Maticsoft.BLL.discuss dis_bll = new BLL.discuss();
                Maticsoft.Model.discuss dis_mod = new Model.discuss();
                dis_mod.text = TextBox1.Text.Trim();
                dis_mod.open_id = open_id;
                dis_mod.name = name;
                dis_mod.shangke_id = sk_id;
                dis_mod.time = DateTime.Now;
                dis_mod.style = "1";
                if (dis_bll.Add(dis_mod) > 0)
                {
                    Response.Write("<script>alert('感谢您的发言');window.location='discuss.aspx?sk_id=" + sk_id + "'</script>");
                }
                else
                {
                    Response.Write("<script>alert('提交失败，请稍后重试')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('内容不能为空')</script>");
            }
            
        }
    }
}