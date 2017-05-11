using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace Maticsoft.Web.photos
{
    public partial class show : System.Web.UI.Page
    {
        protected  void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                
                Literal1.Text = photos("kbfz");
            }
            dataload();
        }

        static int qishu = 0;
        static string pxb_name = "";
        protected void dataload()
        {
            qishu = Convert.ToInt16(Request.QueryString["qishu"]);
            if (qishu != 0)
            {
                Maticsoft.BLL.peixunban1 pxb = new BLL.peixunban1();
                pxb_name = pxb.GetList("id=" + qishu).Tables[0].Rows[0]["name"].ToString();
                biaoti.Text = pxb_name;
            }
            else
            {
                Response.Redirect("showlist.aspx");
            }

            Maticsoft.BLL.photos ph = new BLL.photos();
            DataTable dtph = ph.get_fenlei(qishu.ToString()).Tables[0];
            if (dtph.Rows.Count > 0)
            {
                TableRow row = new TableRow();
                for (int i = 0; i < dtph.Rows.Count; i++)
                {
                    TableCell cell = new TableCell();
                    Button bt = new Button();
                    bt.Text = dtph.Rows[i][0].ToString();
                    bt.Click += new EventHandler(bt_Click);
                    cell.Controls.Add(bt);
                    row.Cells.Add(cell);
                }
                Table1.Rows.Add(row);
            }
        }

        void bt_Click(object sender, EventArgs e)
        {
            Literal1.Text = photos(((Button)sender).Text);
            //throw new NotImplementedException();
        }

        protected void rzxy_Click(object sender, EventArgs e)
        {

            Literal1.Text = photos("kbfz");
        }

        private string photos(string leibie)
        {
            Maticsoft.BLL.photos ph = new BLL.photos();
            DataTable dt = ph.GetList("qishu = " + qishu + " and fenlei2 = '" + leibie + "' and ContentType = 'image/jpeg'").Tables[0];
            
            
            StringBuilder str = new StringBuilder();
            string big_name = "";
            if (dt.Rows.Count == 0)
            {
                str.Append("此类别暂无照片");
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    big_name = dt.Rows[i]["FileName"].ToString().Replace("_small_", "");
                    str.Append("<li class='item-thumbs col-lg-3 design' data-id='id-0' data-type='" + leibie + "'>");
                    str.Append("<a class='hover-wrap fancybox' data-fancybox-group='gallery' title='" + pxb_name + "' href='../images/" + big_name + "'");
                    str.Append("<span class='overlay-img'></span>");
                    str.Append("<span class='overlay-img-thumb'><i class='icon-info-blocks fa fa-search'></i></span></a>");
                    str.Append("<img src='../images/" + dt.Rows[i]["FileName"] + "' alt=''></li>");
                }
            }
            return str.ToString();
        }

        protected void tz_Click(object sender, EventArgs e)
        {
            Literal1.Text = photos("tz");
        }

        protected void qywh_Click(object sender, EventArgs e)
        {
            Literal1.Text = photos("qywh");
        }

        protected void jyfx_Click(object sender, EventArgs e)
        {
            Literal1.Text = photos("jyfx");
        }

        protected void bianlun_Click(object sender, EventArgs e)
        {
            Literal1.Text = photos("bianlun");
        }

        protected void yj_Click(object sender, EventArgs e)
        {
            Literal1.Text = photos("yj");
        }

        protected void wh_Click(object sender, EventArgs e)
        {
            Literal1.Text = photos("wh");
        }

        protected void bj_Click(object sender, EventArgs e)
        {
            Literal1.Text = photos("bj");
        }
    }
}