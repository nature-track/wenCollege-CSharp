using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Maticsoft.Web.photos
{
    public partial class showlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal biaoti = (Literal)Page.Master.FindControl("Literal1");
            biaoti.Text = "相册列表";
            if (!Page.IsPostBack)
            {

                dataload();
            }
        }
        protected void dataload()
        {
            Maticsoft.BLL.photos ph = new BLL.photos();

            DataTable dt = ph.get_photolist();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str.Append("<li class='con'>");
                str.Append("<a href='show.aspx?qishu=");
                str.Append(dt.Rows[i]["qishu"].ToString());
                str.Append("' target='_blank'>");
                str.Append("<img src='../images/");
                str.Append(dt.Rows[i]["FileName"].ToString());
                str.Append("' alt='con'/>");
                str.Append("<div class='txt'><h3>");
                str.Append(dt.Rows[i]["name"].ToString());
                str.Append("</h3><p>");
                str.Append(Convert.ToDateTime(dt.Rows[i]["start_time"].ToString()).ToShortDateString()+" 到 "+Convert.ToDateTime(dt.Rows[i]["end_time"].ToString()).ToShortDateString());
                str.Append("</p></div> </a></li>");
            }
            Literal2.Text = str.ToString();
            
        }


    }
}