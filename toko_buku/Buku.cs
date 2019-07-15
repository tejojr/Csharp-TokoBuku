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
    public partial class Buku : Form
    {
        Config con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Buku()
        {
            InitializeComponent();
        }
        private void bersih()
        {
            t_id.Clear();
            t_diskon.Clear();
            t_Harju.Clear();
            t_Harpok.Clear();
            t_judul.Clear();
            t_no.Clear();
            t_penerbit.Clear();
            t_penulis.Clear();
            t_ppn.Clear();
            t_stok.Clear();
            t_tahun.Clear();

        }
        private void tampil(string cari)
        {
            if (cari.Length == 0)
            {
                 cmd = new SqlCommand("select * from [dbo].[buku]", con.getCon());
            }
            else
            {
                cmd = new SqlCommand("select * from [dbo].[buku] where id_buku like '%"+cari+"%'or judul like '%" + cari + "%' or noisbn like '%" + cari + "%' or penulis like '%" + cari + "%'  or penerbit like '%" + cari + "%'or tahun like '%" + cari + "%'or stok like '%" + cari + "%'or harga_pokok like '%" + cari + "%'or harga_jual like '%" + cari + "%'or ppn like '%" + cari + "%'or diskon like '%" + cari + "%'", con.getCon());

            }

            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            tabel.Columns["id_buku"].ColumnName = "Id";
            tabel.Columns["judul"].ColumnName = "Judul Buku";
            tabel.Columns["noisbn"].ColumnName = "ISBN";
            tabel.Columns["penulis"].ColumnName = "Penulis Buku";
            tabel.Columns["penerbit"].ColumnName = "Penerbit Buku";
            tabel.Columns["tahun"].ColumnName = "Tahun Terbit";
            tabel.Columns["stok"].ColumnName = "Stok Buku";
            tabel.Columns["harga_pokok"].ColumnName = "harag Pokok";
            tabel.Columns["harga_jual"].ColumnName = "Harga Jual";
            tabel.Columns["ppn"].ColumnName = "PPN";
            tabel.Columns["diskon"].ColumnName = "Diskon";

        }
        private void b_tambah_Click(object sender, EventArgs e)
        {
            t_id.Focus();
            bersih();
        }

        private void b_bersih_Click(object sender, EventArgs e)
        {
            bersih();
            con.ber_kon();
        }

        private void Buku_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
            tampil("");
        }

        private void b_simpan_Click(object sender, EventArgs e)
        {
            if (t_diskon.Text.Length == 0 || t_Harju.Text.Length == 0 || t_Harpok.Text.Length == 0 || t_judul.Text.Length==0 || t_no.Text.Length == 0 || t_penerbit.Text.Length == 0 || t_penulis.Text.Length == 0 || t_ppn.Text.Length == 0 || t_stok.Text.Length == 0 || t_tahun.Text.Length == 0)
            {
                MessageBox.Show("Silahkan isi semua inputan dengan data yang benar!", "Informasi");
                
            }
            else
            {
                cmd = new SqlCommand("insert into [dbo].[buku] values('"+t_id.Text+"','"+t_judul.Text+"','"+t_no.Text+"','"+t_penulis.Text+"','"+t_penerbit.Text+"','"+t_tahun.Text+"','"+t_stok.Text+"','"+t_Harpok.Text+"','"+t_Harju.Text+"','"+t_ppn.Text+"',"+t_diskon.Text+")", con.getCon());
                cmd.ExecuteNonQuery();
                tampil("");
                bersih();
                con.sim_kon();
            }
        }

        private void t_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void t_tahun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void t_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void t_Harpok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void t_Harju_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void t_ppn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void t_diskon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            tampil(cari.Text);
        }

        private void b_hapus_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Yakin mau menghapus", "konfirmasi", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from [dbo].[buku] where id_buku = '" + t_id.Text + "'", con.getCon());
                cmd.ExecuteNonQuery();
                tampil("");
                bersih();
                con.hps_kon();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();
            t_judul.Text = dr.Cells[1].Value.ToString();
            t_no.Text = dr.Cells[2].Value.ToString();
            t_penulis.Text = dr.Cells[3].Value.ToString();
            t_penerbit.Text = dr.Cells[4].Value.ToString();
            t_tahun.Text = dr.Cells[5].Value.ToString();
            t_stok.Text = dr.Cells[6].Value.ToString();
            t_Harpok.Text = dr.Cells[7].Value.ToString();
            t_Harju.Text = dr.Cells[8].Value.ToString();
            t_ppn.Text = dr.Cells[9].Value.ToString();
            t_diskon.Text = dr.Cells[10].Value.ToString();

        }

        private void b_ubah_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin akan mengubah data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes){
                cmd = new SqlCommand("update [dbo].[buku] set judul = '" + t_judul.Text + "', noisbn = '" + t_no.Text + "', penulis = '" + t_penulis.Text + "', penerbit = '" + t_penerbit.Text + "', tahun = '" + t_tahun.Text + "', stok = '" + t_stok.Text + "', harga_pokok = '" + t_Harpok.Text + "', harga_jual = '" + t_Harju.Text + "', ppn = '" + t_ppn.Text + "', diskon = '" + t_diskon.Text + "'  where id_buku = '"+t_id.Text+"'", con.getCon());
                cmd.ExecuteNonQuery();
                tampil("");
                bersih();
                con.ubh_kon();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

