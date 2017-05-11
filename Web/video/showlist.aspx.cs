using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.video
{
    public partial class showlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal biaoti = (Literal)Page.Master.FindControl("Literal1");
            biaoti.Text = "请选择视频";
            if (!Page.IsPostBack)
            {
                Maticsoft.BLL.peixunban1 pxb = new BLL.peixunban1();
                DropDownList1.DataSource = pxb.GetList("").Tables[0];
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int qishu = Convert.ToInt16(DropDownList1.SelectedValue);
            Response.Redirect("show.aspx?qishu=" + qishu);
        }
    }
}