/**  版本信息模板在安装目录下，可自行修改。
* hui_kuan_dan.cs
*
* 功 能： N/A
* 类 名： hui_kuan_dan
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-12-21 14:42:54   N/A    初版
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
	/// 数据访问类:hui_kuan_dan
	/// </summary>
	public partial class hui_kuan_dan
	{
		public hui_kuan_dan()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.hui_kuan_dan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hui_kuan_dan(");
			strSql.Append("huikuan_neirong,xiangmu_mingcheng,xiangmu_zongkuan,yifu_jine,zhifu_shijian,benci_jine,yuji_yukuan,supplier_id,leibie,beizhu)");
			strSql.Append(" values (");
			strSql.Append("@huikuan_neirong,@xiangmu_mingcheng,@xiangmu_zongkuan,@yifu_jine,@zhifu_shijian,@benci_jine,@yuji_yukuan,@supplier_id,@leibie,@beizhu)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@huikuan_neirong", SqlDbType.Text),
					new SqlParameter("@xiangmu_mingcheng", SqlDbType.Text),
					new SqlParameter("@xiangmu_zongkuan", SqlDbType.Money,8),
					new SqlParameter("@yifu_jine", SqlDbType.Money,8),
					new SqlParameter("@zhifu_shijian", SqlDbType.Date,3),
					new SqlParameter("@benci_jine", SqlDbType.Money,8),
					new SqlParameter("@yuji_yukuan", SqlDbType.Date,3),
					new SqlParameter("@supplier_id", SqlDbType.Int,4),
					new SqlParameter("@leibie", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.Text)};
			parameters[0].Value = model.huikuan_neirong;
			parameters[1].Value = model.xiangmu_mingcheng;
			parameters[2].Value = model.xiangmu_zongkuan;
			parameters[3].Value = model.yifu_jine;
			parameters[4].Value = model.zhifu_shijian;
			parameters[5].Value = model.benci_jine;
			parameters[6].Value = model.yuji_yukuan;
			parameters[7].Value = model.supplier_id;
			parameters[8].Value = model.leibie;
			parameters[9].Value = model.beizhu;

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
		public bool Update(Maticsoft.Model.hui_kuan_dan model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hui_kuan_dan set ");
			strSql.Append("huikuan_neirong=@huikuan_neirong,");
			strSql.Append("xiangmu_mingcheng=@xiangmu_mingcheng,");
			strSql.Append("xiangmu_zongkuan=@xiangmu_zongkuan,");
			strSql.Append("yifu_jine=@yifu_jine,");
			strSql.Append("zhifu_shijian=@zhifu_shijian,");
			strSql.Append("benci_jine=@benci_jine,");
			strSql.Append("yuji_yukuan=@yuji_yukuan,");
			strSql.Append("supplier_id=@supplier_id,");
			strSql.Append("leibie=@leibie,");
			strSql.Append("beizhu=@beizhu");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@huikuan_neirong", SqlDbType.Text),
					new SqlParameter("@xiangmu_mingcheng", SqlDbType.Text),
					new SqlParameter("@xiangmu_zongkuan", SqlDbType.Money,8),
					new SqlParameter("@yifu_jine", SqlDbType.Money,8),
					new SqlParameter("@zhifu_shijian", SqlDbType.Date,3),
					new SqlParameter("@benci_jine", SqlDbType.Money,8),
					new SqlParameter("@yuji_yukuan", SqlDbType.Date,3),
					new SqlParameter("@supplier_id", SqlDbType.Int,4),
					new SqlParameter("@leibie", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.Text),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.huikuan_neirong;
			parameters[1].Value = model.xiangmu_mingcheng;
			parameters[2].Value = model.xiangmu_zongkuan;
			parameters[3].Value = model.yifu_jine;
			parameters[4].Value = model.zhifu_shijian;
			parameters[5].Value = model.benci_jine;
			parameters[6].Value = model.yuji_yukuan;
			parameters[7].Value = model.supplier_id;
			parameters[8].Value = model.leibie;
			parameters[9].Value = model.beizhu;
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
			strSql.Append("delete from hui_kuan_dan ");
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
			strSql.Append("delete from hui_kuan_dan ");
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
		public Maticsoft.Model.hui_kuan_dan GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,huikuan_neirong,xiangmu_mingcheng,xiangmu_zongkuan,yifu_jine,zhifu_shijian,benci_jine,yuji_yukuan,supplier_id,leibie,beizhu from hui_kuan_dan ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.hui_kuan_dan model=new Maticsoft.Model.hui_kuan_dan();
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
		public Maticsoft.Model.hui_kuan_dan DataRowToModel(DataRow row)
		{
			Maticsoft.Model.hui_kuan_dan model=new Maticsoft.Model.hui_kuan_dan();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["huikuan_neirong"]!=null)
				{
					model.huikuan_neirong=row["huikuan_neirong"].ToString();
				}
				if(row["xiangmu_mingcheng"]!=null)
				{
					model.xiangmu_mingcheng=row["xiangmu_mingcheng"].ToString();
				}
				if(row["xiangmu_zongkuan"]!=null && row["xiangmu_zongkuan"].ToString()!="")
				{
					model.xiangmu_zongkuan=decimal.Parse(row["xiangmu_zongkuan"].ToString());
				}
				if(row["yifu_jine"]!=null && row["yifu_jine"].ToString()!="")
				{
					model.yifu_jine=decimal.Parse(row["yifu_jine"].ToString());
				}
				if(row["zhifu_shijian"]!=null && row["zhifu_shijian"].ToString()!="")
				{
					model.zhifu_shijian=DateTime.Parse(row["zhifu_shijian"].ToString());
				}
				if(row["benci_jine"]!=null && row["benci_jine"].ToString()!="")
				{
					model.benci_jine=decimal.Parse(row["benci_jine"].ToString());
				}
				if(row["yuji_yukuan"]!=null && row["yuji_yukuan"].ToString()!="")
				{
					model.yuji_yukuan=DateTime.Parse(row["yuji_yukuan"].ToString());
				}
				if(row["supplier_id"]!=null && row["supplier_id"].ToString()!="")
				{
					model.supplier_id=int.Parse(row["supplier_id"].ToString());
				}
				if(row["leibie"]!=null && row["leibie"].ToString()!="")
				{
					model.leibie=int.Parse(row["leibie"].ToString());
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
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
			strSql.Append("select id,huikuan_neirong,xiangmu_mingcheng,xiangmu_zongkuan,yifu_jine,zhifu_shijian,benci_jine,yuji_yukuan,supplier_id,leibie,beizhu ");
			strSql.Append(" FROM hui_kuan_dan ");
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
			strSql.Append(" id,huikuan_neirong,xiangmu_mingcheng,xiangmu_zongkuan,yifu_jine,zhifu_shijian,benci_jine,yuji_yukuan,supplier_id,leibie,beizhu ");
			strSql.Append(" FROM hui_kuan_dan ");
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
			strSql.Append("select count(1) FROM hui_kuan_dan ");
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
			strSql.Append(")AS Row, T.*  from hui_kuan_dan T ");
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
			parameters[0].Value = "hui_kuan_dan";
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

