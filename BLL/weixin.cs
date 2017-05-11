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
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Maticsoft.BLL
{
    public partial class weixin
    {

        //public string get_accesstoken()
        //{
        //    WebClient requestClinet = new WebClient();
        //    string responseStr = requestClinet.DownloadString("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=wx980f23d828e4fc37&secret=70a5c1f34745ffc790935d656178af0c");
        //    JavaScriptSerializer json = new JavaScriptSerializer();
        //    Maticsoft.Model.access_token act_mod = new Model.access_token();

        //    List<acc_token> list = json.Deserialize<List<acc_token>>("[" + responseStr + "]");
        //    if (list != null)
        //    {

        //        return list[0].access_token;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        public string get_accesstoken()
        {
            Maticsoft.BLL.access_token at_bll = new access_token();
            Maticsoft.Model.access_token at_mod = new Model.access_token();
            at_mod = at_bll.last_at();
            DateTime dt_now = DateTime.Now;
            DateTime dt_at = Convert.ToDateTime(at_mod.time);
            TimeSpan ts = dt_now - dt_at;
            if (true)
            {
                WebClient requestClinet = new WebClient();
                string responseStr = requestClinet.DownloadString("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=zheshiyigejiadeid&secret=zhendemimazaibendibaocun");
                JavaScriptSerializer json = new JavaScriptSerializer();
                //Maticsoft.Model.access_token act_mod=new Model.access_token();

                List<acc_token> list = json.Deserialize<List<acc_token>>("[" + responseStr + "]");
                if (list != null)
                {
                    at_mod.access_token_str = list[0].access_token;
                    at_mod.time = DateTime.Now;
                    at_bll.Add(at_mod);
                    return at_mod.access_token_str;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return at_mod.access_token_str.Trim();
            }

        }

        /// <summary>
        /// 获取微信用户的openid
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string get_openid(string code)
        {
            WebClient requestClinet = new WebClient();
            string jsonArray = requestClinet.DownloadString("https://api.weixin.qq.com/sns/oauth2/access_token?appid=zheshiyigejiadeid&secret=zhendemimazaibendibaocun&code=" + code + "&grant_type=authorization_code");
            //Response.Write("<script>alert('这是json：" + jsonArray + "')</script>");
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<User> list = json.Deserialize<List<User>>("[" + jsonArray + "]");
            if (list.Count > 0)
            {
                return list[0].openid;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获取网页授权的accesstoken
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<Maticsoft.Model.access_web_token> get_web_accesstoken(string code)
        {
            WebClient requestClinet = new WebClient();
            string jsonArray = requestClinet.DownloadString("https://api.weixin.qq.com/sns/oauth2/access_token?appid=zheshiyigejiadeid&secret=zhendemimazaibendibaocun&code=" + code + "&grant_type=authorization_code");
            //return jsonArray;
            //string jsonArray=@"{""access_token"":""ZMbTwLFXDOLxcvf_XxakEafI7Ohlaux0aO2FDadCaXMEmdpQZ1OFXCseF-Hrx_wV8jSz9eSQqaJ6ZUGCdAlQWrOMVdZH10_mu0M1fmBw1Ho"",""expires_in"":7200,""refresh_token"":""yGd0ELu_hv-FAtiMvnPNZIL0VMYe9FtW5UidYGNRIaLfVg7ToGcgBoixmeiWHBnLOGNSsXQoSjvMxdirxxkXiwcZkDhd8Dky2Tg6XekkJWU"",""openid"":""oPFZYwanSioNrWovMwut_W_cy0h8"",""scope"":""snsapi_base""}";
            //Response.Write("<script>alert('这是json：" + jsonArray + "')</script>");
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<Maticsoft.Model.access_web_token> list = json.Deserialize<List<Maticsoft.Model.access_web_token>>("[" + jsonArray + "]");
            if (list.Count > 0)
            {
                return list;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 通过openid获取用户基本信息
        /// </summary>
        /// <param name="openid"></param>
        /// <param name="access_token"></param>
        /// <returns></returns>
        public List<Maticsoft.Model.weixin_userinfo> get_userinfo(string openid, string access_token)
        {

            WebClient requestClinet2 = new WebClient();
            requestClinet2.Credentials = CredentialCache.DefaultCredentials;
            requestClinet2.Encoding = Encoding.UTF8;
            string str = requestClinet2.DownloadString(" https://api.weixin.qq.com/sns/userinfo?access_token=" + access_token + "&openid=" + openid + "&lang=zh_CN");
            //string userinfo = String2Json(str);
            string userinfo = "[" + str + "]";
            //byte[] sourcebytes = System.Text.Encoding.Default.GetBytes(str);
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<Maticsoft.Model.weixin_userinfo> list = json.Deserialize<List<Maticsoft.Model.weixin_userinfo>>(userinfo); 
            //string userinfo = Encoding.UTF8.GetString(sourcebytes).Replace("\"", """ );
            //List<Maticsoft.Model.weixin_userinfo> list = JsonHelper.ParseFromJson<List<Maticsoft.Model.weixin_userinfo>>(str);
            if (list.Count > 0)
            {
                Maticsoft.BLL.member mem_bll = new member();
                list[0].remark = mem_bll.get_name(list[0].openid);
                return list;
            }
            else
            {
                return null;
            }
        }


        public string update_remark(string openid, string access_token, string remark_str)
        {
            //string jsonMenu = @"{""openid"":""oPFZYwanSioNrWovMwut_W_cy0h8"",""remark"":""聪来的""}";
            string jsonMenu = @"{""openid"":";
            jsonMenu += "\"" + openid + "\",\"remakr\":\""+remark_str+"\"}";

            byte[] jsonBypes = Encoding.UTF8.GetBytes(jsonMenu);
            WebClient nameClinet = new WebClient();
            nameClinet.Headers.Add("Content-Type", "applicaiton/x-www-form-urlencoded");
            byte[] jsonResult = nameClinet.UploadData(" https://api.weixin.qq.com/cgi-bin/user/info/updateremark?access_token=" + access_token, jsonBypes);
            string strResult = Encoding.UTF8.GetString(jsonResult);
            return strResult;
        }




    }

    class acc_token
    {
        public string access_token { get; set; }
        public string expires_in { get; set; }
    }

    class User
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
        public string openid { get; set; }
        public string scope { get; set; }
    }
    //class web_acc_token
    //{
    //    public string access_token { get; set; }
    //    public string expires_in { get; set; }
    //    public string refresh_token { get; set; }
    //    public string openid { get; set; }
    //    public string scope { get; set; }
    //}
   //public  class Userinfo
   // {
   //     public string subscribe { get; set; }
   //     public string openid { get; set; }
   //     public string nickname { get; set; }
   //     public int sex { get; set; }
   //     public string city { get; set; }
   //     public string country { get; set; }
   //     public string province { get; set; }
   //     public string language { get; set; }
   //     public string headimgurl { get; set; }
   //     public string subscribe_time { get; set; }
   //     public string unionid { get; set; }
   //     public string remark { get; set; }
   //     public string groupid { get; set; }
   //     public string tagid_list { get; set; }
   // }

    /// <summary>
    /// 将Json格式数据转化成对象
    /// </summary>
    public class JsonHelper
    {
        /// <summary>  
        /// 生成Json格式  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="obj"></param>  
        /// <returns></returns>  
        //public static string GetJson<T>(T obj)
        //{
        //    DataContractJsonSerializer json = new DataContractJsonSerializer(obj.GetType());
        //    using (MemoryStream stream = new MemoryStream())
        //    {
        //        json.WriteObject(stream, obj);
        //        string szJson = Encoding.UTF8.GetString(stream.ToArray()); return szJson;
        //    }
        //}
        /// <summary>  
        /// 获取Json的Model  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="szJson"></param>  
        /// <returns></returns>  
        //public static T ParseFromJson<T>(string szJson)
        //{
        //    T obj = Activator.CreateInstance<T>();
        //    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(szJson)))
        //    {
        //        DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
        //        return (T)serializer.ReadObject(ms);
        //    }
        //}
    }
}
