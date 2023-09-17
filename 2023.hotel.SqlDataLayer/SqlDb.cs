using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer
{
	public class SqlDb
	{
		public static string ApplicationName { get; set; }

		public static string GetConnectionString(string keyOfConnString)
		{
			string connStr = System.Configuration.ConfigurationManager.ConnectionStrings[keyOfConnString].ToString();

			if (string.IsNullOrEmpty(connStr))
			{
				throw new Exception("找不到字串連線，key=" + keyOfConnString);
			}
			SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);
			if (string.IsNullOrEmpty(ApplicationName) == false)
			{
				sb.ApplicationName = ApplicationName;
			}

			//sb.UserID = "allen";

			return sb.ToString();
			//return connStr;
		}

		public static SqlConnection GetConnection(string keyOfConnString)
		{
			string connStr = GetConnectionString(keyOfConnString);
			return new SqlConnection(connStr);
		}

		public static SqlConnection GetConnection()
		{

			return GetConnection("default");
		}

		public static T Get<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();

				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					return reader.Read()
						? funcAssembler(reader)
						: default(T);
				}
			}
		}
		public static int UpdateOrDelete(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery();//傳回被異動的筆數，如為零，表示沒有異動紀錄
				}
			}
		}

		public static List<T> Search<T>(Func<SqlConnection> funcConn, Func<SqlDataReader, T> funcAssembler, string sql, params SqlParameter[] parameters)
		{
			List<T> list = new List<T>();
			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					while (reader.Read())
					{
						T entity = funcAssembler(reader);
						list.Add(entity);
					}
					return list;
				}
			}
		}
		public static int Create(Func<SqlConnection> funcConn, string sql, params SqlParameter[] parameters)
		{
			sql += ";select scope_identity()";

			using (var conn = funcConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);
					return Convert.ToInt32(cmd.ExecuteScalar());//傳回興增的那個ID
				}
			}

		}
	}
}
