using Maticsoft.Web.m_weixin.message_model.req;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Xml;

namespace Maticsoft.Web.m_weixin.message_core
{
    public class CoreUtils
    {
        private static String token = "wenshr";
        public static bool CheckSignature(string signature, string timestamp, string nonce)
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

        public static ReqBaseMessage handleReqMessage(String requestStr) {
            XmlDocument xmlDoc = new XmlDocument();
            ReqBaseMessage resultMessage = null;
            xmlDoc.LoadXml(requestStr);
            String msgType = xmlDoc.DocumentElement.SelectSingleNode("MsgType").InnerText;
            switch (msgType.ToLower()) { 
                case "text":
                    resultMessage = convertXmlToReqTextMessage(xmlDoc);
                    break;
            }
            return resultMessage;

        }

        public static ReqTextMessage convertXmlToReqTextMessage(XmlDocument xmlDoc) {
            string toUserName = xmlDoc.DocumentElement.SelectSingleNode("ToUserName").InnerText;
            string fromUserName = xmlDoc.DocumentElement.SelectSingleNode("FromUserName").InnerText;
            string createTime = xmlDoc.DocumentElement.SelectSingleNode("CreateTime").InnerText;
            string content = xmlDoc.DocumentElement.SelectSingleNode("Content").InnerText;
            string msgId = xmlDoc.DocumentElement.SelectSingleNode("MsgId").InnerText;

            // create entity
            ReqTextMessage resultMessage = new ReqTextMessage();
            resultMessage.ToUserName = toUserName.Trim();
            resultMessage.FromUserName = fromUserName.Trim();
            resultMessage.Content = content.Trim();
            resultMessage.CreateTime = createTime.Trim();
            resultMessage.MsgId = long.Parse(msgId);
            
            return resultMessage;
        }

        public static ReqImageMessage convertXmlToReqImageMessage(XmlDocument xmlDoc) {
            string toUserName = xmlDoc.DocumentElement.SelectSingleNode("ToUserName").InnerText;
            string fromUserName = xmlDoc.DocumentElement.SelectSingleNode("FromUserName").InnerText;
            string createTime = xmlDoc.DocumentElement.SelectSingleNode("CreateTime").InnerText;
            string msgId = xmlDoc.DocumentElement.SelectSingleNode("MsgId").InnerText;
            string picUrl = xmlDoc.DocumentElement.SelectSingleNode("PicUrl").InnerText;
            string mediaId = xmlDoc.DocumentElement.SelectSingleNode("MediaId").InnerText;

            ReqImageMessage resultMessage = new ReqImageMessage();
            resultMessage.ToUserName = toUserName.Trim();
            resultMessage.FromUserName = fromUserName.Trim();
            resultMessage.CreateTime = createTime.Trim();
            resultMessage.MsgId = long.Parse(msgId);
            resultMessage.PicUrl = picUrl.Trim();
            resultMessage.MediaId = mediaId.Trim();

            return resultMessage;
        }

    }
}