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
    public partial class start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddata();
                BindData();
                buer_hidd.Value = "1";

            }
        }
        public string str_tiao = "";
        
        Maticsoft.Model.shangke_view skv = new Model.shangke_view();
        /// <summary>
        /// 主要用于判定是否有绑定微信号
        /// </summary>
        public void loaddata()
        {
            if (Session["userinfo"] == null)
            {
                Response.Write(@"<script>alert('无法获取您的微信号，返回首页');window.location='..\m_weixin\index.aspx'</script>");
            }
            else
            {
                Maticsoft.Model.weixin_userinfo wx_u_mod =(Maticsoft.Model.weixin_userinfo) Session["userinfo"];
                mem_info.Text = "尊敬的" + wx_u_mod.remark + "(" + wx_u_mod.nickname + ")，您的评价是课程不断改进的基础，请认真填写";
            }
        }

        /// <summary>
        /// 获取培训班信息、课程内容信息，绑定两个下拉框
        /// </summary>
        public void BindData()
        {

            Maticsoft.BLL.peixunban1 bll = new Maticsoft.BLL.peixunban1();
            DataSet ds = new DataSet();
            StringBuilder strWhere = new StringBuilder();
            strWhere.Append("[start_time] < '");
            strWhere.Append(DateTime.Today.AddDays(30).Date.ToShortDateString());
            strWhere.Append("' and [end_time] > '");
            strWhere.Append(DateTime.Today.AddDays(-30).Date.ToShortDateString());
            strWhere.Append("'");
            ds = bll.GetList(strWhere.ToString());
            qishu.DataSource = ds;
            qishu.DataTextField = "name";
            qishu.DataValueField = "id";
            qishu.DataBind();

            Maticsoft.BLL.kecheng_neirong bll2 = new BLL.kecheng_neirong();
            DataSet ds2 = new DataSet();
            ds2 = bll2.GetList("");
            kecheng.DataSource = ds2;
            kecheng.DataTextField = "name";
            kecheng.DataValueField = "id";
            kecheng.DataBind();


            fen_zu(Convert.ToInt16(qishu.SelectedValue));
            ke_cheng(Convert.ToInt16(qishu.SelectedValue));


            if (Session["shangke_vie"] != null)
            {
                Session["shangke_vie"] = null;
            }



        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Write("<script languge='javascript'>alert('成功改动')</script>");

                tiaozhuan();
        }
        /// <summary>
        /// 填入培训班实体的相关属性
        /// </summary>
        /// <param name="qishu">培训班期数id</param>
        /// <param name="kecheng_id">课程内容id</param>
        ///  <param name="fenzu_id">分组id</param>
        public void fil_shangke_view(int qishu, int kecheng_id,int fenzu_id)
        {
            skv.peixunban_id = qishu;
            skv.kechengneirong_id = kecheng_id;
            DataSet ds = new DataSet();
            ds = get_kecheng(qishu, kecheng_id);
            skv.id = Convert.ToInt16( ds.Tables[0].Rows[0]["id"].ToString());
            skv.jiangshi_id = Convert.ToInt16(ds.Tables[0].Rows[0]["jiangshi_id"].ToString());
            skv.jiangshi = ds.Tables[0].Rows[0]["jiangshi"].ToString();
            skv.kecheng = ds.Tables[0].Rows[0]["kecheng"].ToString();
            skv.peixunban = ds.Tables[0].Rows[0]["peixunban"].ToString();
            skv.fenzu_id =Convert.ToInt16( get_zuming(qishu, fenzu_id, "xuhao"));
            skv.fenzu = get_zuming(qishu, fenzu_id, "zuming");
           
        }

        public void tiaozhuan()
        {
            if(kecheng.SelectedValue=="" || fenzu.SelectedValue=="")
            {
                Response.Write("<script>alert('暂无课程或分组，请检查!')</script>"); 
            }else
            {
                fil_shangke_view(Convert.ToInt16(qishu.SelectedValue), Convert.ToInt16(kecheng.SelectedValue), Convert.ToInt16(fenzu.SelectedValue));
                Session["shangke_vie"] = skv;
                Response.Redirect("confirm.aspx");
            }
            
            ////string str = "dafen.aspx";
            //Literal1.Text = @"<script language='javascript' type='text/javascript'> window.location.href = 'confirm.aspx' ; </script> ";

            // //Response.Write("<script languge='javascript'>alert('成功改动')</script>");
            ////Response.Redirect(str);

        }
        /// <summary>
        /// 填入相关信息到实体shangke_vie
        /// </summary>
        public void fill_text()
        {
            if (kecheng.SelectedValue == "" || fenzu.SelectedValue == "")
            {
                Response.Write("<script>alert('暂无课程或分组，请检查!')</script>");
            }
            else
            {
                int qishu1 = Convert.ToInt16(qishu.SelectedValue);
                int fenzu1 = Convert.ToInt16(fenzu.SelectedValue.ToString());
                int kecheng_id1 = Convert.ToInt16(kecheng.SelectedValue);
                DataSet ds = new DataSet();
                ds = get_kecheng(qishu1, kecheng_id1);
            
            //fil_shangke_view(Convert.ToInt16(qishu.SelectedValue), Convert.ToInt16(kecheng.SelectedValue),Convert.ToInt16(fenzu.SelectedValue));
            //jiangshi.Text = skv.jiangshi;
            ////fenzu_id.Text = get_zuming(qishu1, fenzu1, "xuhao");
            //zuming.Text = skv.fenzu;
            //kecheng_neirong.Text = skv.kecheng;
            //peixunban.Text = skv.peixunban;

            fil_shangke_view(Convert.ToInt16(qishu.SelectedValue), Convert.ToInt16(kecheng.SelectedValue), Convert.ToInt16(fenzu.SelectedValue));
            Session["shangke_vie"] = skv;
            }
        }
        /// <summary>
        /// 获取上课内容视图的信息，就是哪一期培训班哪些课程
        /// </summary>
        /// <param name="qishu">培训班期数序号</param>
        /// <param name="kecheng_id">课程序号</param>
        /// <returns></returns>
        public DataSet get_kecheng(int qishu, int kecheng_id)
        {
            Maticsoft.BLL.shangke_view skv = new BLL.shangke_view();
            
            Maticsoft.BLL.dafen_jieguo dfj = new BLL.dafen_jieguo();
            DataSet ds = new DataSet();
            string str="[peixunban_id]= "+qishu +" and [kechengneirong_id]= "+kecheng_id;
            ds = skv.GetList(str);
            //ds = dfj.get_shangke_view(qishu, kecheng_id);

            return ds;
        }
        /// <summary>
        /// 给分组下拉框绑定数据，根据组数
        /// </summary>
        /// <param name="qishu">第几期培训班</param>
        public void fen_zu(int qishu)
        {
            Maticsoft.BLL.fenzu fz = new BLL.fenzu();
            string str = "qishu=" + qishu;
            DataSet ds = fz.GetList(str);
            fenzu.Items.Clear();
            string[] zu_arr = new string[] { "第一组", "第二组", "第三组", "第四组", "第五组", "第六组", "第七组", "第八组" };
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                fenzu.Items.Add(new ListItem(zu_arr[i],(i+1).ToString()));
            }
        }

        public void ke_cheng(int qishu)
        {
            Maticsoft.BLL.shangke_view skv = new BLL.shangke_view();
            string str = "peixunban_id=" + qishu;
            DataSet ds = skv.GetList(str);
            kecheng.DataSource = ds;
            kecheng.DataTextField = "kecheng";
            kecheng.DataValueField = "kechengneirong_id";
            kecheng.DataBind();
        }
        /// <summary>
        /// 根据培训班期数与组号获取组名或序号
        /// </summary>
        /// <param name="qishu">期数</param>
        /// <param name="fenzu">组名</param>
        /// /// <param name="fenzu">识别"zuming" "xuhao"</param>
        public string get_zuming(int qishu, int fenzu, string shibie)
        {
            Maticsoft.BLL.fenzu fz = new BLL.fenzu();
            string str = "qishu = " + qishu + "and zushu =" + fenzu;
            DataSet ds = fz.GetList(str);
            if (ds.Tables[0].Rows.Count == 0)
            {
                Response.Write("<script>alert('该组尚未录入组名，请检查!')</script>"); 

                return "0";
            }
            else
            {
                if (shibie == "zuming")
                {
                    return ds.Tables[0].Rows[0]["zuming"].ToString();
                }
                else if (shibie == "xuhao")
                {
                    return ds.Tables[0].Rows[0]["id"].ToString();
                }
                else
                {
                    return "false";
                }
            }

        }

        //protected void kecheng_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    fill_text();
        //}

        //protected void fenzu_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    fill_text();
        //}

        protected void Button2_Click(object sender, EventArgs e)
        {

            fill_text();
            if (Session["shangke_vie"] == null)
            {
                Response.Write("<script>alert('请先选择培训班期数与组号!')</script>"); 
            }
            else
            {
                Response.Redirect("tongji.aspx");
            }
        }

        protected void qishu_SelectedIndexChanged(object sender, EventArgs e)
        {
            fen_zu(Convert.ToInt16( qishu.SelectedValue));
            ke_cheng(Convert.ToInt16(qishu.SelectedValue));
        }

        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    fill_text();
        //    buer_hidd.Value = "2";
        //}
    }
}