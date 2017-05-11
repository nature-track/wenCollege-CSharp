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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddata();
            }          
        }
        private void loaddata()
        {

            int detail_id = Convert.ToInt16(Request.QueryString["detail_id"]);
            Maticsoft.BLL.account_view acc_v_bll = new BLL.account_view();
            Maticsoft.Model.account_view acc_v_mod = new Model.account_view();
            acc_v_mod= acc_v_bll.GetModel(detail_id);
            txtxiangmu_mingcheng.Text = txthuikuan_neirong.Text = acc_v_mod.peixunban.Trim() + acc_v_mod.wuzi.Trim();
            txtbenci_jine.Text= txtxiangmu_zongkuan.Text = acc_v_mod.xiaoji.ToString().Trim();
            Maticsoft.BLL.supplier sup_bll = new BLL.supplier();
            DropDownList1.DataSource = sup_bll.GetList("");
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
            //if(!PageValidate.IsDateTime(txtzhifu_shijian.Text))
            //{
            //    strErr+="zhifu_shijian格式错误！\\n";	
            //}
			if(!PageValidate.IsDecimal(txtbenci_jine.Text))
			{
				strErr+="benci_jine格式错误！\\n";	
			}
            //if(!PageValidate.IsDateTime(txtyuji_yukuan.Text))
            //{
            //    strErr+="yuji_yukuan格式错误！\\n";	
            //}

            //if(!PageValidate.IsNumber(txtleibie.Text))
            //{
            //    strErr+="leibie格式错误！\\n";	
            //}
            //if(this.txtbeizhu.Text.Trim().Length==0)
            //{
            //    strErr+="beizhu不能为空！\\n";	
            //}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string huikuan_neirong=this.txthuikuan_neirong.Text;
			string xiangmu_mingcheng=this.txtxiangmu_mingcheng.Text;
			decimal xiangmu_zongkuan=decimal.Parse(this.txtxiangmu_zongkuan.Text);
			decimal yifu_jine=decimal.Parse(this.txtyifu_jine.Text);

			decimal benci_jine=decimal.Parse(this.txtbenci_jine.Text);

			int supplier_id=int.Parse(this.DropDownList1.Text);
			string beizhu=this.txtbeizhu.Text;
			Maticsoft.Model.hui_kuan_dan model=new Maticsoft.Model.hui_kuan_dan();
			model.huikuan_neirong=huikuan_neirong;
			model.xiangmu_mingcheng=xiangmu_mingcheng;
			model.xiangmu_zongkuan=xiangmu_zongkuan;
			model.yifu_jine=yifu_jine;
            if (txtzhifu_shijian.Text != "")
            {
                model.zhifu_shijian = DateTime.Parse(this.txtzhifu_shijian.Text);
            }
			model.benci_jine=benci_jine;
            if (txtyuji_yukuan.Text != "")
            {
                model.yuji_yukuan = DateTime.Parse(this.txtyuji_yukuan.Text);
            }
			model.supplier_id=supplier_id;
            if (txtleibie.Text != "")
            {
                model.leibie =Convert.ToInt16( txtleibie.Text);
            }
			model.beizhu=beizhu;

			Maticsoft.BLL.hui_kuan_dan bll=new Maticsoft.BLL.hui_kuan_dan();
			bll.Add(model);
            Session["hui_mod"] = model;
			Maticsoft.Common.MessageBox.ShowAndOpennew(this,"保存成功！","print.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }

    }
}
