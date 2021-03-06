﻿using System;
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
namespace Maticsoft.Web.kecheng_neirong
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		Maticsoft.BLL.kecheng_neirong bll=new Maticsoft.BLL.kecheng_neirong();
		Maticsoft.Model.kecheng_neirong model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtname.Text=model.name;
		this.txtqita.Text=model.qita;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtname.Text.Trim().Length==0)
			{
				strErr+="name不能为空！\\n";	
			}
			if(this.txtqita.Text.Trim().Length==0)
			{
				strErr+="qita不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string name=this.txtname.Text;
			string qita=this.txtqita.Text;


			Maticsoft.Model.kecheng_neirong model=new Maticsoft.Model.kecheng_neirong();
			model.id=id;
			model.name=name;
			model.qita=qita;

			Maticsoft.BLL.kecheng_neirong bll=new Maticsoft.BLL.kecheng_neirong();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
