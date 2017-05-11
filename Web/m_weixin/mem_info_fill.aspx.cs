using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Maticsoft.Web.m_weixin
{
    public partial class mem_info_fill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddata();
            }
        }
        static Maticsoft.Model.weixin_userinfo wx_u_mod = new Model.weixin_userinfo();
        public void loaddata()
        {
            //Session["open_id"] = "ozBiSt0zxI4W3ROkC4Xf0IxAC_Qg";                      
            if (Session["userinfo"] == null)
            {
                Response.Write("<script>alert('获取不到微信信息!');window.location='index.aspx'</script>");
            }
            else
            {
                wx_u_mod = (Maticsoft.Model.weixin_userinfo)Session["userinfo"];
            }

            Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("[start_time] < '");
            strWhere.Append(DateTime.Today.AddDays(30).Date.ToShortDateString());
            strWhere.Append("' and [end_time] > '");
            strWhere.Append(DateTime.Today.AddDays(-30).Date.ToShortDateString());
            strWhere.Append("'");
            ds = bll.GetList(strWhere.ToString());
            qishu.DataSource = ds;
            qishu.DataTextField = "name";
            qishu.DataValueField = "id";
            qishu.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            //Maticsoft.BLL.weixin wx_bll = new BLL.weixin();

            //string result = wx_bll.update_remark(wx_u_mod.openid, wx_bll.get_accesstoken(), name.Text);
            //Response.Write("<script>alert('" + result + "!');</script>");


            Maticsoft.Model.member mem_mod = new Model.member();
            mem_mod.openid = wx_u_mod.openid;
            mem_mod.name = name.Text.Trim();
            mem_mod.time = DateTime.Now;
            mem_mod.peixunban_id =Convert.ToInt16( qishu.SelectedValue);
            mem_mod.name2 = wx_u_mod.nickname;
            Maticsoft.BLL.member mem_bll = new BLL.member();
            

            string str= mem_bll.updatedata(mem_mod);
            if (str == "更新成功" || str == "插入成功")
            {
                //Session["name"] = mem_mod.name;
                //Response.Write("<script>alert('退出系统后重新进入!')</script>");
                Response.Write("<script>alert('" + str + "!');window.location='index.aspx'</script>");
            }
            else
            {
                //Response.Write("<script>alert('退出系统后重新进入!')</script>");
                Response.Write("<script>alert('" + str + "!')/script>");
            }
        }
    }
}