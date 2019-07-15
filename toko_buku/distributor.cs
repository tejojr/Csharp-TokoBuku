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
    public partial class distributor : Form
    {
        Config con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        string id;
        public distributor()
        {

            InitializeComponent();
        }
        private void Tampil(string cari)
        {
            if (cari.Length == 0)
            {
                cmd = new SqlCommand("select * from [dbo].[distributor]", con.getCon());
            }
            else
            {
                cmd = new SqlCommand("select * from [dbo].[distributor] where nama_distri like '%" + cari + "%' or alamat like '%" + cari + "%' or telepon like '%" + cari + "%'", con.getCon());

            }

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            tabel.Columns["id_distri"].ColumnName = "ID";
            tabel.Columns["nama_distri"].ColumnName = "Nama Distributor";
            tabel.Columns["alamat"].ColumnName = "Alamat Ditributor";
            tabel.Columns["telepon"].ColumnName = "No.Telepon";
        }

        private void distributor_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
            Tampil("");
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            Tampil(cari.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t_nama.Text.Length==0 || t_alamat.Text.Length==0 || t_telepon.Text.Length == 0)
            {
                MessageBox.Show("Silahkan isi semua inputan dengan data yang benar!", "Informasi");
            } else
            {
                cmd = new SqlCommand("insert into [dbo].[distributor] (nama_distri, alamat, telepon) values ('" + t_nama.Text + "','" + t_alamat.Text + "','" + t_telepon.Text + "')", con.getCon());
                cmd.ExecuteNonQuery();
                Tampil("");
                bersih();
                con.sim_kon();
            }
            
        }

        private void b_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin mau menghapus", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                cmd = new SqlCommand("delete from [dbo].[distributor] where  id_distri= '" + id + "'", con.getCon());
                cmd.ExecuteNonQuery();
                Tampil("");
                bersih();
                con.hps_kon();
                          }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_alamat.Text = dr.Cells[2].Value.ToString();
            t_telepon.Text = dr.Cells[3].Value.ToString();
            id = dr.Cells[0].Value.ToString();
        }
        private void bersih()
        {
            t_nama.Clear();
            t_alamat.Clear();
            t_telepon.Clear();
          
        }

        private void b_tambah_Click(object sender, EventArgs e)
        {
            bersih();
            t_nama.Focus();
        }

        private void b_ubah_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Yakin mau mengubah data", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                cmd = new SqlCommand("update [dbo].[distributor] set nama_distri = '" + t_nama.Text + "',alamat='" + t_alamat.Text + "',telepon='" + t_telepon.Text + "' where id_distri='" + id + "'", con.getCon());
                cmd.ExecuteNonQuery();
                Tampil("");
                bersih();
                con.ubh_kon();
            }
         
        }

        private void b_bersih_Click(object sender, EventArgs e)
        {
            bersih();
            con.ber_kon();
        }

        private void t_telepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
