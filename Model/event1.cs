/**  版本信息模板在安装目录下，可自行修改。
* event1.cs
*
* 功 能： N/A
* 类 名： event1
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-7-10 15:42:49   N/A    初版
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
	/// event1:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class event1
	{
		public event1()
		{}
		#region Model
		private int _id;
		private DateTime? _sta_time;
		private DateTime? _end_time;
		private string _event_name;
		private string _beizhu;
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
		public DateTime? sta_time
		{
			set{ _sta_time=value;}
			get{return _sta_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? end_time
		{
			set{ _end_time=value;}
			get{return _end_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string event_name
		{
			set{ _event_name=value;}
			get{return _event_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string beizhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
		}
		#endregion Model

	}
}

