using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.m_weixin
{
    public partial class inv_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }

        public void BindGrid()
        {
            Maticsoft.BLL.inv_que_n que_n_bll = new BLL.inv_que_n();
            GridView1.DataSource = que_n_bll.GetList("style ='1'");
            GridView1.DataBind();

        }

    }
}