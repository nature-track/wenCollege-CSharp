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
		Maticsoft.BLL.event1 bll=new Maticsoft.BLL.event1();
		Maticsoft.Model.event1 model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtsta_time.Text=model.sta_time.ToString();
		this.txtend_time.Text=model.end_time.ToString();
		this.txtevent_name.Text=model.event_name;
		this.txtbeizhu.Text=model.beizhu;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int id=int.Parse(this.lblid.Text);
			DateTime sta_time=DateTime.Parse(this.txtsta_time.Text);
			DateTime end_time=DateTime.Parse(this.txtend_time.Text);
			string event_name=this.txtevent_name.Text;
			string beizhu=this.txtbeizhu.Text;


			Maticsoft.Model.event1 model=new Maticsoft.Model.event1();
			model.id=id;
			model.sta_time=sta_time;
			model.end_time=end_time;
			model.event_name=event_name;
			model.beizhu=beizhu;

			Maticsoft.BLL.event1 bll=new Maticsoft.BLL.event1();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
