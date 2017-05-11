/**  版本信息模板在安装目录下，可自行修改。
* member.cs
*
* 功 能： N/A
* 类 名： member
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017-1-25 15:48:25   N/A    初版
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
	/// member:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class member
	{
		public member()
		{}
		#region Model
		private int _id;
		private string _openid;
		private string _name;
		private int? _peixunban_id;
		private int? _fenzu_id;
		private string _style;
		private string _phone;
		private string _name2;
		private DateTime? _time;
		private string _beizhu1;
		private string _beizhu2;
		private string _beizhu3;
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
		public string openid
		{
			set{ _openid=value;}
			get{return _openid;}
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
		public int? peixunban_id
		{
			set{ _peixunban_id=value;}
			get{return _peixunban_id;}
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
		public string style
		{
			set{ _style=value;}
			get{return _style;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name2
		{
			set{ _name2=value;}
			get{return _name2;}
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
		public string beizhu1
		{
			set{ _beizhu1=value;}
			get{return _beizhu1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string beizhu2
		{
			set{ _beizhu2=value;}
			get{return _beizhu2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string beizhu3
		{
			set{ _beizhu3=value;}
			get{return _beizhu3;}
		}
		#endregion Model

	}
}

