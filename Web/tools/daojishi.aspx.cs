using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.tools
{
    public partial class yj_daojishi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                biaoti.Visible = false;
                Literal1.Visible = true;
                Literal1.Text = "倒计时";

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "更换标题")
            {
                biaoti.Visible = true;

                Button1.Text = "确定";
            }
            else if(Button1.Text=="确定")
            {
                Literal1.Text = biaoti.Text;

                biaoti.Visible = false;
                Button1.Text = "更换标题";
            }
        }
    }
}