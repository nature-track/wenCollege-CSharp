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
		Maticsoft.BLL.inv_que_n bll=new Maticsoft.BLL.inv_que_n();
		Maticsoft.Model.inv_que_n model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txttitle.Text=model.title;
		this.txtsubtitle.Text=model.subtitle;
		this.txtname.Text=model.name;
		this.txtstyle.Text=model.style;
		this.txttime.Text=model.time.ToString();
		this.txtbeizhu.Text=model.beizhu;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int id=int.Parse(this.lblid.Text);
			string title=this.txttitle.Text;
			string subtitle=this.txtsubtitle.Text;
			string name=this.txtname.Text;
			string style=this.txtstyle.Text;
			DateTime time=DateTime.Parse(this.txttime.Text);
			string beizhu=this.txtbeizhu.Text;


			Maticsoft.Model.inv_que_n model=new Maticsoft.Model.inv_que_n();
			model.id=id;
			model.title=title;
			model.subtitle=subtitle;
			model.name=name;
			model.style=style;
			model.time=time;
			model.beizhu=beizhu;

			Maticsoft.BLL.inv_que_n bll=new Maticsoft.BLL.inv_que_n();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
