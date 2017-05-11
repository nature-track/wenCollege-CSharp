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
namespace Maticsoft.Web.fenzu
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
		Maticsoft.BLL.fenzu bll=new Maticsoft.BLL.fenzu();
		Maticsoft.Model.fenzu model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtqishu.Text=model.qishu;
		this.txtzushu.Text=model.zushu.ToString();
		this.txtzuming.Text=model.zuming;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtqishu.Text.Trim().Length==0)
			{
				strErr+="qishu不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtzushu.Text))
			{
				strErr+="zushu格式错误！\\n";	
			}
			if(this.txtzuming.Text.Trim().Length==0)
			{
				strErr+="zuming不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string qishu=this.txtqishu.Text;
			int zushu=int.Parse(this.txtzushu.Text);
			string zuming=this.txtzuming.Text;


			Maticsoft.Model.fenzu model=new Maticsoft.Model.fenzu();
			model.id=id;
			model.qishu=qishu;
			model.zushu=zushu;
			model.zuming=zuming;

			Maticsoft.BLL.fenzu bll=new Maticsoft.BLL.fenzu();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
