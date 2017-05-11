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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
                    ShowGridview(id);
                    qishuvisiable();
                    return_str();
				}
			}
		}
                static DataTable dt_all = new DataTable();
	private void ShowInfo(int id)
	{
		Maticsoft.BLL.account bll=new Maticsoft.BLL.account();
		Maticsoft.Model.account model=bll.GetModel(id);
        Maticsoft.BLL.account_detail ac_d = new BLL.account_detail();
        dt_all = ac_d.GetList(500, "", " id desc").Tables[0];
        //leibie.SelectedIndex = 1;
        leibie.SelectedValue = model.leibei.ToString().Trim();
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
        lururen.Text = model.lururen;
        lurushijian.Text = model.time.ToString();
		this.txtbeizhu.Text=model.beizhu;
		this.txtbeizhu2.Text=model.beizhu2;

        Maticsoft.BLL.peixunban1 pei_bll = new Maticsoft.BLL.peixunban1();
        DataSet ds = new DataSet();
        ds = pei_bll.GetList("");
        qishu.DataSource = ds;
        qishu.DataTextField = "name";
        qishu.DataValueField = "id";
        qishu.DataBind();
        //qishu.SelectedValue = model.peixunban_id.ToString();
        if (model.peixunban_id != 0)
        {
            qishu.Items.FindByValue(model.peixunban_id.ToString()).Selected = true;
        }
        else
        {
            qishu.Enabled = false;
        }
	}
    private void ShowGridview(int id)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("id", typeof(int));
        for (int i = 1; i < 6; i++) { DataRow row = dt.NewRow(); row["id"] = i; dt.Rows.Add(row); }
        GridView1.DataSource = dt;
        GridView1.DataBind();

        Maticsoft.BLL.account_detail acc_d_bll = new BLL.account_detail();
        DataTable dt_bll = acc_d_bll.GetList("[account_id]=" + id).Tables[0];
        int j = 0;
        foreach (GridViewRow row in GridView1.Rows)
        {
            if (j < dt_bll.Rows.Count)
            {
                ((Label)row.FindControl("mingxidanhao")).Text = dt_bll.Rows[j]["id"].ToString();
                ((TextBox)row.FindControl("wuzi")).Text = dt_bll.Rows[j]["wuzi"].ToString();
                ((TextBox)row.FindControl("danwei")).Text = dt_bll.Rows[j]["danwei"].ToString();
                ((TextBox)row.FindControl("danjia")).Text = dt_bll.Rows[j]["danjia"].ToString();
                ((TextBox)row.FindControl("shuliang")).Text = dt_bll.Rows[j]["shuliang"].ToString();
                ((TextBox)row.FindControl("beizhu")).Text = dt_bll.Rows[j]["beizhu"].ToString();
            }
            j++;
        }

    }

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}

            //if(!PageValidate.IsDateTime(txttime.Text))
            //{
            //    strErr+="time格式错误！\\n";	
            //}
            //if(!PageValidate.IsNumber(txtpeixunban_id.Text))
            //{
            //    strErr+="peixunban_id格式错误！\\n";	
            //}
            //if(this.txtbeizhu.Text.Trim().Length==0)
            //{
            //    strErr+="beizhu不能为空！\\n";	
            //}
            //if(this.txtbeizhu2.Text.Trim().Length==0)
            //{
            //    strErr+="beizhu2不能为空！\\n";	
            //}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;

            string txtleibei = leibie.SelectedValue; 
            //string lururen=this.txtlururen.Text;
            //DateTime time=DateTime.Parse(this.txttime.Text);
            //int peixunban_id=int.Parse(this.txtpeixunban_id.Text);
			string beizhu=this.txtbeizhu.Text;
			string beizhu2=this.txtbeizhu2.Text;


			Maticsoft.Model.account model=new Maticsoft.Model.account();
			model.id=id;
			model.name=name;
            model.leibei=txtleibei;
            model.lururen = lururen.Text;
            model.time =DateTime.Parse( lurushijian.Text);
            if (leibie.SelectedValue == "培训班费用")
            {
                model.peixunban_id = Convert.ToInt16(qishu.SelectedValue);
            }
            else
            {
                model.peixunban_id = 0;
            }
			model.beizhu=beizhu;
			model.beizhu2=beizhu2;

			Maticsoft.BLL.account bll=new Maticsoft.BLL.account();
			bll.Update(model);

            string err = gridview_err();
            if (err == "")
            {

                StringBuilder str = new StringBuilder();
                Maticsoft.BLL.account_detail acc_d_bll = new BLL.account_detail();
                int i = 0;
                foreach (GridViewRow row in GridView1.Rows)
                {
                    TextBox wuzi = (TextBox)row.FindControl("wuzi");
                    if (wuzi.Text.Trim() != "")
                    {
                        Label mingxidanhao = (Label)row.FindControl("mingxidanhao");
                        TextBox danwei = (TextBox)row.FindControl("danwei");
                        TextBox danjia = (TextBox)row.FindControl("danjia");
                        TextBox shuliang = (TextBox)row.FindControl("shuliang");
                        TextBox beizhu1 = (TextBox)row.FindControl("beizhu");
                        Maticsoft.Model.account_detail acc_d_mod = new Model.account_detail();

                        acc_d_mod.wuzi = wuzi.Text.Trim();
                        acc_d_mod.danwei = danwei.Text.Trim();
                        acc_d_mod.danjia = Convert.ToDecimal(danjia.Text.Trim());
                        acc_d_mod.shuliang = Convert.ToInt16(shuliang.Text.Trim());
                        acc_d_mod.beizhu = beizhu1.Text.Trim();
                        acc_d_mod.account_id = Convert.ToInt16(lblid.Text);
                        if (mingxidanhao.Text == "")
                        {
                            acc_d_bll.Add(acc_d_mod);
                            i++;
                        }
                        else
                        {
                            acc_d_mod.id = Convert.ToInt16(mingxidanhao.Text);
                            if (acc_d_bll.Update(acc_d_mod))
                            {
                                i++;
                            };
                        }
                    }

                }
                string add_str = "list.aspx";
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "共更新了" + i + "条明细", add_str);
            }
            else
            {
                MessageBox.Show(this, err);
                return;
            }


		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }

        protected void buquan(object sender, EventArgs e)
        {
            string wuzi_txt = "wuzi= '" + ((TextBox)sender).Text + "'";
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

        private string gridview_err()
        {
            string strErr = "";
            int i = 1;
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

        protected void leibie_SelectedIndexChanged(object sender, EventArgs e)
        {
            qishuvisiable();
        }
        private void qishuvisiable()
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
    }
}
