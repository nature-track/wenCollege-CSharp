using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.dafen_jieguo
{
    public partial class confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                loaddata();

            }
        }
        Maticsoft.Model.shangke_view skv = new Model.shangke_view();
        public void loaddata()
        {
            if (Session["shangke_vie"] == null)
            {
                //Literal1.Text = @"<script language='javascript' type='text/javascript'> window.location.href = 'start.aspx' ; </script> ";
                Response.Redirect("start.aspx");
            }
            else
            {
                skv = (Maticsoft.Model.shangke_view)Session["shangke_vie"];
                peixunban.Text = skv.peixunban;
                kecheng.Text = skv.kecheng;
                if (skv.fenzu.Trim() != "")
                {
                    zuming.Text = skv.fenzu;
                }
                jiangshi.Text = skv.jiangshi;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (kecheng.Text.Trim() == "培训班整体效果评价")
            {
                Response.Redirect("dafen_total.aspx");
            }
            else
            {
                Response.Redirect("dafen.aspx");
            }
        }


    }
}