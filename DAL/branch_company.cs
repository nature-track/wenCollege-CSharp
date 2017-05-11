/**  版本信息模板在安装目录下，可自行修改。
* branch_company.cs
*
* 功 能： N/A
* 类 名： branch_company
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-10-28 08:44:41   N/A    初版
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
	/// 数据访问类:branch_company
	/// </summary>
	public partial class branch_company
	{
		public branch_company()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.branch_company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into branch_company(");
			strSql.Append("peixunban_id,start_detail,end_detail,num,num_detail,cleaning_fee,fapiao_taitou,basketball_time,fantang,fangka_print,yuedu_shuoming,fengongsi,date,xishu_yongpin)");
			strSql.Append(" values (");
			strSql.Append("@peixunban_id,@start_detail,@end_detail,@num,@num_detail,@cleaning_fee,@fapiao_taitou,@basketball_time,@fantang,@fangka_print,@yuedu_shuoming,@fengongsi,@date,@xishu_yongpin)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@start_detail", SqlDbType.Text),
					new SqlParameter("@end_detail", SqlDbType.Text),
					new SqlParameter("@num", SqlDbType.Int,4),
					new SqlParameter("@num_detail", SqlDbType.Text),
					new SqlParameter("@cleaning_fee", SqlDbType.SmallMoney,4),
					new SqlParameter("@fapiao_taitou", SqlDbType.NVarChar,50),
					new SqlParameter("@basketball_time", SqlDbType.NVarChar,50),
					new SqlParameter("@fantang", SqlDbType.Text),
					new SqlParameter("@fangka_print", SqlDbType.Int,4),
					new SqlParameter("@yuedu_shuoming", SqlDbType.Int,4),
					new SqlParameter("@fengongsi", SqlDbType.NVarChar,50),
					new SqlParameter("@date", SqlDbType.DateTime),
					new SqlParameter("@xishu_yongpin", SqlDbType.Int,4)};
			parameters[0].Value = model.peixunban_id;
			parameters[1].Value = model.start_detail;
			parameters[2].Value = model.end_detail;
			parameters[3].Value = model.num;
			parameters[4].Value = model.num_detail;
			parameters[5].Value = model.cleaning_fee;
			parameters[6].Value = model.fapiao_taitou;
			parameters[7].Value = model.basketball_time;
			parameters[8].Value = model.fantang;
			parameters[9].Value = model.fangka_print;
			parameters[10].Value = model.yuedu_shuoming;
			parameters[11].Value = model.fengongsi;
			parameters[12].Value = model.date;
			parameters[13].Value = model.xishu_yongpin;

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
		public bool Update(Maticsoft.Model.branch_company model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update branch_company set ");
			strSql.Append("peixunban_id=@peixunban_id,");
			strSql.Append("start_detail=@start_detail,");
			strSql.Append("end_detail=@end_detail,");
			strSql.Append("num=@num,");
			strSql.Append("num_detail=@num_detail,");
			strSql.Append("cleaning_fee=@cleaning_fee,");
			strSql.Append("fapiao_taitou=@fapiao_taitou,");
			strSql.Append("basketball_time=@basketball_time,");
			strSql.Append("fantang=@fantang,");
			strSql.Append("fangka_print=@fangka_print,");
			strSql.Append("yuedu_shuoming=@yuedu_shuoming,");
			strSql.Append("fengongsi=@fengongsi,");
			strSql.Append("date=@date,");
			strSql.Append("xishu_yongpin=@xishu_yongpin");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@peixunban_id", SqlDbType.Int,4),
					new SqlParameter("@start_detail", SqlDbType.Text),
					new SqlParameter("@end_detail", SqlDbType.Text),
					new SqlParameter("@num", SqlDbType.Int,4),
					new SqlParameter("@num_detail", SqlDbType.Text),
					new SqlParameter("@cleaning_fee", SqlDbType.SmallMoney,4),
					new SqlParameter("@fapiao_taitou", SqlDbType.NVarChar,50),
					new SqlParameter("@basketball_time", SqlDbType.NVarChar,50),
					new SqlParameter("@fantang", SqlDbType.Text),
					new SqlParameter("@fangka_print", SqlDbType.Int,4),
					new SqlParameter("@yuedu_shuoming", SqlDbType.Int,4),
					new SqlParameter("@fengongsi", SqlDbType.NVarChar,50),
					new SqlParameter("@date", SqlDbType.DateTime),
					new SqlParameter("@xishu_yongpin", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.peixunban_id;
			parameters[1].Value = model.start_detail;
			parameters[2].Value = model.end_detail;
			parameters[3].Value = model.num;
			parameters[4].Value = model.num_detail;
			parameters[5].Value = model.cleaning_fee;
			parameters[6].Value = model.fapiao_taitou;
			parameters[7].Value = model.basketball_time;
			parameters[8].Value = model.fantang;
			parameters[9].Value = model.fangka_print;
			parameters[10].Value = model.yuedu_shuoming;
			parameters[11].Value = model.fengongsi;
			parameters[12].Value = model.date;
			parameters[13].Value = model.xishu_yongpin;
			parameters[14].Value = model.id;

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
			strSql.Append("delete from branch_company ");
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
			strSql.Append("delete from branch_company ");
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
		public Maticsoft.Model.branch_company GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,peixunban_id,start_detail,end_detail,num,num_detail,cleaning_fee,fapiao_taitou,basketball_time,fantang,fangka_print,yuedu_shuoming,fengongsi,date,xishu_yongpin from branch_company ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.branch_company model=new Maticsoft.Model.branch_company();
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
		public Maticsoft.Model.branch_company DataRowToModel(DataRow row)
		{
			Maticsoft.Model.branch_company model=new Maticsoft.Model.branch_company();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["peixunban_id"]!=null && row["peixunban_id"].ToString()!="")
				{
					model.peixunban_id=int.Parse(row["peixunban_id"].ToString());
				}
				if(row["start_detail"]!=null)
				{
					model.start_detail=row["start_detail"].ToString();
				}
				if(row["end_detail"]!=null)
				{
					model.end_detail=row["end_detail"].ToString();
				}
				if(row["num"]!=null && row["num"].ToString()!="")
				{
					model.num=int.Parse(row["num"].ToString());
				}
				if(row["num_detail"]!=null)
				{
					model.num_detail=row["num_detail"].ToString();
				}
				if(row["cleaning_fee"]!=null && row["cleaning_fee"].ToString()!="")
				{
					model.cleaning_fee=decimal.Parse(row["cleaning_fee"].ToString());
				}
				if(row["fapiao_taitou"]!=null)
				{
					model.fapiao_taitou=row["fapiao_taitou"].ToString();
				}
				if(row["basketball_time"]!=null)
				{
					model.basketball_time=row["basketball_time"].ToString();
				}
				if(row["fantang"]!=null)
				{
					model.fantang=row["fantang"].ToString();
				}
				if(row["fangka_print"]!=null && row["fangka_print"].ToString()!="")
				{
					model.fangka_print=int.Parse(row["fangka_print"].ToString());
				}
				if(row["yuedu_shuoming"]!=null && row["yuedu_shuoming"].ToString()!="")
				{
					model.yuedu_shuoming=int.Parse(row["yuedu_shuoming"].ToString());
				}
				if(row["fengongsi"]!=null)
				{
					model.fengongsi=row["fengongsi"].ToString();
				}
				if(row["date"]!=null && row["date"].ToString()!="")
				{
					model.date=DateTime.Parse(row["date"].ToString());
				}
				if(row["xishu_yongpin"]!=null && row["xishu_yongpin"].ToString()!="")
				{
					model.xishu_yongpin=int.Parse(row["xishu_yongpin"].ToString());
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
			strSql.Append("select id,peixunban_id,start_detail,end_detail,num,num_detail,cleaning_fee,fapiao_taitou,basketball_time,fantang,fangka_print,yuedu_shuoming,fengongsi,date,xishu_yongpin ");
			strSql.Append(" FROM branch_company ");
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
			strSql.Append(" id,peixunban_id,start_detail,end_detail,num,num_detail,cleaning_fee,fapiao_taitou,basketball_time,fantang,fangka_print,yuedu_shuoming,fengongsi,date,xishu_yongpin ");
			strSql.Append(" FROM branch_company ");
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
			strSql.Append("select count(1) FROM branch_company ");
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
			strSql.Append(")AS Row, T.*  from branch_company T ");
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
			parameters[0].Value = "branch_company";
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
        /// 通过培训班id得到一个对象实体
        /// </summary>
        public Maticsoft.Model.branch_company GetModel_bypeixunban(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,peixunban_id,start_detail,end_detail,num,num_detail,cleaning_fee,fapiao_taitou,basketball_time,fantang,fangka_print,yuedu_shuoming,fengongsi,date,xishu_yongpin from branch_company ");
            strSql.Append(" where peixunban_id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            Maticsoft.Model.branch_company model = new Maticsoft.Model.branch_company();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
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
        /// 通过培训班id获得分公司表的id
        /// </summary>
        /// <param name="peixunbanid"></param>
        /// <returns></returns>
        public int get_id(int peixunbanid)
        {
            
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id from branch_company ");
            strSql.Append(" where peixunban_id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = peixunbanid;

            Maticsoft.Model.branch_company model = new Maticsoft.Model.branch_company();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return Convert.ToInt16( ds.Tables[0].Rows[0]["id"]);
            }
            else
            {
                return 0;
            }
        }
		#endregion  ExtensionMethod
	}
}

