using EasyEncryption;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class Page : Form
    {
        public Page()
        {
            InitializeComponent();
        }

        public void Move(object sender, EventArgs e)
        {
            this.Hide();
            Navigasi navigasi = new Navigasi();
            string nav = (sender as Button).Text.ToString();

            // PEMINJAMAN

            if (this.Text.ToString() != navigasi.Peminjaman.Text.ToString() && nav == "Buat Peminjaman" || nav == "Masuk" || nav == "1")
            {
                navigasi.Peminjaman.Show();
            }
            else if (this.Text.ToString() != navigasi.Peminjaman_lihat.Text.ToString() && nav == "Lihat Peminjaman")
            {
                navigasi.Peminjaman_lihat.Show();
            }
            else if (this.Text.ToString() != navigasi.Peminjaman_graph.Text.ToString() && nav == "Grafik Peminjaman")
            {
                navigasi.Peminjaman_graph.Show();
            }
            else if (this.Text.ToString() != navigasi.Peminjaman_cetak.Text.ToString() && nav == "Cetak")
            {
                navigasi.Peminjaman_cetak.Show();
            }

            // TEMPAT BUKU

            else if (this.Text.ToString() != navigasi.Buku.Text.ToString() && nav == "Tambah Buku" || nav == "2")
            {
                navigasi.Buku.Show();
            }
            else if (this.Text.ToString() != navigasi.Buku_lihat.Text.ToString() && nav == "Lihat Buku")
            {
                navigasi.Buku_lihat.Show();
            }

            // TEMPAT USER

            else if (this.Text.ToString() != navigasi.User.Text.ToString() && nav == "3")
            {
                navigasi.User.Show();
            }

            //EXIT

            else if (this.Text.ToString() != navigasi.User.Text.ToString() && nav == "4")
            {
                navigasi.Login.Show();
            }
        }

        private void Page_Load(object sender, EventArgs e)
        {

        }

        public static string HashSha256(string pass)
        {
            pass = SHA.ComputeSHA256Hash(pass);
            return pass;
        }

        public static bool ValidateSha256(string passdb, string passuser)
        {
            bool Validated = string.Equals(passdb, passuser);
            return Validated;
        }

        public static void EXECUTE(string sql)
        {
            Navigasi navigasi = new Navigasi();
            SqlCommand cmd = new SqlCommand(sql, navigasi.cnn);
            navigasi.cnn.Open();
            cmd.ExecuteReader();
            navigasi.cnn.Close();
        }

        public static DataTable READ(string sql, DataTable dt)
        {
            Navigasi navigasi = new Navigasi();
            SqlCommand cmd = new SqlCommand(sql, navigasi.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            return dt;
        }
    }
}
