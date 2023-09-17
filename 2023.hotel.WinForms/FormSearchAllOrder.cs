using _2023.hotel.SqlDataLayer;
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
	public partial class FormSearchAllOrder : Form
	{
		private int _Id;
		public FormSearchAllOrder(int id)
		{
			InitializeComponent();
			_Id = id;

		}

		private void FormSearchAllOrder_Load(object sender, EventArgs e)
		{
			var repo = new OrderRepository();
			var products = repo.SearchAll(_Id);
			dataGridView1.DataSource = products;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
