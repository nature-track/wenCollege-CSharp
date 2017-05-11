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
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using LTP.Accounts.Bus;

namespace Maticsoft.Web.fenzu
{
    public partial class Add : Page
    {

        Maticsoft.BLL.fenzu bll_fenzu = new Maticsoft.BLL.fenzu();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                
                BindData();

            }
        }



       

        
        public void BindData()
        {

            Label1.Text = Request.QueryString["name"];
            Label2.Text = Request.QueryString["qishu"];
            //Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            //DataSet ds = new DataSet();
            //StringBuilder strWhere = new StringBuilder();

            //ds = bll.GetList(strWhere.ToString());
            //DropDownList2.DataSource = ds;
            //DropDownList2.DataTextField = "name";
            //DropDownList2.DataValueField = "id";
            //DropDownList2.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            string strErr = "";
            //if(this.txtqishu.Text.Trim().Length==0)
            //{
            //    strErr+="qishu不能为空！\\n";	
            //}
            //if(!PageValidate.IsNumber(txtzushu.Text))
            //{
            //    strErr+="zushu格式错误！\\n";	
            //}
            if (this.txtzuming.Text.Trim().Length == 0)
            {
                strErr += "zuming不能为空！\\n";
            }

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            //string qishu = this.DropDownList2.SelectedValue;
            int zushu = int.Parse(this.DropDownList1.SelectedValue);
            string zuming = this.txtzuming.Text;

            Maticsoft.Model.fenzu model = new Maticsoft.Model.fenzu();
            model.qishu = Label2.Text.ToString().Trim();
            model.zushu = zushu;
            model.zuming = zuming;

            Maticsoft.BLL.fenzu bll = new Maticsoft.BLL.fenzu();
            bll.Add(model);
            string add_str = "add.aspx?qishu=" + Label2.Text+"&name="+Label1.Text;
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", add_str);

        }


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }



 


    }
}
