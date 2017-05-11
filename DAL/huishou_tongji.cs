using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:huishou_tongji
    /// </summary>
    public partial class huishou_tongji
    {
        public huishou_tongji()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string peixunban, string kecheng, int fenzu_id, string zuming, int fenshu_count, int peixunban_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from huishou_tongji");
            strSql.Append(" where peixunban=@peixunban and kecheng=@kecheng and fenzu_id=@fenzu_id and zuming=@zuming and fenshu_count=@fenshu_count and peixunban_id=@peixunban_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@peixunban", SqlDbType.NChar,10),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@zuming", SqlDbType.NVarChar,50),
					new SqlParameter("@fenshu_count", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4)			};
            parameters[0].Value = peixunban;
            parameters[1].Value = kecheng;
            parameters[2].Value = fenzu_id;
            parameters[3].Value = zuming;
            parameters[4].Value = fenshu_count;
            parameters[5].Value = peixunban_id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Maticsoft.Model.huishou_tongji model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into huishou_tongji(");
            strSql.Append("peixunban,kecheng,fenzu_id,zuming,fenshu_count,peixunban_id)");
            strSql.Append(" values (");
            strSql.Append("@peixunban,@kecheng,@fenzu_id,@zuming,@fenshu_count,@peixunban_id)");
            SqlParameter[] parameters = {
					new SqlParameter("@peixunban", SqlDbType.NChar,10),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@zuming", SqlDbType.NVarChar,50),
					new SqlParameter("@fenshu_count", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4)};
            parameters[0].Value = model.peixunban;
            parameters[1].Value = model.kecheng;
            parameters[2].Value = model.fenzu_id;
            parameters[3].Value = model.zuming;
            parameters[4].Value = model.fenshu_count;
            parameters[5].Value = model.peixunban_id;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(Maticsoft.Model.huishou_tongji model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update huishou_tongji set ");
            strSql.Append("peixunban=@peixunban,");
            strSql.Append("kecheng=@kecheng,");
            strSql.Append("fenzu_id=@fenzu_id,");
            strSql.Append("zuming=@zuming,");
            strSql.Append("fenshu_count=@fenshu_count,");
            strSql.Append("peixunban_id=@peixunban_id");
            strSql.Append(" where peixunban=@peixunban and kecheng=@kecheng and fenzu_id=@fenzu_id and zuming=@zuming and fenshu_count=@fenshu_count and peixunban_id=@peixunban_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@peixunban", SqlDbType.NChar,10),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@zuming", SqlDbType.NVarChar,50),
					new SqlParameter("@fenshu_count", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4)};
            parameters[0].Value = model.peixunban;
            parameters[1].Value = model.kecheng;
            parameters[2].Value = model.fenzu_id;
            parameters[3].Value = model.zuming;
            parameters[4].Value = model.fenshu_count;
            parameters[5].Value = model.peixunban_id;

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
        public bool Delete(string peixunban, string kecheng, int fenzu_id, string zuming, int fenshu_count, int peixunban_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from huishou_tongji ");
            strSql.Append(" where peixunban=@peixunban and kecheng=@kecheng and fenzu_id=@fenzu_id and zuming=@zuming and fenshu_count=@fenshu_count and peixunban_id=@peixunban_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@peixunban", SqlDbType.NChar,10),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@zuming", SqlDbType.NVarChar,50),
					new SqlParameter("@fenshu_count", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4)			};
            parameters[0].Value = peixunban;
            parameters[1].Value = kecheng;
            parameters[2].Value = fenzu_id;
            parameters[3].Value = zuming;
            parameters[4].Value = fenshu_count;
            parameters[5].Value = peixunban_id;

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
        /// 得到一个对象实体
        /// </summary>
        public Maticsoft.Model.huishou_tongji GetModel(string peixunban, string kecheng, int fenzu_id, string zuming, int fenshu_count, int peixunban_id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 peixunban,kecheng,fenzu_id,zuming,fenshu_count,peixunban_id from huishou_tongji ");
            strSql.Append(" where peixunban=@peixunban and kecheng=@kecheng and fenzu_id=@fenzu_id and zuming=@zuming and fenshu_count=@fenshu_count and peixunban_id=@peixunban_id ");
            SqlParameter[] parameters = {
					new SqlParameter("@peixunban", SqlDbType.NChar,10),
					new SqlParameter("@kecheng", SqlDbType.NVarChar,50),
					new SqlParameter("@fenzu_id", SqlDbType.Int,4),
					new SqlParameter("@zuming", SqlDbType.NVarChar,50),
					new SqlParameter("@fenshu_count", SqlDbType.Int,4),
					new SqlParameter("@peixunban_id", SqlDbType.Int,4)			};
            parameters[0].Value = peixunban;
            parameters[1].Value = kecheng;
            parameters[2].Value = fenzu_id;
            parameters[3].Value = zuming;
            parameters[4].Value = fenshu_count;
            parameters[5].Value = peixunban_id;

            Maticsoft.Model.huishou_tongji model = new Maticsoft.Model.huishou_tongji();
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
        public Maticsoft.Model.huishou_tongji DataRowToModel(DataRow row)
        {
            Maticsoft.Model.huishou_tongji model = new Maticsoft.Model.huishou_tongji();
            if (row != null)
            {
                if (row["peixunban"] != null)
                {
                    model.peixunban = row["peixunban"].ToString();
                }
                if (row["kecheng"] != null)
                {
                    model.kecheng = row["kecheng"].ToString();
                }
                if (row["fenzu_id"] != null && row["fenzu_id"].ToString() != "")
                {
                    model.fenzu_id = int.Parse(row["fenzu_id"].ToString());
                }
                if (row["zuming"] != null)
                {
                    model.zuming = row["zuming"].ToString();
                }
                if (row["fenshu_count"] != null && row["fenshu_count"].ToString() != "")
                {
                    model.fenshu_count = int.Parse(row["fenshu_count"].ToString());
                }
                if (row["peixunban_id"] != null && row["peixunban_id"].ToString() != "")
                {
                    model.peixunban_id = int.Parse(row["peixunban_id"].ToString());
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
            strSql.Append("select peixunban,kecheng,fenzu_id,zuming,fenshu_count,peixunban_id ");
            strSql.Append(" FROM huishou_tongji ");
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
            strSql.Append(" peixunban,kecheng,fenzu_id,zuming,fenshu_count,peixunban_id ");
            strSql.Append(" FROM huishou_tongji ");
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
            strSql.Append("select count(1) FROM huishou_tongji ");
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
                strSql.Append("order by T.peixunban_id desc");
            }
            strSql.Append(")AS Row, T.*  from huishou_tongji T ");
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
            parameters[0].Value = "huishou_tongji";
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

