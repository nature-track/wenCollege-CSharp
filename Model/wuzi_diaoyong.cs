/**  版本信息模板在安装目录下，可自行修改。
* wuzi_diaoyong.cs
*
* 功 能： N/A
* 类 名： wuzi_diaoyong
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-11-14 15:36:08   N/A    初版
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
	/// wuzi_diaoyong:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class wuzi_diaoyong
	{
		public wuzi_diaoyong()
		{}
		#region Model
		private int _id;
		private int _wuzi_id;
		private string _fengongsi;
		private int? _num;
		private int? _peixunbanid;
		private int? _style;
		private DateTime? _time;
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
		public int wuzi_id
		{
			set{ _wuzi_id=value;}
			get{return _wuzi_id;}
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
		public int? num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? peixunbanid
		{
			set{ _peixunbanid=value;}
			get{return _peixunbanid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? style
		{
			set{ _style=value;}
			get{return _style;}
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
		public string beizhu2
		{
			set{ _beizhu2=value;}
			get{return _beizhu2;}
		}
		#endregion Model

	}
}

