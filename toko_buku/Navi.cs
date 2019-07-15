using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace toko_buku
{
    public partial class Navi : Form
    {
        string idkasir;
        Config con;
        public string jeneng;
        SpeechSynthesizer zeref = new SpeechSynthesizer();
       
        public Navi()
        {
            Thread t = new Thread(new ThreadStart(startForm));
            t.Start();
            Thread.Sleep(1240);
            t.Abort();

            InitializeComponent();
          
            zeref.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
        }
        public void startForm()
        {
            Application.Run(new Loading());
        }
        //public void setNama(string nama)
        //{
          //  this.jeneng = nama;
        //}
        private void Navi_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
            //con.setKasir(this.idkasir);
            timer1.Start();
            string nama = Login.getNama();
          // byte[] gambar = Login.getGbr();
            //MemoryStream ms = new MemoryStream(gambar);
            ///pictureBox2.Image = Image.FromStream(ms);
            
            namakasir.Text = nama;
            b_master.Enabled = false;
            p_master.Visible = true;
            p_atur.Visible = false;
            p_laporan.Visible = false;
            p_transaksi.Visible = false;
            zeref.Speak("welcome "+nama+"to book store application Maca Book, cheap, best quality, special diskon");
            
          
        }

        private void b_transaksi_Click(object sender, EventArgs e)
        {
            b_transaksi.Enabled = false;
            b_master.Enabled = true;
            b_laporan.Enabled = true;
            b_setting.Enabled = true;
            b_logout.Enabled = true;
            p_transaksi.Visible = true;
            p_atur.Visible = false;
            p_laporan.Visible = false;
            p_master.Visible = false;


        }

        private void b_laporan_Click(object sender, EventArgs e)
        {
            b_transaksi.Enabled = true;
            b_master.Enabled = true;
            b_laporan.Enabled = false;
            b_setting.Enabled = true;
            b_logout.Enabled = true;
            p_master.Visible = false;
            p_atur.Visible = false;
            p_laporan.Visible = true;
            p_transaksi.Visible = false;
        
    }

        private void b_setting_Click(object sender, EventArgs e)
        {
            b_transaksi.Enabled = true;
            b_master.Enabled = true;
            b_laporan.Enabled = true;
            b_setting.Enabled = false;
            b_logout.Enabled = true;
            p_master.Visible = false;
            p_atur.Visible = true;
            p_laporan.Visible = false;
            p_transaksi.Visible = false;
        }

        private void b_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Logout dari aplikasi ini!", "Proses Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Login().Show();
                this.Hide();
                zeref.Speak("Good bye, Come Back Again Pelase ");
            }

        }

        private void b_master_Click(object sender, EventArgs e)
        {
            b_transaksi.Enabled = true;
            b_master.Enabled = false;
            b_laporan.Enabled = true;
            b_setting.Enabled = true;
            b_logout.Enabled = true;
            p_master.Visible = true;
            p_atur.Visible = false;
            p_laporan.Visible = false;
            p_transaksi.Visible = false;
        }

        private void l_penj_Click(object sender, EventArgs e)
        {
            new L_penju().Show();
        }

        private void l_pasok_Click(object sender, EventArgs e)
        {
            new L_pasok().Show();
        }

        private void l_buku_Click(object sender, EventArgs e)
        {
            new L_buku().Show();
        }

        private void l_dsitri_Click(object sender, EventArgs e)
        {
            new L_distri().Show();
        }

        private void b_pasok_Click(object sender, EventArgs e)
        {
            new Pasok().Show();
        }

        private void b_jual_Click(object sender, EventArgs e)
        {
            penjualan p = new penjualan();
            //p.setJeneng(Log.getNama().ToString());
            //p.setId(Log.getId());
            p.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Tentang().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
         }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void b_buku_Click(object sender, EventArgs e)
        {
            Buku b = new Buku();
            b.Show();
        }

        private void b_distri_Click(object sender, EventArgs e)
        {
            distributor d = new distributor();
            d.Show();
        }

        private void p_master_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.waktu.Text = time.ToString();

        }
    }
}
