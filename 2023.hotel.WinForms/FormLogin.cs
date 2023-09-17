using _2023.hotel.SqlDataLayer;
using _2023.hotel.SqlDataLayer.Service;
using _2023.hotel.SqlDataLayer.SqlRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2023.hotel.WinForms
{
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			IMemberRepository memberRepository = new SqlMemberRepository();
			MemberService service = new MemberService(memberRepository);

			try
			{
				bool validationResult = service.IsValid(txtAccount.Text, txtPassword.Text);
				if (validationResult == false)
				{
					MessageBox.Show("帳號或密碼有錯誤,請再試一次");
					return;
				}
				
				var dto = service.GetByAccount(txtAccount.Text);
				
				//清空表單值，以便下次在使用時，不會有值
				txtAccount.Text = string.Empty;
				txtPassword.Text = string.Empty;


				var frm = new Form1(dto.Id,dto.Account);
				frm.Owner = this;

				//這點很重要，不能將FormLogin關閉，只能隱藏
				//否則目前的 application就會視同結束
				this.Hide();

				//稍後FormMain關閉時，再將FormLogin顯示
				frm.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private void btnAddMenber_Click(object sender, EventArgs e)
		{
			var frm = new FormAddMember();
			frm.ShowDialog();
		}

	}
}
