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
namespace Maticsoft.Web.supplier
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtperson.Text.Trim().Length==0)
			{
				strErr+="person不能为空！\\n";	
			}
			if(this.txtphone.Text.Trim().Length==0)
			{
				strErr+="phone不能为空！\\n";	
			}
			if(this.txtphone2.Text.Trim().Length==0)
			{
				strErr+="phone2不能为空！\\n";	
			}
			if(this.txtbank.Text.Trim().Length==0)
			{
				strErr+="bank不能为空！\\n";	
			}
			if(this.txtbank_num.Text.Trim().Length==0)
			{
				strErr+="bank_num不能为空！\\n";	
			}
			if(this.txtaddress.Text.Trim().Length==0)
			{
				strErr+="address不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtstyle.Text))
			{
				strErr+="style格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtleibie.Text))
			{
				strErr+="leibie格式错误！\\n";	
			}
			if(this.txtwuzi.Text.Trim().Length==0)
			{
				strErr+="wuzi不能为空！\\n";	
			}
			if(this.txtbeizhu.Text.Trim().Length==0)
			{
				strErr+="beizhu不能为空！\\n";	
			}
			if(this.txtbeizhu2.Text.Trim().Length==0)
			{
				strErr+="beizhu2不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string name=this.txtname.Text;
			string person=this.txtperson.Text;
			string phone=this.txtphone.Text;
			string phone2=this.txtphone2.Text;
			string bank=this.txtbank.Text;
			string bank_num=this.txtbank_num.Text;
			string address=this.txtaddress.Text;
			int style=int.Parse(this.txtstyle.Text);
			int leibie=int.Parse(this.txtleibie.Text);
			string wuzi=this.txtwuzi.Text;
			string beizhu=this.txtbeizhu.Text;
			string beizhu2=this.txtbeizhu2.Text;

			Maticsoft.Model.supplier model=new Maticsoft.Model.supplier();
			model.name=name;
			model.person=person;
			model.phone=phone;
			model.phone2=phone2;
			model.bank=bank;
			model.bank_num=bank_num;
			model.address=address;
			model.style=style;
			model.leibie=leibie;
			model.wuzi=wuzi;
			model.beizhu=beizhu;
			model.beizhu2=beizhu2;

			Maticsoft.BLL.supplier bll=new Maticsoft.BLL.supplier();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
