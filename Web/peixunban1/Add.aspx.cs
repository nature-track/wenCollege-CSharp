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
namespace Maticsoft.Web.peixunban1
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtstart_time.Text))
			{
				strErr+="start_time格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtend_time.Text))
			{
				strErr+="end_time格式错误！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime start_time=DateTime.Parse(this.txtstart_time.Text);
			DateTime end_time=DateTime.Parse(this.txtend_time.Text);
			string name=this.txtname.Text;

			Maticsoft.Model.peixunban1 model=new Maticsoft.Model.peixunban1();
			model.start_time=start_time;
			model.end_time=end_time;
			model.name=name;
            model.beizhu = beizhu.Text;
            model.contact = contact.Text;
            model.phone = phone.Text;
            model.sinal = Convert.ToInt16( sinal.SelectedValue);
			Maticsoft.BLL.peixunban1 bll=new Maticsoft.BLL.peixunban1();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
