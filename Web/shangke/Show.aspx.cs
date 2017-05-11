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
namespace Maticsoft.Web.shangke
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
		Maticsoft.BLL.shangke bll=new Maticsoft.BLL.shangke();
		Maticsoft.Model.shangke model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblqishu.Text=model.qishu;
		this.lblkecheng.Text=model.kecheng;
		this.lbljiangshi.Text=model.jiangshi;
		this.lblkeshi.Text=model.keshi.ToString();

	}


    }
}
