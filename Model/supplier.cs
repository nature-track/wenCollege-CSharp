/**  版本信息模板在安装目录下，可自行修改。
* supplier.cs
*
* 功 能： N/A
* 类 名： supplier
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-12-21 14:42:52   N/A    初版
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
	/// supplier:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class supplier
	{
		public supplier()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _person;
		private string _phone;
		private string _phone2;
		private string _bank;
		private string _bank_num;
		private string _address;
		private int? _style;
		private int? _leibie;
		private string _wuzi;
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
		public string person
		{
			set{ _person=value;}
			get{return _person;}
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
		public string phone2
		{
			set{ _phone2=value;}
			get{return _phone2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bank
		{
			set{ _bank=value;}
			get{return _bank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string bank_num
		{
			set{ _bank_num=value;}
			get{return _bank_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
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
		public int? leibie
		{
			set{ _leibie=value;}
			get{return _leibie;}
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

