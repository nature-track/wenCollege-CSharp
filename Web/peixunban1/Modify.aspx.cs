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
                    ShowInfo_branch(id);
				}
			}
		}
                static string id_load = "";
	private void ShowInfo(int id)
	{
		Maticsoft.BLL.peixunban1 bll=new Maticsoft.BLL.peixunban1();
		Maticsoft.Model.peixunban1 model=bll.GetModel(id);
		id_load=model.id.ToString();
		this.txtstart_time.Text=model.start_time.ToString();
		this.txtend_time.Text=model.end_time.ToString();
		this.txtname.Text=model.name;
        this.txtcontact.Text = model.contact;
        this.txtbeizhu.Text = model.beizhu;
        this.txtphone.Text = model.phone;

	}
    private void ShowInfo_branch(int id)
    {
        Maticsoft.BLL.branch_company bll = new Maticsoft.BLL.branch_company();
        Maticsoft.Model.branch_company model = bll.GetModel_bypeixunban(id);

        this.txtstart_detail.Text = model.start_detail;
        this.txtend_detail.Text = model.end_detail;
        this.txtnum.Text = model.num.ToString();
        this.txtnum_detail.Text = model.num_detail;
        this.txtcleaning_fee.Text = model.cleaning_fee.ToString();
        this.txtfapiao_taitou.Text = model.fapiao_taitou;
        this.txtbasketball_time.Text = model.basketball_time.ToString();
        this.txtfantang.Text = model.fantang;
        //this.txtfangka_print.Text = model.fangka_print.ToString();
        //xishu_yongpin.Text = model.xishu_yongpin.ToString();
        if (model.xishu_yongpin == 1) { xishu.SelectedIndex = 0; } else { xishu.SelectedIndex = 1; };
        if (model.fangka_print == 1) { fangka_print.SelectedIndex = 0; } else { fangka_print.SelectedIndex = 1; };

    }

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtstart_time.Text))
			{
				strErr+="开始时间格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtend_time.Text))
			{
				strErr+="结束时间格式错误！\\n";	
			}
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="培训班名称不能为空！\\n";	
			}
            if (this.txtcontact.Text.Trim().Length == 0)
            {
                strErr += "联系人不能为空！\\n";
            }


            if (this.txtphone.Text.Trim().Length == 0)
            {
                strErr += "联系电话不能为空！\\n";
            }
			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(id_load);
			DateTime start_time=DateTime.Parse(this.txtstart_time.Text);
			DateTime end_time=DateTime.Parse(this.txtend_time.Text);
			string name=this.txtname.Text;
            string contact = this.txtcontact.Text;
            int sinal = 2;
            string beizhu = this.txtbeizhu.Text;
            string phone = this.txtphone.Text;

			Maticsoft.Model.peixunban1 model=new Maticsoft.Model.peixunban1();
			model.id=id;
			model.start_time=start_time;
			model.end_time=end_time;
			model.name=name;
            model.contact = contact;
            model.sinal = sinal;
            model.beizhu = beizhu;
            model.phone = phone;


			Maticsoft.BLL.peixunban1 bll=new Maticsoft.BLL.peixunban1();
			bll.Update(model);

            #region 开始branch_company表的数据更新
            Maticsoft.BLL.branch_company bnc_bll = new BLL.branch_company();
            Maticsoft.Model.branch_company bnc_mod = bnc_bll.GetModel_bypeixunban(id);


            if (this.txtstart_detail.Text.Trim().Length == 0)
            {
                strErr += "入住具体时间不能为空！\\n";
            }
            if (this.txtend_detail.Text.Trim().Length == 0)
            {
                strErr += "退房具体时间不能为空！\\n";
            }
            if (!PageValidate.IsNumber(txtnum.Text))
            {
                strErr += "人数格式错误！\\n";
            }

            if (!PageValidate.IsDecimal(txtcleaning_fee.Text))
            {
                strErr += "清洁费用格式错误！\\n";
            }
            if (this.txtfapiao_taitou.Text.Trim().Length == 0)
            {
                strErr += "发票抬头不能为空！\\n";
            }

            if (this.txtfantang.Text.Trim().Length == 0)
            {
                strErr += "饭堂订餐不能为空！\\n";
            }
            //if (!PageValidate.IsNumber(txtfangka_print.Text))
            //{
            //    strErr += "fangka_print格式错误！\\n";
            //}


            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }


            string start_detail = this.txtstart_detail.Text;
            string end_detail = this.txtend_detail.Text;
            int num = int.Parse(this.txtnum.Text);
            string num_detail = this.txtnum_detail.Text;
            decimal cleaning_fee = decimal.Parse(this.txtcleaning_fee.Text);
            string fapiao_taitou = this.txtfapiao_taitou.Text;
            string basketball_time = this.txtbasketball_time.Text;
            string fantang = this.txtfantang.Text;
            //int fangka_print1 = int.Parse(this.txtfangka_print.Text);



            Maticsoft.Model.branch_company model_branch = new Maticsoft.Model.branch_company();
            model_branch.id = bnc_mod.id;
            model_branch.peixunban_id = id;
            model_branch.start_detail = start_detail;
            model_branch.end_detail = end_detail;
            model_branch.num = num;
            model_branch.num_detail = num_detail;
            model_branch.cleaning_fee = cleaning_fee;
            model_branch.fapiao_taitou = fapiao_taitou;
            model_branch.basketball_time = basketball_time;
            model_branch.fantang = fantang;
            model_branch.fangka_print =Convert.ToInt16( fangka_print.SelectedValue) ;
            model_branch.fengongsi = bnc_mod.fengongsi;
            model_branch.date = DateTime.Today;
            model_branch.xishu_yongpin = Convert.ToInt16(xishu.SelectedValue); 
            Maticsoft.BLL.branch_company bll_branch = new Maticsoft.BLL.branch_company();
            bll_branch.Update(model_branch);
            #endregion
            Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
