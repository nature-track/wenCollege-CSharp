/**  版本信息模板在安装目录下，可自行修改。
* shangke_view.cs
*
* 功 能： N/A
* 类 名： shangke_view
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016-10-8 17:50:04   N/A    初版
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
	/// shangke_view:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shangke_view
	{
		public shangke_view()
		{}
		#region Model
		private int _id;
		private int _kechengneirong_id;
		private string _peixunban;
		private int _peixunban_id;
		private string _kecheng;
		private int _jiangshi_id;
		private string _jiangshi;
		private decimal? _keshi;
        private string _fenzu;
        private int _fenzu_id;
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
		public int kechengneirong_id
		{
			set{ _kechengneirong_id=value;}
			get{return _kechengneirong_id;}
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
		public int peixunban_id
		{
			set{ _peixunban_id=value;}
			get{return _peixunban_id;}
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
		public int jiangshi_id
		{
			set{ _jiangshi_id=value;}
			get{return _jiangshi_id;}
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
		public decimal? keshi
		{
			set{ _keshi=value;}
			get{return _keshi;}
		}
		#endregion Model

        public string fenzu
        {
            set { _fenzu = value; }
            get { return _fenzu; }
        }
        public int fenzu_id
        {
            set { _fenzu_id = value; }
            get { return _fenzu_id; }
        }
	}
}

