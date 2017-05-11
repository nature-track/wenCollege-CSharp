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
namespace Maticsoft.Web.forum_q
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
		Maticsoft.BLL.forum_q bll=new Maticsoft.BLL.forum_q();
		Maticsoft.Model.forum_q model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblteam.Text=model.team;
		this.lblquestion.Text=model.question;
		this.lbltime.Text=model.time.ToString();
		this.lblpassword.Text=model.password.ToString();
		this.lblpeixunban.Text=model.peixunban.ToString();
		this.lblfenshu.Text=model.fenshu.ToString();
		this.lblstyle.Text=model.style.ToString();
		this.lblbeizhu.Text=model.beizhu;
		this.lblbeizhu2.Text=model.beizhu2;

	}


    }
}
