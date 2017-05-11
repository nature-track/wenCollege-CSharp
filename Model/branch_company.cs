/**  版本信息模板在安装目录下，可自行修改。
* branch_company.cs
*
* 功 能： N/A
* 类 名： branch_company
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-10-28 08:44:41   N/A    初版
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
	/// branch_company:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class branch_company
	{
		public branch_company()
		{}
		#region Model
		private int _id;
		private int _peixunban_id;
		private string _start_detail;
		private string _end_detail;
		private int? _num;
		private string _num_detail;
		private decimal? _cleaning_fee;
		private string _fapiao_taitou;
		private string _basketball_time;
		private string _fantang;
		private int? _fangka_print;
		private int? _yuedu_shuoming;
		private string _fengongsi;
		private DateTime? _date;
		private int? _xishu_yongpin;
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
		public int peixunban_id
		{
			set{ _peixunban_id=value;}
			get{return _peixunban_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string start_detail
		{
			set{ _start_detail=value;}
			get{return _start_detail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string end_detail
		{
			set{ _end_detail=value;}
			get{return _end_detail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string num_detail
		{
			set{ _num_detail=value;}
			get{return _num_detail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? cleaning_fee
		{
			set{ _cleaning_fee=value;}
			get{return _cleaning_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fapiao_taitou
		{
			set{ _fapiao_taitou=value;}
			get{return _fapiao_taitou;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string basketball_time
		{
			set{ _basketball_time=value;}
			get{return _basketball_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fantang
		{
			set{ _fantang=value;}
			get{return _fantang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? fangka_print
		{
			set{ _fangka_print=value;}
			get{return _fangka_print;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? yuedu_shuoming
		{
			set{ _yuedu_shuoming=value;}
			get{return _yuedu_shuoming;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fengongsi
		{
			set{ _fengongsi=value;}
			get{return _fengongsi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? xishu_yongpin
		{
			set{ _xishu_yongpin=value;}
			get{return _xishu_yongpin;}
		}
		#endregion Model

	}
}

