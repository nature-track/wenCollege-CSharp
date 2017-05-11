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
namespace Maticsoft.Web.inv_que_n
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txttitle.Text.Trim().Length==0)
			{
				strErr+="title不能为空！\\n";	
			}
			if(this.txtsubtitle.Text.Trim().Length==0)
			{
				strErr+="subtitle不能为空！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtstyle.Text.Trim().Length==0)
			{
				strErr+="style不能为空！\\n";	
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
			string title=this.txttitle.Text;
			string subtitle=this.txtsubtitle.Text;
			string name=this.txtname.Text;
			string style=this.txtstyle.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);
			string beizhu=this.txtbeizhu.Text;

			Maticsoft.Model.inv_que_n model=new Maticsoft.Model.inv_que_n();
			model.title=title;
			model.subtitle=subtitle;
			model.name=name;
			model.style=style;
			model.time=time;
			model.beizhu=beizhu;

			Maticsoft.BLL.inv_que_n bll=new Maticsoft.BLL.inv_que_n();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
