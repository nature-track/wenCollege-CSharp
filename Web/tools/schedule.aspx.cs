using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Maticsoft.Web.tools
{
    public partial class schedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //loadeven();
        }

        public string loadeven()
        {
            string str = "";
            Maticsoft.BLL.peixunban1 pxb = new BLL.peixunban1();
            DataTable dt = pxb.GetList("").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str += "{ title:'";
                str += dt.Rows[i]["name"].ToString()+"（"+dt.Rows[i]["contact"].ToString()+"）";
                str += "',";
                str += "start: new Date("+date_geshi(Convert.ToDateTime(dt.Rows[i]["start_time"].ToString()),1)+"),";
                str += "end: new Date(" + date_geshi(Convert.ToDateTime(dt.Rows[i]["end_time"].ToString()),1) + ")},";
            }

            return str;
        }

        public string loadeven2()
        {
            string str = "";
            Maticsoft.BLL.event1 eve = new BLL.event1();
            DataTable dt=eve.GetList("").Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str += "{ title:'" + dt.Rows[i]["event_name"].ToString() + "',";
                str += "start: new Date(" + date_geshi(Convert.ToDateTime(dt.Rows[i]["sta_time"].ToString()), 2) + "),";
                str += "end: new Date(" + date_geshi(Convert.ToDateTime(dt.Rows[i]["end_time"].ToString()), 2) + "),";
                str += "allDay: false},";
            }
            return str;
        }





        private string date_geshi(DateTime dtime,int i)
        {
            string str = "";
            str += dtime.Year.ToString() + ",";
            str += dtime.Date.AddMonths(-1).Month.ToString()  + ",";
            str += dtime.Day.ToString() ;
            if (i == 1)
            {
                return str;
            }
            else
            {
                str += "," + dtime.Hour.ToString() + ",";
                str += dtime.Minute.ToString();
                return str;
            }
        }
    }
}