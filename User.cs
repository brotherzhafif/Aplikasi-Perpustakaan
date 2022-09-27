using System;
using System.Data;
using System.Data.SqlClient;
using System.Security;
using System.Windows.Forms;
namespace Aplikasi_Perpustakaan
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        public void nav(object sender, EventArgs e)
        {
            Page page = new Page();
            this.Hide();
            page.Move(sender, e);
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
        {
            lbl_nama.Text = Login.nama;

            btn_user.Visible = Login.permission;
            panel4.Visible = Login.permission;
            panel_admin.Visible = !Login.permission;

            FILL();
        }

        void FILL()
        {
            Viewer.DataSource = null;
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM [dbo].[User]";
            SqlCommand cmd = new SqlCommand(sql, Navigasi.cnn);

            Page.READ(cmd, dt);
            Viewer.DataSource = dt;
        }

        void filtering()
        {
            Viewer.DataSource = null;

            string sql = "";
            string search = txt_search.Text;
            
            if (search != "" || !string.IsNullOrEmpty(search))
            {
                sql = "SELECT * FROM [dbo].[User] WHERE Nama=@search OR [Level]=@search";
            }
            else
            {
                sql = "SELECT * FROM [dbo].[User]";
            }
                
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Navigasi.cnn);
            cmd.Parameters.AddWithValue("@search", search);
            Page.READ(cmd, dt);
            Viewer.DataSource = dt;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            filtering();
        }

        private void Viewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = Viewer.Rows[e.RowIndex];
            string sql = "";
            string nama = rows.Cells[4].Value.ToString();
            string pass = rows.Cells[5].Value.ToString();
            var level = rows.Cells[6].Value;
            bool success = false;
            string hashedpass = Page.HashSha256(pass);

            if (nama != "" || !string.IsNullOrEmpty(nama) || pass != "" || !string.IsNullOrEmpty(pass) || nama != "" || !string.IsNullOrEmpty(nama))
            {

                DataTable dt = new DataTable();
                sql = "SELECT * FROM [dbo].[User] Where Nama=@Nama";
                SqlCommand cmd = new SqlCommand(sql, Navigasi.cnn);

                cmd.Parameters.AddWithValue("@Nama", nama);
                Page.READ(cmd, dt);

                if ((dt.Rows.Count > 0) != true)
                {
                    if (rows.Cells[e.ColumnIndex].Value.ToString() == "Insert")
                    {
                        sql = "INSERT INTO [dbo].[User] (Nama, Password, [Level]) Values (@nama,@Hashedpass,@level)";
                        success = true;
                    }
                    else if (rows.Cells[e.ColumnIndex].Value.ToString() == "Update")
                    {
                        if (rows.Cells[3].Value.ToString() == "Masukan Nama" || rows.Cells[4].Value.ToString() == "Masukan Password")
                        {
                            sql = "UPDATE [dbo].[User] SET Nama=@Nama, Password=@Hashedpass,[Level]=@level WHERE ID=@ID";
                            success = true;
                        }
                    }
                }
                else
                {
                    if(rows.Cells[e.ColumnIndex].Value.ToString() == "Delete")
                    {
                        sql = "DELETE FROM [dbo].[user] WHERE ID=@ID";
                        success = true;
                    }
                    else
                    {
                        MessageBox.Show("Nama User Telah Digunakan");
                    }
                }
            }
            else
            {
                MessageBox.Show("Silahkan Isi Nama Dan Password User");
            }  
            
            if (success != false)
            {
                MessageBox.Show(rows.Cells[e.ColumnIndex].Value.ToString() + " Berhasil Dijalankan");
                SqlCommand cmd = new SqlCommand(sql, Navigasi.cnn);
                cmd.Parameters.AddWithValue("@Nama", nama);
                cmd.Parameters.AddWithValue("@level", level);
                cmd.Parameters.AddWithValue("@ID", rows.Cells[3].Value);
                cmd.Parameters.AddWithValue("@Hashedpass", hashedpass);
                Page.EXECUTE(cmd);
                FILL();
            }
        }
    }
}
