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
namespace Maticsoft.Web.peixunban1
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Maticsoft.BLL.peixunban1 bll=new Maticsoft.BLL.peixunban1();
		Maticsoft.Model.peixunban1 model=bll.GetModel(id);

		this.lblstart_time.Text=Convert.ToDateTime( model.start_time.ToString()).ToShortDateString();
		this.lblend_time.Text=Convert.ToDateTime( model.end_time.ToString()).ToShortDateString();
		this.lblname.Text=model.name;
        contact.Text = model.contact;
        phone.Text = model.phone;
        beizhu.Text = model.beizhu;
        Maticsoft.BLL.branch_company bhc_bll = new BLL.branch_company();
        Maticsoft.Model.branch_company bhc_mod = bhc_bll.GetModel_bypeixunban(id);
        start_detail.Text = bhc_mod.start_detail.ToString();
        end_detail.Text = bhc_mod.end_detail.ToString();
        num.Text = bhc_mod.num.ToString() + "人";
        num_detail.Text = bhc_mod.num_detail.ToString();
        cleaning_fee.Text = bhc_mod.cleaning_fee.ToString() + "元";
        fapiao_taitou.Text = bhc_mod.fapiao_taitou.ToString();
        basketball_time.Text = bhc_mod.basketball_time.ToString();
        fantang.Text = bhc_mod.fantang.ToString();
        fangka_print.Text = (bhc_mod.fangka_print == 1 ? "不打印名字" : "打印名字");
        xishu_yongpin.Text = (bhc_mod.xishu_yongpin == 1 ? "简易洗漱用品" : "旅行套装");

	}


    }
}
