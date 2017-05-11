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
namespace Maticsoft.Web.hui_kuan_dan
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
		Maticsoft.BLL.hui_kuan_dan bll=new Maticsoft.BLL.hui_kuan_dan();
		Maticsoft.Model.hui_kuan_dan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txthuikuan_neirong.Text=model.huikuan_neirong;
		this.txtxiangmu_mingcheng.Text=model.xiangmu_mingcheng;
		this.txtxiangmu_zongkuan.Text=model.xiangmu_zongkuan.ToString();
		this.txtyifu_jine.Text=model.yifu_jine.ToString();
		this.txtzhifu_shijian.Text=model.zhifu_shijian.ToString();
		this.txtbenci_jine.Text=model.benci_jine.ToString();
		this.txtyuji_yukuan.Text=model.yuji_yukuan.ToString();
		this.txtsupplier_id.Text=model.supplier_id.ToString();
		this.txtleibie.Text=model.leibie.ToString();
		this.txtbeizhu.Text=model.beizhu;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txthuikuan_neirong.Text.Trim().Length==0)
			{
				strErr+="huikuan_neirong不能为空！\\n";	
			}
			if(this.txtxiangmu_mingcheng.Text.Trim().Length==0)
			{
				strErr+="xiangmu_mingcheng不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtxiangmu_zongkuan.Text))
			{
				strErr+="xiangmu_zongkuan格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtyifu_jine.Text))
			{
				strErr+="yifu_jine格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtzhifu_shijian.Text))
			{
				strErr+="zhifu_shijian格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtbenci_jine.Text))
			{
				strErr+="benci_jine格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtyuji_yukuan.Text))
			{
				strErr+="yuji_yukuan格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtsupplier_id.Text))
			{
				strErr+="supplier_id格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtleibie.Text))
			{
				strErr+="leibie格式错误！\\n";	
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
			string huikuan_neirong=this.txthuikuan_neirong.Text;
			string xiangmu_mingcheng=this.txtxiangmu_mingcheng.Text;
			decimal xiangmu_zongkuan=decimal.Parse(this.txtxiangmu_zongkuan.Text);
			decimal yifu_jine=decimal.Parse(this.txtyifu_jine.Text);
			DateTime zhifu_shijian=DateTime.Parse(this.txtzhifu_shijian.Text);
			decimal benci_jine=decimal.Parse(this.txtbenci_jine.Text);
			DateTime yuji_yukuan=DateTime.Parse(this.txtyuji_yukuan.Text);
			int supplier_id=int.Parse(this.txtsupplier_id.Text);
			int leibie=int.Parse(this.txtleibie.Text);
			string beizhu=this.txtbeizhu.Text;


			Maticsoft.Model.hui_kuan_dan model=new Maticsoft.Model.hui_kuan_dan();
			model.id=id;
			model.huikuan_neirong=huikuan_neirong;
			model.xiangmu_mingcheng=xiangmu_mingcheng;
			model.xiangmu_zongkuan=xiangmu_zongkuan;
			model.yifu_jine=yifu_jine;
			model.zhifu_shijian=zhifu_shijian;
			model.benci_jine=benci_jine;
			model.yuji_yukuan=yuji_yukuan;
			model.supplier_id=supplier_id;
			model.leibie=leibie;
			model.beizhu=beizhu;

			Maticsoft.BLL.hui_kuan_dan bll=new Maticsoft.BLL.hui_kuan_dan();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
