using System;
namespace MedDRASearch.Model
{
	/// <summary>
	/// meddra:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class meddra
	{
		public meddra()
		{}
		#region Model
		private string _soc_name;
		private string _soc_code;
		private string _hlgt_name;
		private string _hlgt_code;
		private string _hlt_name;
		private string _hlt_code;
		private string _pt_name;
		private string _pt_code;
		private string _llt_name;
		private string _llt_code;
		/// <summary>
		/// 
		/// </summary>
		public string soc_name
		{
			set{ _soc_name=value;}
			get{return _soc_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string soc_code
		{
			set{ _soc_code=value;}
			get{return _soc_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hlgt_name
		{
			set{ _hlgt_name=value;}
			get{return _hlgt_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hlgt_code
		{
			set{ _hlgt_code=value;}
			get{return _hlgt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hlt_name
		{
			set{ _hlt_name=value;}
			get{return _hlt_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hlt_code
		{
			set{ _hlt_code=value;}
			get{return _hlt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pt_name
		{
			set{ _pt_name=value;}
			get{return _pt_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pt_code
		{
			set{ _pt_code=value;}
			get{return _pt_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string llt_name
		{
			set{ _llt_name=value;}
			get{return _llt_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string llt_code
		{
			set{ _llt_code=value;}
			get{return _llt_code;}
		}
		#endregion Model

	}
}

