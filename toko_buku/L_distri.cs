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
    public partial class L_distri : Form
    {
        Config con;
        SqlDataAdapter adapter;
        SqlCommand  cmd;
        public L_distri()
        {
            InitializeComponent();
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
        }

        private void L_distri_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from [dbo].[distributor]", con.getCon());
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            System.Data.DataTable tabel = new System.Data.DataTable();
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;

            tabel.Columns["id_distri"].ColumnName = "ID";
            tabel.Columns["nama_distri"].ColumnName = "Nama Distributor";
            tabel.Columns["alamat"].ColumnName = "Alamat Ditributor";
            tabel.Columns["telepon"].ColumnName = "No.Telepon";
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "Id Distributor";
            ws.Cells[1, 2] = "Nama Distributor";
            ws.Cells[1, 3] = "Alamat";
            ws.Cells[1, 4] = "Telepon";


            for (int j = 2; j <= dataGridView1.Rows.Count; j++)
            {
                for (int i = 1; i <= 4; i++)
                {
                    ws.Cells[j, i] = dataGridView1.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }
    }
}
