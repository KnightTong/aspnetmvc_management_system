using System;
namespace HTNResp.Model
{
	/// <summary>
	/// AccessTable:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public partial class AccessTable
	{
		public AccessTable()
		{}
		#region Model
		private int _id;
		private string _tablename;
		private string _tableadress;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TableName
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TableAdress
		{
			set{ _tableadress=value;}
			get{return _tableadress;}
		}
		#endregion Model

	}
}

