using _2023.hotel.SqlDataLayer.core;
using _2023.hotel.SqlDataLayer.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer.SqlRepository
{
	public class SqlMemberRepository : IMemberRepository
	{
		public MemberEntity GetByAccount(string account)
		{
			string sql = "select * from Customer where account = @account";

			SqlParameter parameter = new SqlParameter("account", System.Data.SqlDbType.NVarChar, 50) { Value = account };

			Func<SqlDataReader, MemberEntity> funcAssembler = reader =>
			{
				int id = reader.GetInt32("Id", 0);
				string acc = reader.GetString("account");
				string password = reader.GetString("password");
				string name = reader.GetString("name");
				string phoneNumber = reader.GetString("phoneNumber");
				return new MemberEntity(name, phoneNumber, account, password, id);
			};
			return SqlDb.Get<MemberEntity>(SqlDb.GetConnection, funcAssembler, sql, parameter);
		}
	}
}
