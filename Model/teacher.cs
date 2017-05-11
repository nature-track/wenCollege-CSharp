using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// teacher:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class teacher
	{
		public teacher()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _qita;
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
		public string qita
		{
			set{ _qita=value;}
			get{return _qita;}
		}
		#endregion Model

	}
}

