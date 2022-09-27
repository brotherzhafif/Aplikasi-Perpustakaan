using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    internal class Navigasi
    {

        public User User = new User();
        public Buku Buku = new Buku();
        public Login Login = new Login();
        public Buku_lihat Buku_lihat = new Buku_lihat();
        public Peminjaman Peminjaman = new Peminjaman();
        public Peminjaman_lihat Peminjaman_lihat = new Peminjaman_lihat();
        public Peminjaman_graph Peminjaman_graph = new Peminjaman_graph();
        public Peminjaman_cetak Peminjaman_cetak = new Peminjaman_cetak();

        public static SqlConnection cnn = new SqlConnection("Data Source=BROTHERZHAFIF\\SQLEXPRESS;Initial Catalog=Perpustakaan_SMEKONE;Integrated Security=True");

    }

}
