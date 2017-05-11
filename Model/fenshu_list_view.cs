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
namespace Maticsoft.Model
{
	/// <summary>
	/// fenshu_list_view:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class fenshu_list_view
	{
		public fenshu_list_view()
		{}
		#region Model
		private int _id;
		private string _peixunban;
		private string _kecheng;
		private string _jiangshi;
		private string _text;
		private decimal? _fenshu;
		private int? _fenzu_id;
		private int _peixunban_id;
		private int? _shangke_id;
		private int _dafenbiao_id;
		private string _neirong;
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
		public string peixunban
		{
			set{ _peixunban=value;}
			get{return _peixunban;}
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
		public decimal? fenshu
		{
			set{ _fenshu=value;}
			get{return _fenshu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? fenzu_id
		{
			set{ _fenzu_id=value;}
			get{return _fenzu_id;}
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
		public int? shangke_id
		{
			set{ _shangke_id=value;}
			get{return _shangke_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int dafenbiao_id
		{
			set{ _dafenbiao_id=value;}
			get{return _dafenbiao_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string neirong
		{
			set{ _neirong=value;}
			get{return _neirong;}
		}
		#endregion Model

	}
}

