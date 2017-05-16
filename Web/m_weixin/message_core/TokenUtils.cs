using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Collections;

namespace Maticsoft.Web.m_weixin.message_core
{
    public class TokenUtils
    {
        private static string commonAccessTokenCacheKey = "webchat_common_access_token";
        private static string webAccessTokenCacheKey = "webchat_web_access_token";
        private static readonly string APP_ID = System.Configuration.ConfigurationManager.AppSettings["wechatAppId"].ToString();
        private static readonly string SECRET = System.Configuration.ConfigurationManager.AppSettings["wechatSecret"].ToString();
        public static string getAccessToken() {
            String commonAccessToken = (String)CacheUtils.GetCache(commonAccessTokenCacheKey);
            if (String.IsNullOrEmpty(commonAccessToken)) {
                string uriTemplate = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";
                string uri = String.Format(uriTemplate, APP_ID, SECRET);

                WebClient requestClient = new WebClient();
                string json = requestClient.DownloadString(uri);
                
                JObject jsonObj = JObject.Parse(json);
                Dictionary<string, string> properties = jsonObj.Properties().ToDictionary(item => item.Name, item => item.Value.ToString());
                string accessToken = null;
                string expires = null;
                properties.TryGetValue("access_token", out accessToken);
                properties.TryGetValue("expires_in", out expires);

               /* JsonReader reader = new JsonTextReader(new StringReader(json));
                while (reader.Read()) {
                    switch (reader.TokenType.ToString()) { 
                        case "access_token":
                            accessToken = reader.Value.ToString();
                            break;
                        case "expires_in":
                            expires = int.Parse(reader.Value.ToString());
                            break;
                    }
                } */
                if (!String.IsNullOrEmpty(accessToken))
                {
                    CacheUtils.SetCache(commonAccessTokenCacheKey, accessToken, int.Parse(expires));
                }
                commonAccessToken = accessToken;
            }
            
            return commonAccessToken;
        }

        public static string getWebAccessToken(string code) {
            String webAccessToken = (String)CacheUtils.GetCache(webAccessTokenCacheKey);
            if(String.IsNullOrEmpty(webAccessToken)) {
                string uriTemplate = "https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code";
                string uri = String.Format(uriTemplate, APP_ID, SECRET, code);

                WebClient requestClinet = new WebClient();
                string json = requestClinet.DownloadString(uri);

                JObject jsonObj = JObject.Parse(json);
                Dictionary<string, string> properties = jsonObj.Properties().ToDictionary(item => item.Name, item => item.Value.ToString());
                string accessToken = null;
                string expires = null;
                properties.TryGetValue("access_token", out accessToken);
                properties.TryGetValue("expires_in", out expires);
                if (!String.IsNullOrEmpty(accessToken)) {
                    CacheUtils.SetCache(webAccessTokenCacheKey, accessToken, int.Parse(expires));
                }
                webAccessToken = accessToken;
            }
            
            return webAccessToken;
        }
    }
}