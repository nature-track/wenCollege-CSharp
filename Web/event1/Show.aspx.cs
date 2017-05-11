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
namespace Maticsoft.Web.event1
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
		Maticsoft.BLL.event1 bll=new Maticsoft.BLL.event1();
		Maticsoft.Model.event1 model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblsta_time.Text=model.sta_time.ToString();
		this.lblend_time.Text=model.end_time.ToString();
		this.lblevent_name.Text=model.event_name;
		this.lblbeizhu.Text=model.beizhu;

	}


    }
}
