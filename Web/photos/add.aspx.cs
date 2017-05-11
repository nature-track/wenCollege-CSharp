using System;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.IO;
using System.Data.OleDb;

namespace Maticsoft.Web.photos
{
    public partial class add : System.Web.UI.Page
    {
        public string temp = "upload.aspx?sn=0";
        public string sn;
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                databind();
            }
        }

        protected void databind()
        {
            Maticsoft.BLL.peixunban1 pei = new BLL.peixunban1();
            qishu_dro.DataSource = pei.GetList("");
            qishu_dro.DataTextField = "name";
            qishu_dro.DataValueField = "id";
            qishu_dro.DataBind();
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            ///'遍历File表单元素
            HttpFileCollection files = HttpContext.Current.Request.Files;

            /// '状态信息
            System.Text.StringBuilder strMsg = new System.Text.StringBuilder("培训班为：" + qishu_dro.SelectedValue + "<br/>");
            strMsg.Append("上传的文件分别是：<hr color='red'/>");
            int count=0;
            try
            {
                for (int iFile = 0; iFile < files.Count; iFile++)
                {
                    ///'检查文件扩展名字
                    HttpPostedFile postedFile = files[iFile];
                    string fileName, fileExtension;
                    fileName = System.IO.Path.GetFileNameWithoutExtension(postedFile.FileName)+DateTime.Today.GetDateTimeFormats('D')[0].ToString()+System.IO.Path.GetExtension(postedFile.FileName);
                    if (fileName != "")
                    {
                        fileExtension = System.IO.Path.GetExtension(fileName);
                        
                        strMsg.Append("上传的文件类型：" + postedFile.ContentType.ToString() + "<br>");
                        strMsg.Append("客户端文件地址：" + postedFile.FileName + "<br>");
                        strMsg.Append("上传文件的文件名：" + fileName + "<br>");
                        strMsg.Append("上传文件的扩展名：" + fileExtension + "<br><hr>");
                        ///'可根据扩展名字的不同保存到不同的文件夹
                        ///注意：可能要修改你的文件夹的匿名写入权限。
                        postedFile.SaveAs(System.Web.HttpContext.Current.Request.MapPath("../images/") + fileName);
                        
                       
                        System.Drawing.Image imgPhoto = System.Drawing.Image.FromFile(System.Web.HttpContext.Current.Request.MapPath("../images/") + fileName);

                        string strName = System.IO.Path.GetFileNameWithoutExtension(postedFile.FileName) + DateTime.Today.GetDateTimeFormats('D')[0].ToString() + "_small_" + System.IO.Path.GetExtension(postedFile.FileName);
                        //string strName = System.IO.Path.GetFileNameWithoutExtension(postedFile.FileName) + DateTime.Today.GetDateTimeFormats('D')[0].ToString()  + System.IO.Path.GetExtension(postedFile.FileName);
                        string strResizePicName = System.Web.HttpContext.Current.Request.MapPath("../images/") + strName;
                        Maticsoft.BLL.photos ph = new BLL.photos();
                       string str=  ph.photoscompress(imgPhoto, 400, 300, strResizePicName);
                       if (str == "保存成功")
                       {
                           Maticsoft.Model.photos ph_m = new Model.photos();
                           ph_m.ContentType = postedFile.ContentType.ToString();
                           ph_m.postedFileFileName = postedFile.FileName;
                           ph_m.FileName = strName;
                           ph_m.fileExtension = fileExtension;
                           ph_m.qishu = qishu_dro.SelectedValue;
                           if (fenlei_txt.Text == "")
                           {
                               ph_m.fenlei2 = fenlei_dro.SelectedValue;
                           }
                           else
                           {
                               ph_m.fenlei2 = fenlei_txt.Text.Trim();
                           }
                           Maticsoft.BLL.photos pho = new BLL.photos();
                           count += pho.Add(ph_m);
                       }
                       else
                       {
                           strMsg.Append(str);
                       }
                       
                    }
                }
                strMsg.Append("共上传图片" + count + "张");
                strStatus.Text = strMsg.ToString();
            }
            catch (System.Exception Ex)
            {
                strStatus.Text = Ex.Message;
            }

        }

       
       
           
    }
}