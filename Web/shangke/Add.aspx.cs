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
namespace Maticsoft.Web.shangke
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        static  string peixunban_id = "";
        public void BindData()
        {

            peixunban_id = Request.QueryString["peixunban_id"];
            
            Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("id=" + peixunban_id);
            ds = bll.GetList(strWhere.ToString());
            Label1.Text = ds.Tables[0].Rows[0]["name"].ToString();
            //DropDownList1.DataSource = ds;
            //DropDownList1.DataTextField = "name";
            //DropDownList1.DataValueField = "id";
            //DropDownList1.DataBind();
            //DropDownList1.SelectedValue = peixunban_id.ToString();

            Maticsoft.BLL.kecheng_neirong bll2 = new BLL.kecheng_neirong();
            DataSet ds2 = new DataSet();
            ds2 = bll2.GetList("");
            DropDownList2.DataSource = ds2;
            DropDownList2.DataTextField = "name";
            DropDownList2.DataValueField = "id";
            DropDownList2.DataBind();

            Maticsoft.BLL.teacher bll3 = new BLL.teacher();
            DataSet ds3 = new DataSet();
            ds3 = bll3.GetList("");
            DropDownList3.DataSource = ds3;
            DropDownList3.DataTextField = "name";
            DropDownList3.DataValueField = "id";
            DropDownList3.DataBind();


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //string strErr="";
            //if(this.txtqishu.Text.Trim().Length==0)
            //{
            //    strErr+="qishu不能为空！\\n";	
            //}
            //if(this.txtkecheng.Text.Trim().Length==0)
            //{
            //    strErr+="kecheng不能为空！\\n";	
            //}
            //if(this.txtjiangshi.Text.Trim().Length==0)
            //{
            //    strErr+="jiangshi不能为空！\\n";	
            //}
            //if(!PageValidate.IsDecimal(txtkeshi.Text))
            //{
            //    strErr+="keshi格式错误！\\n";	
            //}

            //if(strErr!="")
            //{
            //    MessageBox.Show(this,strErr);
            //    return;
            //}
            string qishu = peixunban_id;
            string kecheng = this.DropDownList2.SelectedValue;
            string jiangshi = this.DropDownList3.SelectedValue;
            decimal keshi = decimal.Parse(this.txtkeshi.Text);

            Maticsoft.Model.shangke model = new Maticsoft.Model.shangke();
            model.qishu = qishu;
            model.kecheng = kecheng;
            model.jiangshi = jiangshi;
            model.keshi = keshi;

            Maticsoft.BLL.shangke bll = new Maticsoft.BLL.shangke();
            bll.Add(model);
            string url = "add.aspx?peixunban_id=" + peixunban_id;
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", url);

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("../shangke_view/list.aspx");
        }
    }
}
