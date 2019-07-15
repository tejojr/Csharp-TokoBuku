using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace toko_buku.laporan
{
    public partial class cetakreport : Form
    {
        DataSet ds;
        SqlDataAdapter da;
        string t_id;
        SqlCommand cmd;
        Config con;
        public cetakreport()
        {
            
            InitializeComponent();

            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
            
        }
        private void cetak()
        {
            cmd = new SqlCommand("select * from trans where no_kwi = '"+t_id+"'", con.getCon());
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "trans");
            Transaksi tr = new Transaksi();
            tr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = tr;
            crystalReportViewer1.Refresh();
            

        }
         private void crystalReportViewer1_Load(object sender, EventArgs e) { 
              
           
        }

        private void cetakreport_Load(object sender, EventArgs e)
        {
            t_id = penjualan.getKwitansi();
            MessageBox.Show(t_id);
            cetak();
        }
    }
}

