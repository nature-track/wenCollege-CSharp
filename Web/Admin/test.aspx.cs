using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Sms.Model.V20160927;

namespace Maticsoft.Web.Admin
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
         }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.temp tem = new BLL.temp();
            Label1.Text= tem.sent_message();
        }
    }
       
}