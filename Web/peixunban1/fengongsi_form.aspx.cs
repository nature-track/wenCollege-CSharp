using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Maticsoft.Web.peixunban1
{
    public partial class fengongsi_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            Maticsoft.BLL.wuzi wz = new BLL.wuzi();
            DataSet ds = wz.GetList("");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}