/**  版本信息模板在安装目录下，可自行修改。
* account_detail.cs
*
* 功 能： N/A
* 类 名： account_detail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-11-6 15:59:31   N/A    初版
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
	/// 数据访问类:account_detail
	/// </summary>
	public partial class account_detail
	{
		public account_detail()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.account_detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into account_detail(");
			strSql.Append("wuzi,danwei,danjia,shuliang,account_id,wuzi_id,beizhu,beizhu2,beizhu3)");
			strSql.Append(" values (");
			strSql.Append("@wuzi,@danwei,@danjia,@shuliang,@account_id,@wuzi_id,@beizhu,@beizhu2,@beizhu3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@wuzi", SqlDbType.NChar,50),
					new SqlParameter("@danwei", SqlDbType.NChar,10),
					new SqlParameter("@danjia", SqlDbType.Money,8),
					new SqlParameter("@shuliang", SqlDbType.Int,4),
					new SqlParameter("@account_id", SqlDbType.Int,4),
					new SqlParameter("@wuzi_id", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.NChar,50),
					new SqlParameter("@beizhu2", SqlDbType.NChar,50),
					new SqlParameter("@beizhu3", SqlDbType.NChar,50)};
			parameters[0].Value = model.wuzi;
			parameters[1].Value = model.danwei;
			parameters[2].Value = model.danjia;
			parameters[3].Value = model.shuliang;
			parameters[4].Value = model.account_id;
			parameters[5].Value = model.wuzi_id;
			parameters[6].Value = model.beizhu;
			parameters[7].Value = model.beizhu2;
			parameters[8].Value = model.beizhu3;

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
		public bool Update(Maticsoft.Model.account_detail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update account_detail set ");
			strSql.Append("wuzi=@wuzi,");
			strSql.Append("danwei=@danwei,");
			strSql.Append("danjia=@danjia,");
			strSql.Append("shuliang=@shuliang,");
			strSql.Append("account_id=@account_id,");
			strSql.Append("wuzi_id=@wuzi_id,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("beizhu2=@beizhu2,");
			strSql.Append("beizhu3=@beizhu3");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@wuzi", SqlDbType.NChar,50),
					new SqlParameter("@danwei", SqlDbType.NChar,10),
					new SqlParameter("@danjia", SqlDbType.Money,8),
					new SqlParameter("@shuliang", SqlDbType.Int,4),
					new SqlParameter("@account_id", SqlDbType.Int,4),
					new SqlParameter("@wuzi_id", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.NChar,50),
					new SqlParameter("@beizhu2", SqlDbType.NChar,50),
					new SqlParameter("@beizhu3", SqlDbType.NChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.wuzi;
			parameters[1].Value = model.danwei;
			parameters[2].Value = model.danjia;
			parameters[3].Value = model.shuliang;
			parameters[4].Value = model.account_id;
			parameters[5].Value = model.wuzi_id;
			parameters[6].Value = model.beizhu;
			parameters[7].Value = model.beizhu2;
			parameters[8].Value = model.beizhu3;
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
			strSql.Append("delete from account_detail ");
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
			strSql.Append("delete from account_detail ");
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
		public Maticsoft.Model.account_detail GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,wuzi,danwei,danjia,shuliang,account_id,wuzi_id,beizhu,beizhu2,beizhu3 from account_detail ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.account_detail model=new Maticsoft.Model.account_detail();
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
		public Maticsoft.Model.account_detail DataRowToModel(DataRow row)
		{
			Maticsoft.Model.account_detail model=new Maticsoft.Model.account_detail();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["wuzi"]!=null)
				{
					model.wuzi=row["wuzi"].ToString();
				}
				if(row["danwei"]!=null)
				{
					model.danwei=row["danwei"].ToString();
				}
				if(row["danjia"]!=null && row["danjia"].ToString()!="")
				{
					model.danjia=decimal.Parse(row["danjia"].ToString());
				}
				if(row["shuliang"]!=null && row["shuliang"].ToString()!="")
				{
					model.shuliang=int.Parse(row["shuliang"].ToString());
				}
				if(row["account_id"]!=null && row["account_id"].ToString()!="")
				{
					model.account_id=int.Parse(row["account_id"].ToString());
				}
				if(row["wuzi_id"]!=null && row["wuzi_id"].ToString()!="")
				{
					model.wuzi_id=int.Parse(row["wuzi_id"].ToString());
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
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
			strSql.Append("select id,wuzi,danwei,danjia,shuliang,account_id,wuzi_id,beizhu,beizhu2,beizhu3 ");
			strSql.Append(" FROM account_detail ");
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
			strSql.Append(" id,wuzi,danwei,danjia,shuliang,account_id,wuzi_id,beizhu,beizhu2,beizhu3 ");
			strSql.Append(" FROM account_detail ");
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
			strSql.Append("select count(1) FROM account_detail ");
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
			strSql.Append(")AS Row, T.*  from account_detail T ");
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
			parameters[0].Value = "account_detail";
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
        public DataTable select_wuzi()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  distinct [wuzi] FROM [bds238528155_db].[dbo].[account_detail]");
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
		#endregion  ExtensionMethod
	}
}

