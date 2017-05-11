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
    public partial class admin_count : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
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

            ds = bll.GetList(strWhere.ToString());
            qishu.DataSource = ds;
            qishu.DataTextField = "name";
            qishu.DataValueField = "id";
            qishu.DataBind();
            Bindkecheng();
            
        }
        public void Bindkecheng()
        {
            Maticsoft.BLL.fenshu_tongji_fenxiang fstj = new BLL.fenshu_tongji_fenxiang();
            string str = "name= '" + qishu.SelectedItem.Text.ToString() + "'";
            kecheng.DataSource = fstj.get_kecheng(str);
            kecheng.DataTextField = "kecheng";
            kecheng.DataValueField = "shangke_id";
            kecheng.DataBind();
            
        }

        public void grid1bind()
        {
            Maticsoft.BLL.fenshu_tongji fstj = new BLL.fenshu_tongji();
            string str = "peixunban= '" + qishu.SelectedItem.Text.ToString() + "'";
            GridView1.DataSource = fstj.GetList(str);
            GridView1.DataBind();
        }
        public void grid2bind()
        {
            Maticsoft.BLL.fenshu_tongji_fenxiang fstjfx = new BLL.fenshu_tongji_fenxiang();
            string str = "peixunban_id=" + qishu.SelectedValue + " and count_fenshu > 0";
            GridView2.DataSource = fstjfx.GetList(str);
            GridView2.DataBind();
        }
        public void gird3bind()
        {
            Maticsoft.BLL.fenshu_list_view flv_bll = new BLL.fenshu_list_view();
            string str = "[peixunban]= '" + qishu.SelectedItem.Text.ToString()+"'";
            DataTable dt2 = flv_bll.getdistinct_list(str);
            DataTable dt = flv_bll.GetList("DATALENGTH(neirong)>2").Tables[0];

            GridView3.DataSource = getnewtable(dt, dt2);
            GridView3.DataBind();
        }
        public void grid4bind()
        {
            Maticsoft.BLL.fenshu_list_view flv_bll = new BLL.fenshu_list_view();
            string str = "[peixunban]= '" + qishu.SelectedItem.Text.ToString() + "'";
            DataTable dt2 = flv_bll.getdistinct_list_total(str);
            DataTable dt = flv_bll.GetList("DATALENGTH(neirong)>2").Tables[0];
            GridView4.DataSource = getnewtable(dt, dt2);
            GridView4.DataBind();
        }
        public void grid5bind()
        {
            Maticsoft.BLL.fenshu_list_view flv_bll = new BLL.fenshu_list_view();
            string str = "[peixunban]= '" + qishu.SelectedItem.Text.ToString() + "'";
            DataTable dt = flv_bll.get_yuanyi(str);
            StringBuilder strbu = new StringBuilder();
            strbu.Append("愿意的数目为"+count_yuanyi(dt,"愿意")+"，");
            strbu.Append("看情况的数目为" + count_yuanyi(dt, "看情况") + "，");
            strbu.Append("不愿意的数目为" + count_yuanyi(dt, "不愿意") + "。");
            yuanyi.Text = strbu.ToString();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            grid1bind();
            grid2bind();
            gird3bind();
            grid4bind();
            grid5bind();
        }

        protected void qishu_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid1bind();
            grid2bind();
            gird3bind();
            grid4bind();
            grid5bind();
            Bindkecheng();
        }

        protected void kecheng_SelectedIndexChanged(object sender, EventArgs e)
        {
            Maticsoft.BLL.fenshu_tongji_fenxiang fstjfx = new BLL.fenshu_tongji_fenxiang();
            string str = "peixunban_id=" + qishu.SelectedValue + " and count_fenshu > 0";
            str += " and kecheng='" + kecheng.SelectedItem.Text.ToString()+"'";
            GridView2.DataSource = fstjfx.GetList(str);
            GridView2.DataBind();
           
        }

        /// <summary>
        /// 给dt2增加一列，然后把dt1上面的"neirong"列归类添加进去
        /// </summary>
        /// <param name="dt1">一个内容就一列的冗余性很大的表</param>
        /// <param name="dt2">dt2是所有11、12题都有内容的课程</param>
        /// <returns></returns>
        private DataTable getnewtable(DataTable dt1, DataTable dt2)
        {
            dt2.Columns.Add("pingjia", typeof(string));
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                for (int j = 0; j < dt1.Rows.Count; j++)
                {
                    if (dt2.Rows[i]["peixunban_id"].ToString() == dt1.Rows[j]["peixunban_id"].ToString() & dt2.Rows[i]["shangke_id"].ToString() == dt1.Rows[j]["shangke_id"].ToString() & dt2.Rows[i]["dafenbiao_id"].ToString() == dt1.Rows[j]["dafenbiao_id"].ToString())
                    {
                        dt2.Rows[i]["pingjia"] = dt2.Rows[i]["pingjia"].ToString() + "<br /> ·" + dt1.Rows[j]["neirong"].ToString();
                    }
                }
            }
            return dt2;
        }

        private int count_yuanyi(DataTable dt, string str)
        {
            int count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["neirong"].ToString() == str) { count++; }
            }
            return count;
        }
    }
}