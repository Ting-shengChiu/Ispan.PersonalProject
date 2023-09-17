using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer.core
{
	public class MemberEntity
	{
		public int Id { get; private set; }
		public string Name { get; private set; }
		public string PhoneNumber { get; private set; }
		public string Account { get; private set; }
		public string Password { get; private set; }

		public MemberEntity(string name,string phoneNumber, string account, string password,int id=0) 
		{
			Name = name;
			PhoneNumber = phoneNumber;
			Account = account;
			Password = password;
			Id = id;
		}
	}
}
