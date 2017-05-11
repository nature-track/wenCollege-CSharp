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


namespace Maticsoft.Web.dafen_jieguo
{
    public partial class tongji : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                databind();
                gridbind();
            }
        }

        int buer_int = 1;
        Maticsoft.Model.shangke_view skv = new Model.shangke_view();
        int qishu;
        public void databind()
        {
            if (Session["shangke_vie"] == null)
            {
                Response.Redirect("start.aspx");
            }
            else
            {
                skv = (Maticsoft.Model.shangke_view)Session["shangke_vie"];
                peixunban.Text = skv.peixunban;

                DataSet ds = new DataSet();
                Maticsoft.BLL.fenzu fz = new BLL.fenzu();
                ds = fz.GetList("qishu= "+skv.peixunban_id);
                fenzu.DataSource = ds;
                fenzu.DataTextField = "zuming";
                fenzu.DataValueField = "id";
                fenzu.DataBind();
                if (Session["dafen_shu"] != null)
                {
                    Response.Write("<script>alert('提交成功')</script>");
                }


            }
            
            

        }

        public void gridbind()
        {
            
            Maticsoft.BLL.huishou_tongji hstj = new BLL.huishou_tongji();
            string str="fenzu_id="+Convert.ToInt16(fenzu.SelectedValue.ToString());
            GridView1.DataSource= hstj.GetList(str);
            GridView1.DataBind();
            //Session["open_id"] = "ozBiSt0zxI4W3ROkC4Xf0IxAC_Qg"; 

                            if (Session["open_id"] != null)
                {
                    Maticsoft.BLL.fenshu_list_view fs_l_v_bll = new BLL.fenshu_list_view();
                    GridView2.DataSource = fs_l_v_bll.get_by_openid(Session["open_id"].ToString().Trim(), skv.peixunban_id);
                    GridView2.DataBind();
                }
        }

        protected void fenzu_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridbind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Literal1.Text = @"<script language='javascript' type='text/javascript'> window.location.href = 'start.aspx' ; </script> ";
            Response.Redirect("start.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            gridbind();
            buer_int = 2;
        }


        public string buer1()
        {
            if (buer_int==1)
            {
                return "false";
            }
            else
            {
                return "true";
            }
        }
        public string buer2()
        {
            if (buer_int==1)
            {
                return "ture";
            }
            else
            {
                return "false";
            }
        }


    }
}