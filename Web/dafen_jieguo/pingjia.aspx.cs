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
    public partial class pingjia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                BindGrid();
                loaddata();
               
            }
        }
        Maticsoft.Model.shangke_view skv = new Model.shangke_view();
        public void loaddata()
        {
            if (Session["shangke_vie"] == null)
            {
                //Literal1.Text = @"<script language='javascript' type='text/javascript'> window.location.href = 'start.aspx' ; </script> ";
                Response.Redirect("start.aspx");
            }
            else
            {
                skv = (Maticsoft.Model.shangke_view)Session["shangke_vie"];
                peixunban.Text = skv.peixunban;
                kecheng.Text = skv.kecheng;
                zuming.Text = skv.fenzu;
                jiangshi.Text = skv.jiangshi;
                
            }
        }

        /// <summary>
        /// 获取打分表信息，绑定到表格
        /// </summary>
        public void BindGrid()
        {
            Maticsoft.BLL.dafenbiao dfb = new BLL.dafenbiao();
            int style = Convert.ToInt16( Request.QueryString["style"]);
            DataSet ds = new DataSet();
            if (style == 1)
            {
                ds = dfb.GetList("id>=11 and id<=12 order by id");
            }
            else
            {
                ds = dfb.GetList("id>=22 order by id");
            }
            VoteView.DataSource = ds;
            VoteView.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            skv = (Maticsoft.Model.shangke_view)Session["shangke_vie"];
            string open_id = "";
            string name = "";
            string nickname = "";
            if (Session["userinfo"] == null)
            {
                Response.Write(@"<script>alert('无法获取您的微信号，返回首页');window.location='start.aspx'</script>");
            }
            else
            {
                Maticsoft.Model.weixin_userinfo wx_u_mod = (Maticsoft.Model.weixin_userinfo)Session["userinfo"];
                open_id = wx_u_mod.openid;
                name = wx_u_mod.remark;
                nickname = wx_u_mod.nickname;
                int count = 0;
                //获取每一行的打分序号以及得分数
                foreach (GridViewRow row in VoteView.Rows)
                {

                    TextBox teb = (TextBox)row.FindControl("TextBox1");
                    Label lb = (Label)row.FindControl("id_Label");

                    Maticsoft.Model.dafen_jieguo dfjg_m = new Model.dafen_jieguo();
                    dfjg_m.shangke_id = skv.id;
                    dfjg_m.fenzu_id = skv.fenzu_id;
                    dfjg_m.neirong = teb.Text.ToString().Trim();
                    dfjg_m.dafen_xuhao = Convert.ToInt16(lb.Text);
                    dfjg_m.time = DateTime.Now;
                    dfjg_m.open_id = open_id;
                    dfjg_m.name = name;
                    dfjg_m.beizhu = nickname;
                    Maticsoft.BLL.dafen_jieguo dfjg_b = new BLL.dafen_jieguo();
                    int dafen_id = dfjg_b.get_id(Convert.ToInt16(dfjg_m.shangke_id), Convert.ToInt16(dfjg_m.dafen_xuhao), dfjg_m.open_id);
                    if (dafen_id == 0)
                    {
                        if (dfjg_b.Add(dfjg_m) != 0)
                        {
                            count++;
                        }
                        else
                        {
                            count = -10000;
                        };
                    }
                    else
                    {
                        dfjg_m.id = dafen_id;
                        if (dfjg_b.Update(dfjg_m))
                        {
                            count++;
                        }
                        else
                        {
                            count = -10000;
                        };
                    }
                }
                if (count == 0)
                {

                    Response.Write("<script>alert('提交不成功!')</script>");
                }
                else
                {
                    Session["dafen_shu"] = count;
                    tixing.Text = count.ToString();
                    Response.Redirect("tongji.aspx");
                    //Literal1.Text = @"<script language='javascript' type='text/javascript'> window.location.href = 'tongji.aspx' ; </script> ";
                }
            }

            
        }


    }
}