using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer
{
	public class SqlParameterBuilder
	{
		private List<SqlParameter> _parameters = new List<SqlParameter>();

		public static SqlParameterBuilder Create()
		{ return new SqlParameterBuilder(); }

		public SqlParameterBuilder AddInt(string name, int value)
		{
			var parameter = new SqlParameter(name, SqlDbType.Int) { Value = value };
			_parameters.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddNullableInt(string name, int? value)
		{
			return value.HasValue
				? AddInt(name, value.Value)
				: AddNullInt(name);
		}

		public SqlParameterBuilder AddNullInt(string name)
		{
			var parameter = new SqlParameter(name, SqlDbType.Int) { Value = DBNull.Value };
			_parameters.Add(parameter);

			return this;
		}

		public SqlParameter[] Build() { return _parameters.ToArray(); }

		public SqlParameterBuilder AddOutputInt(string name)
		{
			var parameter = new SqlParameter(name, SqlDbType.Int) { Direction = ParameterDirection.Output };
			_parameters.Add(parameter);

			return this;
		}

		public SqlParameterBuilder AddNvarchar(string name, int length, string value)
		{
			var parameter = string.IsNullOrEmpty(value)
				? new SqlParameter(name, SqlDbType.NVarChar, length) { Value = DBNull.Value }
				: new SqlParameter(name, SqlDbType.NVarChar, length) { Value = value };
			_parameters.Add(parameter);
			return this;
		}

		public SqlParameterBuilder AddDateTime(string name, DateTime value)
		{
			var parameter = new SqlParameter(name, SqlDbType.DateTime) { Value = value };
			_parameters.Add(parameter);
			return this;
		}

		public SqlParameterBuilder AddBoolean(string name, bool value)
		{
			var parameter = new SqlParameter(name, SqlDbType.Bit) { Value = value };
			_parameters.Add(parameter);
			return this;
		}
	}
}
