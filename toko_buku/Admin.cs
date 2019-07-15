using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toko_buku
{
    public partial class Admin : Form
    {
        Kasir kasir;
        L_buku buku;
        L_distri distri;
        L_pasok pasok;
        L_penju penju;
        public Admin()
        {
            InitializeComponent();
        }

        private void laporan_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            nama.Text = Login.getNama();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        void Kasir_Closed(object sender, FormClosedEventArgs e)
        {
            kasir = null;
        }
        void L_buku_Closed(object sender, FormClosedEventArgs e)
        {
             buku= null;
        }
        void L_distri_Closed(object sender, FormClosedEventArgs e)
        {
            distri = null;
        }
        void L_pasok_Closed(object sender, FormClosedEventArgs e)
        {
            pasok = null;
        }
        void L_penju_Closed(object sender, FormClosedEventArgs e)
        {
            penju = null;
        }
        private void dataKasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kasir == null)
            {
                kasir = new Kasir();
                kasir.MdiParent = this;
                kasir.FormClosed += new FormClosedEventHandler(Kasir_Closed);
                kasir.Show();
            } else
            {
                kasir.Activate();
            }
        }

        private void laporanBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (buku == null)
            {
                buku = new L_buku();
                buku.MdiParent = this;
                buku.FormClosed += new FormClosedEventHandler(L_buku_Closed);
                buku.Show();
            }
            else
            {
                buku.Activate();
            }
        }

        private void laporanPenjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(penju == null)
            {
                penju = new L_penju();
                penju.MdiParent = this;
            }
        }

        private void laporanPasokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pasok == null)
            {
                pasok = new L_pasok();
                pasok.MdiParent = this;
                pasok.FormClosed += new FormClosedEventHandler(L_pasok_Closed);
                pasok.Show();
            }
            else
            {
                pasok.Activate();
            }
        }

        private void laporanDistributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (distri == null)
            {
                distri = new L_distri();
                distri.MdiParent = this;
                distri.FormClosed += new FormClosedEventHandler(L_distri_Closed);
                distri.Show();
            }
            else
            {
                distri.Activate();
            }
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void data_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Dispose();
        }
    }
}
