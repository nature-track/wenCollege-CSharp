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
namespace Maticsoft.Web.dafen_jieguo
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtshangke_id.Text))
			{
				strErr+="shangke_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfenzu_id.Text))
			{
				strErr+="fenzu_id格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtfenshu.Text))
			{
				strErr+="fenshu格式错误！\\n";	
			}
			if(this.txtneirong.Text.Trim().Length==0)
			{
				strErr+="neirong不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtdafen_xuhao.Text))
			{
				strErr+="dafen_xuhao格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int shangke_id=int.Parse(this.txtshangke_id.Text);
			int fenzu_id=int.Parse(this.txtfenzu_id.Text);
			decimal fenshu=decimal.Parse(this.txtfenshu.Text);
			string neirong=this.txtneirong.Text;
			int dafen_xuhao=int.Parse(this.txtdafen_xuhao.Text);

			Maticsoft.Model.dafen_jieguo model=new Maticsoft.Model.dafen_jieguo();
			model.shangke_id=shangke_id;
			model.fenzu_id=fenzu_id;
			model.fenshu=fenshu;
			model.neirong=neirong;
			model.dafen_xuhao=dafen_xuhao;

			Maticsoft.BLL.dafen_jieguo bll=new Maticsoft.BLL.dafen_jieguo();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Write("<script languge='javascript'>window.location.href='start.aspx'</script>");
            //Response.Redirect("list.aspx");
        }
    }
}
