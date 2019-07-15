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
    public partial class L_pasok : Form
    {
        Config con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public L_pasok()
        {

            InitializeComponent();
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
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

            ws.Cells[1, 1] = "Id Pasok";
            ws.Cells[1, 2] = "Nama Distributor";
            ws.Cells[1, 3] = "Judul";
            ws.Cells[1, 4] = "Jumlah";
            ws.Cells[1, 5] = "Tanggal";



            for (int j = 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }

        private void L_pasok_Load(object sender, EventArgs e)
        {
           
            cmd = new SqlCommand("select * from [dbo].[det_pasok] ", con.getCon());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
           System.Data.DataTable tabel = new System.Data.DataTable();
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            tabel.Columns["id_pasok"].ColumnName = "Id Pasok";
            tabel.Columns["nama_distri"].ColumnName = "Nama Distributor";
            tabel.Columns["judul"].ColumnName = "Judul Buku";
            tabel.Columns["jumlah"].ColumnName = "Jumlah Buku";
            tabel.Columns["tanggal"].ColumnName = "Tanggal Pasok";
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
