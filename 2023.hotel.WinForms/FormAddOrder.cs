using _2023.hotel.SqlDataLayer;
using _2023.hotel.SqlDataLayer.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace _2023.hotel.WinForms
{
	public partial class FormAddOrder : Form
	{
		private int _id;
		public FormAddOrder(int id)
		{
			InitializeComponent();
			_id = id;
		}

		private void btnGetDate_Click(object sender, EventArgs e)
		{
			DateTime checkInDate = Convert.ToDateTime(CheckInPicker.Text);
			DateTime checkOutDate = Convert.ToDateTime(CheckOutPicker.Text);
			int roomId = Convert.ToInt32(comboBoxRoom.Text);
			OrderGetDto dto = new OrderGetDto()
			{
				checkInDate = checkInDate,
				checkOutDate = checkOutDate,
				orderDateTime = default(DateTime),
				roomId = roomId,
				orderId = default(int)

			};
			var get = OrderRepository.GetRoom(dto);
			dataGridView1.Rows.Add(new string[] { comboBoxRoom.SelectedItem.ToString(), dto.checkInDate.ToShortDateString(), dto.checkOutDate.ToShortDateString() });
		}

		private void button1_Click(object sender, EventArgs e)
		{
			bool IsDateTrue()
			{
				if(CheckInPicker.Value>= CheckOutPicker.Value)
				{
					throw new ArgumentNullException(string.Empty, "入住日必須小於退房日!!");
				}return true;
			}
			bool isRoomIdValues(string item)
			{
				item = comboBoxRoom.Text;
				if (string.IsNullOrEmpty(item))
				{ throw new ArgumentNullException(string.Empty, "請選擇房型"); }
				return true;
			}

			try
			{
				isRoomIdValues((string)comboBoxRoom.SelectedItem);
				IsDateTrue();
				int roomId = Convert.ToInt32(comboBoxRoom.Text);


				OrderDetilDto dto = new OrderDetilDto()
				{
					customerId = _id,
					checkInDate = CheckInPicker.Value,
					checkOutDate = CheckOutPicker.Value,
					roomId = roomId,
				};
				int id = OrderRepository.GetRoomDetil(dto);
				dataGridView1.Rows.Add(new string[] { id.ToString(), comboBoxRoom.SelectedItem.ToString(), dto.checkInDate.ToShortDateString(), dto.checkOutDate.ToShortDateString() });
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void FormAddOrder_Load(object sender, EventArgs e)
		{
			CheckInPicker.MinDate = DateTime.Today;
			CheckOutPicker.MinDate = DateTime.Today;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
