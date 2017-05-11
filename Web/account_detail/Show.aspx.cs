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
namespace Maticsoft.Web.account_detail
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
		Maticsoft.BLL.account_detail bll=new Maticsoft.BLL.account_detail();
		Maticsoft.Model.account_detail model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblwuzi.Text=model.wuzi;
		this.lbldanwei.Text=model.danwei;
		this.lbldanjia.Text=model.danjia.ToString();
		this.lblshuliang.Text=model.shuliang.ToString();
		this.lblaccount_id.Text=model.account_id.ToString();
		this.lblwuzi_id.Text=model.wuzi_id.ToString();
		this.lblbeizhu.Text=model.beizhu;
		this.lblbeizhu2.Text=model.beizhu2;
		this.lblbeizhu3.Text=model.beizhu3;

	}


    }
}
