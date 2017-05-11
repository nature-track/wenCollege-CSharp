using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.photos
{
    public partial class datashow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Maticsoft.BLL.work wk = new BLL.work();
                GridView1.DataSource = wk.GetList("");
                GridView1.DataBind();
            }
        }
    }
}