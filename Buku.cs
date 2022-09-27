using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class Buku : Form
    {
        public Buku()
        {
            InitializeComponent();
        }

        public void nav(object sender, EventArgs e)
        {
            Page page = new Page();
            this.Hide();

            page.Move(sender, e);
        }

        private void Buku_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Buku_Load(object sender, EventArgs e)
        {
            lbl_nama.Text = Login.nama;

            btn_user.Visible = Login.permission;
            panel4.Visible = Login.permission;
            panel_admin.Visible = !Login.permission;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string jenis = txt_jenis.Text.ToString();
            string nama = txt_nama.Text.ToString();
            

            if (!string.IsNullOrEmpty(jenis) || !string.IsNullOrEmpty(nama))
            {
                string sql = "INSERT INTO [dbo].[buku] (Nama, Jenis) VALUES ('"+ nama +"', '"+ jenis +"')";
                try
                {   
                    Page.EXECUTE(sql);
                    MessageBox.Show("Buku Berhasil Tersimpan");
                }
                catch(Exception)
                {
                    MessageBox.Show("Simpan Data Gagal");
                }
            }
            else
            {
                MessageBox.Show("Tolong Isi Semua Kolom");
            }
        }
    }
}
