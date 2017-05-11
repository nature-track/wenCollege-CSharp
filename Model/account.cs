/**  版本信息模板在安装目录下，可自行修改。
* account.cs
*
* 功 能： N/A
* 类 名： account
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-11-6 15:59:26   N/A    初版
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
	/// account:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class account
	{
		public account()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _leibei;
		private string _lururen;
		private DateTime? _time;
		private int? _peixunban_id;
		private string _beizhu;
		private string _beizhu2;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string leibei
		{
			set{ _leibei=value;}
			get{return _leibei;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string lururen
		{
			set{ _lururen=value;}
			get{return _lururen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? peixunban_id
		{
			set{ _peixunban_id=value;}
			get{return _peixunban_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string beizhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string beizhu2
		{
			set{ _beizhu2=value;}
			get{return _beizhu2;}
		}
		#endregion Model

	}
}

