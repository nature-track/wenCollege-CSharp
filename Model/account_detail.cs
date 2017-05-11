/**  版本信息模板在安装目录下，可自行修改。
* account_detail.cs
*
* 功 能： N/A
* 类 名： account_detail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-11-6 15:59:31   N/A    初版
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
	/// account_detail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class account_detail
	{
		public account_detail()
		{}
		#region Model
		private int _id;
		private string _wuzi;
		private string _danwei;
		private decimal? _danjia;
		private int? _shuliang;
		private int? _account_id;
		private int? _wuzi_id;
		private string _beizhu;
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
		public int? account_id
		{
			set{ _account_id=value;}
			get{return _account_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? wuzi_id
		{
			set{ _wuzi_id=value;}
			get{return _wuzi_id;}
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

