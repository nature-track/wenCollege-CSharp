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
namespace Maticsoft.Web.inv_option
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
		Maticsoft.BLL.inv_option bll=new Maticsoft.BLL.inv_option();
		Maticsoft.Model.inv_option model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblque_id.Text=model.que_id.ToString();
		this.lbltext.Text=model.text;
		this.lblstyle.Text=model.style;
		this.lblbeizhu.Text=model.beizhu;

	}


    }
}
