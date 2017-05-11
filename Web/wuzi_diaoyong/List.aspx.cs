using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Maticsoft.Common;
using System.Drawing;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.wuzi_diaoyong
{
    public partial class List : Page
    {
        
        
        
		Maticsoft.BLL.wuzi_diaoyong bll = new Maticsoft.BLL.wuzi_diaoyong();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                BindData();
            }
        }

        
        #region gridView
                        
        public void BindData()
        {
            #region
            //if (!Context.User.Identity.IsAuthenticated)
            //{
            //    return;
            //}
            //AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            //if (user.HasPermissionID(PermId_Modify))
            //{
            //    gridView.Columns[6].Visible = true;
            //}
            //if (user.HasPermissionID(PermId_Delete))
            //{
            //    gridView.Columns[7].Visible = true;
            //}
            #endregion
            AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            User currentUser = new LTP.Accounts.Bus.User(user);
            fengongsi.Text = currentUser.TrueName;
            bindqishu();
            bindgridview();
        }
        private void bindgridview()
        {
            int qishu_int =Convert.ToInt16( qishu.SelectedValue);
            DataTable dt = bll.wuzidiaoyong_view("[peixunbanid]=" + qishu_int.ToString());
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        private void bindqishu()
        {
            Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("[start_time] < '");
            strWhere.Append(DateTime.Today.AddDays(30).Date.ToShortDateString());
            strWhere.Append("' and [end_time] > '");
            strWhere.Append(DateTime.Today.AddDays(-30).Date.ToShortDateString());
            strWhere.Append("'");
            DataSet ds = bll.GetList(strWhere.ToString());
            qishu.DataSource = ds;
            qishu.DataTextField = "name";
            qishu.DataValueField = "id";
            qishu.DataBind();
        }
        


        #endregion

        protected void Button1_Click(object sender, EventArgs e)
        {
            bindgridview();
        }

        protected void qishu_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindgridview();
        }





    }
}
