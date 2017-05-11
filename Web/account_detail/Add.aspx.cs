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
namespace Maticsoft.Web.account_detail
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtwuzi.Text.Trim().Length==0)
			{
				strErr+="wuzi不能为空！\\n";	
			}
			if(this.txtdanwei.Text.Trim().Length==0)
			{
				strErr+="danwei不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtdanjia.Text))
			{
				strErr+="danjia格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtshuliang.Text))
			{
				strErr+="shuliang格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtaccount_id.Text))
			{
				strErr+="account_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtwuzi_id.Text))
			{
				strErr+="wuzi_id格式错误！\\n";	
			}
			if(this.txtbeizhu.Text.Trim().Length==0)
			{
				strErr+="beizhu不能为空！\\n";	
			}
			if(this.txtbeizhu2.Text.Trim().Length==0)
			{
				strErr+="beizhu2不能为空！\\n";	
			}
			if(this.txtbeizhu3.Text.Trim().Length==0)
			{
				strErr+="beizhu3不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string wuzi=this.txtwuzi.Text;
			string danwei=this.txtdanwei.Text;
			decimal danjia=decimal.Parse(this.txtdanjia.Text);
			int shuliang=int.Parse(this.txtshuliang.Text);
			int account_id=int.Parse(this.txtaccount_id.Text);
			int wuzi_id=int.Parse(this.txtwuzi_id.Text);
			string beizhu=this.txtbeizhu.Text;
			string beizhu2=this.txtbeizhu2.Text;
			string beizhu3=this.txtbeizhu3.Text;

			Maticsoft.Model.account_detail model=new Maticsoft.Model.account_detail();
			model.wuzi=wuzi;
			model.danwei=danwei;
			model.danjia=danjia;
			model.shuliang=shuliang;
			model.account_id=account_id;
			model.wuzi_id=wuzi_id;
			model.beizhu=beizhu;
			model.beizhu2=beizhu2;
			model.beizhu3=beizhu3;

			Maticsoft.BLL.account_detail bll=new Maticsoft.BLL.account_detail();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
