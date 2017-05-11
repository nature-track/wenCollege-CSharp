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
namespace Maticsoft.Web.shangke_view
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		Maticsoft.BLL.shangke_view bll=new Maticsoft.BLL.shangke_view();
        int id = Convert.ToInt16(Request.QueryString["id"]);
		Maticsoft.Model.shangke_view model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblkechengneirong_id.Text=model.kechengneirong_id.ToString();
		this.lblpeixunban.Text=model.peixunban;
		this.lblpeixunban_id.Text=model.peixunban_id.ToString();
		this.lblkecheng.Text=model.kecheng;
		this.lbljiangshi_id.Text=model.jiangshi_id.ToString();
		this.lbljiangshi.Text=model.jiangshi;
		this.lblkeshi.Text=model.keshi.ToString();

	}


    }
}
