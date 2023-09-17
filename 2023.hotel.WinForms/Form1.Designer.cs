namespace _2023.hotel.WinForms
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnUpdateMember = new System.Windows.Forms.Button();
			this.btnAddOrder = new System.Windows.Forms.Button();
			this.btnSearchOrder = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textCustomerId = new System.Windows.Forms.TextBox();
			this.btnSearchAll = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdateMember
			// 
			this.btnUpdateMember.Location = new System.Drawing.Point(63, 86);
			this.btnUpdateMember.Name = "btnUpdateMember";
			this.btnUpdateMember.Size = new System.Drawing.Size(112, 49);
			this.btnUpdateMember.TabIndex = 0;
			this.btnUpdateMember.Text = "會員資料更新";
			this.btnUpdateMember.UseVisualStyleBackColor = true;
			this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
			// 
			// btnAddOrder
			// 
			this.btnAddOrder.Location = new System.Drawing.Point(63, 182);
			this.btnAddOrder.Name = "btnAddOrder";
			this.btnAddOrder.Size = new System.Drawing.Size(112, 49);
			this.btnAddOrder.TabIndex = 1;
			this.btnAddOrder.Text = "訂房";
			this.btnAddOrder.UseVisualStyleBackColor = true;
			this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
			// 
			// btnSearchOrder
			// 
			this.btnSearchOrder.Location = new System.Drawing.Point(32, 34);
			this.btnSearchOrder.Name = "btnSearchOrder";
			this.btnSearchOrder.Size = new System.Drawing.Size(112, 49);
			this.btnSearchOrder.TabIndex = 2;
			this.btnSearchOrder.Text = "訂房資料查詢";
			this.btnSearchOrder.UseVisualStyleBackColor = true;
			this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(666, 380);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(112, 49);
			this.btnLogout.TabIndex = 3;
			this.btnLogout.Text = "登出";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(167, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "輸入訂單編號:";
			// 
			// textCustomerId
			// 
			this.textCustomerId.Location = new System.Drawing.Point(169, 61);
			this.textCustomerId.Name = "textCustomerId";
			this.textCustomerId.Size = new System.Drawing.Size(100, 22);
			this.textCustomerId.TabIndex = 5;
			// 
			// btnSearchAll
			// 
			this.btnSearchAll.Location = new System.Drawing.Point(63, 273);
			this.btnSearchAll.Name = "btnSearchAll";
			this.btnSearchAll.Size = new System.Drawing.Size(112, 49);
			this.btnSearchAll.TabIndex = 6;
			this.btnSearchAll.Text = "查詢所有訂房資料";
			this.btnSearchAll.UseVisualStyleBackColor = true;
			this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearchOrder);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textCustomerId);
			this.groupBox1.Location = new System.Drawing.Point(466, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 110);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "訂房資料查詢";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(270, 182);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(365, 247);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(138, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(193, 29);
			this.label2.TabIndex = 9;
			this.label2.Text = "舞魚休閒農場";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSearchAll);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnAddOrder);
			this.Controls.Add(this.btnUpdateMember);
			this.Name = "Form1";
			this.Text = "首頁";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdateMember;
		private System.Windows.Forms.Button btnAddOrder;
		private System.Windows.Forms.Button btnSearchOrder;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textCustomerId;
		private System.Windows.Forms.Button btnSearchAll;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
	}
}

