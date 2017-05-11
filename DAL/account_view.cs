/**  版本信息模板在安装目录下，可自行修改。
* account_view.cs
*
* 功 能： N/A
* 类 名： account_view
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-12-16 10:22:45   N/A    初版
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
	/// 数据访问类:account_view
	/// </summary>
	public partial class account_view
	{
		public account_view()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.account_view model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into account_view(");
			strSql.Append("account_id,peixunban_id,detail_id,peixunban,lururen,leibei,wuzi,danwei,danjia,shuliang,xiaoji,beizhu,time)");
			strSql.Append(" values (");
			strSql.Append("@account_id,@peixunban_id,@detail_id,@peixunban,@lururen,@leibei,@wuzi,@danwei,@danjia,@shuliang,@xiaoji,@beizhu,@time)");
			SqlParameter[] parameters = {
					new SqlParameter("@account_id", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@detail_id", SqlDbType.Int,4),
					new SqlParameter("@peixunban", SqlDbType.NChar,50),
					new SqlParameter("@lururen", SqlDbType.NChar,10),
					new SqlParameter("@leibei", SqlDbType.NChar,10),
					new SqlParameter("@wuzi", SqlDbType.NChar,50),
					new SqlParameter("@danwei", SqlDbType.NChar,10),
					new SqlParameter("@danjia", SqlDbType.Money,8),
					new SqlParameter("@shuliang", SqlDbType.Int,4),
					new SqlParameter("@xiaoji", SqlDbType.Money,8),
					new SqlParameter("@beizhu", SqlDbType.NChar,50),
					new SqlParameter("@time", SqlDbType.DateTime)};
			parameters[0].Value = model.account_id;
			parameters[1].Value = model.peixunban_id;
			parameters[2].Value = model.detail_id;
			parameters[3].Value = model.peixunban;
			parameters[4].Value = model.lururen;
			parameters[5].Value = model.leibei;
			parameters[6].Value = model.wuzi;
			parameters[7].Value = model.danwei;
			parameters[8].Value = model.danjia;
			parameters[9].Value = model.shuliang;
			parameters[10].Value = model.xiaoji;
			parameters[11].Value = model.beizhu;
			parameters[12].Value = model.time;

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
		public bool Update(Maticsoft.Model.account_view model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update account_view set ");
			strSql.Append("account_id=@account_id,");
			strSql.Append("peixunban_id=@peixunban_id,");
			strSql.Append("detail_id=@detail_id,");
			strSql.Append("peixunban=@peixunban,");
			strSql.Append("lururen=@lururen,");
			strSql.Append("leibei=@leibei,");
			strSql.Append("wuzi=@wuzi,");
			strSql.Append("danwei=@danwei,");
			strSql.Append("danjia=@danjia,");
			strSql.Append("shuliang=@shuliang,");
			strSql.Append("xiaoji=@xiaoji,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("time=@time");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@account_id", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@detail_id", SqlDbType.Int,4),
					new SqlParameter("@peixunban", SqlDbType.NChar,50),
					new SqlParameter("@lururen", SqlDbType.NChar,10),
					new SqlParameter("@leibei", SqlDbType.NChar,10),
					new SqlParameter("@wuzi", SqlDbType.NChar,50),
					new SqlParameter("@danwei", SqlDbType.NChar,10),
					new SqlParameter("@danjia", SqlDbType.Money,8),
					new SqlParameter("@shuliang", SqlDbType.Int,4),
					new SqlParameter("@xiaoji", SqlDbType.Money,8),
					new SqlParameter("@beizhu", SqlDbType.NChar,50),
					new SqlParameter("@time", SqlDbType.DateTime)};
			parameters[0].Value = model.account_id;
			parameters[1].Value = model.peixunban_id;
			parameters[2].Value = model.detail_id;
			parameters[3].Value = model.peixunban;
			parameters[4].Value = model.lururen;
			parameters[5].Value = model.leibei;
			parameters[6].Value = model.wuzi;
			parameters[7].Value = model.danwei;
			parameters[8].Value = model.danjia;
			parameters[9].Value = model.shuliang;
			parameters[10].Value = model.xiaoji;
			parameters[11].Value = model.beizhu;
			parameters[12].Value = model.time;

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
			strSql.Append("delete from account_view ");
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
		public Maticsoft.Model.account_view GetModel(int detail_id)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 account_id,peixunban_id,detail_id,peixunban,lururen,leibei,wuzi,danwei,danjia,shuliang,xiaoji,beizhu,time from account_view ");
            strSql.Append(" where detail_id=");
            strSql.Append(detail_id);

			Maticsoft.Model.account_view model=new Maticsoft.Model.account_view();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
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
		public Maticsoft.Model.account_view DataRowToModel(DataRow row)
		{
			Maticsoft.Model.account_view model=new Maticsoft.Model.account_view();
			if (row != null)
			{
				if(row["account_id"]!=null && row["account_id"].ToString()!="")
				{
					model.account_id=int.Parse(row["account_id"].ToString());
				}
				if(row["peixunban_id"]!=null && row["peixunban_id"].ToString()!="")
				{
					model.peixunban_id=int.Parse(row["peixunban_id"].ToString());
				}
				if(row["detail_id"]!=null && row["detail_id"].ToString()!="")
				{
					model.detail_id=int.Parse(row["detail_id"].ToString());
				}
				if(row["peixunban"]!=null)
				{
					model.peixunban=row["peixunban"].ToString();
				}
				if(row["lururen"]!=null)
				{
					model.lururen=row["lururen"].ToString();
				}
				if(row["leibei"]!=null)
				{
					model.leibei=row["leibei"].ToString();
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
				if(row["xiaoji"]!=null && row["xiaoji"].ToString()!="")
				{
					model.xiaoji=decimal.Parse(row["xiaoji"].ToString());
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
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
			strSql.Append("select account_id,peixunban_id,detail_id,peixunban,lururen,leibei,wuzi,danwei,danjia,shuliang,xiaoji,beizhu,time ");
			strSql.Append(" FROM account_view ");
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
			strSql.Append(" account_id,peixunban_id,detail_id,peixunban,lururen,leibei,wuzi,danwei,danjia,shuliang,xiaoji,beizhu,time ");
			strSql.Append(" FROM account_view ");
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
			strSql.Append("select count(1) FROM account_view ");
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
			strSql.Append(")AS Row, T.*  from account_view T ");
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
			parameters[0].Value = "account_view";
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

