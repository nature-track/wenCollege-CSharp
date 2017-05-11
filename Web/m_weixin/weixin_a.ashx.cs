using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web;
using System.Web.Security;
using System.IO;
using System.Xml;

namespace Maticsoft.Web
{
    /// <summary>
    /// weixin 的摘要说明
    /// </summary>
    public class weixin_a : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
  
            string signature = context.Request.QueryString["signature"];
            string timestamp = context.Request.QueryString["timestamp"];
            string nonce = context.Request.QueryString["nonce"];
            string echostr = context.Request.QueryString["echostr"];
            //context.Response.Write(echostr);

            switch (context.Request.HttpMethod.ToUpper())//微信请求我们的网站的时候，有两种方式分别为：GET和POST
            {
                case "POST":
                    #region 获取用户发送过来的消息
                    //获取微信发送过来的数据
                    Stream requestStream = context.Request.InputStream;
                    byte[] requestBytes = new byte[requestStream.Length];
                    requestStream.Read(requestBytes, 0, (int)requestStream.Length);
                    string requestStr = Encoding.UTF8.GetString(requestBytes);

                    //将微信发送过来的xml字符串转化为Xml对象
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(requestStr);
                    string MsgType = xmlDoc.DocumentElement.SelectSingleNode("MsgType").InnerText;//消息类型
                    string result;
                    switch (MsgType.ToLower())
                    {
                        case "text":
                            result = get_text_msg(xmlDoc);
                            context.Response.Write(result);
                            break;
                        case "event":
                            result = get_subscribe(xmlDoc);
                            context.Response.Write(result);
                            break;

                    }
                    //获取具体的值


                    #endregion



                    break;
                case "GET":
                    //用于微信服务器第一次接入的时候的验证
                    if (CheckSignature(signature, timestamp, nonce))
                    {
                    context.Response.Write(echostr);
                    }
                    break;
            }
        }


        public string get_subscribe(XmlDocument xmlDoc)
        {
            string ToUserName = xmlDoc.DocumentElement.SelectSingleNode("ToUserName").InnerText;//消息发送给谁
            string FromUserName = xmlDoc.DocumentElement.SelectSingleNode("FromUserName").InnerText;//消息从谁发送过来的
            string CreateTime = xmlDoc.DocumentElement.SelectSingleNode("CreateTime").InnerText;//消息产生的时间 
            string Event = xmlDoc.DocumentElement.SelectSingleNode("Event").InnerText;//事件类型，subscribe(订阅)、unsubscribe(取消订阅)
            string responseContent = "您好，欢迎关注温氏学院，请点击菜单栏中“培训班学员-我的信息”录入个人资料，" + FromUserName;
            //文本消息
            string result = string.Format(@"<xml>
                                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                                    <CreateTime>{2}</CreateTime>
                                                    <MsgType><![CDATA[text]]></MsgType>
                                                    <Content><![CDATA[{3}]]></Content>
                                                    </xml>", FromUserName, ToUserName, ConvertDateTimeInt(DateTime.Now), responseContent);
            return result;
            
        }
        public string get_text_msg(XmlDocument xmlDoc)
        {
            string ToUserName = xmlDoc.DocumentElement.SelectSingleNode("ToUserName").InnerText;//消息发送给谁
            string FromUserName = xmlDoc.DocumentElement.SelectSingleNode("FromUserName").InnerText;//消息从谁发送过来的
            string CreateTime = xmlDoc.DocumentElement.SelectSingleNode("CreateTime").InnerText;//消息产生的时间                    
            string Content = xmlDoc.DocumentElement.SelectSingleNode("Content").InnerText;//消息内容
            string MsgId = xmlDoc.DocumentElement.SelectSingleNode("MsgId").InnerText;//消息的编号
            Maticsoft.BLL.weixin_msg wx_bll = new BLL.weixin_msg();
            Maticsoft.Model.weixin_msg wx_mod = new Model.weixin_msg();
            wx_mod.openid = FromUserName.Trim();
            wx_mod.mesg = Content.Trim();
            wx_mod.time = DateTime.Now;
            string responseContent = "";
            if (wx_bll.Add(wx_mod) > 0)
            {
                #region 向用户返回消息（文本消息，图片消息，语音消息，视频消息，音乐消息，图文消息）

                responseContent = @"你好，你的反馈已经记录好，消息内容：" + Content;


            }
            else
            {
               responseContent = @"对不起，信息获取失败，请稍后再试" ;
            };

            string result = string.Format(@"<xml>
                                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                                    <CreateTime>{2}</CreateTime>
                                                    <MsgType><![CDATA[text]]></MsgType>
                                                    <Content><![CDATA[{3}]]></Content>
                                                    </xml>", FromUserName, ToUserName, ConvertDateTimeInt(DateTime.Now), responseContent);

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

            return result;
            //context.Response.Write(result);

            #endregion
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


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}