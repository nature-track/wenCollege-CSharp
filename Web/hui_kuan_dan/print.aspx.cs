using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.hui_kuan_dan
{
    public partial class print : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loaddata();
            }   
        }
        private void loaddata()
        {
            if (Session["hui_mod"] == null)
            {
                Maticsoft.Common.MessageBox.ShowAndRedirect(this, "没有数据，请核实", "add.aspx");
            }
            else
            {
               Maticsoft.Model.hui_kuan_dan hui_mod=new Model.hui_kuan_dan();
                hui_mod=(Maticsoft.Model.hui_kuan_dan)Session["hui_mod"];
                huikuan_neirong.Text = hui_mod.huikuan_neirong;
                xiangmu_mingcheng.Text = hui_mod.xiangmu_mingcheng;
                xiangmu_zongkuan.Text = string.Format("{0:F}", hui_mod.xiangmu_zongkuan);
                yifu_jine.Text = hui_mod.yifu_jine.ToString();
                zhifu_shijian.Text = hui_mod.zhifu_shijian.ToString();
                benci_jine.Text = string.Format("{0:F}", hui_mod.benci_jine);
                yuji_yukuan.Text = hui_mod.yuji_yukuan.ToString();
                int supplier_id =Convert.ToInt16( hui_mod.supplier_id);
                Maticsoft.Model.supplier sup_mod = new Model.supplier();
                Maticsoft.BLL.supplier sup_bll = new BLL.supplier();
                sup_mod = sup_bll.GetModel(supplier_id);
                name.Text = sup_mod.name;
                bank.Text = sup_mod.bank;
                bank_num.Text = sup_mod.bank_num;
                date_time.Text = DateTime.Today.ToShortDateString();
                RMB.Text = Maticsoft.Common.Rmb.CmycurD(Convert.ToDecimal( hui_mod.benci_jine));
            }
        }
    }
}