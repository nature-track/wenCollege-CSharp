/**  版本信息模板在安装目录下，可自行修改。
* account_view.cs
*
* 功 能： N/A
* 类 名： account_view
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-12-16 10:22:45   N/A    初版
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
	/// account_view:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class account_view
	{
		public account_view()
		{}
		#region Model
		private int _account_id;
		private int? _peixunban_id;
		private int _detail_id;
		private string _peixunban;
		private string _lururen;
		private string _leibei;
		private string _wuzi;
		private string _danwei;
		private decimal? _danjia;
		private int? _shuliang;
		private decimal? _xiaoji;
		private string _beizhu;
		private DateTime? _time;
		/// <summary>
		/// 
		/// </summary>
		public int account_id
		{
			set{ _account_id=value;}
			get{return _account_id;}
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
		public int detail_id
		{
			set{ _detail_id=value;}
			get{return _detail_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string peixunban
		{
			set{ _peixunban=value;}
			get{return _peixunban;}
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
		public string leibei
		{
			set{ _leibei=value;}
			get{return _leibei;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string wuzi
		{
			set{ _wuzi=value;}
			get{return _wuzi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string danwei
		{
			set{ _danwei=value;}
			get{return _danwei;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? danjia
		{
			set{ _danjia=value;}
			get{return _danjia;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? shuliang
		{
			set{ _shuliang=value;}
			get{return _shuliang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? xiaoji
		{
			set{ _xiaoji=value;}
			get{return _xiaoji;}
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
		public DateTime? time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

