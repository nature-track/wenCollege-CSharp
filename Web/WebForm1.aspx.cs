using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal lt = (Literal)Page.Master.FindControl("Literal1");
            lt.Text = "wowowowow";
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            ///'遍历File表单元素
            HttpFileCollection files = HttpContext.Current.Request.Files;

            /// '状态信息
            System.Text.StringBuilder strMsg = new System.Text.StringBuilder("您输入的用户名是：" + TextBox1.Text + "<br/>");
            strMsg.Append("上传的文件分别是：<hr color='red'/>");
            try
            {
                for (int iFile = 0; iFile < files.Count; iFile++)
                {
                    ///'检查文件扩展名字
                    HttpPostedFile postedFile = files[iFile];
                    string fileName, fileExtension;
                    fileName = System.IO.Path.GetFileName(postedFile.FileName);
                    if (fileName != "")
                    {
                        fileExtension = System.IO.Path.GetExtension(fileName);
                        strMsg.Append("上传的文件类型：" + postedFile.ContentType.ToString() + "<br>");
                        strMsg.Append("客户端文件地址：" + postedFile.FileName + "<br>");
                        strMsg.Append("上传文件的文件名：" + fileName + "<br>");
                        strMsg.Append("上传文件的扩展名：" + fileExtension + "<br><hr>");
                        ///'可根据扩展名字的不同保存到不同的文件夹
                        ///注意：可能要修改你的文件夹的匿名写入权限。
                        postedFile.SaveAs(System.Web.HttpContext.Current.Request.MapPath("images/") + fileName);
                    }
                }
                strStatus.Text = strMsg.ToString();
            }
            catch (System.Exception Ex)
            {
                strStatus.Text = Ex.Message;
            }

        }
    }
}