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
using System.Collections.Generic;
using Maticsoft.Common;
using Maticsoft.Model;
namespace Maticsoft.BLL
{
	/// <summary>
	/// fenshu_list_view
	/// </summary>
	public partial class fenshu_list_view
	{
		private readonly Maticsoft.DAL.fenshu_list_view dal=new Maticsoft.DAL.fenshu_list_view();
		public fenshu_list_view()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.fenshu_list_view model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.fenshu_list_view model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.fenshu_list_view GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.fenshu_list_view GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "fenshu_list_viewModel-" ;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Maticsoft.Model.fenshu_list_view)objModel;
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
		public List<Maticsoft.Model.fenshu_list_view> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.fenshu_list_view> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.fenshu_list_view> modelList = new List<Maticsoft.Model.fenshu_list_view>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.fenshu_list_view model;
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
        public DataTable getdistinct_list(string strWhere)
        {
            return dal.getdistinct_list(strWhere);
        }
        public DataTable getdistinct_list_total(string strWhere)
        {
            return dal.getdistinct_list_total(strWhere);
        }
        public DataTable get_yuanyi(string strWhere)
        {
            return dal.get_yuanyi(strWhere);
        }
        /// <summary>
        /// 获取某个人本期培训班已填课程
        /// </summary>
        /// <param name="open_id"></param>
        /// <param name="peixunbanid"></param>
        /// <returns></returns>
        public DataTable get_by_openid(string open_id,int peixunbanid)
        {
            return dal.GetList("peixunban_id=" + peixunbanid + " and dafenbiao_id=1 and open_id='" + open_id + "'").Tables[0];
        }
        /// <summary>
        /// 获取某个人某门课程的所有评分情况
        /// </summary>
        /// <param name="open_id">个人识别号</param>
        /// <param name="shangke_id">上课id</param>
        /// <returns></returns>
        public DataTable get_by_openid_shangke(string open_id, int shangke_id)
        {
            return dal.GetList("open_id='" + open_id + "'" + " and shangke_id='" + shangke_id + "'").Tables[0];
        }
		#endregion  ExtensionMethod
	}
}

