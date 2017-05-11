using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;

namespace Maticsoft.Web.account_detail
{
    public partial class list_detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddata();
            }
        }
        private void loaddata()
        {
            Maticsoft.BLL.account_view acc_bll = new BLL.account_view();
            GridView1.DataSource= acc_bll.GetList(100, "", "detail_id");
            GridView1.DataBind();

            Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("[start_time] < '");
            strWhere.Append(DateTime.Today.AddDays(30).Date.ToShortDateString());
            strWhere.Append("' and [end_time] > '");
            strWhere.Append(DateTime.Today.AddDays(-30).Date.ToShortDateString());
            strWhere.Append("'");
            ds = bll.GetList(strWhere.ToString());
            DataRow newrow = ds.Tables[0].NewRow();
            newrow["id"] = "999";
            newrow["name"] = "—全部显示—";
            ds.Tables[0].Rows.Add(newrow);
            qishu.DataSource = ds;
            qishu.DataTextField = "name";
            qishu.DataValueField = "id";
            qishu.DataBind();
            Maticsoft.BLL.account account_bll = new BLL.account();
            DataSet ds2 = account_bll.lururen("");
            DataRow newrow2 = ds2.Tables[0].NewRow();
            newrow2["lururen"] = "—全部显示—";
            ds2.Tables[0].Rows.Add(newrow2);
            lururen.DataSource = ds2;
            lururen.DataTextField = "lururen";
            lururen.DataValueField = "lururen";
            lururen.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder str=new StringBuilder();
            if (start_time.Text != "")
            {
                str.Append("time> '"+start_time.Text.Trim()+"' and ");
            }
            if (end_time.Text != "")
            {
                str.Append("time< '" + end_time.Text.Trim() + "' and ");
            }
            if (qishu.SelectedValue != "999")
            {
                str.Append("peixunban_id=" + qishu.SelectedValue + " and ");
            }
            if (lururen.SelectedValue != "—全部显示—")
            {
                str.Append("lururen='" + lururen.SelectedValue.Trim() + "' and ");
            }
            if (str.ToString() != "")
            {
                str.Remove(str.Length - 4, 4);
            }
            Maticsoft.BLL.account_view acc_vie_bll = new BLL.account_view();

            GridView1.DataSource = acc_vie_bll.GetList(str.ToString());
            GridView1.DataBind();
            //if (CheckBox1.Checked == true)
            //{
            //    GridView1.Columns[0].Visible = false;
            //    GridView1.Columns[5].Visible = false;
            //    GridView1.Columns[6].Visible = false;
            //    GridView1.Columns[7].Visible = false;
            //}
        }


        public decimal ReturnTotal(int col)   //根据col变量（col值代表某一列，值由GridView1_RowDataBound传入）计算某列的合计值
        {

            decimal char_total = 0;

            foreach (GridViewRow gvr in GridView1.Rows)
            {

                if (null != gvr.Cells[col].Text)
                {

                    char_total += Convert.ToDecimal(gvr.Cells[col].Text);

                }

            }

            return char_total;

        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.Footer)//判断此行是否是页尾，如果是则开始统计数据
            {

                e.Row.Cells[1].Text = "合计";//每一列的数

                e.Row.Cells[7].Text = ReturnTotal(7).ToString();

                e.Row.Cells[8].Text = ReturnTotal(8).ToString();



            }

        }
    }
}