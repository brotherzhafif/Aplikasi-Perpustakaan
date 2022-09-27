using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class Peminjaman_lihat : Form
    {
        public Peminjaman_lihat()
        {
            InitializeComponent();
            Page move = new Page();
        }

        public void nav(object sender, EventArgs e)
        {
            Page page = new Page();
            this.Hide();

            page.Move(sender, e);
        }

        private void Peminjaman_lihat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        void Fill()
        {
            string sql = "SELECT * FROM [dbo].[Peminjaman]";
            DataTable dt = new DataTable();

            Page.READ(sql, dt);
            Viewer.DataSource = dt;
        }

        private void Peminjaman_lihat_Load(object sender, EventArgs e)
        {
            Fill();
            lbl_nama.Text = Login.nama;

            btn_user.Visible = Login.permission;
            panel4.Visible = Login.permission;
            panel_admin.Visible = !Login.permission;
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            fitering();
        }

        public void fitering()
        {
            Viewer.DataSource = null;

            string tanggal = "";

            if (btn_tanggal.Checked != true)
            {
                tanggal = "";
            }
            else
            {
                tanggal = datepick_search.Value.ToString("yyyy/MM/dd");
            }

            string sql;
            if (!string.IsNullOrEmpty(txt_search.Text.ToString()) || txt_search.Text != "")
            {
                if (tanggal != "")
                {
                    sql = "SELECT * FROM [dbo].[Peminjaman] WHERE [Tanggal] = '" + tanggal + "' AND [Nama]='" + txt_search.Text + "' OR [Kelas]='" + txt_search.Text + "' OR [Buku]='" + txt_search.Text + "' OR [Pengawas]='" + txt_search.Text + "' OR [Status]='" + txt_search.Text + "'";
                }
                else
                {
                    sql = "SELECT * FROM [dbo].[Peminjaman] WHERE [Nama]='" + txt_search.Text + "' OR [Kelas]='" + txt_search.Text + "' OR [Buku]='" + txt_search.Text + "' OR [Pengawas]='" + txt_search.Text + "' OR [Status]='" + txt_search.Text + "'";
                }
            }
            else
            {
                if (tanggal != "")
                {
                    sql = "SELECT * FROM [dbo].[Peminjaman] WHERE [Tanggal] = '" + tanggal + "'";
                }
                else
                {
                    sql = "SELECT * FROM [dbo].[Peminjaman]";
                }
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
                if (MessageBox.Show("Yakin ingin melakuan " + rows, rows, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.Cancel)
                {
                    string sql = "DELETE FROM [dbo].[Peminjaman] WHERE ID='" + Viewer.Rows[e.RowIndex].Cells[2].Value.ToString() + "'";
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
                    string sql = "UPDATE [dbo].[Peminjaman] SET Nama='" + Viewer.Rows[e.RowIndex].Cells[3].Value.ToString() + "', Kelas='" + Viewer.Rows[e.RowIndex].Cells[4].Value.ToString() + "', Buku='" + Viewer.Rows[e.RowIndex].Cells[5].Value.ToString() + "', Pengawas='" + Viewer.Rows[e.RowIndex].Cells[6].Value.ToString() + "', Denda='" + Viewer.Rows[e.RowIndex].Cells[8].Value.ToString() + "', Status='" + Viewer.Rows[e.RowIndex].Cells[9].Value.ToString() + "'WHERE ID='" + Viewer.Rows[e.RowIndex].Cells[2].Value.ToString() + "'";
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
    }
}
