/**  版本信息模板在安装目录下，可自行修改。
* fenshu_list_view.cs
*
* 功 能： N/A
* 类 名： fenshu_list_view
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-10-17 20:31:51   N/A    初版
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
	/// 数据访问类:fenshu_list_view
	/// </summary>
	public partial class fenshu_list_view
	{
		public fenshu_list_view()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.fenshu_list_view model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into fenshu_list_view(");
			strSql.Append("id,peixunban,kecheng,jiangshi,text,fenshu,fenzu_id,peixunban_id,shangke_id,dafenbiao_id,neirong)");
			strSql.Append(" values (");
			strSql.Append("@id,@peixunban,@kecheng,@jiangshi,@text,@fenshu,@fenzu_id,@peixunban_id,@shangke_id,@dafenbiao_id,@neirong)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@peixunban", SqlDbType.NChar,50),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@jiangshi", SqlDbType.NChar,10),
					new SqlParameter("@text", SqlDbType.NVarChar,50),
					new SqlParameter("@fenshu", SqlDbType.Float,8),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@shangke_id", SqlDbType.Int,4),
					new SqlParameter("@dafenbiao_id", SqlDbType.Int,4),
					new SqlParameter("@neirong", SqlDbType.Text)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.peixunban;
			parameters[2].Value = model.kecheng;
			parameters[3].Value = model.jiangshi;
			parameters[4].Value = model.text;
			parameters[5].Value = model.fenshu;
			parameters[6].Value = model.fenzu_id;
			parameters[7].Value = model.peixunban_id;
			parameters[8].Value = model.shangke_id;
			parameters[9].Value = model.dafenbiao_id;
			parameters[10].Value = model.neirong;

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
		public bool Update(Maticsoft.Model.fenshu_list_view model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update fenshu_list_view set ");
			strSql.Append("id=@id,");
			strSql.Append("peixunban=@peixunban,");
			strSql.Append("kecheng=@kecheng,");
			strSql.Append("jiangshi=@jiangshi,");
			strSql.Append("text=@text,");
			strSql.Append("fenshu=@fenshu,");
			strSql.Append("fenzu_id=@fenzu_id,");
			strSql.Append("peixunban_id=@peixunban_id,");
			strSql.Append("shangke_id=@shangke_id,");
			strSql.Append("dafenbiao_id=@dafenbiao_id,");
			strSql.Append("neirong=@neirong");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4),
					new SqlParameter("@peixunban", SqlDbType.NChar,50),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@jiangshi", SqlDbType.NChar,10),
					new SqlParameter("@text", SqlDbType.NVarChar,50),
					new SqlParameter("@fenshu", SqlDbType.Float,8),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@shangke_id", SqlDbType.Int,4),
					new SqlParameter("@dafenbiao_id", SqlDbType.Int,4),
					new SqlParameter("@neirong", SqlDbType.Text)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.peixunban;
			parameters[2].Value = model.kecheng;
			parameters[3].Value = model.jiangshi;
			parameters[4].Value = model.text;
			parameters[5].Value = model.fenshu;
			parameters[6].Value = model.fenzu_id;
			parameters[7].Value = model.peixunban_id;
			parameters[8].Value = model.shangke_id;
			parameters[9].Value = model.dafenbiao_id;
			parameters[10].Value = model.neirong;

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
			strSql.Append("delete from fenshu_list_view ");
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
		public Maticsoft.Model.fenshu_list_view GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,peixunban,kecheng,jiangshi,text,fenshu,fenzu_id,peixunban_id,shangke_id,dafenbiao_id,neirong from fenshu_list_view ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Maticsoft.Model.fenshu_list_view model=new Maticsoft.Model.fenshu_list_view();
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
		public Maticsoft.Model.fenshu_list_view DataRowToModel(DataRow row)
		{
			Maticsoft.Model.fenshu_list_view model=new Maticsoft.Model.fenshu_list_view();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
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
				if(row["text"]!=null)
				{
					model.text=row["text"].ToString();
				}
				if(row["fenshu"]!=null && row["fenshu"].ToString()!="")
				{
					model.fenshu=decimal.Parse(row["fenshu"].ToString());
				}
				if(row["fenzu_id"]!=null && row["fenzu_id"].ToString()!="")
				{
					model.fenzu_id=int.Parse(row["fenzu_id"].ToString());
				}
				if(row["peixunban_id"]!=null && row["peixunban_id"].ToString()!="")
				{
					model.peixunban_id=int.Parse(row["peixunban_id"].ToString());
				}
				if(row["shangke_id"]!=null && row["shangke_id"].ToString()!="")
				{
					model.shangke_id=int.Parse(row["shangke_id"].ToString());
				}
				if(row["dafenbiao_id"]!=null && row["dafenbiao_id"].ToString()!="")
				{
					model.dafenbiao_id=int.Parse(row["dafenbiao_id"].ToString());
				}
				if(row["neirong"]!=null)
				{
					model.neirong=row["neirong"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表（已增加open_id name）
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,peixunban,kecheng,jiangshi,text,fenshu,fenzu_id,peixunban_id,shangke_id,dafenbiao_id,neirong,open_id,name ");
			strSql.Append(" FROM fenshu_list_view ");
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
			strSql.Append(" id,peixunban,kecheng,jiangshi,text,fenshu,fenzu_id,peixunban_id,shangke_id,dafenbiao_id,neirong ");
			strSql.Append(" FROM fenshu_list_view ");
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
			strSql.Append("select count(1) FROM fenshu_list_view ");
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
			strSql.Append(")AS Row, T.*  from fenshu_list_view T ");
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
			parameters[0].Value = "fenshu_list_view";
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
        /// <summary>
        /// 获取的是那些11、12题都有写内容的每一节课的信息
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getdistinct_list(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT distinct [peixunban] ,[kecheng] ,[jiangshi] ,[text] ,[peixunban_id] ,[shangke_id],[dafenbiao_id]  FROM [bds238528155_db].[dbo].[fenshu_list_view] where (dafenbiao_id=11 or dafenbiao_id=12)");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
        /// <summary>
        /// 获取的是22-25题
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable getdistinct_list_total(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT distinct [peixunban],[kecheng],[jiangshi],[text],[fenshu] ,[fenzu_id],[peixunban_id],[shangke_id] ,[dafenbiao_id] FROM [bds238528155_db].[dbo].[fenshu_list_view]  where kecheng='培训班整体效果评价' and dafenbiao_id>=22 and dafenbiao_id<=25");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and" + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }

        public DataTable get_yuanyi(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select neirong  FROM fenshu_list_view where dafenbiao_id=21 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and" + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
        }
		#endregion  ExtensionMethod
	}
}

