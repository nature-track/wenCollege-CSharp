﻿/**  版本信息模板在安装目录下，可自行修改。
* wuzi_diaoyong.cs
*
* 功 能： N/A
* 类 名： wuzi_diaoyong
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-11-14 15:36:08   N/A    初版
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
	/// 数据访问类:wuzi_diaoyong
	/// </summary>
	public partial class wuzi_diaoyong
	{
		public wuzi_diaoyong()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.wuzi_diaoyong model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into wuzi_diaoyong(");
			strSql.Append("wuzi_id,fengongsi,num,peixunbanid,style,time,beizhu,beizhu2)");
			strSql.Append(" values (");
			strSql.Append("@wuzi_id,@fengongsi,@num,@peixunbanid,@style,@time,@beizhu,@beizhu2)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@wuzi_id", SqlDbType.Int,4),
					new SqlParameter("@fengongsi", SqlDbType.NChar,50),
					new SqlParameter("@num", SqlDbType.Int,4),
					new SqlParameter("@peixunbanid", SqlDbType.Int,4),
					new SqlParameter("@style", SqlDbType.Int,4),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@beizhu", SqlDbType.Text),
					new SqlParameter("@beizhu2", SqlDbType.Text)};
			parameters[0].Value = model.wuzi_id;
			parameters[1].Value = model.fengongsi;
			parameters[2].Value = model.num;
			parameters[3].Value = model.peixunbanid;
			parameters[4].Value = model.style;
			parameters[5].Value = model.time;
			parameters[6].Value = model.beizhu;
			parameters[7].Value = model.beizhu2;

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
		public bool Update(Maticsoft.Model.wuzi_diaoyong model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update wuzi_diaoyong set ");
			strSql.Append("wuzi_id=@wuzi_id,");
			strSql.Append("fengongsi=@fengongsi,");
			strSql.Append("num=@num,");
			strSql.Append("peixunbanid=@peixunbanid,");
			strSql.Append("style=@style,");
			strSql.Append("time=@time,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("beizhu2=@beizhu2");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@wuzi_id", SqlDbType.Int,4),
					new SqlParameter("@fengongsi", SqlDbType.NChar,50),
					new SqlParameter("@num", SqlDbType.Int,4),
					new SqlParameter("@peixunbanid", SqlDbType.Int,4),
					new SqlParameter("@style", SqlDbType.Int,4),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@beizhu", SqlDbType.Text),
					new SqlParameter("@beizhu2", SqlDbType.Text),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.wuzi_id;
			parameters[1].Value = model.fengongsi;
			parameters[2].Value = model.num;
			parameters[3].Value = model.peixunbanid;
			parameters[4].Value = model.style;
			parameters[5].Value = model.time;
			parameters[6].Value = model.beizhu;
			parameters[7].Value = model.beizhu2;
			parameters[8].Value = model.id;

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
			strSql.Append("delete from wuzi_diaoyong ");
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
			strSql.Append("delete from wuzi_diaoyong ");
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
		public Maticsoft.Model.wuzi_diaoyong GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,wuzi_id,fengongsi,num,peixunbanid,style,time,beizhu,beizhu2 from wuzi_diaoyong ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.wuzi_diaoyong model=new Maticsoft.Model.wuzi_diaoyong();
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
		public Maticsoft.Model.wuzi_diaoyong DataRowToModel(DataRow row)
		{
			Maticsoft.Model.wuzi_diaoyong model=new Maticsoft.Model.wuzi_diaoyong();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["wuzi_id"]!=null && row["wuzi_id"].ToString()!="")
				{
					model.wuzi_id=int.Parse(row["wuzi_id"].ToString());
				}
				if(row["fengongsi"]!=null)
				{
					model.fengongsi=row["fengongsi"].ToString();
				}
				if(row["num"]!=null && row["num"].ToString()!="")
				{
					model.num=int.Parse(row["num"].ToString());
				}
				if(row["peixunbanid"]!=null && row["peixunbanid"].ToString()!="")
				{
					model.peixunbanid=int.Parse(row["peixunbanid"].ToString());
				}
				if(row["style"]!=null && row["style"].ToString()!="")
				{
					model.style=int.Parse(row["style"].ToString());
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
				}
				if(row["beizhu2"]!=null)
				{
					model.beizhu2=row["beizhu2"].ToString();
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
			strSql.Append("select id,wuzi_id,fengongsi,num,peixunbanid,style,time,beizhu,beizhu2 ");
			strSql.Append(" FROM wuzi_diaoyong ");
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
			strSql.Append(" id,wuzi_id,fengongsi,num,peixunbanid,style,time,beizhu,beizhu2 ");
			strSql.Append(" FROM wuzi_diaoyong ");
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
			strSql.Append("select count(1) FROM wuzi_diaoyong ");
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
			strSql.Append(")AS Row, T.*  from wuzi_diaoyong T ");
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
			parameters[0].Value = "wuzi_diaoyong";
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
        public DataTable wuzidiaoyong_view(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  [id],[name],[fengongsi] ,[num],[danjia],[peixunban] ,[time] ,[peixunbanid],[style] FROM [bds238528155_db].[dbo].[wuzidiaoyong_View]");
            if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
		#endregion  ExtensionMethod
	}
}

