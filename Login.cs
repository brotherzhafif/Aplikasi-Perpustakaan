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
using EasyEncryption;

namespace Aplikasi_Perpustakaan
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        public static string role, nama;
        public static bool permission;

        private void btn_login_Click(object sender, EventArgs e)
        {
            Page page = new Page();

            if (!string.IsNullOrEmpty(txt_nama.Text) || !string.IsNullOrEmpty(txt_pass.Text))
            {
                nama = txt_nama.Text.ToString();
                string pass = SHA.ComputeSHA256Hash(txt_pass.Text);

                string sql = "SELECT * FROM [dbo].[User] WHERE Nama='" + nama +"'";

                DataTable dt = new DataTable();

                Page.READ(sql, dt);

                if (dt.Rows.Count > 0)
                {
                    role = dt.Rows[0][3].ToString();
                    string dbpass = dt.Rows[0][2].ToString();

                    if(string.Equals(dbpass,pass))
                    {
                        if (Login.role != "2")
                        {
                            permission = false;
                        }
                        else
                        {
                            permission = true;
                        }
                        page.Move(sender, e);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password Salah");
                    }
                }
                else
                {
                    MessageBox.Show("Pengguna Tidak Ditemukan");
                }
            }
            else
            {
                MessageBox.Show("Tolong Isi Semua Kolom");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
