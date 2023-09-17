using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer
{
	public static class SQLDataReaderExtensions
	{
		public static string GetString(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? null
				: reader.GetString(colIndex);
		}

		public static int? GetInt32(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (int?)null
				: reader.GetInt32(colIndex);
		}
		//public static int? GetInt32(this SqlDataReader reader, int columnName)
		//{
		//	int colIndex = reader.GetOrdinal(columnName);
		//	return reader.IsDBNull(colIndex)
		//		? (int?)null
		//		: reader.GetInt32(colIndex);
		//}



		public static bool GetBoolean(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.GetBoolean(colIndex);
		}

		public static int GetInt32(this SqlDataReader reader, string columnName, int defaultValuue)
		{
			int? result = reader.GetInt32(columnName);
			return result.HasValue
				? result.Value
				: defaultValuue;
		}

		public static DateTime? GetDateTime(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (DateTime?)null
				: reader.GetDateTime(colIndex);
		}
		public static DateTime GetDateTime(this SqlDataReader reader, string columnName, DateTime defaultValue)
		{
			DateTime? result = reader.GetDateTime(columnName);
			return result.HasValue
				? result.Value
				: defaultValue;
		}
	}
}
