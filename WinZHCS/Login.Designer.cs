namespace WinZHCS
{
    partial class sxct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labServer = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
            this.labPwd = new System.Windows.Forms.Label();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labServer
            // 
            this.labServer.AutoSize = true;
            this.labServer.Location = new System.Drawing.Point(56, 43);
            this.labServer.Name = "labServer";
            this.labServer.Size = new System.Drawing.Size(54, 20);
            this.labServer.TabIndex = 0;
            this.labServer.Text = "服务器";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(56, 86);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(39, 20);
            this.labUser.TabIndex = 1;
            this.labUser.Text = "用户";
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.Location = new System.Drawing.Point(56, 128);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(39, 20);
            this.labPwd.TabIndex = 2;
            this.labPwd.Text = "密码";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(134, 42);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(156, 27);
            this.textBoxServer.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(134, 86);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(156, 27);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.Location = new System.Drawing.Point(134, 128);
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.Size = new System.Drawing.Size(156, 27);
            this.textBoxPwd.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(76, 198);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(208, 198);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 29);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // sxct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 329);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.labPwd);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.labServer);
            this.Name = "sxct";
            this.Text = "sxct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labServer;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}
