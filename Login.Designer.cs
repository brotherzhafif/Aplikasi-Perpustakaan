namespace Aplikasi_Perpustakaan
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(28, 41);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(85, 39);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Login";
            // 
            // txt_nama
            // 
            this.txt_nama.BackColor = System.Drawing.Color.Maroon;
            this.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nama.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.ForeColor = System.Drawing.Color.White;
            this.txt_nama.Location = new System.Drawing.Point(14, 7);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(234, 29);
            this.txt_nama.TabIndex = 2;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nama.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.Color.White;
            this.lbl_nama.Location = new System.Drawing.Point(16, 129);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(58, 25);
            this.lbl_nama.TabIndex = 4;
            this.lbl_nama.Text = "Nama";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pwd.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.ForeColor = System.Drawing.Color.White;
            this.lbl_pwd.Location = new System.Drawing.Point(16, 226);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(84, 25);
            this.lbl_pwd.TabIndex = 5;
            this.lbl_pwd.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.txt_nama);
            this.panel1.Location = new System.Drawing.Point(21, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 45);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.txt_pass);
            this.panel2.Location = new System.Drawing.Point(21, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 45);
            this.panel2.TabIndex = 7;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Maroon;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.White;
            this.txt_pass.Location = new System.Drawing.Point(14, 7);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(234, 29);
            this.txt_pass.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Maroon;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(168, 348);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(92, 35);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Masuk";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(292, 411);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_nama);
            this.Controls.Add(this.lbl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 450);
            this.MinimumSize = new System.Drawing.Size(308, 450);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masuk Perpustakaan SMKN 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_login;
    }
}