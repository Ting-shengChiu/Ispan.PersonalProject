using _2023.hotel.SqlDataLayer.core;
using _2023.hotel.SqlDataLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.hotel.SqlDataLayer.Service
{
	public class MemberService
	{
		private readonly IMemberRepository _repo;

		public MemberService(IMemberRepository repo)
		{
			_repo = repo;
		}
		public bool IsValid(string account, string password)
		{
			//precondition cheaks
			//account,password必填
			if (string.IsNullOrEmpty(account)) { throw new ArgumentNullException(string.Empty, "帳號要打字"); }
			if (string.IsNullOrEmpty(password)) { throw new ArgumentNullException(string.Empty, "密碼要打字"); }

			//取得單一使用者
			MemberEntity user = _repo.GetByAccount(account);
			if (user == null) { return false; }
			//判斷密碼是否正確
			string passwordInDb = user.Password;//這是正確的密碼

			//如果大小寫不拘
			return (passwordInDb.ToLower() == password.ToLower());
			//如果區分大小寫
			//return passwordInDb== password;

		}
		public bool AddmemberIsValid(string account, string password, string cellphoneNumber, string name)
		{
			if (string.IsNullOrEmpty(account)) { throw new ArgumentNullException(string.Empty, "帳號要打字"); }

			MemberEntity user = _repo.GetByAccount(account);
			if (user != null)
			{
				throw new ArgumentNullException(string.Empty, "帳號重複");
			}
			if (string.IsNullOrEmpty(password)) { throw new ArgumentNullException(string.Empty, "密碼要打字"); }
			if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException(string.Empty, "名字為必填"); }
			if (string.IsNullOrEmpty(cellphoneNumber)) { throw new ArgumentNullException(string.Empty, "電話為必填"); }




			return true;
		}

		public MemberDto GetByAccount(string account)
		{
			var user = _repo.GetByAccount(account);
			if (user is null) { return null; }
			return _repo.GetByAccount(account).ToDto();
		}


	}
}
