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
namespace Maticsoft.Web.inv_option
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddata();
            }          
        }
        public void loaddata()
        {
            Maticsoft.BLL.inv_que que_bll = new BLL.inv_que();
            inv_que.DataSource = que_bll.GetList("");
            inv_que.DataTextField = "text";
            inv_que.DataValueField = "id";
            inv_que.DataBind();
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";

			if(this.txttext.Text.Trim().Length==0)
			{
				strErr+="text不能为空！\\n";	
			}
			if(this.txtstyle.Text.Trim().Length==0)
			{
				strErr+="style不能为空！\\n";	
			}
			if(this.txtbeizhu.Text.Trim().Length==0)
			{
				strErr+="beizhu不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int que_id=int.Parse(inv_que.SelectedValue);
			string text=this.txttext.Text;
			string style=this.txtstyle.Text;
			string beizhu=this.txtbeizhu.Text;

			Maticsoft.Model.inv_option model=new Maticsoft.Model.inv_option();
			model.que_id=que_id;
			model.text=text;
			model.style=style;
			model.beizhu=beizhu;

			Maticsoft.BLL.inv_option bll=new Maticsoft.BLL.inv_option();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
