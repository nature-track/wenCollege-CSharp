/**  版本信息模板在安装目录下，可自行修改。
* fenshu_tongji.cs
*
* 功 能： N/A
* 类 名： fenshu_tongji
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-7-1 14:38:00   N/A    初版
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
	/// 数据访问类:fenshu_tongji
	/// </summary>
	public partial class fenshu_tongji
	{
		public fenshu_tongji()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.fenshu_tongji model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into fenshu_tongji(");
			strSql.Append("peixunban,kecheng,jiangshi,pingjunfen)");
			strSql.Append(" values (");
			strSql.Append("@peixunban,@kecheng,@jiangshi,@pingjunfen)");
			SqlParameter[] parameters = {
					new SqlParameter("@peixunban", SqlDbType.NChar,10),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@jiangshi", SqlDbType.NChar,10),
					new SqlParameter("@pingjunfen", SqlDbType.Float,8)};
			parameters[0].Value = model.peixunban;
			parameters[1].Value = model.kecheng;
			parameters[2].Value = model.jiangshi;
			parameters[3].Value = model.pingjunfen;

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
		public bool Update(Maticsoft.Model.fenshu_tongji model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update fenshu_tongji set ");
			strSql.Append("peixunban=@peixunban,");
			strSql.Append("kecheng=@kecheng,");
			strSql.Append("jiangshi=@jiangshi,");
			strSql.Append("pingjunfen=@pingjunfen");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@peixunban", SqlDbType.NChar,10),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@jiangshi", SqlDbType.NChar,10),
					new SqlParameter("@pingjunfen", SqlDbType.Float,8)};
			parameters[0].Value = model.peixunban;
			parameters[1].Value = model.kecheng;
			parameters[2].Value = model.jiangshi;
			parameters[3].Value = model.pingjunfen;

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
			strSql.Append("delete from fenshu_tongji ");
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
		public Maticsoft.Model.fenshu_tongji GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 peixunban,kecheng,jiangshi,pingjunfen from fenshu_tongji ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.fenshu_tongji model=new Maticsoft.Model.fenshu_tongji();
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
		public Maticsoft.Model.fenshu_tongji DataRowToModel(DataRow row)
		{
			Maticsoft.Model.fenshu_tongji model=new Maticsoft.Model.fenshu_tongji();
			if (row != null)
			{
				if(row["peixunban"]!=null)
				{
					model.peixunban=row["peixunban"].ToString();
				}
				if(row["kecheng"]!=null)
				{
					model.kecheng=row["kecheng"].ToString();
				}
				if(row["jiangshi"]!=null)
				{
					model.jiangshi=row["jiangshi"].ToString();
				}
				if(row["pingjunfen"]!=null && row["pingjunfen"].ToString()!="")
				{
					model.pingjunfen=decimal.Parse(row["pingjunfen"].ToString());
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
			strSql.Append("select peixunban,kecheng,jiangshi,pingjunfen ");
			strSql.Append(" FROM fenshu_tongji ");
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
			strSql.Append(" peixunban,kecheng,jiangshi,pingjunfen ");
			strSql.Append(" FROM fenshu_tongji ");
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
			strSql.Append("select count(1) FROM fenshu_tongji ");
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
				strSql.Append("order by T.peixunban_id desc");
			}
			strSql.Append(")AS Row, T.*  from fenshu_tongji T ");
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
			parameters[0].Value = "fenshu_tongji";
			parameters[1].Value = "peixunban_id";
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

