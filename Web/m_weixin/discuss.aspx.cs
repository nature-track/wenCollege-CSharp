using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.m_weixin
{
    public partial class discuss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();

            }
        }
        static int sk_id;
        public void BindData()
        {
            if (Request.QueryString["sk_id"] == null)
            {
                Response.Redirect("dis_index.aspx");
            }
            else
            {
                sk_id = Convert.ToInt16(Request.QueryString["sk_id"]);
                Maticsoft.BLL.discuss dis_bll=new BLL.discuss();
                GridView1.DataSource = dis_bll.GetList("shangke_id = " + sk_id);
                GridView1.DataBind();

                Maticsoft.BLL.shangke_view sk_v_bll = new BLL.shangke_view();
                Maticsoft.Model.shangke_view sk_v_mod = new Model.shangke_view();
                sk_v_mod = sk_v_bll.GetModel(sk_id);
                shangke_txt.Text = sk_v_mod.kecheng + "(" + sk_v_mod.jiangshi + ")";
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("dis_que.aspx?sk_id=" + sk_id);
        }
    }
}