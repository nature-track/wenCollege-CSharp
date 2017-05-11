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
    public partial class dafen : System.Web.UI.Page
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
            }else
            {      
                skv =(Maticsoft.Model.shangke_view) Session["shangke_vie"];
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
            if (Session["userinfo"] == null)
            {
                Response.Write(@"<script>alert('错了')</script>");
            }

        }
        /// <summary>
        /// 获取打分表信息，绑定到表格
        /// </summary>
        public void BindGrid()
        {
            Maticsoft.BLL.dafenbiao dfb = new BLL.dafenbiao();
            DataSet ds = dfb.GetList(10,"","id" );
            VoteView.DataSource = ds;
            VoteView.DataBind();
        }


        ///// <summary>
        ///// 获取上课内容视图的信息，就是哪一期培训班哪些课程
        ///// </summary>
        ///// <param name="qishu">培训班期数序号</param>
        ///// <param name="kecheng_id">课程序号</param>
        ///// <returns></returns>
        //public DataSet get_kecheng(int qishu, int kecheng_id)
        //{
        //    Maticsoft.BLL.dafen_jieguo dfj= new BLL.dafen_jieguo();
        //    DataSet ds = new DataSet();
        //    ds = dfj.get_shangke_view(qishu, kecheng_id);

        //    return ds;
        //}
        /// <summary>
        /// 根据培训班期数与组号获取组名
        /// </summary>
        /// <param name="qishu">期数</param>
        /// <param name="fenzu">组名</param>
        public void get_zuming(int qishu, int fenzu)
        {
            Maticsoft.BLL.fenzu fz = new BLL.fenzu();
            string str="qishu = "+qishu+"and zushu ="+fenzu;
            DataSet ds = fz.GetList(str);
            zuming.Text = ds.Tables[0].Rows[0]["zuming"].ToString();
        }

        protected void VoteView_RowDataBound(object sender, GridViewRowEventArgs e)
        {   ///找到添加控件的Panel
            //Panel ItemPanel = (Panel)e.Row.FindControl("ItemPanel");
            //RadioButtonList radioList = new RadioButtonList();
            //radioList.ID = "radioList";
            /////绑定控件的数据
            //radioList.Items.Add("1");
            //radioList.Items.Add("2");
            ///////显示控件

            //ItemPanel.Controls.Add(radioList);
           
            
            

        }

        private void BindItemData(RadioButtonList radioList)
        {
            Maticsoft.BLL.fenzu fz = new BLL.fenzu();
            DataSet ds2 = new DataSet();
            ds2 = fz.GetList("");
            radioList.DataSource = ds2.Tables[0];
            radioList.DataTextField = "id";
            radioList.DataValueField = "id";
            radioList.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            skv = (Maticsoft.Model.shangke_view)Session["shangke_vie"];
            if (Session["userinfo"] == null)
            {
                Response.Write(@"<script>alert('无法获取您的微信号，返回首页');window.location='start.aspx'</script>");
            }
            else
            {
                Maticsoft.Model.weixin_userinfo wx_u_mod = (Maticsoft.Model.weixin_userinfo)Session["userinfo"];
                    int count = 0;
                    //获取每一行的打分序号以及得分数
                   foreach( GridViewRow row in VoteView.Rows){
               
                            RadioButtonList rbl = (RadioButtonList)row.FindControl("RadioButtonList2");
                            Label lb = (Label)row.FindControl("id_Label");

                            Maticsoft.Model.dafen_jieguo dfjg_m = new Model.dafen_jieguo();
                            dfjg_m.shangke_id = skv.id;
                            dfjg_m.fenzu_id = skv.fenzu_id;
                            dfjg_m.fenshu =Convert.ToInt16( rbl.SelectedValue.ToString());
                            dfjg_m.dafen_xuhao = Convert.ToInt16(lb.Text);
                            dfjg_m.time = DateTime.Now;
                            dfjg_m.open_id =wx_u_mod.openid;
                            dfjg_m.name = wx_u_mod.remark;
                            dfjg_m.beizhu =wx_u_mod.nickname;
                            Maticsoft.BLL.dafen_jieguo dfjg_b = new BLL.dafen_jieguo();
                            int dafen_id = dfjg_b.get_id(Convert.ToInt16( dfjg_m.shangke_id), Convert.ToInt16( dfjg_m.dafen_xuhao), dfjg_m.open_id);
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
                       tixing.Text = "共提交" + count + "行数据";
                       tixing.CssClass = "alert";
                       Response.Redirect("pingjia.aspx?style=1");
                       //Literal1.Text = @"<script language='javascript' type='text/javascript'> window.location.href = 'pingjia.aspx' ; </script> ";
                   }
            }
        }









    }

}