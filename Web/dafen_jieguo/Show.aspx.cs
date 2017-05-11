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
namespace Maticsoft.Web.dafen_jieguo
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
		Maticsoft.BLL.dafen_jieguo bll=new Maticsoft.BLL.dafen_jieguo();
		Maticsoft.Model.dafen_jieguo model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblshangke_id.Text=model.shangke_id.ToString();
		this.lblfenzu_id.Text=model.fenzu_id.ToString();
		this.lblfenshu.Text=model.fenshu.ToString();
		this.lblneirong.Text=model.neirong;
		this.lbldafen_xuhao.Text=model.dafen_xuhao.ToString();

	}


    }
}
