/**  版本信息模板在安装目录下，可自行修改。
* inv_answer.cs
*
* 功 能： N/A
* 类 名： inv_answer
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-2-2 14:24:03   N/A    初版
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
	/// inv_answer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class inv_answer
	{
		public inv_answer()
		{}
		#region Model
		private int _id;
		private int? _option_id;
		private decimal? _an_int;
		private string _an_text;
		private string _open_id;
		private string _name;
		private DateTime? _time;
		private string _beizhu;
		private int? _que_id;
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
		public int? option_id
		{
			set{ _option_id=value;}
			get{return _option_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? an_int
		{
			set{ _an_int=value;}
			get{return _an_int;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string an_text
		{
			set{ _an_text=value;}
			get{return _an_text;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string open_id
		{
			set{ _open_id=value;}
			get{return _open_id;}
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
		public DateTime? time
		{
			set{ _time=value;}
			get{return _time;}
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
		public int? que_id
		{
			set{ _que_id=value;}
			get{return _que_id;}
		}
		#endregion Model

	}
}

