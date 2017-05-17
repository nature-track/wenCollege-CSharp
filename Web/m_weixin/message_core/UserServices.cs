using Maticsoft.Web.m_weixin.message_model.entity;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Maticsoft.Web.m_weixin.message_core
{
    public class UserServices
    {
        public static UserInfo getUserInfo(string openid) {
            string uriTemplate = "https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang=zh_CN";
            string access_token = TokenUtils.getAccessToken();
            
            string uri = String.Format(uriTemplate, access_token, openid);

            WebClient requestClient = new WebClient();
            requestClient.Encoding = System.Text.Encoding.UTF8;
            string json = requestClient.DownloadString(uri);

            JObject jsonObj = JObject.Parse(json);
            Dictionary<string, string> properties = jsonObj.Properties().ToDictionary(item => item.Name, item => item.Value.ToString());

            
            string openidValue = null;
            string nicknameValue = null;
            string languageValue = null;
            properties.TryGetValue("openid", out openidValue);
            properties.TryGetValue("nickname", out nicknameValue);
            properties.TryGetValue("language", out languageValue);

            UserInfo userInfo = new UserInfo();
            userInfo.openid = openidValue;
            userInfo.nickname = nicknameValue;
            userInfo.language = languageValue;

            return userInfo;
        }
    }
}