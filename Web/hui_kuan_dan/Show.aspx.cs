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
namespace Maticsoft.Web.hui_kuan_dan
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
		Maticsoft.BLL.hui_kuan_dan bll=new Maticsoft.BLL.hui_kuan_dan();
		Maticsoft.Model.hui_kuan_dan model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblhuikuan_neirong.Text=model.huikuan_neirong;
		this.lblxiangmu_mingcheng.Text=model.xiangmu_mingcheng;
		this.lblxiangmu_zongkuan.Text=model.xiangmu_zongkuan.ToString();
		this.lblyifu_jine.Text=model.yifu_jine.ToString();
		this.lblzhifu_shijian.Text=model.zhifu_shijian.ToString();
		this.lblbenci_jine.Text=model.benci_jine.ToString();
		this.lblyuji_yukuan.Text=model.yuji_yukuan.ToString();
		this.lblsupplier_id.Text=model.supplier_id.ToString();
		this.lblleibie.Text=model.leibie.ToString();
		this.lblbeizhu.Text=model.beizhu;

	}


    }
}
