using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// shangke:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shangke
	{
		public shangke()
		{}
		#region Model
		private int _id;
		private string _qishu;
		private string _kecheng;
		private string _jiangshi;
		private decimal? _keshi;
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
		public string qishu
		{
			set{ _qishu=value;}
			get{return _qishu;}
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
		public decimal? keshi
		{
			set{ _keshi=value;}
			get{return _keshi;}
		}
		#endregion Model

	}
}

