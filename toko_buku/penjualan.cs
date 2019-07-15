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
using System.Globalization;

namespace toko_buku
{
    public partial class penjualan : Form
    {
   
        Config con;
        SqlCommand cmd;
        //SqlDataAdapter adapter;
        SqlDataReader reader;
        public static string kwitansi;
        int id_buku, rega, stok,stock,id;
        int subtotal;
        string j_buku, no, jeneng;
        public penjualan()
        {
            InitializeComponent();
            
             
        }
        DataTable table = new DataTable();
        private void setTable()
        {
            table.Columns.Add("No",typeof(string));
            table.Columns.Add("Kode Buku", typeof(int));
            table.Columns.Add("Judul", typeof(string));
            table.Columns.Add("Harga", typeof(int));
            table.Columns.Add("Jumlah", typeof(int));
            table.Columns.Add("Total", typeof(int));

            dataGridView1.DataSource = table;

        }
       
        private void Idbuku()
        {
            cmd = new SqlCommand("select * from [dbo].[buku] where stok > 0", con.getCon());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //stok = (int)reader["stok"];
                j_buku = (string)reader["judul"];
                id_buku = (int)reader["id_buku"];
               c_judul.Items.Add(id_buku+ " - " + j_buku);
      
            }
            reader.Close();
        }
        private void hargabuku()
        {
            string[] isi = c_judul.SelectedItem.ToString().Split('-');
            cmd = new SqlCommand("select harga_jual from [dbo].[buku] where id_buku = '"+isi[0]+"'", con.getCon());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                rega = (int)reader["harga_jual"];
                t_harga.Text = rega.ToString();

            }
            reader.Close();
            t_jum.Focus();
        }

        private void c_judul_SelectedIndexChanged(object sender, EventArgs e)
        {
            hargabuku();

        }

        private void b_tambah_Click(object sender, EventArgs e)
        {
           
            string[] buku = c_judul.SelectedItem.ToString().Split('-');
            cmd = new SqlCommand("select stok from [dbo].[buku] where id_buku = '" + buku[0] + "'", con.getCon());
            reader  =cmd.ExecuteReader();
            if (reader.Read())
            {
                stock = (int)reader["stok"];
            }
            reader.Close();
             int jum = Convert.ToInt32(t_jum.Text, CultureInfo.InvariantCulture);
            if (t_jum.Text.Length == 0)
            {
                MessageBox.Show("Data harus diisi dengan lengkap!");
            }
            else if (jum > stock)
            {
                MessageBox.Show("Stok buku " + buku[1] + " tersisa " + stock);
                t_jum.Clear();
            }
            else
            {
                
                int val1 = Convert.ToInt32(t_harga.Text, CultureInfo.InvariantCulture);
                int val2 = Convert.ToInt32(t_jum.Text, CultureInfo.InvariantCulture);
                subtotal = val1 * val2;
                subtotal.ToString(); 
                //t_subtotal.Text = subtotal.ToString();
               
                table.Rows.Add(t_beli.Text, buku[0], buku[1], t_harga.Text, t_jum.Text, subtotal);
                dataGridView1.DataSource = table;
                int sum = Convert.ToInt32(table.Compute("SUM(Total)", string.Empty));
                t_total.Text = sum.ToString();
                //--------
                DateTime time = DateTime.Now;              
                string format = "yyyy-MM-dd";
              //  MessageBox.Show(t_beli.Text);
               cmd = new SqlCommand("insert into [dbo].[penjualan] values ('"+t_beli.Text+"','"+ t_id.Text+"','"+id+"','" + buku[0] + "','" + t_jum.Text+ "','"+subtotal+"','"+ time.ToString(format) +"')", con.getCon());
               cmd.ExecuteNonQuery();
                //Idbuku(); 
                t_jum.Clear();
                t_harga.Clear();
        
                autobeli();
                
            }
            kwitansi = t_id.Text;

        }

        private void b_selesai_Click(object sender, EventArgs e)
        {
            
            if (t_bayar.Text.Length == 0)
            {
                MessageBox.Show("Masukkan biaya pemabayaran!", "Informasi");
            } else {
               
                int val1 = Convert.ToInt32(t_total.Text);
                int val2 = Convert.ToInt32(t_bayar.Text);
                int kem = val2 - val1;
                t_kembalian.Text = kem.ToString();
                MessageBox.Show("Transaksi selesai, uang kembalian adalah Rp. " + kem.ToString());
                laporan.cetakreport cr = new laporan.cetakreport();
                cr.Show();
                auto();
                c_judul.Refresh();
                table.Clear();
                t_total.Clear();
                t_bayar.Clear();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void b_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin mau menghapus", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from [dbo].[penjualan] where id_penjualan = '"+no+"'",con.getCon());
                cmd.ExecuteNonQuery();
                int row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
                autobeli();
                t_jum.Clear();
                t_harga.Clear();
                c_judul.Focus();
               
          

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            no = dr.Cells[0].Value.ToString();
                       
        }
        private void penjualan_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
            Idbuku();
            setTable();
            jeneng = Login.getNama();
            id = Login.getId();
            t_subtotal.Text = jeneng + id;
            auto();
            autobeli();
            c_judul.Focus();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void auto()
        {
            long hitung;
            string urut;
            cmd = new SqlCommand("select [no_kwi] from [dbo].[penjualan] where no_kwi in(select max(no_kwi) from [dbo].[penjualan]) order by no_kwi desc", con.getCon());
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["no_kwi"].ToString().Length - 12, 4))+1;
                string joinstr = "0000" + hitung;
                urut = "MAC-" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString("MM/yyyy");
            } else
            {
                urut = "MAC-0001/" + DateTime.Now.ToString("MM/yyyy");

            }
            reader.Close();
            t_id.Text = urut;
            t_id.Enabled = false;
            
        }
        private void autobeli()
        {
            long hitung;
            string urut;
            cmd = new SqlCommand("select [id_penjualan] from [dbo].[penjualan] where id_penjualan in(select max(id_penjualan) from [dbo].[penjualan]) order by id_penjualan desc", con.getCon());
          
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                hitung = Convert.ToInt64(reader[0].ToString().Substring(reader["id_penjualan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urut = "P001";

            }
            reader.Close();
            t_beli.Text = urut;
            t_beli.Enabled = false;

        }
        public static string getKwitansi()
        {
            return kwitansi;
        }
    }   
}
