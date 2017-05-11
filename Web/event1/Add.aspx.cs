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
namespace Maticsoft.Web.event1
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtsta_time.Text))
			{
				strErr+="sta_time格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtend_time.Text))
			{
				strErr+="end_time格式错误！\\n";	
			}
			if(this.txtevent_name.Text.Trim().Length==0)
			{
				strErr+="event_name不能为空！\\n";	
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
			DateTime sta_time=DateTime.Parse(this.txtsta_time.Text);
			DateTime end_time=DateTime.Parse(this.txtend_time.Text);
			string event_name=this.txtevent_name.Text;
			string beizhu=this.txtbeizhu.Text;

			Maticsoft.Model.event1 model=new Maticsoft.Model.event1();
			model.sta_time=sta_time;
			model.end_time=end_time;
			model.event_name=event_name;
			model.beizhu=beizhu;

			Maticsoft.BLL.event1 bll=new Maticsoft.BLL.event1();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
