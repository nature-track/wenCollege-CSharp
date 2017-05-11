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
namespace Maticsoft.Web.account
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
                    ShowGrid(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		Maticsoft.BLL.account bll=new Maticsoft.BLL.account();
		Maticsoft.Model.account model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblname.Text=model.name;
		this.lblleibei.Text=model.leibei;
		this.lbllururen.Text=model.lururen;
		this.lbltime.Text=model.time.ToString();
        if (model.peixunban_id != 0)
        {
            Maticsoft.BLL.peixunban1 pei_bll = new BLL.peixunban1();
            Maticsoft.Model.peixunban1 pei_mol = new Model.peixunban1();
            pei_mol = pei_bll.GetModel(Convert.ToInt16(model.peixunban_id));
            this.lblpeixunban_id.Text = pei_mol.name;
        }
		this.lblbeizhu.Text=model.beizhu;
	}
    private void ShowGrid(int id)
    {
        Maticsoft.BLL.account_detail acc_d_bll = new BLL.account_detail();
        DataTable dt = acc_d_bll.GetList("[account_id]=" + id).Tables[0];

        GridView1.DataSource = add_xiaoji(dt);
        GridView1.DataBind();
    }
    private DataTable add_xiaoji(DataTable dt)
    {
        float sum = 0;
        dt.Columns.Add("xiaoji", typeof(float));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt.Rows[i]["xiaoji"] = Convert.ToDecimal(dt.Rows[i]["danjia"]) * Convert.ToDecimal(dt.Rows[i]["shuliang"]);
            sum +=(float) dt.Rows[i]["xiaoji"];
        }
        sum_id.Text = sum.ToString();
        return dt;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
      Literal1.Text= GridView1.Rows[0].Cells[0].Text;
      Response.Redirect("../hui_kuan_dan/add.aspx?detail_id=" + GridView1.Rows[0].Cells[0].Text);
    }




    }
}
