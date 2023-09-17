using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2023.hotel.SqlDataLayer.Dto;

namespace _2023.hotel.SqlDataLayer
{
	public class OrderRepository
	{
		public static object GetRoom(OrderGetDto dto)
		{
			string sql = @"SET NOCOUNT ON;
insert into OrderDetail(roomId,checkInDate,checkOutDate) 
values
(@roomId,@checkInDate,@checkOutDate);";

			var parameters = SqlParameterBuilder.Create()
				.AddDateTime("@checkInDate", dto.checkInDate)
				.AddDateTime("@checkOutDate", dto.checkOutDate)
				.AddInt("@roomId", dto.roomId)
				.Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}

		public int Delete(int orderId)
		{
			string sql = @"DELETE [Order] WHERE Id = @orderId";

			SqlParameter[] parameters = SqlParameterBuilder.Create()
			 .AddInt("@orderId", orderId)
			 .Build();

			return SqlDb.UpdateOrDelete(SqlDb.GetConnection, sql, parameters);
		}

		public OrderGetDto Get(int orderId)
		{
			using (SqlConnection conn = SqlDb.GetConnection("default"))
			{
				conn.Open();

				var Sql = $"select orderId,roomId,checkInDate,checkOutDate,orderDatetime from OrderDetail join [Order] on  OrderDetail.orderId=[Order].id where orderId = {orderId}";
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = Sql;
					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					if (reader.Read())
					{
						var order = new OrderGetDto();

						order.orderId = reader.GetInt32("orderId", 0);
						order.roomId = reader.GetInt32("roomId", 0);
						order.checkInDate = reader.GetDateTime("checkInDate", DateTime.MinValue);
						order.checkOutDate = reader.GetDateTime("checkOutDate", DateTime.MinValue);
						order.orderDateTime = reader.GetDateTime("orderDateTime", DateTime.MinValue);
						return order;
					}
					else
					{ return null; }
				}
			}
		}
		public int Create(OrderAddDto dto)
		{
			string sql = @"SET NOCOUNT ON;
INSERT INTO Order
(customerId)
VALUES
(@customerId);
SET @Id = SCOPE_IDENTITY()";


			var parameters = SqlParameterBuilder.Create()
			.AddInt("@customerId", dto.CustomerId)
			.AddOutputInt("@Id")
			.Build();

			using (var conn = SqlDb.GetConnection("default"))
			{
				conn.Open();
				using (var cmd = conn.CreateCommand())
				{
					cmd.CommandText = sql;
					cmd.Parameters.AddRange(parameters);
					cmd.ExecuteNonQuery();
					return (int)cmd.Parameters["@Id"].Value;
				}
			}
		}

		public static int GetRoomDetil(OrderDetilDto dto)
		{
			string sql = @"insert into [Order]([customerId])
values (@customerId)";

			string sql2 = @"insert into OrderDetail(orderId,roomId,checkInDate,checkOutDate)
values (@orderId,@roomId,@checkInDate,@checkOutDate)";

			var parameters = SqlParameterBuilder.Create()
				.AddInt("@customerId", dto.customerId)
				.Build();


			int id = SqlDb.Create(SqlDb.GetConnection, sql, parameters);

			var parameters2 = SqlParameterBuilder.Create()
	.AddInt("@orderId", id)
	.AddDateTime("@checkInDate", dto.checkInDate)
	.AddDateTime("@checkOutDate", dto.checkOutDate)
	.AddInt("@roomId", dto.roomId)
	.Build();


			SqlDb.Create(SqlDb.GetConnection, sql2, parameters2);
			return id;
		}

		public List<OrderGetAllDto> SearchAll(int id)
		{
			var Sql = @"select [Order].id,roomId,checkInDate,checkOutDate,orderDatetime from [Order]
left join OrderDetail
on [Order].id = OrderDetail.orderId
where customerId =  " + id;

			Func<SqlDataReader, OrderGetAllDto> funcAssembler = reader =>
			{
				return new OrderGetAllDto()
				{
					orderId = reader.GetInt32("id", 0),
					roomId = reader.GetInt32("roomId", 0),
					checkInDate = reader.GetDateTime("checkInDate", DateTime.MinValue),
					checkOutDate = reader.GetDateTime("checkOutDate", DateTime.MinValue),
					orderDateTime = reader.GetDateTime("orderDatetime", DateTime.MinValue)
				};
			};
			return SqlDb.Search<OrderGetAllDto>(SqlDb.GetConnection, funcAssembler, Sql);
		}
	}
}
