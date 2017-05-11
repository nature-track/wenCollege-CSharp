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
namespace Maticsoft.Web.forum_q
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
			if(this.txtteam.Text.Trim().Length==0)
			{
				strErr+="team不能为空！\\n";	
			}
			if(this.txtquestion.Text.Trim().Length==0)
			{
				strErr+="question不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txttime.Text))
			{
				strErr+="time格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpassword.Text))
			{
				strErr+="password格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpeixunban.Text))
			{
				strErr+="peixunban格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfenshu.Text))
			{
				strErr+="fenshu格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstyle.Text))
			{
				strErr+="style格式错误！\\n";	
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
			string team=this.txtteam.Text;
			string question=this.txtquestion.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);
			int password=int.Parse(this.txtpassword.Text);
			int peixunban=int.Parse(this.txtpeixunban.Text);
			int fenshu=int.Parse(this.txtfenshu.Text);
			int style=int.Parse(this.txtstyle.Text);
			string beizhu=this.txtbeizhu.Text;
			string beizhu2=this.txtbeizhu2.Text;

			Maticsoft.Model.forum_q model=new Maticsoft.Model.forum_q();
			model.name=name;
			model.team=team;
			model.question=question;
			model.time=time;
			model.password=password;
			model.peixunban=peixunban;
			model.fenshu=fenshu;
			model.style=style;
			model.beizhu=beizhu;
			model.beizhu2=beizhu2;

			Maticsoft.BLL.forum_q bll=new Maticsoft.BLL.forum_q();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
