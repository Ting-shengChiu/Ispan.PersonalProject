using _2023.hotel.SqlDataLayer.core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer.Dto
{
	public class MemberDto
	{
		public int Id { get; set; }
		public string Name { get; set; }

		[Required(ErrorMessage = "Phone number is required.")]
		[RegularExpression(@"^09\d{8}$", ErrorMessage = "Invalid phone number format.")]
		public string PhoneNumber { get; set; }
		public string Account { get; set; }

		public string Password { get; set; }
	}

	public static class MemberEntityExts
	{
		public static MemberDto ToDto(this MemberEntity entity)
		{
			return new MemberDto
			{
				Id = entity.Id,
				Name = entity.Name,
				PhoneNumber = entity.PhoneNumber,
				Account = entity.Account,
				Password = entity.Password
			};
		}
		public static MemberEntity ToEntity(this MemberDto dto)
		{
			return new MemberEntity(dto.Name,dto.PhoneNumber,dto.Account,dto.Password,dto.Id);
		}
	}
}
