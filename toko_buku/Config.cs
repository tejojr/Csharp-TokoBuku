using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace toko_buku
{
    class Config
    {
        static string strkoneksi;
        SqlConnection con;
       // SqlDataReader reader;
       
         public void hps_kon()
        {
            MessageBox.Show("Data berhasil di hapus","Proses Hapus");
        }
        public void ubh_kon ()
        {
            MessageBox.Show("Data berhasil di Edit", "Proses Edit");
        }
        public void sim_kon()
        {
            MessageBox.Show("Data berhasil di Simpan", "Proses Simpan");
        }
        public void ber_kon()
        {
            MessageBox.Show("Semua inputan telah dibersihkan", "Proses Clear");
        }
        public void car_kon()
        {
            MessageBox.Show("Data yang anda cari tidak ditemukan", "Proses Pencarian");
        }
        public void setConnection(string server, string user, string pass, string db)
        {
            strkoneksi = "server=" + server + ";database=" + db + ";uid=" + user + ";password=" + pass;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = strkoneksi;
                con.Open();
                //MessageBox.Show("Terhubung");

            }
            catch (SqlException e)
            {
                MessageBox.Show("Gagal"+e.Message);
            }

        }
        public SqlConnection getCon()
        {
            return con;
        }
       
    }

}
