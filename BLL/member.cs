/**  版本信息模板在安装目录下，可自行修改。
* member.cs
*
* 功 能： N/A
* 类 名： member
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-1-25 15:48:25   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// member
	/// </summary>
	public partial class member
	{
		private readonly Maticsoft.DAL.member dal=new Maticsoft.DAL.member();
		public member()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.member model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.member model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(Maticsoft.Common.PageValidate.SafeLongFilter(idlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.member GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.member GetModelByCache(int id)
		{
			
			string CacheKey = "memberModel-" + id;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.member)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.member> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.member> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.member> modelList = new List<Maticsoft.Model.member>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.member model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 首先判断是否存在该数据，如果存在则更新，不存在则插入
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public string updatedata(Maticsoft.Model.member model)
        {
            DataSet ds = GetList("openid = '" + model.openid.Trim() + "'");
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                model.id = Convert.ToInt16(ds.Tables[0].Rows[0]["id"].ToString());
                if (Update(model))
                {
                    return "更新成功";
                }
                else
                {
                    return "更新失败";
                }

            }
            else
            {
                if (Add(model) > 0)
                {
                    return "插入成功";
                }
                else
                {
                    return "插入失败";
                };
            }

        }
        /// <summary>
        /// 通过openid获取真实姓名
        /// </summary>
        /// <param name="openid"></param>
        /// <returns></returns>
        public string get_name(string openid)
        {
            string name = "";
            Maticsoft.BLL.member mem_bll = new BLL.member();
            if (!string.IsNullOrEmpty(openid))
            {
                DataSet ds_mem = mem_bll.GetList("[openid]= '" + openid.Trim() + "'");
                if (ds_mem != null && ds_mem.Tables[0].Rows.Count > 0)
                {
                    name = ds_mem.Tables[0].Rows[0]["name"].ToString();
                }
                else
                {
                    name = "空";
                }
            }
            else
            {
                name = openid + "无名";
            }
            return name;
        }
		#endregion  ExtensionMethod
	}
}

