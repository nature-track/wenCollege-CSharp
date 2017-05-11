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
namespace Maticsoft.Web.shangke_view
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
		Maticsoft.BLL.shangke_view bll=new Maticsoft.BLL.shangke_view();
        int id = Convert.ToInt16(Request.QueryString["id"]);
		Maticsoft.Model.shangke_view model=bll.GetModel(id);
		this.txtid.Text=model.id.ToString();
		this.txtkechengneirong_id.Text=model.kechengneirong_id.ToString();
		this.txtpeixunban.Text=model.peixunban;
		this.txtpeixunban_id.Text=model.peixunban_id.ToString();
		this.txtkecheng.Text=model.kecheng;
		this.txtjiangshi_id.Text=model.jiangshi_id.ToString();
		this.txtjiangshi.Text=model.jiangshi;
		this.txtkeshi.Text=model.keshi.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtid.Text))
			{
				strErr+="id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtkechengneirong_id.Text))
			{
				strErr+="kechengneirong_id格式错误！\\n";	
			}
			if(this.txtpeixunban.Text.Trim().Length==0)
			{
				strErr+="peixunban不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtpeixunban_id.Text))
			{
				strErr+="peixunban_id格式错误！\\n";	
			}
			if(this.txtkecheng.Text.Trim().Length==0)
			{
				strErr+="kecheng不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtjiangshi_id.Text))
			{
				strErr+="jiangshi_id格式错误！\\n";	
			}
			if(this.txtjiangshi.Text.Trim().Length==0)
			{
				strErr+="jiangshi不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtkeshi.Text))
			{
				strErr+="keshi格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.txtid.Text);
			int kechengneirong_id=int.Parse(this.txtkechengneirong_id.Text);
			string peixunban=this.txtpeixunban.Text;
			int peixunban_id=int.Parse(this.txtpeixunban_id.Text);
			string kecheng=this.txtkecheng.Text;
			int jiangshi_id=int.Parse(this.txtjiangshi_id.Text);
			string jiangshi=this.txtjiangshi.Text;
			decimal keshi=decimal.Parse(this.txtkeshi.Text);


			Maticsoft.Model.shangke_view model=new Maticsoft.Model.shangke_view();
			model.id=id;
			model.kechengneirong_id=kechengneirong_id;
			model.peixunban=peixunban;
			model.peixunban_id=peixunban_id;
			model.kecheng=kecheng;
			model.jiangshi_id=jiangshi_id;
			model.jiangshi=jiangshi;
			model.keshi=keshi;

			Maticsoft.BLL.shangke_view bll=new Maticsoft.BLL.shangke_view();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
