using System;
namespace HTNResp.Model
{
    /// <summary>
    /// SubtMedicineDetail:ʵ����(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
    /// </summary>
    [Serializable]
	public partial class SubtMedicineDetail
    {
		public SubtMedicineDetail()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _filepath;
		private string _imgpaht;
		/// <summary>
		/// ˵��
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string FilePath
		{
			set{ _filepath=value;}
			get{return _filepath; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgPath
		{
			set{ _imgpaht=value;}
			get{return _imgpaht; }
		}
		#endregion Model

	}
}

