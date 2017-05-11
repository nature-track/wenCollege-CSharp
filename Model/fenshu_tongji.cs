/**  版本信息模板在安装目录下，可自行修改。
* fenshu_tongji.cs
*
* 功 能： N/A
* 类 名： fenshu_tongji
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
	/// fenshu_tongji:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class fenshu_tongji
	{
		public fenshu_tongji()
		{}
		#region Model
		private string _peixunban;
		private string _kecheng;
		private string _jiangshi;
		private decimal? _pingjunfen;
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
		public decimal? pingjunfen
		{
			set{ _pingjunfen=value;}
			get{return _pingjunfen;}
		}
		#endregion Model

	}
}

