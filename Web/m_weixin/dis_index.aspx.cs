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
    public partial class dis_index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();

            }
        }

        public void BindData()
        {
            Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("[start_time] < '");
            strWhere.Append(DateTime.Today.AddDays(10).Date.ToShortDateString());
            strWhere.Append("' and [end_time] > '");
            strWhere.Append(DateTime.Today.AddDays(-10).Date.ToShortDateString());
            strWhere.Append("'");
            ds = bll.GetList(strWhere.ToString());
            qishu.DataSource = ds;
            qishu.DataTextField = "name";
            qishu.DataValueField = "id";
            qishu.DataBind();
            int qishu_nit = Convert.ToInt16(qishu.SelectedValue);
            BindView(qishu_nit);
        }

        protected void qishu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qishu_nit = Convert.ToInt16(qishu.SelectedValue);
            BindView(qishu_nit);
        }

        protected void BindView(int qishu)
        {
            Maticsoft.BLL.shangke_view sk_v_bll = new BLL.shangke_view();
            GridView1.DataSource = sk_v_bll.GetList("[peixunban_id]= " + qishu);
            GridView1.DataBind();
        }
    }
}