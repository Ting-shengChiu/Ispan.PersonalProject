namespace _2023.hotel.WinForms
{
	partial class FormLogin
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
			this.btnAddMenber = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAccount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAddMenber
			// 
			this.btnAddMenber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnAddMenber.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnAddMenber.Location = new System.Drawing.Point(59, 117);
			this.btnAddMenber.Name = "btnAddMenber";
			this.btnAddMenber.Size = new System.Drawing.Size(75, 23);
			this.btnAddMenber.TabIndex = 0;
			this.btnAddMenber.Text = "加入會員";
			this.btnAddMenber.UseVisualStyleBackColor = false;
			this.btnAddMenber.Click += new System.EventHandler(this.btnAddMenber_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(200, 117);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 23);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "登入";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(79, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "帳號:";
			// 
			// txtAccount
			// 
			this.txtAccount.Location = new System.Drawing.Point(128, 24);
			this.txtAccount.Name = "txtAccount";
			this.txtAccount.Size = new System.Drawing.Size(100, 22);
			this.txtAccount.TabIndex = 1;
			this.txtAccount.Text = "fizz";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(79, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "密碼:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(128, 68);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(100, 22);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "123";
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(343, 190);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtAccount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnAddMenber);
			this.Name = "FormLogin";
			this.Text = "登入會員";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddMenber;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAccount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPassword;
	}
}