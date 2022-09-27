using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Aplikasi_Perpustakaan
{
    public partial class Peminjaman : Form
    {
        public string buku, siswa, kelas, pustakawan;
        

        public Peminjaman()
        {
            InitializeComponent();
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            lbl_nama.Text = Login.nama;

            btn_user.Visible = Login.permission;
            panel4.Visible = Login.permission;
            panel_admin.Visible = !Login.permission;

            load_pustakawan();
            load_buku();
        }
        private void load_pustakawan()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Nama FROM [dbo].[User]";
            SqlCommand cmd = new SqlCommand(sql, Navigasi.cnn);
            Page.READ(cmd, dt);

            txt_pustakawan.DataSource = dt;
            txt_pustakawan.ValueMember = "Nama";
            txt_pustakawan.DisplayMember = "Nama";
        }

        private void load_buku()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT Nama FROM [dbo].[Buku]";
            SqlCommand cmd = new SqlCommand(sql, Navigasi.cnn);
            Page.READ(cmd, dt);

            txt_buku.DataSource = dt;
            txt_buku.ValueMember = "Nama";
            txt_buku.DisplayMember = "Nama";
        }

        public void nav(object sender, EventArgs e)
        {
            Page page = new Page();
            this.Hide();

            page.Move(sender, e);
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            
            buku = txt_buku.Text;
            siswa = txt_siswa.Text;
            kelas = txt_kelas.Text;
            pustakawan = txt_pustakawan.Text;

            if (!string.IsNullOrEmpty(buku) && !string.IsNullOrEmpty(kelas) && !string.IsNullOrEmpty(pustakawan) && !string.IsNullOrEmpty(siswa))
            {
                string sql = "INSERT INTO [dbo].[Peminjaman] (Nama, Kelas, Buku, Pengawas) VALUES ('" + siswa + "','" + kelas + "','" + buku + "','" + pustakawan + "')";
                SqlCommand cmd = new SqlCommand(sql, Navigasi.cnn);

                cmd.Parameters.AddWithValue("@siswa", siswa);
                cmd.Parameters.AddWithValue("@siswa", kelas);
                cmd.Parameters.AddWithValue("@siswa", buku);
                cmd.Parameters.AddWithValue("@siswa", pustakawan);

                try
                {
                    Page.EXECUTE(cmd);
                    MessageBox.Show("Peminjaman Buku Berhasil Ditambahkan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }    
            }
            else
            {
                MessageBox.Show("Tolong Isi Semua Kolom");
            }

        }

        private void Peminjaman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
