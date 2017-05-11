/**  版本信息模板在安装目录下，可自行修改。
* wuzi.cs
*
* 功 能： N/A
* 类 名： wuzi
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-11-14 16:19:33   N/A    初版
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
	/// wuzi:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class wuzi
	{
		public wuzi()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _gongyingshang;
		private string _person;
		private string _phone;
		private string _beizhu;
		private decimal? _danjia;
		private string _beizhu2;
		private int? _style;
		private string _danwei;
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
		public string gongyingshang
		{
			set{ _gongyingshang=value;}
			get{return _gongyingshang;}
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
		public string beizhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
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
		public string beizhu2
		{
			set{ _beizhu2=value;}
			get{return _beizhu2;}
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
		public string danwei
		{
			set{ _danwei=value;}
			get{return _danwei;}
		}
		#endregion Model

	}
}

