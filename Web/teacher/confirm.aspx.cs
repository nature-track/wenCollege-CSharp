using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Maticsoft.Web.teacher
{
    public partial class confirm : System.Web.UI.Page
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
            Maticsoft.BLL.member mem_bll = new BLL.member();
            DataTable dt = mem_bll.GetList("fenzu_id is null and style='2'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                openid.Text = dt.Rows[0]["openid"].ToString();
                name.Text = dt.Rows[0]["name"].ToString();
                date_time.Text = dt.Rows[0]["time"].ToString();
                Maticsoft.BLL.weixin wx_bll = new BLL.weixin();
                weixn_nickname.Text = wx_bll.get_userinfo(dt.Rows[0]["openid"].ToString(), wx_bll.get_accesstoken())[0].nickname;
                Maticsoft.BLL.teacher tea_bll = new BLL.teacher();
                DataSet ds = tea_bll.GetList("");
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
            }
        }
        protected void confirm_btn_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.member mem_bll = new BLL.member();
            Maticsoft.Model.member mem_mod = new Model.member();
            mem_mod.openid = openid.Text;
            mem_mod.name = name.Text;
            mem_mod.style = "2";
            mem_mod.time = DateTime.Now;
            mem_mod.fenzu_id = Convert.ToInt16(DropDownList1.SelectedValue);
        }
    }
}