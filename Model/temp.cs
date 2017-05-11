/**  版本信息模板在安装目录下，可自行修改。
* temp.cs
*
* 功 能： N/A
* 类 名： temp
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/7/15 16:01:20   N/A    初版
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
	/// temp:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class temp
	{
		public temp()
		{}
		#region Model
		private int _id;
		private string _temp_sn;
		private string _temp_content;
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
		public string temp_SN
		{
			set{ _temp_sn=value;}
			get{return _temp_sn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string temp_Content
		{
			set{ _temp_content=value;}
			get{return _temp_content;}
		}
		#endregion Model

	}
}

