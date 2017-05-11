using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.teacher
{
    public partial class m_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.Model.member mem_mod = new Model.member();
            mem_mod.openid = Session["open_id"].ToString();
            mem_mod.name = TextBox1.Text.Trim();
            mem_mod.time = DateTime.Now;
            mem_mod.style = "2";
            Maticsoft.BLL.member mem_bll = new BLL.member();
            string str = mem_bll.updatedata(mem_mod);
            Response.Write("<script>alert('"+str+"，我们会尽快与您确认信息')</script>");
        }
    }
}