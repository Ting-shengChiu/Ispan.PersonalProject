using _2023.hotel.SqlDataLayer.core;
using _2023.hotel.SqlDataLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer
{
	public interface IMemberRepository
	{
		MemberEntity GetByAccount(string account);
	}

}
