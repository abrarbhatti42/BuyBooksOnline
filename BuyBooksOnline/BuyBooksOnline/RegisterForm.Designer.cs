namespace BuyBooksOnline
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegsiterEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRegisterAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Location = new System.Drawing.Point(369, 287);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(75, 23);
            this.buttonRegisterUser.TabIndex = 36;
            this.buttonRegisterUser.Text = "Register";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            this.buttonRegisterUser.Click += new System.EventHandler(this.buttonRegisterUser_Click);
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(318, 221);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '*';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(218, 20);
            this.textBoxRegisterPassword.TabIndex = 35;
            // 
            // textBoxRegisterUsername
            // 
            this.textBoxRegisterUsername.Location = new System.Drawing.Point(318, 83);
            this.textBoxRegisterUsername.Name = "textBoxRegisterUsername";
            this.textBoxRegisterUsername.Size = new System.Drawing.Size(218, 20);
            this.textBoxRegisterUsername.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(244, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(332, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fill in All the Fields To Register:";
            // 
            // textBoxRegsiterEmail
            // 
            this.textBoxRegsiterEmail.Location = new System.Drawing.Point(318, 130);
            this.textBoxRegsiterEmail.Name = "textBoxRegsiterEmail";
            this.textBoxRegsiterEmail.Size = new System.Drawing.Size(218, 20);
            this.textBoxRegsiterEmail.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(244, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Email :";
            // 
            // textBoxRegisterAddress
            // 
            this.textBoxRegisterAddress.Location = new System.Drawing.Point(318, 174);
            this.textBoxRegisterAddress.Name = "textBoxRegisterAddress";
            this.textBoxRegisterAddress.Size = new System.Drawing.Size(218, 20);
            this.textBoxRegisterAddress.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(244, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Address :";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(780, 431);
            this.Controls.Add(this.textBoxRegisterAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRegsiterEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRegisterUser);
            this.Controls.Add(this.textBoxRegisterPassword);
            this.Controls.Add(this.textBoxRegisterUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "RegisterForm";
            this.Text = "Registration Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRegsiterEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRegisterAddress;
        private System.Windows.Forms.Label label5;
    }
}
