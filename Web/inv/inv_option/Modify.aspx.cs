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
namespace Maticsoft.Web.inv_option
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
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Maticsoft.BLL.inv_option bll=new Maticsoft.BLL.inv_option();
		Maticsoft.Model.inv_option model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtque_id.Text=model.que_id.ToString();
		this.txttext.Text=model.text;
		this.txtstyle.Text=model.style;
		this.txtbeizhu.Text=model.beizhu;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtque_id.Text))
			{
				strErr+="que_id格式错误！\\n";	
			}
			if(this.txttext.Text.Trim().Length==0)
			{
				strErr+="text不能为空！\\n";	
			}
			if(this.txtstyle.Text.Trim().Length==0)
			{
				strErr+="style不能为空！\\n";	
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
			int id=int.Parse(this.lblid.Text);
			int que_id=int.Parse(this.txtque_id.Text);
			string text=this.txttext.Text;
			string style=this.txtstyle.Text;
			string beizhu=this.txtbeizhu.Text;


			Maticsoft.Model.inv_option model=new Maticsoft.Model.inv_option();
			model.id=id;
			model.que_id=que_id;
			model.text=text;
			model.style=style;
			model.beizhu=beizhu;

			Maticsoft.BLL.inv_option bll=new Maticsoft.BLL.inv_option();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
