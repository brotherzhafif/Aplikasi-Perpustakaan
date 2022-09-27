namespace Aplikasi_Perpustakaan
{
    partial class Peminjaman_lihat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peminjaman_lihat));
            this.datepick_search = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.sub_btn_graph = new System.Windows.Forms.Button();
            this.sub_btn_buat = new System.Windows.Forms.Button();
            this.sub_btn_lihat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_admin = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_buku = new System.Windows.Forms.Button();
            this.btn_peminjaman = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_tanggal = new System.Windows.Forms.CheckBox();
            this.Viewer = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // datepick_search
            // 
            this.datepick_search.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.datepick_search.Font = new System.Drawing.Font("Palatino Linotype", 14.25F);
            this.datepick_search.Location = new System.Drawing.Point(3, 3);
            this.datepick_search.Name = "datepick_search";
            this.datepick_search.Size = new System.Drawing.Size(200, 33);
            this.datepick_search.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel5.Controls.Add(this.datepick_search);
            this.panel5.Location = new System.Drawing.Point(561, 501);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 39);
            this.panel5.TabIndex = 41;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel9.Controls.Add(this.sub_btn_graph);
            this.panel9.Controls.Add(this.sub_btn_buat);
            this.panel9.Controls.Add(this.sub_btn_lihat);
            this.panel9.Location = new System.Drawing.Point(67, 67);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1236, 30);
            this.panel9.TabIndex = 37;
            // 
            // sub_btn_graph
            // 
            this.sub_btn_graph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sub_btn_graph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sub_btn_graph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub_btn_graph.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_btn_graph.ForeColor = System.Drawing.Color.White;
            this.sub_btn_graph.Location = new System.Drawing.Point(286, 2);
            this.sub_btn_graph.Name = "sub_btn_graph";
            this.sub_btn_graph.Size = new System.Drawing.Size(136, 28);
            this.sub_btn_graph.TabIndex = 15;
            this.sub_btn_graph.Text = "Grafik Peminjaman";
            this.sub_btn_graph.UseVisualStyleBackColor = false;
            this.sub_btn_graph.Click += new System.EventHandler(this.nav);
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
            this.sub_btn_buat.Text = "Buat Peminjaman";
            this.sub_btn_buat.UseVisualStyleBackColor = false;
            this.sub_btn_buat.Click += new System.EventHandler(this.nav);
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
            this.sub_btn_lihat.Text = "Lihat Peminjaman";
            this.sub_btn_lihat.UseVisualStyleBackColor = false;
            this.sub_btn_lihat.Click += new System.EventHandler(this.nav);
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
            this.panel1.TabIndex = 33;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.panel_admin);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_user);
            this.panel2.Controls.Add(this.btn_buku);
            this.panel2.Controls.Add(this.btn_peminjaman);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 562);
            this.panel2.TabIndex = 35;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel3.Location = new System.Drawing.Point(4, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 3);
            this.panel3.TabIndex = 42;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "Search";
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_simpan.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.ForeColor = System.Drawing.Color.White;
            this.btn_simpan.Location = new System.Drawing.Point(1057, 492);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(234, 48);
            this.btn_simpan.TabIndex = 36;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel10.Location = new System.Drawing.Point(73, 465);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1218, 3);
            this.panel10.TabIndex = 34;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.Color.Black;
            this.txt_search.Location = new System.Drawing.Point(12, 6);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(449, 26);
            this.txt_search.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel6.Controls.Add(this.txt_search);
            this.panel6.Location = new System.Drawing.Point(75, 501);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(464, 39);
            this.panel6.TabIndex = 40;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_filter.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.ForeColor = System.Drawing.Color.White;
            this.btn_filter.Location = new System.Drawing.Point(75, 563);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(234, 48);
            this.btn_filter.TabIndex = 43;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // btn_tanggal
            // 
            this.btn_tanggal.AutoSize = true;
            this.btn_tanggal.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic);
            this.btn_tanggal.Location = new System.Drawing.Point(389, 563);
            this.btn_tanggal.Name = "btn_tanggal";
            this.btn_tanggal.Size = new System.Drawing.Size(150, 31);
            this.btn_tanggal.TabIndex = 45;
            this.btn_tanggal.Text = "Filter Tanggal";
            this.btn_tanggal.UseVisualStyleBackColor = true;
            // 
            // Viewer
            // 
            this.Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Viewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Update});
            this.Viewer.Location = new System.Drawing.Point(76, 103);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(1215, 356);
            this.Viewer.TabIndex = 59;
            this.Viewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Viewer_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 50;
            // 
            // Peminjaman_lihat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 623);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.btn_tanggal);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Peminjaman_lihat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peminjaman_lihat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Peminjaman_lihat_FormClosing);
            this.Load += new System.EventHandler(this.Peminjaman_lihat_Load);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_peminjaman;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker datepick_search;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button sub_btn_buat;
        private System.Windows.Forms.Button sub_btn_lihat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_buku;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button sub_btn_graph;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Panel panel_admin;
        private System.Windows.Forms.CheckBox btn_tanggal;
        private System.Windows.Forms.DataGridView Viewer;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
    }
}