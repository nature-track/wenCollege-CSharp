/**  版本信息模板在安装目录下，可自行修改。
* fenshu_tongji_fenxiang.cs
*
* 功 能： N/A
* 类 名： fenshu_tongji_fenxiang
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-7-1 14:38:00   N/A    初版
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
	/// fenshu_tongji_fenxiang:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class fenshu_tongji_fenxiang
	{
		public fenshu_tongji_fenxiang()
		{}
		#region Model
		private string _name;
		private string _kecheng;
		private string _jiangshi;
		private string _text;
		private int? _count_fenshu;
		private decimal? _avg_fenshu;
		private int? _shangke_id;
		private int _peixunban_id;
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
		public string kecheng
		{
			set{ _kecheng=value;}
			get{return _kecheng;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jiangshi
		{
			set{ _jiangshi=value;}
			get{return _jiangshi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string text
		{
			set{ _text=value;}
			get{return _text;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? count_fenshu
		{
			set{ _count_fenshu=value;}
			get{return _count_fenshu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? avg_fenshu
		{
			set{ _avg_fenshu=value;}
			get{return _avg_fenshu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? shangke_id
		{
			set{ _shangke_id=value;}
			get{return _shangke_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int peixunban_id
		{
			set{ _peixunban_id=value;}
			get{return _peixunban_id;}
		}
		#endregion Model

	}
}

