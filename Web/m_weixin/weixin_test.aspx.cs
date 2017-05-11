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

namespace Maticsoft.Web
{
    public partial class weixin_test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                //LoadData();
            }
        }
        static string responseStr = "";
        protected void Button1_Click(object sender, EventArgs e)
        {
            WebClient requestClinet = new WebClient();
            responseStr = requestClinet.DownloadString("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=zheshiyigejiadeid&secret=zhendemimazaibendibaocun");
            Label1.Text = responseStr;
        }
        public void LoadData()
        {
            Response.ContentType = "text/plain";

            ////获取微信后台get方式传递过来的参数
            string signature = Request.QueryString["signature"];//微信加密签名，signature结合了开发者填写的token参数和请求中的timestamp参数、nonce参数。
            string timestamp = Request.QueryString["timestamp"];//时间戳
            string nonce = Request.QueryString["nonce"];//随机数
            string echostr = Request.QueryString["echostr"];//随机字符串

            switch (Request.HttpMethod.ToUpper())//微信请求我们的网站的时候，有两种方式分别为：GET和POST
            {
                case "POST":
                    #region 获取用户发送过来的消息
                    //获取微信发送过来的数据
                    Stream requestStream = Request.InputStream;
                    byte[] requestBytes = new byte[requestStream.Length];
                    requestStream.Read(requestBytes, 0, (int)requestStream.Length);
                    string requestStr = Encoding.UTF8.GetString(requestBytes);

                    //将微信发送过来的xml字符串转化为Xml对象
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(requestStr);

                    //获取具体的值
                    string ToUserName = xmlDoc.DocumentElement.SelectSingleNode("ToUserName").InnerText;//消息发送给谁
                    string FromUserName = xmlDoc.DocumentElement.SelectSingleNode("FromUserName").InnerText;//消息从谁发送过来的
                    string CreateTime = xmlDoc.DocumentElement.SelectSingleNode("CreateTime").InnerText;//消息产生的时间
                    string MsgType = xmlDoc.DocumentElement.SelectSingleNode("MsgType").InnerText;//消息类型
                    string Content = xmlDoc.DocumentElement.SelectSingleNode("Content").InnerText;//消息内容
                    string MsgId = xmlDoc.DocumentElement.SelectSingleNode("MsgId").InnerText;//消息的编号

                    #endregion

                    #region 向用户返回消息（文本消息，图片消息，语音消息，视频消息，音乐消息，图文消息）

                    string responseContent = @"你好，GeekFish已通过开发模式获取到你发送的消息，消息内容：
" + Content;

                    //文本消息
                    string result = string.Format(@"<xml>
                                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                                    <CreateTime>{2}</CreateTime>
                                                    <MsgType><![CDATA[text]]></MsgType>
                                                    <Content><![CDATA[{3}]]></Content>
                                                    </xml>", FromUserName, ToUserName,  ConvertDateTimeInt(DateTime.Now), responseContent);

                    //图文消息
                    //                    string result = string.Format(@"<xml>
                    //                                  <ToUserName><![CDATA[{0}]]></ToUserName>
                    //                                  <FromUserName><![CDATA[{1}]]></FromUserName>
                    //                                  <CreateTime>{2}</CreateTime>
                    //                                  <MsgType><![CDATA[news]]></MsgType>
                    //                                  <ArticleCount>2</ArticleCount>
                    //                                  <Articles>
                    //                                    <item>
                    //                                      <Title><![CDATA[title1]]></Title>
                    //                                      <Description><![CDATA[description1]]></Description>
                    //                                      <PicUrl><![CDATA[http://pic.sogou.com/pics/news/detail_top.jsp?category=%E5%9B%BD%E9%99%85&mark=b6f6b5563f25c79c&did=1#did0]]></PicUrl>
                    //                                      <Url><![CDATA[https://mp.weixin.qq.com/cgi-bin/home?t=home/index&lang=zh_CN&token=1026173498]]></Url>
                    //                                    </item>
                    //                                    <item>
                    //                                      <Title><![CDATA[title]]></Title>
                    //                                      <Description><![CDATA[description]]></Description>
                    //                                      <PicUrl><![CDATA[http://pic.sogou.com/pics/news/detail_top.jsp?category=%E5%9B%BD%E9%99%85&mark=b6f6b5563f25c79c&did=1#did0_1]]></PicUrl>
                    //                                      <Url><![CDATA[https://mp.weixin.qq.com/cgi-bin/home?t=home/index&lang=zh_CN&token=1026173498]]></Url>
                    //                                    </item>
                    //                                  </Articles>
                    //                                </xml>", FromUserName, ToUserName, CreateTime, responseContent);


                    Response.Write(result);

                    #endregion

                    break;
                case "GET":
                    //用于微信服务器第一次接入的时候的验证
                    if (CheckSignature(signature, timestamp, nonce))
                    {
                        Response.Write(echostr);
                    }
                    break;
            }
        }

        string token = "wenshr";
        /// <summary>
        /// 验证服务器地址的有效性
        /// </summary>
        /// <param name="signature">微信加密签名，signature结合了开发者填写的token参数和请求中的timestamp参数、nonce参数。</param>
        /// <param name="timestamp">时间戳</param>
        /// <param name="nonce">随机数</param>
        /// <returns></returns>
        public bool CheckSignature(string signature, string timestamp, string nonce)
        {
            string[] arr = new string[] { token, timestamp, nonce };
            //1.将token、timestamp、nonce三个参数进行字典序排序
            Array.Sort(arr);

            StringBuilder sbuilder = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                sbuilder.Append(arr[i]);
            }

            //2.将三个参数字符串拼接成一个字符串进行sha1加密
            string sha1Result = FormsAuthentication.HashPasswordForStoringInConfigFile(sbuilder.ToString(), "SHA1");

            //3. 开发者获得加密后的字符串可与signature对比，标识该请求来源于微信
            return sha1Result.ToUpper().Equals(signature.ToUpper());
        }

        /// <summary>
        /// datetime转换为unixtime
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            //Maticsoft.Model.access_token act_mod=new Model.access_token();

            List<acc_token> list = json.Deserialize<List<acc_token>>("["+responseStr+"]");
            if (list != null)
            {
                GridView1.DataSource = list;
                GridView1.DataBind();
            }

            string jsonMenu = @"{""button"":[{""name"":""学院讲师"",""sub_button"":[{""type"":""view"",""name"":""我的信息"",""url"":""https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx980f23d828e4fc37&redirect_uri=http%3a%2f%2fwsc.wens.com.cn%2fm_weixin%2findex.aspx&response_type=code&scope=snsapi_userinfo&state=STATE#wechat_redirect""},{""type"":""view"",""name"":""我的课程"",""url"":""https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx980f23d828e4fc37&redirect_uri=http%3a%2f%2fwsc.wens.com.cn%2fdafen_jieguo%2fstart.aspx&response_type=code&scope=snsapi_base&state=STATE#wechat_redirect""}]},{""name"":""培训班学员"",""sub_button"":[{""type"":""view"",""name"":""进入系统"",""url"":""https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx980f23d828e4fc37&redirect_uri=http%3a%2f%2fwsc.wens.com.cn%2fm_weixin%2findex.aspx&response_type=code&scope=snsapi_base&state=STATE#wechat_redirect""}]},{""name"":""培训组织者"",""sub_button"":[{""type"":""view"",""name"":""学院排期"",""url"":""https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx980f23d828e4fc37&redirect_uri=http%3a%2f%2fwsc.wens.com.cn%2fm_weixin%2findex.aspx&response_type=code&scope=snsapi_base&state=STATE#wechat_redirect""},{""type"":""view"",""name"":""使用申请"",""url"":""https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx980f23d828e4fc37&redirect_uri=http%3a%2f%2fwsc.wens.com.cn%2fdafen_jieguo%2fstart.aspx&response_type=code&scope=snsapi_base&state=STATE#wechat_redirect""},{""type"":""view"",""name"":""信息反馈"",""url"":""https://open.weixin.qq.com/connect/oauth2/authorize?appid=wx980f23d828e4fc37&redirect_uri=http%3a%2f%2fwsc.wens.com.cn%2fdafen_jieguo%2fstart.aspx&response_type=code&scope=snsapi_base&state=STATE#wechat_redirect""}]}]}";
            byte[] jsonBypes = Encoding.UTF8.GetBytes(jsonMenu);

            WebClient menuClinet = new WebClient();
            menuClinet.Headers.Add("Content-Type", "applicaiton/x-www-form-urlencoded");
            byte[] jsonResult = menuClinet.UploadData(" https://api.weixin.qq.com/cgi-bin/menu/create?access_token=" + list[0].access_token, jsonBypes);
            string strResult = Encoding.UTF8.GetString(jsonResult);
            Response.Write(strResult);
        }

        class acc_token
        {
            public string access_token { get; set; }
            public string expires_in { get; set; }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //JavaScriptSerializer json = new JavaScriptSerializer();
            //List<acc_token> list = json.Deserialize<List<acc_token>>("[" + responseStr + "]");
            //WebClient requestClinet = new WebClient();
            //string str = requestClinet.DownloadString("https://api.weixin.qq.com/cgi-bin/user/info?access_token=" + list[0].access_token + "&openid=oPFZYwbAiqy5APlJiaFB-i8N068Y&lang=zh_CN");
            ////System.Text.Encoding iso_8859_1 = System.Text.Encoding.GetEncoding("iso-8859-1");
            ////System.Text.Encoding utf_8 = System.Text.Encoding.UTF8;
            ////byte[] isoBytes = iso_8859_1.GetBytes(str);
            ////byte[] utf8Bytes = System.Text.Encoding.Convert(iso_8859_1, utf_8, isoBytes);
            // byte[] sourcebytes = System.Text.Encoding.Default.GetBytes(str);
            //  Label2.Text = Encoding.UTF8.GetString(sourcebytes);

            Maticsoft.BLL.weixin weixin = new BLL.weixin();
            string accesstoken = weixin.get_accesstoken();
            List<Maticsoft.Model.weixin_userinfo> list = weixin.get_userinfo("oPFZYwanSioNrWovMwut_W_cy0h8", accesstoken);
            Label1.Text = list[0].ToString();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<acc_token> list = json.Deserialize<List<acc_token>>("[" + responseStr + "]");
            if (list != null)
            {
                GridView1.DataSource = list;
                GridView1.DataBind();
            }

            string jsonMenu = @"{""openid"":""oPFZYwanSioNrWovMwut_W_cy0h8"",""remark"":""聪来的""}";
                byte[] jsonBypes = Encoding.UTF8.GetBytes(jsonMenu);
                WebClient nameClinet = new WebClient();
                nameClinet.Headers.Add("Content-Type", "applicaiton/x-www-form-urlencoded");
                byte[] jsonResult = nameClinet.UploadData(" https://api.weixin.qq.com/cgi-bin/user/info/updateremark?access_token=" + list[0].access_token, jsonBypes);
                string strResult = Encoding.UTF8.GetString(jsonResult);
                Response.Write(strResult);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Maticsoft.BLL.weixin wx_bll = new BLL.weixin();

            //Label1.Text = wx_bll.get_web_accesstoken("021a3Ip90X21gu11Vsq90tcDp90a3Ip6");
        }

    }
}