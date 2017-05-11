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
using Maticsoft.Common;
using LTP.Accounts.Bus;

namespace Maticsoft.Web.peixunban1
{
    public partial class branch_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
                

            }
        }
        public void BindData()
        {
            if (Session["peixunban"] != null)
            {
                Session["peixunban"] = null;
            }
            int i=Convert.ToInt16(Request.QueryString["screen"]);
            if (i == 1)
            {
                Literal_css.Text="<link href='css/form_css.css' rel='stylesheet' type='text/css' />";
                Session["screen"] = 1;
            }
            else
            {
                Literal_css.Text = "<link href='css/form_moblie.css' rel='stylesheet' type='text/css' />";
                Session["screen"]=2;
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (!PageValidate.IsDateTime(start_time.Text))
            {
                strErr += "开始时间格式错误！\\n";
            }
            if (!PageValidate.IsDateTime(end_time.Text))
            {
                strErr += "结束时间格式错误！\\n";
            }
            if (this.peixunban_name.Text.Trim().Length == 0)
            {
                strErr += "培训班名称不能为空！\\n";
            }
            if (this.contact_per.Text.Trim().Length == 0)
            {
                strErr += "联系人不能为空！\\n";
            }
            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }

            Maticsoft.Model.peixunban1 pxb = new Model.peixunban1();
            pxb.name = peixunban_name.Text.Trim();
            pxb.contact = contact_per.Text.Trim();
            pxb.phone = phone.Text.Trim();
            pxb.start_time = DateTime.Parse(start_time.Text);
            pxb.end_time = DateTime.Parse(end_time.Text);
            pxb.sinal = 2;
            pxb.beizhu = num.Text;
            
            Maticsoft.BLL.peixunban1 pxb_bll = new BLL.peixunban1();
           int id=  pxb_bll.Add(pxb);
           pxb.id = id;
           Session["peixunban"] = pxb;
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "branch_add2.aspx");
        }
    }
}