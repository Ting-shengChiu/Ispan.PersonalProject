namespace _2023.hotel.WinForms
{
	partial class FormAddOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrder));
			this.CheckInPicker = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CheckOutPicker = new System.Windows.Forms.DateTimePicker();
			this.comboBoxRoom = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGetDate = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// CheckInPicker
			// 
			this.CheckInPicker.Location = new System.Drawing.Point(24, 26);
			this.CheckInPicker.MinDate = new System.DateTime(2023, 5, 12, 10, 29, 21, 0);
			this.CheckInPicker.Name = "CheckInPicker";
			this.CheckInPicker.Size = new System.Drawing.Size(200, 22);
			this.CheckInPicker.TabIndex = 0;
			this.CheckInPicker.Value = new System.DateTime(2023, 5, 12, 10, 29, 21, 0);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "入住日期";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(245, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "退房日期";
			// 
			// CheckOutPicker
			// 
			this.CheckOutPicker.Location = new System.Drawing.Point(245, 26);
			this.CheckOutPicker.Name = "CheckOutPicker";
			this.CheckOutPicker.Size = new System.Drawing.Size(200, 22);
			this.CheckOutPicker.TabIndex = 2;
			// 
			// comboBoxRoom
			// 
			this.comboBoxRoom.FormattingEnabled = true;
			this.comboBoxRoom.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
			this.comboBoxRoom.Location = new System.Drawing.Point(24, 76);
			this.comboBoxRoom.Name = "comboBoxRoom";
			this.comboBoxRoom.Size = new System.Drawing.Size(121, 20);
			this.comboBoxRoom.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "房型";
			// 
			// btnGetDate
			// 
			this.btnGetDate.Location = new System.Drawing.Point(98, 212);
			this.btnGetDate.Name = "btnGetDate";
			this.btnGetDate.Size = new System.Drawing.Size(75, 23);
			this.btnGetDate.TabIndex = 6;
			this.btnGetDate.Text = "訂房";
			this.btnGetDate.UseVisualStyleBackColor = true;
			this.btnGetDate.Click += new System.EventHandler(this.btnGetDate_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "訂房資訊";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.roomName,
            this.CheckInDate,
            this.CheckOutDate});
			this.dataGridView1.Location = new System.Drawing.Point(24, 212);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(436, 236);
			this.dataGridView1.TabIndex = 8;
			// 
			// OrderId
			// 
			this.OrderId.HeaderText = "訂單編號";
			this.OrderId.Name = "OrderId";
			this.OrderId.ReadOnly = true;
			// 
			// roomName
			// 
			this.roomName.DataPropertyName = "RoomType";
			this.roomName.HeaderText = "房型";
			this.roomName.Name = "roomName";
			this.roomName.ReadOnly = true;
			// 
			// CheckInDate
			// 
			this.CheckInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CheckInDate.DataPropertyName = "CheckInDate";
			this.CheckInDate.HeaderText = "入住日期";
			this.CheckInDate.Name = "CheckInDate";
			this.CheckInDate.ReadOnly = true;
			// 
			// CheckOutDate
			// 
			this.CheckOutDate.DataPropertyName = "CheckOutDate";
			this.CheckOutDate.HeaderText = "退房日期";
			this.CheckOutDate.Name = "CheckOutDate";
			this.CheckOutDate.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(370, 140);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "確定訂房";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(385, 472);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "回首頁";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(542, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(177, 209);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(780, 26);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(177, 209);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 12;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(542, 252);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(177, 225);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(780, 252);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(177, 225);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 14;
			this.pictureBox4.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(487, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 15;
			this.label5.Text = "房型1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(741, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 12);
			this.label6.TabIndex = 16;
			this.label6.Text = "房型2";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(487, 252);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 12);
			this.label7.TabIndex = 17;
			this.label7.Text = "房型3";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(741, 252);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 12);
			this.label8.TabIndex = 18;
			this.label8.Text = "房型4";
			// 
			// FormAddOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(984, 516);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBoxRoom);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CheckOutPicker);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CheckInPicker);
			this.Controls.Add(this.btnGetDate);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1000, 1000);
			this.MinimumSize = new System.Drawing.Size(509, 555);
			this.Name = "FormAddOrder";
			this.Text = "開始訂房";
			this.Load += new System.EventHandler(this.FormAddOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker CheckInPicker;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker CheckOutPicker;
		private System.Windows.Forms.ComboBox comboBoxRoom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGetDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}