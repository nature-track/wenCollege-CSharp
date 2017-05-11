/**  版本信息模板在安装目录下，可自行修改。
* hui_kuan_dan.cs
*
* 功 能： N/A
* 类 名： hui_kuan_dan
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-12-21 14:42:54   N/A    初版
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
	/// hui_kuan_dan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hui_kuan_dan
	{
		public hui_kuan_dan()
		{}
		#region Model
		private int _id;
		private string _huikuan_neirong;
		private string _xiangmu_mingcheng;
		private decimal? _xiangmu_zongkuan;
		private decimal? _yifu_jine;
		private DateTime? _zhifu_shijian;
		private decimal? _benci_jine;
		private DateTime? _yuji_yukuan;
		private int? _supplier_id;
		private int? _leibie;
		private string _beizhu;
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
		public string huikuan_neirong
		{
			set{ _huikuan_neirong=value;}
			get{return _huikuan_neirong;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string xiangmu_mingcheng
		{
			set{ _xiangmu_mingcheng=value;}
			get{return _xiangmu_mingcheng;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? xiangmu_zongkuan
		{
			set{ _xiangmu_zongkuan=value;}
			get{return _xiangmu_zongkuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? yifu_jine
		{
			set{ _yifu_jine=value;}
			get{return _yifu_jine;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? zhifu_shijian
		{
			set{ _zhifu_shijian=value;}
			get{return _zhifu_shijian;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? benci_jine
		{
			set{ _benci_jine=value;}
			get{return _benci_jine;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? yuji_yukuan
		{
			set{ _yuji_yukuan=value;}
			get{return _yuji_yukuan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? supplier_id
		{
			set{ _supplier_id=value;}
			get{return _supplier_id;}
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
		public string beizhu
		{
			set{ _beizhu=value;}
			get{return _beizhu;}
		}
		#endregion Model

	}
}

