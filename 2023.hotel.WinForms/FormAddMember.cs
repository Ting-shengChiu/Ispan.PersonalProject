using _2023.hotel.SqlDataLayer;
using _2023.hotel.SqlDataLayer.Dto;
using _2023.hotel.SqlDataLayer.Service;
using _2023.hotel.SqlDataLayer.SqlRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023.hotel.WinForms
{
	public partial class FormAddMember : Form
	{
		public FormAddMember()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{


			IMemberRepository memberRepository = new SqlMemberRepository();
			MemberService service = new MemberService(memberRepository);


			var member = new MemberDto();

			member.Name = txtName.Text;
			member.PhoneNumber = txtPhoneNumber.Text;
			member.Account = txtAccount.Text;
			member.Password = txtPassword.Text;


			try
			{
				bool validationResult = service.AddmemberIsValid(member.Account, member.Password, member.PhoneNumber,member.Name );
				

			


				int id = new MemberRepository().Create(member);
				MessageBox.Show($"創立成功!");
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
	}
}
