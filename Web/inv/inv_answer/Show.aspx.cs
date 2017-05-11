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
namespace Maticsoft.Web.inv_answer
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
		Maticsoft.BLL.inv_answer bll=new Maticsoft.BLL.inv_answer();
		Maticsoft.Model.inv_answer model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lbloption_id.Text=model.option_id.ToString();
		this.lblan_int.Text=model.an_int.ToString();
		this.lblan_text.Text=model.an_text;
		this.lblopen_id.Text=model.open_id;
		this.lblname.Text=model.name;
		this.lbltime.Text=model.time.ToString();
		this.lblbeizhu.Text=model.beizhu;

	}


    }
}
