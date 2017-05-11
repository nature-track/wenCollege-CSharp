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
namespace Maticsoft.Web.wuzi_diaoyong
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
		Maticsoft.BLL.wuzi_diaoyong bll=new Maticsoft.BLL.wuzi_diaoyong();
		Maticsoft.Model.wuzi_diaoyong model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtwuzi_id.Text=model.wuzi_id.ToString();
		this.txtfengongsi.Text=model.fengongsi;
		this.txtnum.Text=model.num.ToString();
		this.txtpeixunbanid.Text=model.peixunbanid.ToString();
		this.txtstyle.Text=model.style.ToString();
		this.txttime.Text=model.time.ToString();
		this.txtbeizhu.Text=model.beizhu;
		this.txtbeizhu2.Text=model.beizhu2;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtwuzi_id.Text))
			{
				strErr+="wuzi_id格式错误！\\n";	
			}
			if(this.txtfengongsi.Text.Trim().Length==0)
			{
				strErr+="fengongsi不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtnum.Text))
			{
				strErr+="num格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtpeixunbanid.Text))
			{
				strErr+="peixunbanid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtstyle.Text))
			{
				strErr+="style格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txttime.Text))
			{
				strErr+="time格式错误！\\n";	
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
			int id=int.Parse(this.lblid.Text);
			int wuzi_id=int.Parse(this.txtwuzi_id.Text);
			string fengongsi=this.txtfengongsi.Text;
			int num=int.Parse(this.txtnum.Text);
			int peixunbanid=int.Parse(this.txtpeixunbanid.Text);
			int style=int.Parse(this.txtstyle.Text);
			DateTime time=DateTime.Parse(this.txttime.Text);
			string beizhu=this.txtbeizhu.Text;
			string beizhu2=this.txtbeizhu2.Text;


			Maticsoft.Model.wuzi_diaoyong model=new Maticsoft.Model.wuzi_diaoyong();
			model.id=id;
			model.wuzi_id=wuzi_id;
			model.fengongsi=fengongsi;
			model.num=num;
			model.peixunbanid=peixunbanid;
			model.style=style;
			model.time=time;
			model.beizhu=beizhu;
			model.beizhu2=beizhu2;

			Maticsoft.BLL.wuzi_diaoyong bll=new Maticsoft.BLL.wuzi_diaoyong();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
