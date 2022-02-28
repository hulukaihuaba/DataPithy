namespace WinZHCS
{
    partial class Register
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
            this.labAccount = new System.Windows.Forms.Label();
            this.labPassword = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labConfirmPwd = new System.Windows.Forms.Label();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPwd = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAccount
            // 
            this.labAccount.AutoSize = true;
            this.labAccount.Location = new System.Drawing.Point(57, 51);
            this.labAccount.Name = "labAccount";
            this.labAccount.Size = new System.Drawing.Size(39, 20);
            this.labAccount.TabIndex = 0;
            this.labAccount.Text = "账号";
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(57, 103);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(39, 20);
            this.labPassword.TabIndex = 1;
            this.labPassword.Text = "密码";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(57, 206);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(39, 20);
            this.labEmail.TabIndex = 2;
            this.labEmail.Text = "邮箱";
            // 
            // labConfirmPwd
            // 
            this.labConfirmPwd.AutoSize = true;
            this.labConfirmPwd.Location = new System.Drawing.Point(57, 152);
            this.labConfirmPwd.Name = "labConfirmPwd";
            this.labConfirmPwd.Size = new System.Drawing.Size(69, 20);
            this.labConfirmPwd.TabIndex = 3;
            this.labConfirmPwd.Text = "确认密码";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Location = new System.Drawing.Point(152, 51);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(125, 27);
            this.textBoxAccount.TabIndex = 4;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(152, 103);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(125, 27);
            this.textBoxPwd.TabIndex = 5;
            // 
            // textBoxConfirmPwd
            // 
            this.textBoxConfirmPwd.Location = new System.Drawing.Point(153, 152);
            this.textBoxConfirmPwd.Name = "textBoxConfirmPwd";
            this.textBoxConfirmPwd.Size = new System.Drawing.Size(125, 27);
            this.textBoxConfirmPwd.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(152, 206);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(125, 27);
            this.textBoxEmail.TabIndex = 7;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(153, 282);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(94, 29);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "确认";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxConfirmPwd);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.labConfirmPwd);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.labAccount);
            this.Name = "Register";
            this.Text = "注册页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAccount;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labConfirmPwd;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.TextBox textBoxConfirmPwd;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonOk;
    }
}