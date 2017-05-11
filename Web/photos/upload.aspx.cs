using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;
using System.IO;

public partial class _upload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //此处有时候穿过来的sn后面还有一些乱七八糟的字符，没研究什么意思，就判断一下，截取一下就完事了，小项目~
        string sn = Request.QueryString["sn"].ToString();
        if (sn.Length > 14)
            sn = sn.Substring(0,14);

        try
        {
            //获取上传的文件数据
            HttpPostedFile file = Request.Files["Filedata"];
            string fileName = file.FileName;
            string fileType = Path.GetExtension(fileName).ToLower();
            //由于不同浏览器取出的FileName不同（有的是文件绝对路径，有的是只有文件名），故要进行处理
            if (fileName.IndexOf(' ') > -1)
            {
                fileName = fileName.Substring(fileName.LastIndexOf(' ') + 1);
            }
            else if (fileName.IndexOf('/') > -1)
            {
                fileName = fileName.Substring(fileName.LastIndexOf('/') + 1);
            }
            //上传的目录
            string uploadDir = "~/uploadfile/" + System.DateTime.Now.ToString("yyyyMM") + "/";
            //上传的路径
            //生成年月文件夹及日文件夹
            if (Directory.Exists(Server.MapPath(uploadDir)) == false)
            {
                Directory.CreateDirectory(Server.MapPath(uploadDir));
            }

            if (Directory.Exists(Server.MapPath(uploadDir + System.DateTime.Now.ToString("dd") + "/")) == false)
            {
                Directory.CreateDirectory(Server.MapPath(uploadDir + System.DateTime.Now.ToString("dd") + "/"));
            }

            uploadDir = uploadDir + System.DateTime.Now.ToString("dd") + "/";

            string uploadPath = uploadDir + MD5.strToMD5(fileName).Substring(0,8) + fileType;

            //保存文件
            file.SaveAs(Server.MapPath(uploadPath));
            //下面这句代码缺少的话，上传成功后上传队列的显示不会自动消失
            Maticsoft.Model.temp tem_mod = new Maticsoft.Model.temp();
            tem_mod.temp_SN = sn;
            tem_mod.temp_Content = uploadPath;
            Maticsoft.BLL.temp tem = new Maticsoft.BLL.temp();
            tem.Add(tem_mod);
            //DbHelperOleDb.ExecuteSql("insert into [temp](temp_sn,temp_Content) values('" + sn + "','" + uploadPath + "')");
            //Response.Write("1");
        }
        catch
        {
            //Response.Write("0");
        }
    }
}
