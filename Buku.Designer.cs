namespace Aplikasi_Perpustakaan
{
    partial class Buku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buku));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_admin = new System.Windows.Forms.Panel();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_buku = new System.Windows.Forms.Button();
            this.btn_peminjaman = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.txt_jenis = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sub_btn_lihat = new System.Windows.Forms.Button();
            this.sub_btn_buat = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(147, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nama Buku";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel_admin);
            this.panel2.Controls.Add(this.btn_user);
            this.panel2.Controls.Add(this.btn_buku);
            this.panel2.Controls.Add(this.btn_peminjaman);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 562);
            this.panel2.TabIndex = 40;
            // 
            // panel_admin
            // 
            this.panel_admin.BackColor = System.Drawing.Color.White;
            this.panel_admin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel_admin.Location = new System.Drawing.Point(4, 288);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(60, 3);
            this.panel_admin.TabIndex = 70;
            this.panel_admin.Visible = false;
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_user.BackgroundImage = global::Aplikasi_Perpustakaan.Properties.Resources.User;
            this.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Monotype Corsiva", 1F, System.Drawing.FontStyle.Italic);
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.Location = new System.Drawing.Point(4, 297);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(60, 60);
            this.btn_user.TabIndex = 5;
            this.btn_user.Text = "3";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.nav);
            // 
            // btn_buku
            // 
            this.btn_buku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_buku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buku.BackgroundImage")));
            this.btn_buku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buku.Font = new System.Drawing.Font("Monotype Corsiva", 1F, System.Drawing.FontStyle.Italic);
            this.btn_buku.ForeColor = System.Drawing.Color.White;
            this.btn_buku.Location = new System.Drawing.Point(4, 185);
            this.btn_buku.Name = "btn_buku";
            this.btn_buku.Size = new System.Drawing.Size(60, 60);
            this.btn_buku.TabIndex = 4;
            this.btn_buku.Text = "2";
            this.btn_buku.UseVisualStyleBackColor = false;
            this.btn_buku.Click += new System.EventHandler(this.nav);
            // 
            // btn_peminjaman
            // 
            this.btn_peminjaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_peminjaman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_peminjaman.BackgroundImage")));
            this.btn_peminjaman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_peminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_peminjaman.Font = new System.Drawing.Font("Monotype Corsiva", 1F, System.Drawing.FontStyle.Italic);
            this.btn_peminjaman.ForeColor = System.Drawing.Color.White;
            this.btn_peminjaman.Location = new System.Drawing.Point(4, 72);
            this.btn_peminjaman.Name = "btn_peminjaman";
            this.btn_peminjaman.Size = new System.Drawing.Size(60, 60);
            this.btn_peminjaman.TabIndex = 3;
            this.btn_peminjaman.Text = "1";
            this.btn_peminjaman.UseVisualStyleBackColor = false;
            this.btn_peminjaman.Click += new System.EventHandler(this.nav);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel4.Location = new System.Drawing.Point(4, 398);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 3);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel3.Location = new System.Drawing.Point(4, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 3);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel5.Controls.Add(this.txt_nama);
            this.panel5.Location = new System.Drawing.Point(152, 223);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(464, 39);
            this.panel5.TabIndex = 43;
            // 
            // txt_nama
            // 
            this.txt_nama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nama.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.ForeColor = System.Drawing.Color.Black;
            this.txt_nama.Location = new System.Drawing.Point(12, 6);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(449, 26);
            this.txt_nama.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel10.Location = new System.Drawing.Point(118, 309);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1156, 3);
            this.panel10.TabIndex = 39;
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_simpan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(990, 350);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(234, 48);
            this.btn_simpan.TabIndex = 41;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_nama);
            this.panel1.Controls.Add(this.lbl_welcome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 67);
            this.panel1.TabIndex = 38;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.BackgroundImage = global::Aplikasi_Perpustakaan.Properties.Resources.Exit;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Monotype Corsiva", 1F, System.Drawing.FontStyle.Italic);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(1240, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(60, 60);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "4";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.nav);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 58);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.Color.White;
            this.lbl_nama.Location = new System.Drawing.Point(209, 18);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(106, 27);
            this.lbl_nama.TabIndex = 1;
            this.lbl_nama.Text = "Nama User";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_welcome.Location = new System.Drawing.Point(68, 18);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(146, 27);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Selamat Datang";
            // 
            // txt_jenis
            // 
            this.txt_jenis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txt_jenis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_jenis.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_jenis.ForeColor = System.Drawing.Color.Black;
            this.txt_jenis.Location = new System.Drawing.Point(15, 6);
            this.txt_jenis.Name = "txt_jenis";
            this.txt_jenis.Size = new System.Drawing.Size(449, 26);
            this.txt_jenis.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel7.Controls.Add(this.txt_jenis);
            this.panel7.Location = new System.Drawing.Point(760, 223);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(464, 39);
            this.panel7.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(759, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 44;
            this.label3.Text = "Jenis Buku";
            // 
            // sub_btn_lihat
            // 
            this.sub_btn_lihat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sub_btn_lihat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sub_btn_lihat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub_btn_lihat.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_btn_lihat.ForeColor = System.Drawing.Color.White;
            this.sub_btn_lihat.Location = new System.Drawing.Point(144, 2);
            this.sub_btn_lihat.Name = "sub_btn_lihat";
            this.sub_btn_lihat.Size = new System.Drawing.Size(136, 28);
            this.sub_btn_lihat.TabIndex = 14;
            this.sub_btn_lihat.Text = "Lihat Buku";
            this.sub_btn_lihat.UseVisualStyleBackColor = false;
            this.sub_btn_lihat.Click += new System.EventHandler(this.nav);
            // 
            // sub_btn_buat
            // 
            this.sub_btn_buat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sub_btn_buat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sub_btn_buat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub_btn_buat.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_btn_buat.ForeColor = System.Drawing.Color.White;
            this.sub_btn_buat.Location = new System.Drawing.Point(2, 2);
            this.sub_btn_buat.Name = "sub_btn_buat";
            this.sub_btn_buat.Size = new System.Drawing.Size(136, 28);
            this.sub_btn_buat.TabIndex = 6;
            this.sub_btn_buat.Text = "Tambah Buku";
            this.sub_btn_buat.UseVisualStyleBackColor = false;
            this.sub_btn_buat.Click += new System.EventHandler(this.nav);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.sub_btn_buat);
            this.panel9.Controls.Add(this.sub_btn_lihat);
            this.panel9.Location = new System.Drawing.Point(67, 67);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1236, 30);
            this.panel9.TabIndex = 46;
            // 
            // Buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1319, 662);
            this.MinimumSize = new System.Drawing.Size(1319, 662);
            this.Name = "Buku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buku";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Buku_FormClosing);
            this.Load += new System.EventHandler(this.Buku_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_buku;
        private System.Windows.Forms.Button btn_peminjaman;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.TextBox txt_jenis;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sub_btn_lihat;
        private System.Windows.Forms.Button sub_btn_buat;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_admin;
    }
}