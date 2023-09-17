namespace _2023.hotel.WinForms
{
	partial class FormUpdateMember
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
			this.btnUpdateMember = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCellphoneNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnUpdateMember
			// 
			this.btnUpdateMember.Location = new System.Drawing.Point(169, 211);
			this.btnUpdateMember.Name = "btnUpdateMember";
			this.btnUpdateMember.Size = new System.Drawing.Size(75, 23);
			this.btnUpdateMember.TabIndex = 0;
			this.btnUpdateMember.Text = "修改";
			this.btnUpdateMember.UseVisualStyleBackColor = true;
			this.btnUpdateMember.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "你的帳號:";
			// 
			// txtAccount
			// 
			this.txtAccount.Location = new System.Drawing.Point(144, 41);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.ReadOnly = true;
			this.txtAccount.Size = new System.Drawing.Size(100, 22);
			this.txtAccount.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(144, 82);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(100, 22);
			this.txtPassword.TabIndex = 4;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "更改密碼:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(144, 124);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 22);
			this.txtName.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(71, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "更改姓名:";
			// 
			// txtCellphoneNumber
			// 
			this.txtCellphoneNumber.Location = new System.Drawing.Point(144, 167);
			this.txtCellphoneNumber.Name = "txtCellphoneNumber";
			this.txtCellphoneNumber.Size = new System.Drawing.Size(100, 22);
			this.txtCellphoneNumber.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(71, 178);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "更改電話:";
			// 
			// FormUpdateMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(322, 283);
			this.Controls.Add(this.txtCellphoneNumber);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAccount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnUpdateMember);
			this.Name = "FormUpdateMember";
			this.Text = "修改會員資料";
			this.Load += new System.EventHandler(this.FormUpdateMember_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdateMember;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCellphoneNumber;
		private System.Windows.Forms.Label label4;
	}
}