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
using System.Xml.Linq;

namespace _2023.hotel.WinForms
{
	public partial class FormGetOrder : Form
	{
		private int _orderId;
		public FormGetOrder(int orderId)
		{
			InitializeComponent();
			_orderId = orderId;
		}

		private void FormGetOrder_Load(object sender, EventArgs e)
		{
			OrderGetDto order = new OrderRepository().Get(_orderId);
			if (order == null)
			{
				MessageBox.Show("無此訂單!");
				DialogResult = DialogResult.Cancel;
				return;
			}

			textOrderId.Text = Convert.ToString(order.orderId);
			textRoomId.Text = Convert.ToString(order.roomId);
			textCheckInDate.Text = Convert.ToString(order.checkInDate);
			textCheckOutDate.Text = Convert.ToString(order.checkOutDate);
			textOrderDate.Text = Convert.ToString(order.orderDateTime);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
			
		}

		private void btnDeleteOrder_Click(object sender, EventArgs e)
		{
			bool isInt = int.TryParse(textOrderId.Text, out int OrderId);
			if (!isInt)
			{
				MessageBox.Show("請輸入 News Id, 再試一次");
				return;
			}

			int rowAffected = new OrderRepository().Delete(OrderId);
			if (rowAffected == 1)
			{
				MessageBox.Show("已刪除");
			}
			else
			{
				MessageBox.Show("沒有紀錄被刪除, 可能此紀錄不存在");
			}
			this.Close();
		}
	}
}
