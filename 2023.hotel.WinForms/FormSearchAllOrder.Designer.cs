namespace _2023.hotel.WinForms
{
	partial class FormSearchAllOrder
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.checkInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.checkOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.roomId,
            this.checkInDate,
            this.checkOutDate,
            this.orderDatetime});
			this.dataGridView1.Location = new System.Drawing.Point(33, 35);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(667, 325);
			this.dataGridView1.TabIndex = 0;
			// 
			// OrderId
			// 
			this.OrderId.DataPropertyName = "OrderId";
			this.OrderId.HeaderText = "訂單編號";
			this.OrderId.Name = "OrderId";
			this.OrderId.Width = 107;
			// 
			// roomId
			// 
			this.roomId.DataPropertyName = "roomId";
			this.roomId.HeaderText = "房間號";
			this.roomId.Name = "roomId";
			// 
			// checkInDate
			// 
			this.checkInDate.DataPropertyName = "checkInDate";
			this.checkInDate.HeaderText = "入住時間";
			this.checkInDate.Name = "checkInDate";
			// 
			// checkOutDate
			// 
			this.checkOutDate.DataPropertyName = "checkOutDate";
			this.checkOutDate.HeaderText = "退房時間";
			this.checkOutDate.Name = "checkOutDate";
			// 
			// orderDatetime
			// 
			this.orderDatetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.orderDatetime.DataPropertyName = "orderDatetime";
			this.orderDatetime.HeaderText = "訂房日期";
			this.orderDatetime.Name = "orderDatetime";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(615, 380);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "上一頁";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// FormSearchAllOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(734, 433);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dataGridView1);
			this.MaximumSize = new System.Drawing.Size(750, 472);
			this.MinimumSize = new System.Drawing.Size(750, 472);
			this.Name = "FormSearchAllOrder";
			this.Text = "所有訂單";
			this.Load += new System.EventHandler(this.FormSearchAllOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomId;
		private System.Windows.Forms.DataGridViewTextBoxColumn checkInDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDatetime;
		private System.Windows.Forms.Button btnClose;
	}
}