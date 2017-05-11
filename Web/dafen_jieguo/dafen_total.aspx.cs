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
    public partial class dafen_total : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                BindGrid();
                loaddata();


            }
        }
        int with = 0;
        Maticsoft.Model.shangke_view skv = new Model.shangke_view();
        public void loaddata()
        {
            if (Session["shangke_vie"] == null)
            {
                Response.Redirect("start.aspx");
            }
            else
            {
                skv = (Maticsoft.Model.shangke_view)Session["shangke_vie"];
                peixunban.Text = skv.peixunban;
                kecheng.Text = skv.kecheng;
                zuming.Text = skv.fenzu;
                jiangshi.Text = skv.jiangshi;

                with = Convert.ToInt16(Request.QueryString["with"]);
                foreach (GridViewRow row in VoteView.Rows)
                {
                    if (with > 650)
                    {
                        ((RadioButtonList)row.FindControl("RadioButtonList2")).RepeatColumns = 10;
                    }
                    else if (with > 350)
                    {
                        ((RadioButtonList)row.FindControl("RadioButtonList2")).RepeatColumns = 5;
                    }
                    else
                    {
                        ((RadioButtonList)row.FindControl("RadioButtonList2")).RepeatColumns = 4;
                    }
                }


            }
        }
        /// <summary>
        /// 获取打分表信息，绑定到表格
        /// </summary>
        public void BindGrid()
        {
            Maticsoft.BLL.dafenbiao dfb = new BLL.dafenbiao();
            DataSet ds = dfb.GetList("id>=13 and id <= 20 order by id");
            VoteView.DataSource = ds;
            VoteView.DataBind();
            DataSet ds2 = dfb.GetList("id=21");
            View_yiyuan.DataSource = ds2;
            View_yiyuan.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            skv = (Maticsoft.Model.shangke_view)Session["shangke_vie"];


            int count = 0;
            //获取每一行的打分序号以及得分数
            foreach (GridViewRow row in VoteView.Rows)
            {

                RadioButtonList rbl = (RadioButtonList)row.FindControl("RadioButtonList2");
                Label lb = (Label)row.FindControl("id_Label");

                Maticsoft.Model.dafen_jieguo dfjg_m = new Model.dafen_jieguo();
                dfjg_m.shangke_id = skv.id;
                dfjg_m.fenzu_id = skv.fenzu_id;
                dfjg_m.fenshu = Convert.ToInt16(rbl.SelectedValue.ToString());
                dfjg_m.dafen_xuhao = Convert.ToInt16(lb.Text);
                dfjg_m.time = DateTime.Now;
                Maticsoft.BLL.dafen_jieguo dfjg_b = new BLL.dafen_jieguo();
                if (dfjg_b.Add(dfjg_m) != 0)
                {
                    count++;
                }
                else
                {
                    count = -10000;
                };
            }

            foreach (GridViewRow row in View_yiyuan.Rows)
            {
                RadioButtonList rbl2 = (RadioButtonList)row.FindControl("RadioButtonList2");
                Label lb2 = (Label)row.FindControl("id_Label");
                Maticsoft.Model.dafen_jieguo dfjg_m2 = new Model.dafen_jieguo();
                dfjg_m2.shangke_id = skv.id;
                dfjg_m2.fenzu_id = skv.fenzu_id;
                dfjg_m2.neirong = rbl2.SelectedValue;
                dfjg_m2.dafen_xuhao = Convert.ToInt16(lb2.Text);
                dfjg_m2.time = DateTime.Now;
                Maticsoft.BLL.dafen_jieguo dfjg_b2 = new BLL.dafen_jieguo();
                if (dfjg_b2.Add(dfjg_m2) != 0)
                {
                    count++;
                }
                else
                {
                    count = -10000;
                };
            }
            if (count == 0)
            {
                Response.Write("<script>alert('提交不成功!')</script>");
            }
            else
            {
                Session["dafen_shu"] = count;
                tixing.Text = "共提交" + count + "行数据";
                tixing.CssClass = "alert";
                Response.Redirect("pingjia.aspx?style=2");
                //Literal1.Text = @"<script language='javascript' type='text/javascript'> window.location.href = 'pingjia.aspx' ; </script> ";
            }

        }
    }
}