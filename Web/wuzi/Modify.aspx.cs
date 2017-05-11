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
namespace Maticsoft.Web.wuzi
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
		Maticsoft.BLL.wuzi bll=new Maticsoft.BLL.wuzi();
		Maticsoft.Model.wuzi model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtgongyingshang.Text=model.gongyingshang;
		this.txtperson.Text=model.person;
		this.txtphone.Text=model.phone;
		this.txtbeizhu.Text=model.beizhu;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtgongyingshang.Text.Trim().Length==0)
			{
				strErr+="gongyingshang不能为空！\\n";	
			}
			if(this.txtperson.Text.Trim().Length==0)
			{
				strErr+="person不能为空！\\n";	
			}
			if(this.txtphone.Text.Trim().Length==0)
			{
				strErr+="phone不能为空！\\n";	
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
			string name=this.txtname.Text;
			string gongyingshang=this.txtgongyingshang.Text;
			string person=this.txtperson.Text;
			string phone=this.txtphone.Text;
			string beizhu=this.txtbeizhu.Text;


			Maticsoft.Model.wuzi model=new Maticsoft.Model.wuzi();
			model.id=id;
			model.name=name;
			model.gongyingshang=gongyingshang;
			model.person=person;
			model.phone=phone;
			model.beizhu=beizhu;

			Maticsoft.BLL.wuzi bll=new Maticsoft.BLL.wuzi();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
