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
namespace Maticsoft.Web.branch_company
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
		Maticsoft.BLL.branch_company bll=new Maticsoft.BLL.branch_company();
		Maticsoft.Model.branch_company model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblpeixunban_id.Text=model.peixunban_id.ToString();
		this.lblstart_detail.Text=model.start_detail;
		this.lblend_detail.Text=model.end_detail;
		this.lblnum.Text=model.num.ToString();
		this.lblnum_detail.Text=model.num_detail;
		this.lblcleaning_fee.Text=model.cleaning_fee.ToString();
		this.lblfapiao_taitou.Text=model.fapiao_taitou;
		this.lblbasketball_time.Text=model.basketball_time.ToString();
		this.lblfantang.Text=model.fantang;
		this.lblfangka_print.Text=model.fangka_print.ToString();
		this.lblyuedu_shuoming.Text=model.yuedu_shuoming.ToString();
		this.lblfengongsi.Text=model.fengongsi;
		this.lbldate.Text=model.date.ToString();

	}


    }
}
