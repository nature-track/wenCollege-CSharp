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
namespace Maticsoft.Web.shangke
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
		Maticsoft.BLL.shangke bll=new Maticsoft.BLL.shangke();
		Maticsoft.Model.shangke model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtqishu.Text=model.qishu;
		this.txtkecheng.Text=model.kecheng;
		this.txtjiangshi.Text=model.jiangshi;
		this.txtkeshi.Text=model.keshi.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtqishu.Text.Trim().Length==0)
			{
				strErr+="qishu不能为空！\\n";	
			}
			if(this.txtkecheng.Text.Trim().Length==0)
			{
				strErr+="kecheng不能为空！\\n";	
			}
			if(this.txtjiangshi.Text.Trim().Length==0)
			{
				strErr+="jiangshi不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtkeshi.Text))
			{
				strErr+="keshi格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string qishu=this.txtqishu.Text;
			string kecheng=this.txtkecheng.Text;
			string jiangshi=this.txtjiangshi.Text;
			decimal keshi=decimal.Parse(this.txtkeshi.Text);


			Maticsoft.Model.shangke model=new Maticsoft.Model.shangke();
			model.id=id;
			model.qishu=qishu;
			model.kecheng=kecheng;
			model.jiangshi=jiangshi;
			model.keshi=keshi;

			Maticsoft.BLL.shangke bll=new Maticsoft.BLL.shangke();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
