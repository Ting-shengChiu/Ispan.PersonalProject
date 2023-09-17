using _2023.hotel.SqlDataLayer.Dto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer
{
	public class MemberRepository
	{
		public int Create(MemberDto dto)
		{
			string sql = @"SET NOCOUNT ON;
INSERT INTO Customer
(name,phoneNumber,account,password)
VALUES
(@name,@phoneNumber,@account,@password);
SET @newId = SCOPE_IDENTITY()";


			var parameters = SqlParameterBuilder.Create()
			.AddNvarchar("@name", 50, dto.Name)
			.AddNvarchar("@phoneNumber", 50, dto.PhoneNumber)
			.AddNvarchar("@account",50,dto.Account)
			.AddNvarchar("@password",50,dto.Password)
			.AddOutputInt("@newId")
			.Build();

			using (var conn = SqlDb.GetConnection("default"))
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					cmd.Parameters.AddRange(parameters);
					cmd.ExecuteNonQuery();
					return (int)cmd.Parameters["@newId"].Value;
				}
			}
		}

		public int Update(MemberDto dto)
		{
			string sql = @"update Customer set
name = @name,
phoneNumber =@phoneNumber,
password = @password
where
account = @account ";
			SqlParameter[] parameters = SqlParameterBuilder.Create()
			.AddNvarchar("@name", 50, dto.Name)
			.AddNvarchar("@phoneNumber", 50, dto.PhoneNumber)
			.AddNvarchar("@password", 50, dto.Password)
			.AddNvarchar("@account",50,dto.Account)
				.Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);

		}


		public MemberDto Get(int id)
		{
			Func<SqlConnection> funcConn = SqlDb.GetConnection;
			var sql = $"select * from customer where id=@id";
			Func<SqlDataReader, MemberDto> funcAssembler = reader =>
			{
				return new MemberDto
				{
					Id = reader.GetInt32("Id", 0),
					Account = reader.GetString("Account"),
					Name = reader.GetString("name"),
					PhoneNumber = reader.GetString("phoneNumber"),
					Password = reader.GetString("password")
				};
			};
			SqlParameter[] parameters = SqlParameterBuilder.Create()
				.AddInt("@id", id)
				.Build();
			return SqlDb.Get(funcConn, funcAssembler, sql,parameters);

		}
	}
}
