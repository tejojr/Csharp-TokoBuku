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
namespace toko_buku
{
    public partial class Pasok : Form
    {
        Config con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        string judul, distributor, pasokid;
        int idbuku, iddist;
        public Pasok()
        {
            InitializeComponent();
        }
        private void Idbuku()
        {
            cmd = new SqlCommand("select * from [dbo].[buku]",con.getCon());
            reader =cmd.ExecuteReader();
            while (reader.Read())
            {
                judul = (string)reader["judul"];
                idbuku = (int)reader["id_buku"];
                c_buku.Items.Add(idbuku + " - " + judul); 

            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cek();
            string[] isi = c_buku.SelectedItem.ToString().Split('-');
            string[] a = c_dist.SelectedItem.ToString().Split('-');
            cmd = new SqlCommand("insert into [dbo].[pasok] (id_distri,id_buku,jumlah,tanggal) values ('"+a[0]+"','"+isi[0]+"','"+t_jum.Text+"','"+t_date.Text+"')", con.getCon());
            cmd.ExecuteNonQuery();
            bersih();
            Tampil("");
            con.sim_kon();
           
        }

        private void Iddist()
        {
            cmd = new SqlCommand("select * from [dbo].[distributor]", con.getCon());
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                distributor = (string)reader["nama_distri"];
                iddist = (int)reader["id_distri"];
                c_dist.Items.Add(iddist + " - " + distributor);
            }
            reader.Close();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            Tampil("cari");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pasok_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
            Idbuku();
            Iddist();
            Tampil("");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin mau menghapus", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from [dbo].[pasok] where id_pasok = '" + pasokid + "' ", con.getCon());
                cmd.ExecuteNonQuery();
               // MessageBox.Show(pasokid);
                Tampil("");
                bersih();
                con.hps_kon();
            }
        }

        private void Tampil(string cari)
        {
            if (cari.Length == 0)
            {
                cmd = new SqlCommand("select id_pasok,(select nama_distri from [dbo].[distributor] where id_distri=[dbo].[pasok].id_distri) nama_distri, (select judul from [dbo].[buku] where id_buku=[dbo].[pasok].id_buku)judul ,jumlah, tanggal from [dbo].[pasok]", con.getCon());
               // ("select id_pasok, tanggal, (select nama_distributor from distributor where id_distributor=pasok.id_distributor) nama_distributor, (select judul from buku where id_buku=pasok.id_buku) judul, jumlah FROM pasok");
            }
            else
            {
                cmd = new SqlCommand("select p.id_pasok, p.tanggal, d.nama_distri, b.judul, p.jumlah FROM [dbo].[pasok] p, [dbo].[distributor] d, [dbo].[buku] b where d.id_distri=p.id_distri and b.id_buku=p.id_buku and (p.id_pasok like '%" + cari + "%' or p.tanggal like '%" + cari + "%' or d.nama_distri like '%" + cari + "%' or b.judul like '%" + cari + "%' or p.jumlah like '%" + cari + "%')", con.getCon());
            }
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            tabel.Columns["id_pasok"].ColumnName = "Id Pasok";
            tabel.Columns["nama_distri"].ColumnName = "Nama Distributor";
            tabel.Columns["judul"].ColumnName = "Judul Buku";
            tabel.Columns["jumlah"].ColumnName = "Jumlah Buku";
            tabel.Columns["tanggal"].ColumnName = "Tanggal Pasok";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            pasokid = dr.Cells[0].Value.ToString();
            c_dist.Text = dr.Cells[1].Value.ToString();
            c_buku.Text = dr.Cells[2].Value.ToString();
            t_date.Text = dr.Cells[4].Value.ToString();
            t_jum.Text = dr.Cells[3].Value.ToString();

        }

        private void t_jum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bersih();
            con.ber_kon();
        }

        private void bersih()
        {
            t_jum.Clear();
         
        }
        private void cek()
        {
            if (t_jum.Text.Length==0)
            {
                MessageBox.Show("Silahkan isi semua inputan dengan data yang benar!", "Informasi");
            }
        }
    }
}
