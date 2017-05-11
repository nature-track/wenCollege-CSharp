using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.m_weixin
{
    public partial class investigate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
                loaddata();
            }
        }

        public void loaddata()
        {
        }

        public void BindGrid()
        {
            if (Request.QueryString["inv_n"] == null)
            {
                Response.Redirect("inv_index.aspx");
            }
            else
            {
                int inv_n = Convert.ToInt16(Request.QueryString["inv_n"]);
                Maticsoft.BLL.inv_que que_bll = new BLL.inv_que();
                GridView1.DataSource = que_bll.GetList("[que_n_id] = " + inv_n);
                GridView1.DataBind();

                foreach (GridViewRow row in GridView1.Rows)
                {
                    int id = Convert.ToInt16(((Label)row.FindControl("id_Label")).Text);
                    string style = ((Label)row.FindControl("style_Label")).Text.Trim();
                    if (style == "单选题")
                    {
                        ((RadioButtonList)row.FindControl("RadioButtonList1")).Visible = true;
                        ((TextBox)row.FindControl("TextBox1")).Visible = false;
                        Maticsoft.BLL.inv_option opt_bll = new BLL.inv_option();
                        ((RadioButtonList)row.FindControl("RadioButtonList1")).DataSource = opt_bll.GetList("que_id = " + id);
                        ((RadioButtonList)row.FindControl("RadioButtonList1")).DataTextField = "text";
                        ((RadioButtonList)row.FindControl("RadioButtonList1")).DataValueField = "id";
                        ((RadioButtonList)row.FindControl("RadioButtonList1")).DataBind();
                    }
                    else if (style == "问答题")
                    {
                        ((RadioButtonList)row.FindControl("RadioButtonList1")).Visible = false;
                        ((TextBox)row.FindControl("TextBox1")).Visible = true;
                    }
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.inv_answer ans_bll = new BLL.inv_answer();
            int i = 0;
            foreach (GridViewRow row in GridView1.Rows)
            {
                Maticsoft.Model.inv_answer ans_mod = new Model.inv_answer();
                string style = ((Label)row.FindControl("style_Label")).Text.Trim();
                RadioButtonList rbl = (RadioButtonList)row.FindControl("RadioButtonList1");
                ans_mod.que_id = Convert.ToInt16(((Label)row.FindControl("id_Label")).Text);
                if (style == "单选题")
                {
                    ans_mod.option_id = Convert.ToInt16(rbl.SelectedValue);
                }
                else if (style == "问答题")
                {
                    ans_mod.an_text = ((TextBox)row.FindControl("TextBox1")).Text.Trim();
                }
                ans_mod.time = DateTime.Now;
                if (Session["open_id"] != null)
                {
                    ans_mod.open_id = Session["open_id"].ToString();
                }
                if (Session["name"] != null)
                {
                    ans_mod.name = Session["name"].ToString();
                }
                i+= ans_bll.Add(ans_mod);
            }
            if (i > 0)
            {
                Response.Write("<script>alert('感谢您的配合');window.location='index.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('数据写入失败')</script>");
            }
        }


    }
}