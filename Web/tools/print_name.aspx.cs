using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text;


namespace Maticsoft.Web.tools
{
    public partial class print_name : System.Web.UI.Page
    {

             //protected System.Web.UI.HtmlControls.HtmlInputFile FileExcel;
        //protected System.Web.UI.WebControls.Button BtnImport;
        //protected System.Web.UI.WebControls.Label LblMessage;
        DataSet _da = new DataSet();
        //protected ZsoftDataAccess.DataAccess _da = new ZsoftDataAccess.DataAccess();
        private void Page_Load(object sender, System.EventArgs e)
        {
            // 在此处放置用户代码以初始化页面
            if (!Page.IsPostBack)
            {
                Button1.Enabled = false;

            }
        }

        #region Web 窗体设计器生成的代码
        //override protected void OnInit(EventArgs e)
        //{
        //    //
        //    // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
        //    //
        //    InitializeComponent();
        //    base.OnInit(e);
        //}
        
        ///// <summary>
        ///// 设计器支持所需的方法 - 不要使用代码编辑器修改
        ///// 此方法的内容。
        ///// </summary>
        //private void InitializeComponent()
        //{    
        //    this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
        //    this.Load += new System.EventHandler(this.Page_Load);

        //}
        #endregion


        /// <summary>
        /// 读取Excel文档
        /// </summary>
        /// <param name="Path">文件名称</param>
        /// <returns>返回一个数据集</returns>
        public void ExcelToDS(string Path)
        {
            
            string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + Path + ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'";
            //string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            System.Data.DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            if (dt.Rows.Count > 1)
            {

                LblMessage.Text = "您上传的excel文件包含多个工作表，请把空白的工作表删除";
            }
            else
            {
                bindtable(dt, strConn);
            }
            //string strExcel = "";
            //OleDbDataAdapter myCommand = null;
            //DataSet ds = null;
            //strExcel = "select * from ["+dt.Rows[0]["TABLE_NAME"].ToString()+"]";
            //myCommand = new OleDbDataAdapter(strExcel, strConn);
            //ds = new DataSet();
            //myCommand.Fill(ds, "table1");
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
            //Label1.Text = dt.Rows[0]["TABLE_NAME"].ToString();
        }

        private void bindtable(DataTable dt,string strConn)
        {
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            strExcel = "select * from [" + dt.Rows[0]["TABLE_NAME"].ToString() + "]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            if (ds.Tables[0].Rows.Count == 0)
            {
                LblMessage.Text = "此表无数据，请检查！";
            }else
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
                LblMessage.Text = "请检查数据完整性，并且保证第一列为公司名称，第二列为姓名";
                Button1.Enabled = true;
            }

        }



        //// <summary>
        /// 从Excel提取数据--》Dataset
        /// </summary>
        /// <param name="filename">Excel文件路径名</param>
        private void ImportXlsToData(string fileName)
        {
            try
            {
                if (fileName == string.Empty) 
                {                     
                    throw new ArgumentNullException("Excel文件上传失败！");
                }
                
                string oleDBConnString = String.Empty; 
                oleDBConnString = "Provider=Microsoft.Jet.OLEDB.4.0;"; 
                oleDBConnString += "Data Source="; 
                oleDBConnString += fileName; 
                oleDBConnString += ";Extended Properties=Excel 8.0;";                 
                OleDbConnection oleDBConn = null; 
                OleDbDataAdapter oleAdMaster = null; 
                DataTable m_tableName=new DataTable();
                DataSet ds=new DataSet(); 

                oleDBConn = new OleDbConnection(oleDBConnString); 
                oleDBConn.Open(); 
                m_tableName=oleDBConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,null); 

                if (m_tableName != null && m_tableName.Rows.Count > 0) 
                { 

                    m_tableName.TableName =m_tableName.Rows[0]["TABLE_NAME"].ToString(); 

                } 
                string sqlMaster; 
                sqlMaster=" SELECT *  FROM ["+m_tableName.TableName+"]"; 
                oleAdMaster=new OleDbDataAdapter(sqlMaster,oleDBConn); 
                oleAdMaster.Fill(ds,"m_tableName"); 
                oleAdMaster.Dispose();
                oleDBConn.Close();
                oleDBConn.Dispose();
                GridView1.DataSource = ds;
                GridView1.DataBind();
                //AddDatasetToSQL(ds,14);
            }
            catch(Exception ex)
            {
                throw ex;        
            }
        }
        
        /// <summary>
        /// 上传Excel文件
        /// </summary>
        /// <param name="inputfile">上传的控件名</param>
        /// <returns></returns>
        private string UpLoadXls(System.Web.UI.HtmlControls.HtmlInputFile inputfile)
        {
            string orifilename = string.Empty;
            string uploadfilepath = string.Empty;
            string modifyfilename = string.Empty;
            string fileExtend = "" ;//文件扩展名
            int fileSize = 0;//文件大小
            try
            {
                if(inputfile.Value != string.Empty)
                {
                    //得到文件的大小
                    fileSize = inputfile.PostedFile.ContentLength;
                    if(fileSize == 0 )
                    {
                        throw new Exception("导入的Excel文件大小为0，请检查是否正确！");
                    }
                    //得到扩展名
                    fileExtend = inputfile.Value.Substring(inputfile.Value.LastIndexOf(".")+1);
                    if (fileExtend.ToLower() != "xls" && fileExtend.ToLower() != "xlsx")
                    {                        
                        throw new Exception("你选择的文件格式不正确，只能导入EXCEL文件！");
                    }
                    //路径
                    uploadfilepath = Server.MapPath("~/Service/GraduateChannel/GraduateApply/ImgUpLoads");
                    //新文件名
                    modifyfilename = System.Guid.NewGuid().ToString();
                    modifyfilename += "."+inputfile.Value.Substring(inputfile.Value.LastIndexOf(".")+1);
                    //判断是否有该目录
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(uploadfilepath);                    
                    if (!dir.Exists)
                    {
                        dir.Create();
                    }
                    orifilename = uploadfilepath+"\\"+modifyfilename;
                    //如果存在,删除文件
                    if(File.Exists(orifilename))
                    {
                        File.Delete(orifilename);
                    }
                    // 上传文件
                    inputfile.PostedFile.SaveAs(orifilename);
                }
                else
                {
                    throw new Exception("请选择要导入的Excel文件!");                        
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return orifilename;
        }
        



        protected void BtnImport_Click1(object sender, EventArgs e)
        {
            string filename = string.Empty;
            try
            {
                filename = UpLoadXls(FileExcel);//上传XLS文件
                ExcelToDS(filename);
                //ImportXlsToData(filename);//将XLS文件的数据导入数据库                
                if (filename != string.Empty && System.IO.File.Exists(filename))
                {
                    System.IO.File.Delete(filename);//删除上传的XLS文件
                }
                LblMessage.Text = "数据导入成功！";
            }
            catch (Exception ex)
            {

                Label1.Text= ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str_name = "";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                str_name += GridView1.Rows[i].Cells[0].Text.ToString() + "," + GridView1.Rows[i].Cells[1].Text.ToString() + ";";
            }
            Session["str_name"] = str_name;
            Response.Redirect("print_name3.aspx");
        }
    
        }

}