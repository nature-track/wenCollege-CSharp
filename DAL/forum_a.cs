/**  版本信息模板在安装目录下，可自行修改。
* forum_a.cs
*
* 功 能： N/A
* 类 名： forum_a
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-1-4 17:13:15   N/A    初版
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
	/// 数据访问类:forum_a
	/// </summary>
	public partial class forum_a
	{
		public forum_a()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.forum_a model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into forum_a(");
			strSql.Append("id,que_id,name,team,answer,time,password,fenshu,beizhu,beizhu2)");
			strSql.Append(" values (");
			strSql.Append("@id,@que_id,@name,@team,@answer,@time,@password,@fenshu,@beizhu,@beizhu2)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@que_id", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@team", SqlDbType.NChar,50),
					new SqlParameter("@answer", SqlDbType.Text),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@password", SqlDbType.Int,4),
					new SqlParameter("@fenshu", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.NChar,50),
					new SqlParameter("@beizhu2", SqlDbType.Text)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.que_id;
			parameters[2].Value = model.name;
			parameters[3].Value = model.team;
			parameters[4].Value = model.answer;
			parameters[5].Value = model.time;
			parameters[6].Value = model.password;
			parameters[7].Value = model.fenshu;
			parameters[8].Value = model.beizhu;
			parameters[9].Value = model.beizhu2;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.forum_a model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update forum_a set ");
			strSql.Append("id=@id,");
			strSql.Append("que_id=@que_id,");
			strSql.Append("name=@name,");
			strSql.Append("team=@team,");
			strSql.Append("answer=@answer,");
			strSql.Append("time=@time,");
			strSql.Append("password=@password,");
			strSql.Append("fenshu=@fenshu,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("beizhu2=@beizhu2");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@que_id", SqlDbType.Int,4),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@team", SqlDbType.NChar,50),
					new SqlParameter("@answer", SqlDbType.Text),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@password", SqlDbType.Int,4),
					new SqlParameter("@fenshu", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.NChar,50),
					new SqlParameter("@beizhu2", SqlDbType.Text)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.que_id;
			parameters[2].Value = model.name;
			parameters[3].Value = model.team;
			parameters[4].Value = model.answer;
			parameters[5].Value = model.time;
			parameters[6].Value = model.password;
			parameters[7].Value = model.fenshu;
			parameters[8].Value = model.beizhu;
			parameters[9].Value = model.beizhu2;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from forum_a ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.forum_a GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,que_id,name,team,answer,time,password,fenshu,beizhu,beizhu2 from forum_a ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.forum_a model=new Maticsoft.Model.forum_a();
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
		public Maticsoft.Model.forum_a DataRowToModel(DataRow row)
		{
			Maticsoft.Model.forum_a model=new Maticsoft.Model.forum_a();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["que_id"]!=null && row["que_id"].ToString()!="")
				{
					model.que_id=int.Parse(row["que_id"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["team"]!=null)
				{
					model.team=row["team"].ToString();
				}
				if(row["answer"]!=null)
				{
					model.answer=row["answer"].ToString();
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
				}
				if(row["password"]!=null && row["password"].ToString()!="")
				{
					model.password=int.Parse(row["password"].ToString());
				}
				if(row["fenshu"]!=null && row["fenshu"].ToString()!="")
				{
					model.fenshu=int.Parse(row["fenshu"].ToString());
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
			strSql.Append("select id,que_id,name,team,answer,time,password,fenshu,beizhu,beizhu2 ");
			strSql.Append(" FROM forum_a ");
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
			strSql.Append(" id,que_id,name,team,answer,time,password,fenshu,beizhu,beizhu2 ");
			strSql.Append(" FROM forum_a ");
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
			strSql.Append("select count(1) FROM forum_a ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from forum_a T ");
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
			parameters[0].Value = "forum_a";
			parameters[1].Value = "";
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

