/**  版本信息模板在安装目录下，可自行修改。
* dafen_jieguo.cs
*
* 功 能： N/A
* 类 名： dafen_jieguo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-2-3 16:32:26   N/A    初版
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
	/// 数据访问类:dafen_jieguo
	/// </summary>
	public partial class dafen_jieguo
	{
		public dafen_jieguo()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.dafen_jieguo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into dafen_jieguo(");
			strSql.Append("shangke_id,fenzu_id,fenshu,neirong,dafen_xuhao,time,open_id,name,beizhu,style)");
			strSql.Append(" values (");
			strSql.Append("@shangke_id,@fenzu_id,@fenshu,@neirong,@dafen_xuhao,@time,@open_id,@name,@beizhu,@style)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@shangke_id", SqlDbType.Int,4),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@fenshu", SqlDbType.Float,8),
					new SqlParameter("@neirong", SqlDbType.Text),
					new SqlParameter("@dafen_xuhao", SqlDbType.Int,4),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@open_id", SqlDbType.NChar,50),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@beizhu", SqlDbType.NChar,10),
					new SqlParameter("@style", SqlDbType.Int,4)};
			parameters[0].Value = model.shangke_id;
			parameters[1].Value = model.fenzu_id;
			parameters[2].Value = model.fenshu;
			parameters[3].Value = model.neirong;
			parameters[4].Value = model.dafen_xuhao;
			parameters[5].Value = model.time;
			parameters[6].Value = model.open_id;
			parameters[7].Value = model.name;
			parameters[8].Value = model.beizhu;
			parameters[9].Value = model.style;

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
		public bool Update(Maticsoft.Model.dafen_jieguo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update dafen_jieguo set ");
			strSql.Append("shangke_id=@shangke_id,");
			strSql.Append("fenzu_id=@fenzu_id,");
			strSql.Append("fenshu=@fenshu,");
			strSql.Append("neirong=@neirong,");
			strSql.Append("dafen_xuhao=@dafen_xuhao,");
			strSql.Append("time=@time,");
			strSql.Append("open_id=@open_id,");
			strSql.Append("name=@name,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("style=@style");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@shangke_id", SqlDbType.Int,4),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@fenshu", SqlDbType.Float,8),
					new SqlParameter("@neirong", SqlDbType.Text),
					new SqlParameter("@dafen_xuhao", SqlDbType.Int,4),
					new SqlParameter("@time", SqlDbType.DateTime),
					new SqlParameter("@open_id", SqlDbType.NChar,50),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@beizhu", SqlDbType.NChar,10),
					new SqlParameter("@style", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.shangke_id;
			parameters[1].Value = model.fenzu_id;
			parameters[2].Value = model.fenshu;
			parameters[3].Value = model.neirong;
			parameters[4].Value = model.dafen_xuhao;
			parameters[5].Value = model.time;
			parameters[6].Value = model.open_id;
			parameters[7].Value = model.name;
			parameters[8].Value = model.beizhu;
			parameters[9].Value = model.style;
			parameters[10].Value = model.id;

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
			strSql.Append("delete from dafen_jieguo ");
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
			strSql.Append("delete from dafen_jieguo ");
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
		public Maticsoft.Model.dafen_jieguo GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,shangke_id,fenzu_id,fenshu,neirong,dafen_xuhao,time,open_id,name,beizhu,style from dafen_jieguo ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.dafen_jieguo model=new Maticsoft.Model.dafen_jieguo();
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
		public Maticsoft.Model.dafen_jieguo DataRowToModel(DataRow row)
		{
			Maticsoft.Model.dafen_jieguo model=new Maticsoft.Model.dafen_jieguo();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["shangke_id"]!=null && row["shangke_id"].ToString()!="")
				{
					model.shangke_id=int.Parse(row["shangke_id"].ToString());
				}
				if(row["fenzu_id"]!=null && row["fenzu_id"].ToString()!="")
				{
					model.fenzu_id=int.Parse(row["fenzu_id"].ToString());
				}
				if(row["fenshu"]!=null && row["fenshu"].ToString()!="")
				{
					model.fenshu=decimal.Parse(row["fenshu"].ToString());
				}
				if(row["neirong"]!=null)
				{
					model.neirong=row["neirong"].ToString();
				}
				if(row["dafen_xuhao"]!=null && row["dafen_xuhao"].ToString()!="")
				{
					model.dafen_xuhao=int.Parse(row["dafen_xuhao"].ToString());
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
				}
				if(row["open_id"]!=null)
				{
					model.open_id=row["open_id"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
				}
				if(row["style"]!=null && row["style"].ToString()!="")
				{
					model.style=int.Parse(row["style"].ToString());
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
			strSql.Append("select id,shangke_id,fenzu_id,fenshu,neirong,dafen_xuhao,time,open_id,name,beizhu,style ");
			strSql.Append(" FROM dafen_jieguo ");
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
			strSql.Append(" id,shangke_id,fenzu_id,fenshu,neirong,dafen_xuhao,time,open_id,name,beizhu,style ");
			strSql.Append(" FROM dafen_jieguo ");
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
			strSql.Append("select count(1) FROM dafen_jieguo ");
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
			strSql.Append(")AS Row, T.*  from dafen_jieguo T ");
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
			parameters[0].Value = "dafen_jieguo";
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
        /// <summary>
        /// 通过上课号、打分序号、openid获取打分序号id
        /// </summary>
        /// <param name="shangke_id"></param>
        /// <param name="dafen_xuhao"></param>
        /// <param name="open_id"></param>
        /// <returns>如果为0，尚未填写该项</returns>
        public int get_id(int shangke_id, int dafen_xuhao, string open_id)
        {
            int id = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id from dafen_jieguo ");
            strSql.Append(" where [shangke_id]= "+shangke_id+" and [dafen_xuhao]= "+dafen_xuhao+" and [open_id]='"+open_id+"'");
           DataSet ds=  DbHelperSQL.Query(strSql.ToString());
           if (ds.Tables[0].Rows.Count > 0)
           {
               id =Convert.ToInt32( ds.Tables[0].Rows[0]["id"].ToString());
           }
            return id;
        }
		#endregion  ExtensionMethod
	}
}

