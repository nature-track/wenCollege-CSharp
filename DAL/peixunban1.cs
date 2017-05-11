using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:peixunban1
    /// </summary>
    public partial class peixunban1
    {
        public peixunban1()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from peixunban1");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Maticsoft.Model.peixunban1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into peixunban1(");
            strSql.Append("start_time,end_time,name,contact,sinal,beizhu,phone)");
            strSql.Append(" values (");
            strSql.Append("@start_time,@end_time,@name,@contact,@sinal,@beizhu,@phone)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@start_time", SqlDbType.Date,3),
					new SqlParameter("@end_time", SqlDbType.Date,3),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@contact", SqlDbType.NChar,10),
					new SqlParameter("@sinal", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,50),
					new SqlParameter("@phone", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.start_time;
            parameters[1].Value = model.end_time;
            parameters[2].Value = model.name;
            parameters[3].Value = model.contact;
            parameters[4].Value = model.sinal;
            parameters[5].Value = model.beizhu;
            parameters[6].Value = model.phone;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Maticsoft.Model.peixunban1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update peixunban1 set ");
            strSql.Append("start_time=@start_time,");
            strSql.Append("end_time=@end_time,");
            strSql.Append("name=@name,");
            strSql.Append("contact=@contact,");
            strSql.Append("sinal=@sinal,");
            strSql.Append("beizhu=@beizhu,");
            strSql.Append("phone=@phone");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@start_time", SqlDbType.Date,3),
					new SqlParameter("@end_time", SqlDbType.Date,3),
					new SqlParameter("@name", SqlDbType.NChar,50),
					new SqlParameter("@contact", SqlDbType.NChar,10),
					new SqlParameter("@sinal", SqlDbType.Int,4),
					new SqlParameter("@beizhu", SqlDbType.NVarChar,50),
					new SqlParameter("@phone", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.start_time;
            parameters[1].Value = model.end_time;
            parameters[2].Value = model.name;
            parameters[3].Value = model.contact;
            parameters[4].Value = model.sinal;
            parameters[5].Value = model.beizhu;
            parameters[6].Value = model.phone;
            parameters[7].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from peixunban1 ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from peixunban1 ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Maticsoft.Model.peixunban1 GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,start_time,end_time,name,contact,sinal,beizhu,phone from peixunban1 ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            Maticsoft.Model.peixunban1 model = new Maticsoft.Model.peixunban1();
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
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.peixunban1 DataRowToModel(DataRow row)
        {
            Maticsoft.Model.peixunban1 model = new Maticsoft.Model.peixunban1();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["start_time"] != null && row["start_time"].ToString() != "")
                {
                    model.start_time = DateTime.Parse(row["start_time"].ToString());
                }
                if (row["end_time"] != null && row["end_time"].ToString() != "")
                {
                    model.end_time = DateTime.Parse(row["end_time"].ToString());
                }
                if (row["name"] != null)
                {
                    model.name = row["name"].ToString();
                }
                if (row["contact"] != null)
                {
                    model.contact = row["contact"].ToString();
                }
                if (row["sinal"] != null && row["sinal"].ToString() != "")
                {
                    model.sinal = int.Parse(row["sinal"].ToString());
                }
                if (row["beizhu"] != null)
                {
                    model.beizhu = row["beizhu"].ToString();
                }
                if (row["phone"] != null)
                {
                    model.phone = row["phone"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,start_time,end_time,name,contact,sinal,beizhu,phone ");
            strSql.Append(" FROM peixunban1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,start_time,end_time,name,contact,sinal,beizhu,phone ");
            strSql.Append(" FROM peixunban1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM peixunban1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.id desc");
            }
            strSql.Append(")AS Row, T.*  from peixunban1 T ");
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
            parameters[0].Value = "peixunban1";
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
        /// 更新一条备注
        /// </summary>
        public bool Update_beizhu(Maticsoft.Model.peixunban1 model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update peixunban1 set ");

            strSql.Append("beizhu=@beizhu ");

            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {

					new SqlParameter("@beizhu", SqlDbType.NVarChar,50),

					new SqlParameter("@id", SqlDbType.Int,4)};

            parameters[0].Value = model.beizhu;

            parameters[1].Value = model.id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion  ExtensionMethod
    }
}

