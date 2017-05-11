/**  版本信息模板在安装目录下，可自行修改。
* dafen_jieguo.cs
*
* 功 能： N/A
* 类 名： dafen_jieguo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-2-3 16:32:26   N/A    初版
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
	/// dafen_jieguo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class dafen_jieguo
	{
		public dafen_jieguo()
		{}
		#region Model
		private int _id;
		private int? _shangke_id;
		private int? _fenzu_id;
		private decimal? _fenshu;
		private string _neirong;
		private int? _dafen_xuhao;
		private DateTime? _time;
		private string _open_id;
		private string _name;
		private string _beizhu;
		private int? _style;
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
		public int? shangke_id
		{
			set{ _shangke_id=value;}
			get{return _shangke_id;}
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
		public decimal? fenshu
		{
			set{ _fenshu=value;}
			get{return _fenshu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string neirong
		{
			set{ _neirong=value;}
			get{return _neirong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? dafen_xuhao
		{
			set{ _dafen_xuhao=value;}
			get{return _dafen_xuhao;}
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
		public string beizhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? style
		{
			set{ _style=value;}
			get{return _style;}
		}
		#endregion Model

	}
}

