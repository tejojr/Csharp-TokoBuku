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
    public partial class Login : Form
    {
        int x = 0;
        public static string nama;
        public static byte[] gambar;
        string status, akses;
        public static int id_kasir;
        Config con;
        SqlDataReader reader;
        SqlCommand cmd;
        
        public Login()
        {
            InitializeComponent();
        }
        private void bersih()
        {
            t_uname.Clear();
            t_pass.Clear();
            t_uname.Focus();
        }
        public static int getId()
        {
            return id_kasir;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            con = new Config();
            con.setConnection("ZEREF-WEISMANN\\ZEREF", "sa", "root", "toko_buku");
        }
        private void cek()
        {
            //validasi email 
            if (!this.t_uname.Text.Contains('@'))
            {
                MessageBox.Show("Username harus diisi!");
            }
            else if (t_uname.Text.Length == 0)
            {
                MessageBox.Show("Password harus diisi!");
            }
            else
            {

            }
        } 
        private void b_login_Click(object sender, EventArgs e)
        {
            if (t_uname.Text.Length == 0)
            {
                MessageBox.Show("Username harus diisi!");
            }
            else if (t_uname.Text.Length == 0)
            {
                MessageBox.Show("Password harus diisi!");
            }
            else
            {
                try {
                    cmd = new SqlCommand("SELECT * FROM [dbo].[kasir] where username='" + t_uname.Text + "' and password='" + t_pass.Text + "'", con.getCon());
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_kasir = (int)reader["id_kasir"];
                                status = (string)reader["status"];
                                akses = (string)reader["akses"];
                                nama = (string)reader["nama"];
                              //  gambar = (byte[])reader[8];


                            }
                            if (status.Equals("1"))
                            {
                                if (akses.Equals("admin"))
                                {
                                    MessageBox.Show(nama, "status login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    new Admin().Show();
                                    this.Hide();
                                } else if (akses.Equals("kasir"))
                                {
                                    MessageBox.Show("Login Berhasil" , "status login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Navi n = new Navi();
                                    //n.setNama(getNama());
                                    n.Show();
                                    this.Hide();
                                }
                            } else
                            {
                                MessageBox.Show("Login Gagal, Akun Anda terblokir! silahkan hubungi Admin","status login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                x = x + 1;
                            }
                        } else
                        {
                            MessageBox.Show("Akun tidak ditemukan!");
                            x = x + 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (x == 3)
            {
                MessageBox.Show("Anda gagal login 3x, aplikasi akan otomati tertutup");
                Application.Exit();
            }
            bersih();
            
            }
        private void label3_Click_1(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Panel().Show();
            this.Hide();
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass.Checked)
            {
                t_pass.UseSystemPasswordChar = true;
            } else
            {
                t_pass.UseSystemPasswordChar = false;
            }
        }
        public static string getNama()
        {
            return nama;
        }
        public static byte[] getGbr()
        {
            return gambar;
        }
    }
}
