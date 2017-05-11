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
namespace Maticsoft.Web.inv_que
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

        public void loaddata()
        {
            Maticsoft.BLL.inv_que_n que_n_bll = new BLL.inv_que_n();
            inv_que_n.DataSource = que_n_bll.GetList("");
            inv_que_n.DataTextField = "title";
            inv_que_n.DataValueField = "id";
            inv_que_n.DataBind();
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(this.txttext.Text.Trim().Length==0)
			{
				strErr+="text不能为空！\\n";	
			}

			if(this.txtbeizhu.Text.Trim().Length==0)
			{
				strErr+="beizhu不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int que_n_id=int.Parse(inv_que_n.SelectedValue);
			string text=this.txttext.Text;
			string style=style_dro.SelectedValue;
			string beizhu=this.txtbeizhu.Text;

			Maticsoft.Model.inv_que model=new Maticsoft.Model.inv_que();
			model.que_n_id=que_n_id;
			model.text=text;
			model.style=style;
			model.beizhu=beizhu;

			Maticsoft.BLL.inv_que bll=new Maticsoft.BLL.inv_que();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
