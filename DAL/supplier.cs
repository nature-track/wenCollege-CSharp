/**  版本信息模板在安装目录下，可自行修改。
* supplier.cs
*
* 功 能： N/A
* 类 名： supplier
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-12-21 14:42:52   N/A    初版
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
	/// 数据访问类:supplier
	/// </summary>
	public partial class supplier
	{
		public supplier()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.supplier model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into supplier(");
			strSql.Append("name,person,phone,phone2,bank,bank_num,address,style,leibie,wuzi,beizhu,beizhu2)");
			strSql.Append(" values (");
			strSql.Append("@name,@person,@phone,@phone2,@bank,@bank_num,@address,@style,@leibie,@wuzi,@beizhu,@beizhu2)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@person", SqlDbType.NChar,50),
					new SqlParameter("@phone", SqlDbType.NChar,50),
					new SqlParameter("@phone2", SqlDbType.NChar,50),
					new SqlParameter("@bank", SqlDbType.NChar,50),
					new SqlParameter("@bank_num", SqlDbType.NChar,50),
					new SqlParameter("@address", SqlDbType.Text),
					new SqlParameter("@style", SqlDbType.Int,4),
					new SqlParameter("@leibie", SqlDbType.Int,4),
					new SqlParameter("@wuzi", SqlDbType.Text),
					new SqlParameter("@beizhu", SqlDbType.Text),
					new SqlParameter("@beizhu2", SqlDbType.Text)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.person;
			parameters[2].Value = model.phone;
			parameters[3].Value = model.phone2;
			parameters[4].Value = model.bank;
			parameters[5].Value = model.bank_num;
			parameters[6].Value = model.address;
			parameters[7].Value = model.style;
			parameters[8].Value = model.leibie;
			parameters[9].Value = model.wuzi;
			parameters[10].Value = model.beizhu;
			parameters[11].Value = model.beizhu2;

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
		public bool Update(Maticsoft.Model.supplier model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update supplier set ");
			strSql.Append("name=@name,");
			strSql.Append("person=@person,");
			strSql.Append("phone=@phone,");
			strSql.Append("phone2=@phone2,");
			strSql.Append("bank=@bank,");
			strSql.Append("bank_num=@bank_num,");
			strSql.Append("address=@address,");
			strSql.Append("style=@style,");
			strSql.Append("leibie=@leibie,");
			strSql.Append("wuzi=@wuzi,");
			strSql.Append("beizhu=@beizhu,");
			strSql.Append("beizhu2=@beizhu2");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@person", SqlDbType.NChar,50),
					new SqlParameter("@phone", SqlDbType.NChar,50),
					new SqlParameter("@phone2", SqlDbType.NChar,50),
					new SqlParameter("@bank", SqlDbType.NChar,50),
					new SqlParameter("@bank_num", SqlDbType.NChar,50),
					new SqlParameter("@address", SqlDbType.Text),
					new SqlParameter("@style", SqlDbType.Int,4),
					new SqlParameter("@leibie", SqlDbType.Int,4),
					new SqlParameter("@wuzi", SqlDbType.Text),
					new SqlParameter("@beizhu", SqlDbType.Text),
					new SqlParameter("@beizhu2", SqlDbType.Text),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.name;
			parameters[1].Value = model.person;
			parameters[2].Value = model.phone;
			parameters[3].Value = model.phone2;
			parameters[4].Value = model.bank;
			parameters[5].Value = model.bank_num;
			parameters[6].Value = model.address;
			parameters[7].Value = model.style;
			parameters[8].Value = model.leibie;
			parameters[9].Value = model.wuzi;
			parameters[10].Value = model.beizhu;
			parameters[11].Value = model.beizhu2;
			parameters[12].Value = model.id;

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
			strSql.Append("delete from supplier ");
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
			strSql.Append("delete from supplier ");
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
		public Maticsoft.Model.supplier GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,name,person,phone,phone2,bank,bank_num,address,style,leibie,wuzi,beizhu,beizhu2 from supplier ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.supplier model=new Maticsoft.Model.supplier();
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
		public Maticsoft.Model.supplier DataRowToModel(DataRow row)
		{
			Maticsoft.Model.supplier model=new Maticsoft.Model.supplier();
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
				if(row["person"]!=null)
				{
					model.person=row["person"].ToString();
				}
				if(row["phone"]!=null)
				{
					model.phone=row["phone"].ToString();
				}
				if(row["phone2"]!=null)
				{
					model.phone2=row["phone2"].ToString();
				}
				if(row["bank"]!=null)
				{
					model.bank=row["bank"].ToString();
				}
				if(row["bank_num"]!=null)
				{
					model.bank_num=row["bank_num"].ToString();
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["style"]!=null && row["style"].ToString()!="")
				{
					model.style=int.Parse(row["style"].ToString());
				}
				if(row["leibie"]!=null && row["leibie"].ToString()!="")
				{
					model.leibie=int.Parse(row["leibie"].ToString());
				}
				if(row["wuzi"]!=null)
				{
					model.wuzi=row["wuzi"].ToString();
				}
				if(row["beizhu"]!=null)
				{
					model.beizhu=row["beizhu"].ToString();
				}
				if(row["beizhu2"]!=null)
				{
					model.beizhu2=row["beizhu2"].ToString();
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
			strSql.Append("select id,name,person,phone,phone2,bank,bank_num,address,style,leibie,wuzi,beizhu,beizhu2 ");
			strSql.Append(" FROM supplier ");
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
			strSql.Append(" id,name,person,phone,phone2,bank,bank_num,address,style,leibie,wuzi,beizhu,beizhu2 ");
			strSql.Append(" FROM supplier ");
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
			strSql.Append("select count(1) FROM supplier ");
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
			strSql.Append(")AS Row, T.*  from supplier T ");
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
			parameters[0].Value = "supplier";
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

