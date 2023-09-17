using _2023.hotel.SqlDataLayer;
using _2023.hotel.SqlDataLayer.Dto;
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
	public partial class FormUpdateMember : Form
	{
		private int _id;
		public FormUpdateMember(int id)
		{
			InitializeComponent();
			_id = id;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var member = new MemberDto
			{
				Id=_id,
				Account = txtAccount.Text,
				Name = txtName.Text,
				Password = txtPassword.Text,
				PhoneNumber = txtCellphoneNumber.Text,
			};

			int rowAffected = new MemberRepository().Update(member);

			if (rowAffected > 0)
			{
				MessageBox.Show("紀錄已更新");
			}
			else
			{
				MessageBox.Show("紀錄沒有被異動，可能紀錄已經被刪除");
			}
			//this.Owner.Show();
			DialogResult = DialogResult.OK;
		}

		private void FormUpdateMember_Load(object sender, EventArgs e)
		{
			MemberDto memberDto = new MemberRepository().Get(_id);
			txtCellphoneNumber .Text = memberDto.PhoneNumber;
			txtAccount .Text = memberDto.Account;
			txtName .Text = memberDto.Name;
			txtPassword .Text = memberDto.Password;
		}
	}
}
