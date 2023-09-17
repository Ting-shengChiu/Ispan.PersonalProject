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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2023.hotel.WinForms
{
	public partial class Form1 : Form
	{
		private int _id;
		private string _account;


		public Form1(int id, string account)
		{
			InitializeComponent();
			this._id = id;
			_account = account;
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Owner.Show();
			DialogResult = DialogResult.OK;
		}

		private void btnUpdateMember_Click(object sender, EventArgs e)
		{
			var frm = new FormUpdateMember(this._id);
			frm.ShowDialog();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void btnAddOrder_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(this._account);
			var frm = new FormAddOrder(this._id);
			frm.ShowDialog();
		}

		private void btnSearchOrder_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textCustomerId.Text, out int orderId);
			if (!isInt)
			{
				MessageBox.Show("請輸入 customer Id,再試一次");
				return;
			}
			var frm = new FormGetOrder(orderId);
			frm.ShowDialog();
		}

		private void btnSearchAll_Click(object sender, EventArgs e)
		{
			var frm = new FormSearchAllOrder(this._id);
			frm.ShowDialog();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
