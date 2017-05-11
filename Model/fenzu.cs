using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// fenzu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class fenzu
	{
		public fenzu()
		{}
		#region Model
		private int _id;
		private string _qishu;
		private int _zushu;
		private string _zuming;
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
		public int zushu
		{
			set{ _zushu=value;}
			get{return _zushu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zuming
		{
			set{ _zuming=value;}
			get{return _zuming;}
		}
		#endregion Model

	}
}

