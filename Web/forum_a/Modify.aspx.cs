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
namespace Maticsoft.Web.forum_a
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		Maticsoft.BLL.forum_a bll=new Maticsoft.BLL.forum_a();
		Maticsoft.Model.forum_a model=bll.GetModel();
		this.txtid.Text=model.id.ToString();
		this.txtque_id.Text=model.que_id.ToString();
		this.txtname.Text=model.name;
		this.txtteam.Text=model.team;
		this.txtanswer.Text=model.answer;
		this.txttime.Text=model.time.ToString();
		this.txtpassword.Text=model.password.ToString();
		this.txtfenshu.Text=model.fenshu.ToString();
		this.txtbeizhu.Text=model.beizhu;
		this.txtbeizhu2.Text=model.beizhu2;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtid.Text))
			{
				strErr+="id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtque_id.Text))
			{
				strErr+="que_id格式错误！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtteam.Text.Trim().Length==0)
			{
				strErr+="team不能为空！\\n";	
			}
			if(this.txtanswer.Text.Trim().Length==0)
			{
				strErr+="answer不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txttime.Text))
			{
				strErr+="time格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpassword.Text))
			{
				strErr+="password格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtfenshu.Text))
			{
				strErr+="fenshu格式错误！\\n";	
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
			int id=int.Parse(this.txtid.Text);
			int que_id=int.Parse(this.txtque_id.Text);
			string name=this.txtname.Text;
			string team=this.txtteam.Text;
			string answer=this.txtanswer.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);
			int password=int.Parse(this.txtpassword.Text);
			int fenshu=int.Parse(this.txtfenshu.Text);
			string beizhu=this.txtbeizhu.Text;
			string beizhu2=this.txtbeizhu2.Text;


			Maticsoft.Model.forum_a model=new Maticsoft.Model.forum_a();
			model.id=id;
			model.que_id=que_id;
			model.name=name;
			model.team=team;
			model.answer=answer;
			model.time=time;
			model.password=password;
			model.fenshu=fenshu;
			model.beizhu=beizhu;
			model.beizhu2=beizhu2;

			Maticsoft.BLL.forum_a bll=new Maticsoft.BLL.forum_a();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
