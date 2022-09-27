using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Aplikasi_Perpustakaan
{
    public partial class Buku_lihat : Form
    {
        public Buku_lihat()
        {
            InitializeComponent();
        }

        public void nav(object sender, EventArgs e)
        {
            Page page = new Page();
            this.Hide();

            page.Move(sender, e);
        }

        private void Buku_lihat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Buku_lihat_Load(object sender, EventArgs e)
        {
            lbl_nama.Text = Login.nama;

            btn_user.Visible = Login.permission;
            panel4.Visible = Login.permission;
            panel_admin.Visible = !Login.permission;
            Fill();
        }

        void Fill()
        {
            Viewer.DataSource = null;
            string sql = "SELECT * FROM [dbo].[Buku]";
            DataTable dt = new DataTable();

            Page.READ(sql, dt);
            Viewer.DataSource = dt;
        }

        void filtering()
        {
            Viewer.DataSource = null;

            string sql = "";
            string search = txt_search.Text.ToString();

            if (search != "" || !string.IsNullOrEmpty(search))
            {
                sql = "SELECT * FROM [dbo].[Buku] WHERE Nama='" + search + "'OR Jenis='"+search+"'";
            }
            else
            {
                sql = "SELECT * FROM [dbo].[Buku]";
            }

            DataTable dt = new DataTable();
            Page.READ(sql, dt);
            Viewer.DataSource = dt;
        }

        private void Viewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = Viewer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            
            if (rows == "Delete")
            {
                if (MessageBox.Show("Yakin ingin melakuan " + rows,  rows, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                {
                    string sql = "DELETE FROM [dbo].[buku] WHERE ID='" + Viewer.Rows[e.RowIndex].Cells[2].Value.ToString() + "'";
                    Page.EXECUTE(sql);
                    Fill();
                    MessageBox.Show(rows + " Berhasil");
                }
                else
                {
                    MessageBox.Show(rows + " Dibatalkan");
                }
            }
            else if (rows == "Update")
            {
                if (MessageBox.Show("Yakin ingin melakuan " + rows, rows, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                {
                    string sql = "UPDATE [dbo].[buku] WHERE ID='" + Viewer.Rows[e.RowIndex].Cells[2].Value.ToString() + "' SET Nama='"+ Viewer.Rows[e.RowIndex].Cells[3].Value.ToString() +"', Jenis='" + Viewer.Rows[e.RowIndex].Cells[4].Value.ToString() + "'";
                    Page.EXECUTE(sql);
                    Fill();
                    MessageBox.Show(rows + " Berhasil");
                }
                else
                {
                    MessageBox.Show(rows + " Dibatalkan");
                }
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            filtering();
        }
    }
}
