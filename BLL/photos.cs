/**  版本信息模板在安装目录下，可自行修改。
* photos.cs
*
* 功 能： N/A
* 类 名： photos
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/8/1 8:35:09   N/A    初版
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
	/// photos
	/// </summary>
	public partial class photos
	{
		private readonly Maticsoft.DAL.photos dal=new Maticsoft.DAL.photos();
		public photos()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Maticsoft.Model.photos model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.photos model)
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
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.photos GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Maticsoft.Model.photos GetModelByCache(int id)
		{
			
			string CacheKey = "photosModel-" + id;
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
			return (Maticsoft.Model.photos)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        public DataSet get_fenlei(string qishu)
        {
            return dal.get_fenlei(qishu);
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
		public List<Maticsoft.Model.photos> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Maticsoft.Model.photos> DataTableToList(DataTable dt)
		{
			List<Maticsoft.Model.photos> modelList = new List<Maticsoft.Model.photos>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Maticsoft.Model.photos model;
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
        public string photoscompress(System.Drawing.Image imgPhoto, int width, int hight, string strResizePicName)
        {
            int maxWidth = width;   //图片宽度最大限制
            int maxHeight = hight;  //图片高度最大限制
            int imgWidth = imgPhoto.Width;
            int imgHeight = imgPhoto.Height;
            if (imgWidth > imgHeight)  //如果宽度超过高度以宽度为准来压缩
            {
                if (imgWidth > maxWidth)  //如果图片宽度超过限制
                {
                    float toImgWidth = maxWidth;   //图片压缩后的宽度
                    float toImgHeight = imgHeight / (float)(imgWidth / toImgWidth); //图片压缩后的高度
                    try
                    {
                        System.Drawing.Bitmap img = new System.Drawing.Bitmap(imgPhoto, Convert.ToInt16(toImgWidth),Convert.ToInt16(toImgHeight));
                        img.Save(strResizePicName);//保存压缩后的图片
                        return "保存成功";
                    }
                    catch (Exception e)
                    {
                      return e.Message;
                    }
                }
                else
                {
                    imgPhoto.Save(strResizePicName);
                    return "保存成功";
                }

            }
            else
            {
                if (imgHeight > maxHeight)
                {
                    float toImgHeight1 = maxHeight;
                    float toImgWidth1 = imgWidth / (float)(imgHeight / toImgHeight1);
                    try
                    {
                        System.Drawing.Bitmap img = new System.Drawing.Bitmap(imgPhoto, Convert.ToInt16(toImgWidth1),Convert.ToInt16(toImgHeight1));
                        img.Save(strResizePicName);
                        return "保存成功";
                    }
                    catch (Exception e)
                    {
                        return e.Message;
                    }
                }
                else
                {
                    imgPhoto.Save(strResizePicName);
                    return "保存成功";
                }
            }
        }


        public DataTable get_photolist()
        {
            DataSet ds = dal.get_photolist();
            return ds.Tables[0];
        }
		#endregion  ExtensionMethod
	}
}

