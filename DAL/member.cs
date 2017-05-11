/**  版本信息模板在安装目录下，可自行修改。
* member.cs
*
* 功 能： N/A
* 类 名： member
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-1-25 15:48:25   N/A    初版
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
	/// 数据访问类:member
	/// </summary>
	public partial class member
	{
		public member()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into member(");
			strSql.Append("openid,name,peixunban_id,fenzu_id,style,phone,name2,time,beizhu1,beizhu2,beizhu3)");
			strSql.Append(" values (");
			strSql.Append("@openid,@name,@peixunban_id,@fenzu_id,@style,@phone,@name2,@time,@beizhu1,@beizhu2,@beizhu3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@openid", SqlDbType.NChar,50),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@style", SqlDbType.NChar,10),
					new SqlParameter("@phone", SqlDbType.NChar,50),
					new SqlParameter("@name2", SqlDbType.NChar,50),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@beizhu1", SqlDbType.NChar,50),
					new SqlParameter("@beizhu2", SqlDbType.Text),
					new SqlParameter("@beizhu3", SqlDbType.Text)};
			parameters[0].Value = model.openid;
			parameters[1].Value = model.name;
			parameters[2].Value = model.peixunban_id;
			parameters[3].Value = model.fenzu_id;
			parameters[4].Value = model.style;
			parameters[5].Value = model.phone;
			parameters[6].Value = model.name2;
			parameters[7].Value = model.time;
			parameters[8].Value = model.beizhu1;
			parameters[9].Value = model.beizhu2;
			parameters[10].Value = model.beizhu3;

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
		public bool Update(Maticsoft.Model.member model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update member set ");
			strSql.Append("openid=@openid,");
			strSql.Append("name=@name,");
			strSql.Append("peixunban_id=@peixunban_id,");
			strSql.Append("fenzu_id=@fenzu_id,");
			strSql.Append("style=@style,");
			strSql.Append("phone=@phone,");
			strSql.Append("name2=@name2,");
			strSql.Append("time=@time,");
			strSql.Append("beizhu1=@beizhu1,");
			strSql.Append("beizhu2=@beizhu2,");
			strSql.Append("beizhu3=@beizhu3");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@openid", SqlDbType.NChar,50),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@style", SqlDbType.NChar,10),
					new SqlParameter("@phone", SqlDbType.NChar,50),
					new SqlParameter("@name2", SqlDbType.NChar,50),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@beizhu1", SqlDbType.NChar,50),
					new SqlParameter("@beizhu2", SqlDbType.Text),
					new SqlParameter("@beizhu3", SqlDbType.Text),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.openid;
			parameters[1].Value = model.name;
			parameters[2].Value = model.peixunban_id;
			parameters[3].Value = model.fenzu_id;
			parameters[4].Value = model.style;
			parameters[5].Value = model.phone;
			parameters[6].Value = model.name2;
			parameters[7].Value = model.time;
			parameters[8].Value = model.beizhu1;
			parameters[9].Value = model.beizhu2;
			parameters[10].Value = model.beizhu3;
			parameters[11].Value = model.id;

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
			strSql.Append("delete from member ");
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
			strSql.Append("delete from member ");
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
		public Maticsoft.Model.member GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,openid,name,peixunban_id,fenzu_id,style,phone,name2,time,beizhu1,beizhu2,beizhu3 from member ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.member model=new Maticsoft.Model.member();
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
		public Maticsoft.Model.member DataRowToModel(DataRow row)
		{
			Maticsoft.Model.member model=new Maticsoft.Model.member();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["openid"]!=null)
				{
					model.openid=row["openid"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["peixunban_id"]!=null && row["peixunban_id"].ToString()!="")
				{
					model.peixunban_id=int.Parse(row["peixunban_id"].ToString());
				}
				if(row["fenzu_id"]!=null && row["fenzu_id"].ToString()!="")
				{
					model.fenzu_id=int.Parse(row["fenzu_id"].ToString());
				}
				if(row["style"]!=null)
				{
					model.style=row["style"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["name2"]!=null)
				{
					model.name2=row["name2"].ToString();
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
				}
				if(row["beizhu1"]!=null)
				{
					model.beizhu1=row["beizhu1"].ToString();
				}
				if(row["beizhu2"]!=null)
				{
					model.beizhu2=row["beizhu2"].ToString();
				}
				if(row["beizhu3"]!=null)
				{
					model.beizhu3=row["beizhu3"].ToString();
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
			strSql.Append("select id,openid,name,peixunban_id,fenzu_id,style,phone,name2,time,beizhu1,beizhu2,beizhu3 ");
			strSql.Append(" FROM member ");
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
			strSql.Append(" id,openid,name,peixunban_id,fenzu_id,style,phone,name2,time,beizhu1,beizhu2,beizhu3 ");
			strSql.Append(" FROM member ");
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
			strSql.Append("select count(1) FROM member ");
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
			strSql.Append(")AS Row, T.*  from member T ");
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
			parameters[0].Value = "member";
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

