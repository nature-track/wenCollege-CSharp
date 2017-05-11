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
namespace Maticsoft.Web.account
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


        static DataTable dt_all = new DataTable();
        private void loaddata()
        {
            name.Text = DateTime.Now.ToShortDateString() + "填的单据";
            return_str();
            Maticsoft.BLL.account_detail ac_d = new BLL.account_detail();
            dt_all = ac_d.GetList(500, "", " id desc").Tables[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            for (int i = 1; i < 6; i++) { DataRow row = dt.NewRow(); row["id"] = i; dt.Rows.Add(row); }
            GridView1.DataSource = dt;
            GridView1.DataBind();

            AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            User currentUser = new LTP.Accounts.Bus.User(user);
            //lururen.Text = currentUser.TrueName;


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

            Maticsoft.BLL.account account_bll = new BLL.account();
            DataSet ds2 = account_bll.lururen("");
            jingshouren.DataSource = ds2;
            jingshouren.DataTextField = "lururen";
            jingshouren.DataValueField = "lururen";          
            jingshouren.DataBind();
            for (int i = 0; i < jingshouren.Items.Count; i++)
            {
                if (jingshouren.Items[i].Value.Trim() == currentUser.TrueName)
                {
                    jingshouren.Items[i].Selected = true;
                }
            }
            //jingshouren.SelectedValue = currentUser.TrueName;
            luru_time.Text = DateTime.Now.ToShortDateString();
        }
        public void return_str()
        {
            StringBuilder str = new StringBuilder();
            str.Append("<script type='text/javascript'> var availableTags = [");

                DataTable dt_wuzi = new DataTable();
                Maticsoft.BLL.account_detail ac_d = new BLL.account_detail();
                dt_wuzi = ac_d.select_wuzi();
                for (int i = 0; i < dt_wuzi.Rows.Count; i++)
                {
                    str.Append("'");
                    str.Append(dt_wuzi.Rows[i]["wuzi"].ToString().Trim());
                    str.Append("',");
                }
                str.Append("'水果' ]   </script>");
                Literal1.Text = str.ToString();
        }



        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string err = gridview_err();
            if (err == "")
            {
                int accountid = add_account();
                StringBuilder str = new StringBuilder();
                Maticsoft.BLL.account_detail acc_d_bll = new BLL.account_detail();
                int i = 0;
                foreach (GridViewRow row in GridView1.Rows)
                {
                    TextBox wuzi = (TextBox)row.FindControl("wuzi");
                    if (wuzi.Text.Trim() != "")
                    {
                        TextBox danwei = (TextBox)row.FindControl("danwei");
                        TextBox danjia = (TextBox)row.FindControl("danjia");
                        TextBox shuliang = (TextBox)row.FindControl("shuliang");
                        TextBox beizhu = (TextBox)row.FindControl("beizhu");
                        Maticsoft.Model.account_detail acc_d_mod = new Model.account_detail();
                        acc_d_mod.wuzi = wuzi.Text.Trim();
                        acc_d_mod.danwei = danwei.Text.Trim();
                        acc_d_mod.danjia = Convert.ToDecimal(danjia.Text.Trim());
                        acc_d_mod.shuliang = Convert.ToInt16(shuliang.Text.Trim());
                        acc_d_mod.beizhu = beizhu.Text.Trim();
                        acc_d_mod.account_id = accountid;
                        if (acc_d_bll.Add(acc_d_mod) > 0)
                        {
                            i++;
                        };
                    }

                } 
                string add_str = "list.aspx";
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "共录入了"+i+"条明细", add_str);
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
            int i=1;
            foreach (GridViewRow row in GridView1.Rows)
            {
                TextBox wuzi = (TextBox)row.FindControl("wuzi");
                if (wuzi.Text.Trim() != "")
                {
                    TextBox danwei = (TextBox)row.FindControl("danwei");
                    TextBox danjia = (TextBox)row.FindControl("danjia");
                    TextBox shuliang = (TextBox)row.FindControl("shuliang");
                    if (danwei.Text.Trim().Length == 0)
                    {
                        strErr += "第" + i + "行的单位为空！\\n";
                    }
                    if (!PageValidate.IsDecimal(danjia.Text))
                    {
                        strErr += "第" + i + "行的单价不是数字！\\n";
                    }
                    if (!PageValidate.IsNumber(shuliang.Text))
                    {
                        strErr += "第" + i + "行的数量不是整数！\\n";
                    }
                }
                i++;
            }
                    return strErr;
        }
        private int add_account()
        {
            Maticsoft.BLL.account acc_bll = new BLL.account();
            Maticsoft.Model.account acc_mod = new Model.account();
            acc_mod.leibei = leibie.SelectedValue;
            if (leibie.SelectedValue == "培训班费用")
            {
                acc_mod.peixunban_id = Convert.ToInt16(qishu.SelectedValue);
            }
            else
            {
                acc_mod.peixunban_id = 0;
            }
            acc_mod.name = name.Text.Trim();
            acc_mod.time =Convert.ToDateTime( luru_time.Text.Trim()); 
            acc_mod.beizhu = beizhu.Text.Trim();

            acc_mod.lururen = jingshouren.SelectedValue;
            
            int i= acc_bll.Add(acc_mod);
            return i;
        }
        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    foreach (GridViewRow row in GridView1.Rows)
        //    {
        //        TextBox wuzi = (TextBox)row.FindControl("wuzi");
        //        if (wuzi.Text.Trim() != "")
        //        {
        //            ((TextBox)row.FindControl("danwei")).Text = "aaa";
        //        }
        //    }
        //}
        protected void buquan(object sender, EventArgs e)
        {
            string wuzi_txt="wuzi= '"+ ((TextBox)sender).Text+"'";
            DataRow[] rows = dt_all.Select(wuzi_txt);

                TextBox tb = sender as TextBox;
                GridViewRow row = (GridViewRow)tb.NamingContainer;
            if (rows.Length != 0)
            {
                ((TextBox)row.FindControl("danwei")).Text = rows[0]["danwei"].ToString();
                ((TextBox)row.FindControl("danjia")).Text = rows[0]["danjia"].ToString();
                ((TextBox)row.FindControl("shuliang")).Text = rows[0]["shuliang"].ToString();
            }
            else
            {
                ((TextBox)row.FindControl("danwei")).Text = "";
                ((TextBox)row.FindControl("danjia")).Text = "";
                ((TextBox)row.FindControl("shuliang")).Text = "1";
            }
        }

        protected void leibie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (leibie.SelectedValue != "培训班费用")
            {
                qishu.Enabled = false;
            }
            else
            {
                qishu.Enabled = true;
            }
        }

        protected void hangshu_queding_Click(object sender, EventArgs e)
        {
            int num =Convert.ToInt16( hangshu.Text.Trim())+1;
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            for (int i = 1; i < num; i++) { DataRow row = dt.NewRow(); row["id"] = i; dt.Rows.Add(row); }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
