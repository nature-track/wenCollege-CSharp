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
namespace Maticsoft.Web.wuzi_diaoyong
{
    public partial class Add : Page
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
            Maticsoft.BLL.wuzi wuzi_bll = new BLL.wuzi();
            DataTable dt = wuzi_bll.GetList("style = 1").Tables[0];
            GridView1.DataSource = dt;
            GridView1.DataBind();
            AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            User currentUser = new LTP.Accounts.Bus.User(user);
            fengongsi.Text = currentUser.TrueName;
            Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("[start_time] < '");
            strWhere.Append(DateTime.Today.AddDays(30).Date.ToShortDateString());
            strWhere.Append("' and [end_time] > '");
            strWhere.Append(DateTime.Today.AddDays(-30).Date.ToShortDateString());
            strWhere.Append("'");
            ds = bll.GetList(strWhere.ToString());
            qishu.DataSource = ds;
            qishu.DataTextField = "name";
            qishu.DataValueField = "id";
            qishu.DataBind();
            shijian.Text = DateTime.Now.ToShortDateString();
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
            string err = gridview_err();
            string str = "";
            int wuzi_id = 0;
            AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            User currentUser = new LTP.Accounts.Bus.User(user);
            string fengongsi = currentUser.TrueName;
            int num = 0;
            int peixunbanid =Convert.ToInt16( qishu.SelectedValue);
            int style = Convert.ToInt16(RadioButtonList1.SelectedValue);
            DateTime dtime = DateTime.Now;
            string beizhu = "";
            if (err == "")
            {
                int i = 0;
                foreach (GridViewRow row in GridView1.Rows)
                {
                    num = Convert.ToInt16(((TextBox)row.FindControl("num")).Text);
                    if (num != 0)
                    {
                        beizhu = ((TextBox)row.FindControl("beizhu")).Text;
                        wuzi_id = Convert.ToInt16(((Label)row.FindControl("id")).Text);
                        Maticsoft.Model.wuzi_diaoyong model = new Maticsoft.Model.wuzi_diaoyong();
                        model.wuzi_id = wuzi_id;
                        model.fengongsi = fengongsi;
                        model.num = num;
                        model.peixunbanid = peixunbanid;
                        model.style = style;
                        model.time = dtime;
                        model.beizhu = beizhu;
                        Maticsoft.BLL.wuzi_diaoyong bll = new Maticsoft.BLL.wuzi_diaoyong();
                        if (bll.Add(model) > 0)
                        {
                            i++;
                        };
                    }
                }
                if (i > 0)
                {
                    Maticsoft.Common.MessageBox.ShowAndRedirect(this, "共调用了" + i + "项物品", "list.aspx");
                }
            }
            else
            {
                MessageBox.Show(this, err);
                return;
            }
            

		}

                private string gridview_err()
                {
                    string strErr = "";
                    int i = 1;
                    foreach (GridViewRow row in GridView1.Rows)
                    {

                            TextBox num_txt = (TextBox)row.FindControl("num");

                            if (!PageValidate.IsNumber(num_txt.Text))
                            {
                                strErr += "第" + i + "行的数量不是整数！\\n";
                            }

                        i++;
                    }
                    return strErr;
                }


    }
}
