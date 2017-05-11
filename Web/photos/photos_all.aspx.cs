using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Specialized;
using System.Data;
using System.IO;

namespace Maticsoft.Web.photos
{
    public partial class photos_all : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataload();
        }

        public void dataload()
        {
            StringCollection strs = new StringCollection();
            strs = GetAllFiles("D:\\wenjunsheng");
            for (int i = 0; i < strs.Count; i++)
            {
                Label1.Text += strs[i].ToString();
            }
        }

        /// <summary>
        /// 遍历 rootdir目录下的所有文件
        /// </summary>
        /// <param name="rootdir">目录名称</param>
        /// <returns>该目录下的所有文件</returns>
        public StringCollection GetAllFiles(string rootdir)
        {
            StringCollection result = new StringCollection();
            GetAllFiles(rootdir, result);
            return result;
        }
        /// <summary>
        /// 作为遍历文件函数的子函数
        /// </summary>
        /// <param name="parentDir">目录名称</param>
        /// <param name="result">该目录下的所有文件</param>
        public void GetAllFiles(string parentDir, StringCollection result)
        {
            //获取目录parentDir下的所有的子文件夹
            //string[] dir = Directory.GetDirectories(parentDir);
            //for (int i = 0; i < dir.Length; i++)
            //    GetAllFiles(dir[i], result);

            //获取目录parentDir下的所有的文件，并过滤得到所有的文本文件
            string[] file = Directory.GetFiles(parentDir, "*.ppt");
            for (int i = 0; i < file.Length; i++)
            {
                //FileInfo fi = new FileInfo(file[i]);
                //if (fi.Extension.ToLower() == "txt")
                //{
                result.Add(file[i]);
                //}                
            }
        }
  
 
    }
}