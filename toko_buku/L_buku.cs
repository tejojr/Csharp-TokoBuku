using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
namespace toko_buku
{
    public partial class L_buku : Form
    {
        Config con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        public L_buku()
        {
            InitializeComponent();
            con = new Config ();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
        }

        private void L_buku_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from [dbo].[buku]", con.getCon());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            System.Data.DataTable tabel = new System.Data.DataTable();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;
            ws.Cells[1, 1] = "Id Buku";
            ws.Cells[1, 2] = "Judul";
            ws.Cells[1, 3] = "NoISBN";
            ws.Cells[1, 4] = "Penulis";
            ws.Cells[1, 5] = "Penerbit";
            ws.Cells[1, 6] = "Tahun";
            ws.Cells[1, 7] = "Stok";
            ws.Cells[1, 8] = "Harga Pokok";
            ws.Cells[1, 9] = "harga Jual";
            ws.Cells[1, 10] = "PPN";
            ws.Cells[1, 11] = "Diskon";




            for (int j = 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 1; i <= 11; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }
    }
}
