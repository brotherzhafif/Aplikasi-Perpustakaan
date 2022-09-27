using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class Peminjaman_graph : Form
    {
        public Peminjaman_graph()
        {
            InitializeComponent();
        }

        public void nav(object sender, EventArgs e)
        {
            Page page = new Page();
            this.Hide();

            page.Move(sender, e);
        }

        private void Peminjaman_graph_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Peminjaman_graph_Load(object sender, EventArgs e)
        {
            lbl_nama.Text = Login.nama;

            btn_user.Visible = Login.permission;
            panel4.Visible = Login.permission;
            panel_admin.Visible = !Login.permission;
            Fill();
        }      

        void Fill()
        {

            string sql = "SELECT COUNT(*) AS Peminjaman, Tanggal from [dbo].[Peminjaman] Group BY Tanggal Having(COUNT(*)>=1)";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, Navigasi.cnn);

            Page.READ(cmd, dt);
            Viewer.DataSource = dt;

            Viewer.Series["Peminjaman"].XValueMember = "Tanggal";
            Viewer.Series["Peminjaman"].YValueMembers = "Peminjaman";

            Viewer.Titles.Add("Peminjaman Bulanan");
        }

        /*void fitering()
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
                    sql = "SELECT COUNT(*) AS Peminjaman, Tanggal from [dbo].[Peminjaman] Group BY Tanggal Having(COUNT(*)>=1) WHERE [Tanggal] = '" + tanggal + "' AND [Nama]='" + txt_search.Text + "' OR [Kelas]='" + txt_search.Text + "' OR [Buku]='" + txt_search.Text + "' OR [Pengawas]='" + txt_search.Text + "' OR [Status]='" + txt_search.Text + "'";
                }
                else
                {
                    sql = "SELECT COUNT(*) AS Peminjaman, Tanggal from [dbo].[Peminjaman] Group BY Tanggal Having(COUNT(*)>=1) WHERE [Nama]='" + txt_search.Text + "' OR [Kelas]='" + txt_search.Text + "' OR [Buku]='" + txt_search.Text + "' OR [Pengawas]='" + txt_search.Text + "' OR [Status]='" + txt_search.Text + "'";
                }
            }
            else
            {
                if (tanggal != "")
                {
                    sql = "SELECT COUNT(*) AS Peminjaman, Tanggal from [dbo].[Peminjaman] Group BY Tanggal Having(COUNT(*)>=1) WHERE [Tanggal] = '" + tanggal + "'";
                }
                else
                {
                    sql = "SELECT COUNT(*) AS Peminjaman, Tanggal from [dbo].[Peminjaman] Group BY Tanggal Having(COUNT(*)>=1)";
                }
            }

            DataTable dt = new DataTable();

            Page.READ(sql, dt);

            Viewer.DataSource = dt;

            Viewer.Series["Peminjaman"].XValueMember = "Tanggal";
            Viewer.Series["Peminjaman"].YValueMembers = "Peminjaman";
        }*/

        private void btn_filter_Click(object sender, EventArgs e)
        {
            
        }
    }
}
