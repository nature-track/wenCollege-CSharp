using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.tools
{
    public partial class print_name3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["str_name"] == null)
            {
                Response.Redirect("print_name.aspx");
            }



        }

        protected string str()
        {
            string str_name;
            str_name = (string)Session["str_name"];
            return str_name;

        }
    }
}