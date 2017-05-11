using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

namespace Maticsoft.Web.video
{
    public partial class show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                dataload();
            }
        }

        protected void dataload()
        {
            int qishu = 0;
            qishu = Convert.ToInt16(Request.QueryString["qishu"]);
            if (qishu != 0)
            {
                Maticsoft.BLL.peixunban1 pxb = new BLL.peixunban1();
                Literal biaoti = (Literal)Page.Master.FindControl("Literal1");
                biaoti.Text = pxb.GetList("id=" + qishu).Tables[0].Rows[0]["name"].ToString()+"总结视频";
                StringBuilder str = new StringBuilder();                         
                Maticsoft.BLL.photos ph = new BLL.photos();
                DataTable dt = ph.GetList("qishu =" + qishu + " and fileExtension = '.mp4'").Tables[0];
                if (dt.Rows.Count == 0)
                {
                  Literal1.Text = "暂无视频";
                }
                else
                {
                    string video_url = "../images/" + dt.Rows[0]["FileName"].ToString();
                    string _type = dt.Rows[0]["ContentType"].ToString();
                    str.Append(" <video id='example_video_1' class='video-js vjs-default-skin' controls preload='none' width='800' height='550'   poster='http://video-js.zencoder.com/oceans-clip.png'   data-setup='{}'>");
                    str.Append(" <source src='" + video_url + "' type='" + _type + "' />");
                    str.Append("<track kind='captions' src='demo.captions.vtt' srclang='en' label='English'></track><!-- Tracks need an ending tag thanks to IE9 -->");
                    str.Append(" <track kind='subtitles' src='demo.captions.vtt' srclang='en' label='English'></track><!-- Tracks need an ending tag thanks to IE9 -->");
                    Literal1.Text = str.ToString();
                }
                
            }
            else
            {
                Response.Redirect("showlist.aspx");
            }
        }
    }
}