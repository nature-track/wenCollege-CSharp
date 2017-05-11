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
namespace Maticsoft.Web.wuzi_diaoyong
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
		Maticsoft.BLL.wuzi_diaoyong bll=new Maticsoft.BLL.wuzi_diaoyong();
		Maticsoft.Model.wuzi_diaoyong model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblwuzi_id.Text=model.wuzi_id.ToString();
		this.lblfengongsi.Text=model.fengongsi;
		this.lblnum.Text=model.num.ToString();
		this.lblpeixunbanid.Text=model.peixunbanid.ToString();
		this.lblstyle.Text=model.style.ToString();
		this.lbltime.Text=model.time.ToString();
		this.lblbeizhu.Text=model.beizhu;
		this.lblbeizhu2.Text=model.beizhu2;

	}


    }
}
