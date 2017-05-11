﻿/**  版本信息模板在安装目录下，可自行修改。
* forum_q.cs
*
* 功 能： N/A
* 类 名： forum_q
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-1-4 17:13:17   N/A    初版
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
	/// forum_q:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class forum_q
	{
		public forum_q()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _team;
		private string _question;
		private DateTime? _time;
		private int? _password;
		private int? _peixunban;
		private int? _fenshu;
		private int? _style;
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
		public string team
		{
			set{ _team=value;}
			get{return _team;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string question
		{
			set{ _question=value;}
			get{return _question;}
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
		public int? password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? peixunban
		{
			set{ _peixunban=value;}
			get{return _peixunban;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? fenshu
		{
			set{ _fenshu=value;}
			get{return _fenshu;}
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

