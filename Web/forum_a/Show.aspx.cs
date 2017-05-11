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
namespace Maticsoft.Web.forum_a
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
		Maticsoft.BLL.forum_a bll=new Maticsoft.BLL.forum_a();
		Maticsoft.Model.forum_a model=bll.GetModel();
		this.lblid.Text=model.id.ToString();
		this.lblque_id.Text=model.que_id.ToString();
		this.lblname.Text=model.name;
		this.lblteam.Text=model.team;
		this.lblanswer.Text=model.answer;
		this.lbltime.Text=model.time.ToString();
		this.lblpassword.Text=model.password.ToString();
		this.lblfenshu.Text=model.fenshu.ToString();
		this.lblbeizhu.Text=model.beizhu;
		this.lblbeizhu2.Text=model.beizhu2;

	}


    }
}
