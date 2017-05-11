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

namespace Maticsoft.Web.peixunban1
{
    public partial class branch_add2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddata();
            }
        }
        Maticsoft.Model.peixunban1 pxb = new Model.peixunban1();
        Maticsoft.Model.branch_company bcp = new Model.branch_company();
        static int num = 0;
        static int peixunbanid = 0;
        public void loaddata()
        {
            if (Session["peixunban"] == null)
            {
                Response.Redirect("branch_add.aspx");
            }
            else
            {
                if (Convert.ToInt16( Session["screen"]) == 1)
                {
                    Literal_css.Text = "<link href='css/form_css.css' rel='stylesheet' type='text/css' />";
                }
                else
                {
                    Literal_css.Text = "<link href='css/form_moblie.css' rel='stylesheet' type='text/css' />";
                }
                pxb = (Maticsoft.Model.peixunban1)Session["peixunban"];
                num = Convert.ToInt16(pxb.beizhu);
                peixunbanid = pxb.id;
                Literal1.Text = pxb.name;
                cleaning_fee.Text = clean_fee(Convert.ToInt16(pxb.beizhu)).ToString();
                fantang.Text = dingcan(Convert.ToDateTime( pxb.start_time), Convert.ToDateTime(pxb.end_time), Convert.ToInt16(pxb.beizhu));
            }
        }

        private int clean_fee(int fee)
        {
            int sum = 0;
            if (fee > 50)
            {
                sum = fee * 100 + 1000;
            }
            else if (fee > 45)
            {
                sum = fee * 100 + 800;
            }
            else if (fee > 30)
            {
                sum = fee * 100 + 600;
            }
            else if (fee > 15)
            {
                sum = fee * 100 + 400;
            }
            else
            {
                sum = fee * 100;
            }
            return sum;
        }

        private string dingcan(DateTime str_time, DateTime end_time, int num)
        {
            string str = "";
            str += "分公司举办" + pxb.name + "，需要订餐：从";
            str += str_time.Date.Month.ToString() + "月" + str_time.Date.Day.ToString() + "日到" + end_time.Date.Month.ToString() + "月" + end_time.Date.Day.ToString() + "日，";
            str += "每天早中晚三餐，各" + weizhuo(num) + "桌。";
            return str;
        }
        private int weizhuo(int num)
        {
            int weizhu = 1;
            if(num>55){weizhu =7;}
            else if(num>45){weizhu=6;}
            else if(num>35){weizhu=5;}
            else if (num > 25) { weizhu = 4; }
            else if (num > 15) { weizhu = 3; }
            else if (num > 8) { weizhu = 2; }
            else { weizhu = 1; }
            return weizhu;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string strErr = "";

            if (this.start_detail.Text.Trim().Length == 0)
            {
                strErr += "入住时间明细不能为空！\\n";
            }
            if (this.end_detail.Text.Trim().Length == 0)
            {
                strErr += "退房时间明细不能为空！\\n";
            }


            if (!PageValidate.IsDecimal(cleaning_fee.Text))
            {
                strErr += "清洁费必须为数字！\\n";
            }
            if (this.fapiao_taitou.Text.Trim().Length == 0)
            {
                strErr += "发票抬头不能为空！\\n";
            }

            if (this.fantang.Text.Trim().Length == 0)
            {
                strErr += "fantang不能为空！\\n";
            }
            //if (!PageValidate.IsNumber(txtyuedu_shuoming.Text))
            //{
            //    strErr += "yuedu_shuoming格式错误！\\n";
            //}

            if (strErr != "")
            {
                MessageBox.Show(this, strErr);
                return;
            }
            AccountsPrincipal user = new AccountsPrincipal(Context.User.Identity.Name);
            User currentUser = new LTP.Accounts.Bus.User(user);
            bcp.peixunban_id = peixunbanid;
            bcp.num = num;
            bcp.start_detail = start_detail.Text.Trim();
            bcp.end_detail = end_detail.Text.Trim();
            bcp.num_detail = num_detail.Text.Trim();
            bcp.cleaning_fee =Convert.ToDecimal( cleaning_fee.Text.Trim());
            bcp.fapiao_taitou = fapiao_taitou.Text.Trim();
            bcp.basketball_time = basketball_time.Text.Trim();
            bcp.fantang = fantang.Text.Trim();
            bcp.fangka_print = Convert.ToInt16( fangka_print.SelectedValue);
            bcp.xishu_yongpin = Convert.ToInt16(xishu.SelectedValue);
            bcp.fengongsi = currentUser.TrueName;
            bcp.date = DateTime.Today;


            Maticsoft.BLL.branch_company bcp_bll = new Maticsoft.BLL.branch_company();
            bcp_bll.Add(bcp);
            Maticsoft.BLL.peixunban1 pxb_bll = new BLL.peixunban1();
            pxb.id = peixunbanid;
            pxb.beizhu=beizhu.Text.Trim();
            pxb_bll.Update_beizhu(pxb);
            Maticsoft.Common.MessageBox.ShowAndRedirect(this, "保存成功！", "list.aspx");
        }
    
    }
}