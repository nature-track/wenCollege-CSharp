/**  版本信息模板在安装目录下，可自行修改。
* wuzi.cs
*
* 功 能： N/A
* 类 名： wuzi
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-11-14 16:19:33   N/A    初版
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
	/// 数据访问类:wuzi
	/// </summary>
	public partial class wuzi
	{
		public wuzi()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.wuzi model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into wuzi(");
			strSql.Append("name,gongyingshang,person,phone,beizhu,danjia,beizhu2,style,danwei)");
			strSql.Append(" values (");
			strSql.Append("@name,@gongyingshang,@person,@phone,@beizhu,@danjia,@beizhu2,@style,@danwei)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@gongyingshang", SqlDbType.NVarChar,50),
					new SqlParameter("@person", SqlDbType.NVarChar,50),
					new SqlParameter("@phone", SqlDbType.NVarChar,50),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,50),
					new SqlParameter("@danjia", SqlDbType.Money,8),
					new SqlParameter("@beizhu2", SqlDbType.Text),
					new SqlParameter("@style", SqlDbType.Int,4),
					new SqlParameter("@danwei", SqlDbType.NChar,10)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.gongyingshang;
			parameters[2].Value = model.person;
			parameters[3].Value = model.phone;
			parameters[4].Value = model.beizhu;
			parameters[5].Value = model.danjia;
			parameters[6].Value = model.beizhu2;
			parameters[7].Value = model.style;
			parameters[8].Value = model.danwei;

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
		public bool Update(Maticsoft.Model.wuzi model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update wuzi set ");
			strSql.Append("name=@name,");
			strSql.Append("gongyingshang=@gongyingshang,");
			strSql.Append("person=@person,");
			strSql.Append("phone=@phone,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("danjia=@danjia,");
			strSql.Append("beizhu2=@beizhu2,");
			strSql.Append("style=@style,");
			strSql.Append("danwei=@danwei");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@gongyingshang", SqlDbType.NVarChar,50),
					new SqlParameter("@person", SqlDbType.NVarChar,50),
					new SqlParameter("@phone", SqlDbType.NVarChar,50),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,50),
					new SqlParameter("@danjia", SqlDbType.Money,8),
					new SqlParameter("@beizhu2", SqlDbType.Text),
					new SqlParameter("@style", SqlDbType.Int,4),
					new SqlParameter("@danwei", SqlDbType.NChar,10),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.gongyingshang;
			parameters[2].Value = model.person;
			parameters[3].Value = model.phone;
			parameters[4].Value = model.beizhu;
			parameters[5].Value = model.danjia;
			parameters[6].Value = model.beizhu2;
			parameters[7].Value = model.style;
			parameters[8].Value = model.danwei;
			parameters[9].Value = model.id;

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
			strSql.Append("delete from wuzi ");
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
			strSql.Append("delete from wuzi ");
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
		public Maticsoft.Model.wuzi GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,gongyingshang,person,phone,beizhu,danjia,beizhu2,style,danwei from wuzi ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.wuzi model=new Maticsoft.Model.wuzi();
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
		public Maticsoft.Model.wuzi DataRowToModel(DataRow row)
		{
			Maticsoft.Model.wuzi model=new Maticsoft.Model.wuzi();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["gongyingshang"]!=null)
				{
					model.gongyingshang=row["gongyingshang"].ToString();
				}
				if(row["person"]!=null)
				{
					model.person=row["person"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
				}
				if(row["danjia"]!=null && row["danjia"].ToString()!="")
				{
					model.danjia=decimal.Parse(row["danjia"].ToString());
				}
				if(row["beizhu2"]!=null)
				{
					model.beizhu2=row["beizhu2"].ToString();
				}
				if(row["style"]!=null && row["style"].ToString()!="")
				{
					model.style=int.Parse(row["style"].ToString());
				}
				if(row["danwei"]!=null)
				{
					model.danwei=row["danwei"].ToString();
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
			strSql.Append("select id,name,gongyingshang,person,phone,beizhu,danjia,beizhu2,style,danwei ");
			strSql.Append(" FROM wuzi ");
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
			strSql.Append(" id,name,gongyingshang,person,phone,beizhu,danjia,beizhu2,style,danwei ");
			strSql.Append(" FROM wuzi ");
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
			strSql.Append("select count(1) FROM wuzi ");
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
			strSql.Append(")AS Row, T.*  from wuzi T ");
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
			parameters[0].Value = "wuzi";
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

