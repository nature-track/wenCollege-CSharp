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
namespace Maticsoft.Web.inv_answer
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
		Maticsoft.BLL.inv_answer bll=new Maticsoft.BLL.inv_answer();
		Maticsoft.Model.inv_answer model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtoption_id.Text=model.option_id.ToString();
		this.txtan_int.Text=model.an_int.ToString();
		this.txtan_text.Text=model.an_text;
		this.txtopen_id.Text=model.open_id;
		this.txtname.Text=model.name;
		this.txttime.Text=model.time.ToString();
		this.txtbeizhu.Text=model.beizhu;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtoption_id.Text))
			{
				strErr+="option_id格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtan_int.Text))
			{
				strErr+="an_int格式错误！\\n";	
			}
			if(this.txtan_text.Text.Trim().Length==0)
			{
				strErr+="an_text不能为空！\\n";	
			}
			if(this.txtopen_id.Text.Trim().Length==0)
			{
				strErr+="open_id不能为空！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txttime.Text))
			{
				strErr+="time格式错误！\\n";	
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
			int option_id=int.Parse(this.txtoption_id.Text);
			decimal an_int=decimal.Parse(this.txtan_int.Text);
			string an_text=this.txtan_text.Text;
			string open_id=this.txtopen_id.Text;
			string name=this.txtname.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);
			string beizhu=this.txtbeizhu.Text;


			Maticsoft.Model.inv_answer model=new Maticsoft.Model.inv_answer();
			model.id=id;
			model.option_id=option_id;
			model.an_int=an_int;
			model.an_text=an_text;
			model.open_id=open_id;
			model.name=name;
			model.time=time;
			model.beizhu=beizhu;

			Maticsoft.BLL.inv_answer bll=new Maticsoft.BLL.inv_answer();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
