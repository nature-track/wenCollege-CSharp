using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// dafenbiao:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class dafenbiao
	{
		public dafenbiao()
		{}
		#region Model
		private int _id;
		private string _leibie;
		private string _text;
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
		public string leibie
		{
			set{ _leibie=value;}
			get{return _leibie;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string text
		{
			set{ _text=value;}
			get{return _text;}
		}
		#endregion Model

	}
}

