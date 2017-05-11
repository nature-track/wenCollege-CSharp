/**  版本信息模板在安装目录下，可自行修改。
* shangke_view.cs
*
* 功 能： N/A
* 类 名： shangke_view
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-10-8 17:50:04   N/A    初版
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
	/// 数据访问类:shangke_view
	/// </summary>
	public partial class shangke_view
	{
		public shangke_view()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.shangke_view model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shangke_view(");
			strSql.Append("id,kechengneirong_id,peixunban,peixunban_id,kecheng,jiangshi_id,jiangshi,keshi)");
			strSql.Append(" values (");
			strSql.Append("@id,@kechengneirong_id,@peixunban,@peixunban_id,@kecheng,@jiangshi_id,@jiangshi,@keshi)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@kechengneirong_id", SqlDbType.Int,4),
					new SqlParameter("@peixunban", SqlDbType.NChar,50),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@jiangshi_id", SqlDbType.Int,4),
					new SqlParameter("@jiangshi", SqlDbType.NChar,10),
					new SqlParameter("@keshi", SqlDbType.Float,8)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.kechengneirong_id;
			parameters[2].Value = model.peixunban;
			parameters[3].Value = model.peixunban_id;
			parameters[4].Value = model.kecheng;
			parameters[5].Value = model.jiangshi_id;
			parameters[6].Value = model.jiangshi;
			parameters[7].Value = model.keshi;

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
		public bool Update(Maticsoft.Model.shangke_view model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shangke_view set ");
			strSql.Append("id=@id,");
			strSql.Append("kechengneirong_id=@kechengneirong_id,");
			strSql.Append("peixunban=@peixunban,");
			strSql.Append("peixunban_id=@peixunban_id,");
			strSql.Append("kecheng=@kecheng,");
			strSql.Append("jiangshi_id=@jiangshi_id,");
			strSql.Append("jiangshi=@jiangshi,");
			strSql.Append("keshi=@keshi");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@kechengneirong_id", SqlDbType.Int,4),
					new SqlParameter("@peixunban", SqlDbType.NChar,50),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@jiangshi_id", SqlDbType.Int,4),
					new SqlParameter("@jiangshi", SqlDbType.NChar,10),
					new SqlParameter("@keshi", SqlDbType.Float,8)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.kechengneirong_id;
			parameters[2].Value = model.peixunban;
			parameters[3].Value = model.peixunban_id;
			parameters[4].Value = model.kecheng;
			parameters[5].Value = model.jiangshi_id;
			parameters[6].Value = model.jiangshi;
			parameters[7].Value = model.keshi;

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
			strSql.Append("delete from shangke_view ");
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
		public Maticsoft.Model.shangke_view GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,kechengneirong_id,peixunban,peixunban_id,kecheng,jiangshi_id,jiangshi,keshi from shangke_view ");
            //strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.shangke_view model=new Maticsoft.Model.shangke_view();
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
        /// 得到一个对象实体，通过id
        /// </summary>
        public Maticsoft.Model.shangke_view GetModel(int id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,kechengneirong_id,peixunban,peixunban_id,kecheng,jiangshi_id,jiangshi,keshi from shangke_view ");
            strSql.Append(" where id="+id);


            Maticsoft.Model.shangke_view model = new Maticsoft.Model.shangke_view();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
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
		public Maticsoft.Model.shangke_view DataRowToModel(DataRow row)
		{
			Maticsoft.Model.shangke_view model=new Maticsoft.Model.shangke_view();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["kechengneirong_id"]!=null && row["kechengneirong_id"].ToString()!="")
				{
					model.kechengneirong_id=int.Parse(row["kechengneirong_id"].ToString());
				}
				if(row["peixunban"]!=null)
				{
					model.peixunban=row["peixunban"].ToString();
				}
				if(row["peixunban_id"]!=null && row["peixunban_id"].ToString()!="")
				{
					model.peixunban_id=int.Parse(row["peixunban_id"].ToString());
				}
				if(row["kecheng"]!=null)
				{
					model.kecheng=row["kecheng"].ToString();
				}
				if(row["jiangshi_id"]!=null && row["jiangshi_id"].ToString()!="")
				{
					model.jiangshi_id=int.Parse(row["jiangshi_id"].ToString());
				}
				if(row["jiangshi"]!=null)
				{
					model.jiangshi=row["jiangshi"].ToString();
				}
				if(row["keshi"]!=null && row["keshi"].ToString()!="")
				{
					model.keshi=decimal.Parse(row["keshi"].ToString());
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
			strSql.Append("select id,kechengneirong_id,peixunban,peixunban_id,kecheng,jiangshi_id,jiangshi,keshi ");
			strSql.Append(" FROM shangke_view ");
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
			strSql.Append(" id,kechengneirong_id,peixunban,peixunban_id,kecheng,jiangshi_id,jiangshi,keshi ");
			strSql.Append(" FROM shangke_view ");
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
			strSql.Append("select count(1) FROM shangke_view ");
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
			strSql.Append(")AS Row, T.*  from shangke_view T ");
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
			parameters[0].Value = "shangke_view";
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

