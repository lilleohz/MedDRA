using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using MedDRASearch.DBUtility;//Please add references
namespace MedDRASearch.DAL
{
	/// <summary>
	/// 数据访问类:meddra
	/// </summary>
	public partial class meddra
	{
		public meddra()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MedDRASearch.Model.meddra model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into meddra(");
			strSql.Append("soc_name,soc_code,hlgt_name,hlgt_code,hlt_name,hlt_code,pt_name,pt_code,llt_name,llt_code)");
			strSql.Append(" values (");
			strSql.Append("@soc_name,@soc_code,@hlgt_name,@hlgt_code,@hlt_name,@hlt_code,@pt_name,@pt_code,@llt_name,@llt_code)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@soc_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@soc_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@hlgt_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@hlgt_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@hlt_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@hlt_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@pt_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@pt_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@llt_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@llt_code", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.soc_name;
			parameters[1].Value = model.soc_code;
			parameters[2].Value = model.hlgt_name;
			parameters[3].Value = model.hlgt_code;
			parameters[4].Value = model.hlt_name;
			parameters[5].Value = model.hlt_code;
			parameters[6].Value = model.pt_name;
			parameters[7].Value = model.pt_code;
			parameters[8].Value = model.llt_name;
			parameters[9].Value = model.llt_code;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MedDRASearch.Model.meddra model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update meddra set ");
			strSql.Append("soc_name=@soc_name,");
			strSql.Append("soc_code=@soc_code,");
			strSql.Append("hlgt_name=@hlgt_name,");
			strSql.Append("hlgt_code=@hlgt_code,");
			strSql.Append("hlt_name=@hlt_name,");
			strSql.Append("hlt_code=@hlt_code,");
			strSql.Append("pt_name=@pt_name,");
			strSql.Append("pt_code=@pt_code,");
			strSql.Append("llt_name=@llt_name,");
			strSql.Append("llt_code=@llt_code");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@soc_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@soc_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@hlgt_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@hlgt_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@hlt_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@hlt_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@pt_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@pt_code", MySqlDbType.VarChar,255),
					new MySqlParameter("@llt_name", MySqlDbType.VarChar,255),
					new MySqlParameter("@llt_code", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.soc_name;
			parameters[1].Value = model.soc_code;
			parameters[2].Value = model.hlgt_name;
			parameters[3].Value = model.hlgt_code;
			parameters[4].Value = model.hlt_name;
			parameters[5].Value = model.hlt_code;
			parameters[6].Value = model.pt_name;
			parameters[7].Value = model.pt_code;
			parameters[8].Value = model.llt_name;
			parameters[9].Value = model.llt_code;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from meddra ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MedDRASearch.Model.meddra GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select soc_name,soc_code,hlgt_name,hlgt_code,hlt_name,hlt_code,pt_name,pt_code,llt_name,llt_code from meddra ");
			strSql.Append(" where ");
			MySqlParameter[] parameters = {
			};

			MedDRASearch.Model.meddra model=new MedDRASearch.Model.meddra();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MedDRASearch.Model.meddra DataRowToModel(DataRow row)
		{
			MedDRASearch.Model.meddra model=new MedDRASearch.Model.meddra();
			if (row != null)
			{
				if(row["soc_name"]!=null)
				{
					model.soc_name=row["soc_name"].ToString();
				}
				if(row["soc_code"]!=null)
				{
					model.soc_code=row["soc_code"].ToString();
				}
				if(row["hlgt_name"]!=null)
				{
					model.hlgt_name=row["hlgt_name"].ToString();
				}
				if(row["hlgt_code"]!=null)
				{
					model.hlgt_code=row["hlgt_code"].ToString();
				}
				if(row["hlt_name"]!=null)
				{
					model.hlt_name=row["hlt_name"].ToString();
				}
				if(row["hlt_code"]!=null)
				{
					model.hlt_code=row["hlt_code"].ToString();
				}
				if(row["pt_name"]!=null)
				{
					model.pt_name=row["pt_name"].ToString();
				}
				if(row["pt_code"]!=null)
				{
					model.pt_code=row["pt_code"].ToString();
				}
				if(row["llt_name"]!=null)
				{
					model.llt_name=row["llt_name"].ToString();
				}
				if(row["llt_code"]!=null)
				{
					model.llt_code=row["llt_code"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select soc_name,soc_code,hlgt_name,hlgt_code,hlt_name,hlt_code,pt_name,pt_code,llt_name,llt_code ");
			strSql.Append(" FROM meddra ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM meddra ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from meddra T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "meddra";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

