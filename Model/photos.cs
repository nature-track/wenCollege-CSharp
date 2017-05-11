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
namespace Maticsoft.Model
{
	/// <summary>
	/// photos:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class photos
	{
		public photos()
		{}
		#region Model
		private int _id;
		private string _contenttype;
		private string _postedfilefilename;
		private string _filename;
		private string _fileextension;
		private string _qishu;
		private string _fenlei2;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ContentType
		{
			set{ _contenttype=value;}
			get{return _contenttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string postedFileFileName
		{
			set{ _postedfilefilename=value;}
			get{return _postedfilefilename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fileExtension
		{
			set{ _fileextension=value;}
			get{return _fileextension;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string qishu
		{
			set{ _qishu=value;}
			get{return _qishu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fenlei2
		{
			set{ _fenlei2=value;}
			get{return _fenlei2;}
		}
		#endregion Model

	}
}

