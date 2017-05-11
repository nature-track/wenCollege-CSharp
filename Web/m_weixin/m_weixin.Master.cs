using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Script.Serialization;
using System.Data;
using System.Text;
using System.IO;
using System.Xml;
using System.Web.Security;

namespace Maticsoft.Web.weixin
{
    public partial class m_weixin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //loaddata();
                loaddata1();
            }
        }
        string code = "";
        public void loaddata1()
        {
            if (Session["userinfo"] == null)
            {
                code = Request.QueryString["code"];
                if (string.IsNullOrEmpty(code))
                {
                    Response.Write("<script>alert('请从微信端登陆系统!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('感谢您进入温氏学院系统!')</script>");
                    Maticsoft.BLL.weixin wx_bll = new BLL.weixin();
                    Maticsoft.Model.access_web_token awt_mod = new Model.access_web_token();
                    awt_mod = wx_bll.get_web_accesstoken(code)[0];
                    if (awt_mod == null || string.IsNullOrEmpty(awt_mod.openid))
                    {
                        Response.Write("<script>alert('无法获取你的识别号!')</script>");
                    }
                    else
                    {
                        string opend_id = awt_mod.openid;
                        string accesstonken = awt_mod.access_token;
                        Maticsoft.Model.weixin_userinfo wx_u_mod = wx_bll.get_userinfo(opend_id, accesstonken)[0];

                        if (wx_u_mod == null)
                        {
                            Response.Write("<script>alert('无法获取你的微信信息!')</script>");
                        }
                        else
                        {
                            openid.Text = "您好，" + wx_u_mod.remark + "(" + wx_u_mod.nickname + "),欢迎进入温氏学院测试系统";
                            touxiang.ImageUrl = wx_u_mod.headimgurl;
                            Session["userinfo"] = wx_u_mod;
                            //if(string.IsNullOrEmpty(wx_u_mod.remark))
                            //{
                            //    Response.Write("<script>alert('请录入个人信息');window.location='mem_info_fill.aspx'</script>");
                            //}
                        }
                    }
                }
            }
            else
            {
                Maticsoft.Model.weixin_userinfo wx_u_mod = (Maticsoft.Model.weixin_userinfo)Session["userinfo"];
                Maticsoft.BLL.member mem_bll = new BLL.member();
                wx_u_mod.remark = mem_bll.get_name(wx_u_mod.openid);
                openid.Text = "您好，" + wx_u_mod.remark + "(" + wx_u_mod.nickname + "),欢迎进入温氏学院测试系统";
                touxiang.ImageUrl = wx_u_mod.headimgurl;
                Session["userinfo"] = wx_u_mod;
            }
           // code = Request.QueryString["code"];
           // //WebClient requestClinet1 = new WebClient();
           // //string jsonArray1 = requestClinet1.DownloadString("https://api.weixin.qq.com/sns/oauth2/access_token?appid=zheshiyigejiadeid&secret=zhendemimazaibendibaocun&code=" + code + "&grant_type=authorization_code");
           
            
           // Maticsoft.BLL.weixin wx_bll = new BLL.weixin();

           // Maticsoft.Model.access_web_token awt_mod = new Model.access_web_token();
           // awt_mod = wx_bll.get_web_accesstoken(code)[0];
           //string  opend_id=  awt_mod.openid;
           // string accesstonken=awt_mod.access_token;
           //Literal1.Text = code + "色打发士大夫大师傅个" +opend_id+"士大夫士大夫" +accesstonken;
           //Maticsoft.Model.weixin_userinfo wx_u_mod = wx_bll.get_userinfo(opend_id, accesstonken)[0];
           //openid.Text = wx_u_mod.nickname;
           //touxiang.ImageUrl = wx_u_mod.headimgurl;
        }
        //public void loaddata()
        //{
        //    //Session["open_id"] = "ozBiSt0zxI4W3ROkC4Xf0IxAC_Qg";                      
        //    if (Session["open_id"] == null )
        //    {
        //        Response.Write("<script>alert('感谢您进入温氏学院系统!')</script>");
        //        code = Request.QueryString["code"];
        //        if (code != null && code != "")
        //        {


                    
                    
                    
                    
        //            //Response.Write("<script>alert('这是code：" + code + "')</script>");
        //            WebClient requestClinet = new WebClient();
        //            string jsonArray = requestClinet.DownloadString("https://api.weixin.qq.com/sns/oauth2/access_token?appid=zheshiyigejiadeid&secret=zhendemimazaibendibaocun&code=" + code + "&grant_type=authorization_code");
        //            //Response.Write("<script>alert('这是json：" + jsonArray + "')</script>");
        //            JavaScriptSerializer json = new JavaScriptSerializer();
        //            List<User> list = json.Deserialize<List<User>>("[" + jsonArray + "]");
        //            if (list.Count>0)
        //            {
        //                //Response.Write("<script>alert('"+list[0].openid+"!')</script>");
        //                Session["open_id"] = list[0].openid;
        //                if (data_name_exit(Session["open_id"].ToString()) == 0)
        //                {
        //                    Response.Write("<script>alert('尚未填入培训信息');window.location='mem_info_fill.aspx'</script>");
        //                }
        //                else
        //                {
        //                    //Response.Write("<script>alert('最后一个')</script>");
        //                    Maticsoft.BLL.member mem_bll = new BLL.member();
        //                    DataSet ds_mem = mem_bll.GetList("[openid]= '" + Session["open_id"].ToString() + "'");
        //                    string name = "";
        //                    if (ds_mem != null && ds_mem.Tables[0].Rows.Count > 0)
        //                    {
        //                        name = ds_mem.Tables[0].Rows[0]["name"].ToString();
        //                    }
        //                    string open_id = Session["open_id"].ToString().Trim();
        //                    Maticsoft.BLL.weixin wx = new BLL.weixin();
        //                    string nickname = wx.get_userinfo(open_id, wx.get_web_accesstoken(code))[0].nickname;
        //                    openid.Text = "您好，" + name + "(" + nickname + ")，欢迎进入温氏培训系统" + open_id.Trim() + "另11111外" + wx.get_web_accesstoken(code);
        //                    touxiang.ImageUrl = wx.get_userinfo(open_id, wx.get_web_accesstoken(code))[0].headimgurl;
        //                    Session["name"] = name;
        //                }
        //            }else
        //            {
        //                Response.Write("<script>alert('获取微信openid失败')</script>");
        //            }
        //        }else
        //        {
        //            Response.Write("<script>alert('请从微信端登陆系统');window.location='error.aspx'</script>");
        //        }
        //    }else if(data_openid_exit(Session["open_id"].ToString())==0)
        //    {
        //        Response.Write("<script>alert('请填入你的培训信息');window.location='mem_info_fill.aspx'</script>");
        //        Maticsoft.BLL.member mem_bll = new BLL.member();
        //          Maticsoft.Model.member mem_mod = new Model.member();
        //          mem_mod.openid = Session["open_id"].ToString();
        //          mem_mod.name = "空";
        //          mem_bll.Add(mem_mod);
                 

        //    }
        //    else if (data_name_exit(Session["open_id"].ToString()) == 0)
        //    {
        //        Response.Write("<script>alert('尚未填入培训信息');window.location='mem_info_fill.aspx'</script>");
        //        //Maticsoft.Common.MessageBox.ShowAndRedirect(this,"尚未填入培训信息","user_info_fill.aspx");
        //    }
        //    else
        //    {
        //        //Response.Write("<script>alert('最后一个')</script>");
        //        Maticsoft.BLL.member mem_bll=new BLL.member();
        //        DataSet ds_mem = mem_bll.GetList("[openid]= '" + Session["open_id"].ToString() + "'");
        //    string name = "";
        //    if (ds_mem != null && ds_mem.Tables[0].Rows.Count > 0)
        //    {
        //        name = ds_mem.Tables[0].Rows[0]["name"].ToString();
        //    }
        //    string open_id = Session["open_id"].ToString().Trim();

        //        Maticsoft.BLL.weixin wx = new BLL.weixin();
        //        string nickname = wx.get_userinfo(open_id, wx.get_web_accesstoken(code))[0].nickname;
        //        openid.Text = "您好，" + name + "(" + nickname + ")，欢迎进入温氏培训系统测试版" + open_id + "啊啊啊啊啊" + wx.get_web_accesstoken(code);
        //        touxiang.ImageUrl = wx.get_userinfo(open_id, wx.get_web_accesstoken(code))[0].headimgurl;
        //        Session["name"] = name;
        //    }
        //}


            public int data_openid_exit(string openid)
            {
                //Response.Write("<script>alert('开始判断openid是否存在数据库')</script>");
                Maticsoft.BLL.member mem_bll = new BLL.member();
                DataSet ds_mem = mem_bll.GetList(" [openid]= '"+openid+"'");
                if (ds_mem == null || ds_mem.Tables[0].Rows.Count == 0)
                {
                    return 0;
                }else
                {
                    return 1;
                }
            }

        public int data_name_exit(string openid)
        {
            //Response.Write("<script>alert('开始判断name是否存在数据库')</script>");
            Maticsoft.BLL.member mem_bll=new BLL.member();
            DataSet ds_mem=mem_bll.GetList("[openid]= '"+openid+"'");
            string name = "";
            if(ds_mem !=null && ds_mem.Tables[0].Rows.Count>0){
            name=ds_mem.Tables[0].Rows[0]["name"].ToString();
            }
            if(name.Trim()=="空" ||name.Trim()=="")
            {
                return 0;
            }else
            {
                return 1;
            }
        }
            //            Maticsoft.BLL.member mem_bll = new BLL.member();
            //            DataSet ds_mem = mem_bll.GetList(list[0].openid);
            //            if (ds_mem == null || ds_mem.Tables[0].Rows.Count == 0)
            //            {
            //                Maticsoft.Model.member mem_mod = new Model.member();
            //                mem_mod.openid = list[0].openid;
            //                mem_mod.name = "空";
            //                if (mem_bll.Add(mem_mod) > 0)
            //                {
            //                    Response.Write("<script>alert('感谢您进入温氏学院系统，请先填写个人信息!')</script>");
            //                    Response.Redirect("user_info_fill.aspx");
            //                }
            //                else 
            //                {
            //                    Response.Write("<script>alert('微信数据无法插入数据库，请稍后重试!')</script>");
            //                }
            //            }
            //            else if (Session["name"] == null)
            //            {
            //                if (ds_mem.Tables[0].Rows[0]["name"] == "空")
            //                {
            //                    Response.Write("<script>alert('感谢您进入温氏学院系统，请先填写个人信息!')</script>");
            //                    Response.Redirect("user_info_fill.aspx");
            //                }
            //                else
            //                {
            //                    Session["name"] = ds_mem.Tables[0].Rows[0]["name"];
            //                }
            //            }
            //        }
            //        else
            //        {
            //            Response.Write("<script>alert('获取不到微信数据，请稍后!')</script>");
            //        }
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('请从微信号进入该页面!')</script>");
            //    }
            //}
            //else if (Session["name"] == null)
            //{
            //    //数据库查询名字操作
            //    openid.Text = "你的id是" + Session["open_id"];
            //    Response.Write("<script>alert('请绑定你的培训信息!')</script>");
            //    //跳转到名字设置页
            //}
            //else
            //{
            //    openid.Text = "你的id是" + Session["open_id"] + "，你的名字是" + Session["name"];
            //}


         class User
        {
            public string access_token { get; set; }
            public int expires_in { get; set; }
            public string refresh_token { get; set; }
            public string openid { get; set; }
            public string scope { get; set; }
        }
    }
}