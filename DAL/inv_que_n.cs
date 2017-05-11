﻿/**  版本信息模板在安装目录下，可自行修改。
* inv_que_n.cs
*
* 功 能： N/A
* 类 名： inv_que_n
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-2-1 16:05:21   N/A    初版
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
	/// 数据访问类:inv_que_n
	/// </summary>
	public partial class inv_que_n
	{
		public inv_que_n()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.inv_que_n model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into inv_que_n(");
			strSql.Append("title,subtitle,name,style,time,beizhu)");
			strSql.Append(" values (");
			strSql.Append("@title,@subtitle,@name,@style,@time,@beizhu)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.Text),
					new SqlParameter("@subtitle", SqlDbType.Text),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@style", SqlDbType.NChar,10),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@beizhu", SqlDbType.NChar,50)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.subtitle;
			parameters[2].Value = model.name;
			parameters[3].Value = model.style;
			parameters[4].Value = model.time;
			parameters[5].Value = model.beizhu;

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
		public bool Update(Maticsoft.Model.inv_que_n model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update inv_que_n set ");
			strSql.Append("title=@title,");
			strSql.Append("subtitle=@subtitle,");
			strSql.Append("name=@name,");
			strSql.Append("style=@style,");
			strSql.Append("time=@time,");
			strSql.Append("beizhu=@beizhu");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.Text),
					new SqlParameter("@subtitle", SqlDbType.Text),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@style", SqlDbType.NChar,10),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@beizhu", SqlDbType.NChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.title;
			parameters[1].Value = model.subtitle;
			parameters[2].Value = model.name;
			parameters[3].Value = model.style;
			parameters[4].Value = model.time;
			parameters[5].Value = model.beizhu;
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
			strSql.Append("delete from inv_que_n ");
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
			strSql.Append("delete from inv_que_n ");
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
		public Maticsoft.Model.inv_que_n GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,title,subtitle,name,style,time,beizhu from inv_que_n ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.inv_que_n model=new Maticsoft.Model.inv_que_n();
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
		public Maticsoft.Model.inv_que_n DataRowToModel(DataRow row)
		{
			Maticsoft.Model.inv_que_n model=new Maticsoft.Model.inv_que_n();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["subtitle"]!=null)
				{
					model.subtitle=row["subtitle"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["style"]!=null)
				{
					model.style=row["style"].ToString();
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
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
			strSql.Append("select id,title,subtitle,name,style,time,beizhu ");
			strSql.Append(" FROM inv_que_n ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			strSql.Append(" id,title,subtitle,name,style,time,beizhu ");
			strSql.Append(" FROM inv_que_n ");
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
			strSql.Append("select count(1) FROM inv_que_n ");
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
			strSql.Append(")AS Row, T.*  from inv_que_n T ");
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
			parameters[0].Value = "inv_que_n";
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

		#endregion  ExtensionMethod
	}
}

