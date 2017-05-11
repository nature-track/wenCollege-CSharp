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
namespace Maticsoft.Web.branch_company
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtpeixunban_id.Text))
			{
				strErr+="peixunban_id格式错误！\\n";	
			}
			if(this.txtstart_detail.Text.Trim().Length==0)
			{
				strErr+="start_detail不能为空！\\n";	
			}
			if(this.txtend_detail.Text.Trim().Length==0)
			{
				strErr+="end_detail不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtnum.Text))
			{
				strErr+="num格式错误！\\n";	
			}
			if(this.txtnum_detail.Text.Trim().Length==0)
			{
				strErr+="num_detail不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtcleaning_fee.Text))
			{
				strErr+="cleaning_fee格式错误！\\n";	
			}
			if(this.txtfapiao_taitou.Text.Trim().Length==0)
			{
				strErr+="fapiao_taitou不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtbasketball_time.Text))
			{
				strErr+="basketball_time格式错误！\\n";	
			}
			if(this.txtfantang.Text.Trim().Length==0)
			{
				strErr+="fantang不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtfangka_print.Text))
			{
				strErr+="fangka_print格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtyuedu_shuoming.Text))
			{
				strErr+="yuedu_shuoming格式错误！\\n";	
			}
			if(this.txtfengongsi.Text.Trim().Length==0)
			{
				strErr+="fengongsi不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtdate.Text))
			{
				strErr+="date格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int peixunban_id=int.Parse(this.txtpeixunban_id.Text);
			string start_detail=this.txtstart_detail.Text;
			string end_detail=this.txtend_detail.Text;
			int num=int.Parse(this.txtnum.Text);
			string num_detail=this.txtnum_detail.Text;
			decimal cleaning_fee=decimal.Parse(this.txtcleaning_fee.Text);
			string fapiao_taitou=this.txtfapiao_taitou.Text;
			string basketball_time=this.txtbasketball_time.Text;
			string fantang=this.txtfantang.Text;
			int fangka_print=int.Parse(this.txtfangka_print.Text);
			int yuedu_shuoming=int.Parse(this.txtyuedu_shuoming.Text);
			string fengongsi=this.txtfengongsi.Text;
			DateTime date=DateTime.Parse(this.txtdate.Text);

			Maticsoft.Model.branch_company model=new Maticsoft.Model.branch_company();
			model.peixunban_id=peixunban_id;
			model.start_detail=start_detail;
			model.end_detail=end_detail;
			model.num=num;
			model.num_detail=num_detail;
			model.cleaning_fee=cleaning_fee;
			model.fapiao_taitou=fapiao_taitou;
			model.basketball_time=basketball_time;
			model.fantang=fantang;
			model.fangka_print=fangka_print;
			model.yuedu_shuoming=yuedu_shuoming;
			model.fengongsi=fengongsi;
			model.date=date;

			Maticsoft.BLL.branch_company bll=new Maticsoft.BLL.branch_company();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
