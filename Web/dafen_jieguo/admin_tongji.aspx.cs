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

namespace Maticsoft.Web.dafen_jieguo
{
    public partial class admin_tongji : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }

        /// <summary>
        /// 获取培训班信息、课程内容信息，绑定两个下拉框
        /// </summary>
        public void BindData()
        {

            Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();

            ds = bll.GetList(strWhere.ToString());
            qishu.DataSource = ds;
            qishu.DataTextField = "name";
            qishu.DataValueField = "id";
            qishu.DataBind();
        }

        public void grid1bind()
        {
            Maticsoft.BLL.fenshu_tongji fstj = new BLL.fenshu_tongji();
            string str = "peixunban= '" + qishu.SelectedItem.Text.ToString() +"'";
            GridView1.DataSource = fstj.GetList(str);
            GridView1.DataBind();
        }

        public void grid2bind()
        {
            Maticsoft.BLL.fenshu_tongji_fenxiang fstjfx = new BLL.fenshu_tongji_fenxiang();
            string str = "peixunban_id=" + qishu.SelectedValue;
            GridView2.DataSource = fstjfx.GetList(str);
            GridView2.DataBind();
        }

        protected void tongji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tongji.SelectedValue) == 1)
            {
                GridView1.Visible = true;
                GridView2.Visible = false;
                grid1bind();
            }
            else
            {
                GridView1.Visible = false;
                GridView2.Visible = true;
                grid2bind();
            }
        }
    }
}