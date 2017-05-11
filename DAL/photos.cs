/**  版本信息模板在安装目录下，可自行修改。
* photos.cs
*
* 功 能： N/A
* 类 名： photos
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/1 8:35:09   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:photos
	/// </summary>
	public partial class photos
	{
		public photos()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.photos model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into photos(");
			strSql.Append("ContentType,postedFileFileName,FileName,fileExtension,qishu,fenlei2)");
			strSql.Append(" values (");
			strSql.Append("@ContentType,@postedFileFileName,@FileName,@fileExtension,@qishu,@fenlei2)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ContentType", SqlDbType.NVarChar,50),
					new SqlParameter("@postedFileFileName", SqlDbType.NVarChar,50),
					new SqlParameter("@FileName", SqlDbType.NVarChar,50),
					new SqlParameter("@fileExtension", SqlDbType.NVarChar,50),
					new SqlParameter("@qishu", SqlDbType.NVarChar,50),
					new SqlParameter("@fenlei2", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ContentType;
			parameters[1].Value = model.postedFileFileName;
			parameters[2].Value = model.FileName;
			parameters[3].Value = model.fileExtension;
			parameters[4].Value = model.qishu;
			parameters[5].Value = model.fenlei2;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.photos model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update photos set ");
			strSql.Append("ContentType=@ContentType,");
			strSql.Append("postedFileFileName=@postedFileFileName,");
			strSql.Append("FileName=@FileName,");
			strSql.Append("fileExtension=@fileExtension,");
			strSql.Append("qishu=@qishu,");
			strSql.Append("fenlei2=@fenlei2");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@ContentType", SqlDbType.NVarChar,50),
					new SqlParameter("@postedFileFileName", SqlDbType.NVarChar,50),
					new SqlParameter("@FileName", SqlDbType.NVarChar,50),
					new SqlParameter("@fileExtension", SqlDbType.NVarChar,50),
					new SqlParameter("@qishu", SqlDbType.NVarChar,50),
					new SqlParameter("@fenlei2", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.ContentType;
			parameters[1].Value = model.postedFileFileName;
			parameters[2].Value = model.FileName;
			parameters[3].Value = model.fileExtension;
			parameters[4].Value = model.qishu;
			parameters[5].Value = model.fenlei2;
			parameters[6].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from photos ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from photos ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.photos GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,ContentType,postedFileFileName,FileName,fileExtension,qishu,fenlei2 from photos ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.photos model=new Maticsoft.Model.photos();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.photos DataRowToModel(DataRow row)
		{
			Maticsoft.Model.photos model=new Maticsoft.Model.photos();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["ContentType"]!=null)
				{
					model.ContentType=row["ContentType"].ToString();
				}
				if(row["postedFileFileName"]!=null)
				{
					model.postedFileFileName=row["postedFileFileName"].ToString();
				}
				if(row["FileName"]!=null)
				{
					model.FileName=row["FileName"].ToString();
				}
				if(row["fileExtension"]!=null)
				{
					model.fileExtension=row["fileExtension"].ToString();
				}
				if(row["qishu"]!=null)
				{
					model.qishu=row["qishu"].ToString();
				}
				if(row["fenlei2"]!=null)
				{
					model.fenlei2=row["fenlei2"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,ContentType,postedFileFileName,FileName,fileExtension,qishu,fenlei2 ");
			strSql.Append(" FROM photos ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        public DataSet get_fenlei(string qishu)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select distinct fenlei2 from photos");
            if (qishu.Trim() != "")
            {
                strSql.Append(" where qishu= '" + qishu + "'");
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,ContentType,postedFileFileName,FileName,fileExtension,qishu,fenlei2 ");
			strSql.Append(" FROM photos ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM photos ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from photos T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "photos";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        public DataSet get_photolist()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from get_photolist");
           
            return DbHelperSQL.Query(strSql.ToString());
        }
		#endregion  ExtensionMethod
	}
}

