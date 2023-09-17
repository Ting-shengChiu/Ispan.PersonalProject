namespace _2023.hotel.WinForms
{
	partial class FormGetOrder
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
			this.btnClose = new System.Windows.Forms.Button();
			this.btnDeleteOrder = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textOrderId = new System.Windows.Forms.TextBox();
			this.textRoomId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textCheckOutDate = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textCheckInDate = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textOrderDate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(263, 268);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "關閉";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnDeleteOrder
			// 
			this.btnDeleteOrder.Location = new System.Drawing.Point(126, 268);
			this.btnDeleteOrder.Name = "btnDeleteOrder";
			this.btnDeleteOrder.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteOrder.TabIndex = 2;
			this.btnDeleteOrder.Text = "刪除訂單";
			this.btnDeleteOrder.UseVisualStyleBackColor = true;
			this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "訂單編號";
			// 
			// textOrderId
			// 
			this.textOrderId.Location = new System.Drawing.Point(158, 23);
			this.textOrderId.Name = "textOrderId";
			this.textOrderId.ReadOnly = true;
			this.textOrderId.Size = new System.Drawing.Size(100, 22);
			this.textOrderId.TabIndex = 4;
			// 
			// textRoomId
			// 
			this.textRoomId.Location = new System.Drawing.Point(158, 66);
			this.textRoomId.Name = "textRoomId";
			this.textRoomId.ReadOnly = true;
			this.textRoomId.Size = new System.Drawing.Size(100, 22);
			this.textRoomId.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "房間";
			// 
			// textCheckOutDate
			// 
			this.textCheckOutDate.Location = new System.Drawing.Point(158, 155);
			this.textCheckOutDate.Name = "textCheckOutDate";
			this.textCheckOutDate.ReadOnly = true;
			this.textCheckOutDate.Size = new System.Drawing.Size(180, 22);
			this.textCheckOutDate.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "退房日期";
			// 
			// textCheckInDate
			// 
			this.textCheckInDate.Location = new System.Drawing.Point(158, 112);
			this.textCheckInDate.Name = "textCheckInDate";
			this.textCheckInDate.ReadOnly = true;
			this.textCheckInDate.Size = new System.Drawing.Size(180, 22);
			this.textCheckInDate.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(76, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "入住日期";
			// 
			// textOrderDate
			// 
			this.textOrderDate.Location = new System.Drawing.Point(158, 202);
			this.textOrderDate.Name = "textOrderDate";
			this.textOrderDate.ReadOnly = true;
			this.textOrderDate.Size = new System.Drawing.Size(180, 22);
			this.textOrderDate.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(76, 213);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "訂房日期";
			// 
			// FormGetOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 383);
			this.Controls.Add(this.textOrderDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textCheckOutDate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textCheckInDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textRoomId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textOrderId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDeleteOrder);
			this.Controls.Add(this.btnClose);
			this.Name = "FormGetOrder";
			this.Text = "FormGetOrder";
			this.Load += new System.EventHandler(this.FormGetOrder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnDeleteOrder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textOrderId;
		private System.Windows.Forms.TextBox textRoomId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textCheckOutDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textCheckInDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textOrderDate;
		private System.Windows.Forms.Label label5;
	}
}