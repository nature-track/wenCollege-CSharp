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
namespace Maticsoft.Web.supplier
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
		Maticsoft.BLL.supplier bll=new Maticsoft.BLL.supplier();
		Maticsoft.Model.supplier model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblperson.Text=model.person;
		this.lblphone.Text=model.phone;
		this.lblphone2.Text=model.phone2;
		this.lblbank.Text=model.bank;
		this.lblbank_num.Text=model.bank_num;
		this.lbladdress.Text=model.address;
		this.lblstyle.Text=model.style.ToString();
		this.lblleibie.Text=model.leibie.ToString();
		this.lblwuzi.Text=model.wuzi;
		this.lblbeizhu.Text=model.beizhu;
		this.lblbeizhu2.Text=model.beizhu2;

	}


    }
}
