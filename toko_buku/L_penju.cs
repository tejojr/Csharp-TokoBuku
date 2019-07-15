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
    
    public partial class L_penju : Form
    {
        Config con;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        public L_penju()
        {
            InitializeComponent();
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
        }

        private void L_penju_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from [dbo].[det_penju]", con.getCon());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            System.Data.DataTable tabel = new System.Data.DataTable();
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;

            tabel.Columns["no_kwi"].ColumnName = "No. Kuitansi";
            tabel.Columns["id_penjualan"].ColumnName = "Id Penjualan";
            tabel.Columns["judul"].ColumnName = "Judul Buku";
            tabel.Columns["nama"].ColumnName = "Kasir";
            tabel.Columns["harga_jual"].ColumnName = "Harga";
            tabel.Columns["jumlah"].ColumnName = "Qty";
            tabel.Columns["total"].ColumnName = "Total";
            tabel.Columns["tanggal"].ColumnName = "Waktu";
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "No Kwitansi";
            ws.Cells[1, 2] = "Id Penjualan";
            ws.Cells[1, 3] = "Judul";
            ws.Cells[1, 4] = "Nama";
            ws.Cells[1, 5] = "Harga Jual";
            ws.Cells[1, 6] = "Jumlah";
            ws.Cells[1, 7] = "Total";
            ws.Cells[1, 8] = "Tanggal";



            for (int j = 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 1; i <= 8; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }
    }
}
