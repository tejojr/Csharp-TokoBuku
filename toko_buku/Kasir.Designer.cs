namespace toko_buku
{
    partial class Kasir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nol = new System.Windows.Forms.RadioButton();
            this.satu = new System.Windows.Forms.RadioButton();
            this.t_alamat = new System.Windows.Forms.RichTextBox();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.t_uname = new System.Windows.Forms.TextBox();
            this.t_telp = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.po = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_ubah = new System.Windows.Forms.Button();
            this.b_bersih = new System.Windows.Forms.Button();
            this.b_hapus = new System.Windows.Forms.Button();
            this.b_simpan = new System.Windows.Forms.Button();
            this.b_tambah = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cari = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 79);
            this.panel1.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Batik Gangster", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(367, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 42);
            this.label13.TabIndex = 19;
            this.label13.Text = "Book";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Berthold City", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(297, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 31);
            this.label14.TabIndex = 18;
            this.label14.Text = "Maca";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(289, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "DATA KASIR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nol);
            this.groupBox1.Controls.Add(this.satu);
            this.groupBox1.Controls.Add(this.t_alamat);
            this.groupBox1.Controls.Add(this.t_pass);
            this.groupBox1.Controls.Add(this.t_uname);
            this.groupBox1.Controls.Add(this.t_telp);
            this.groupBox1.Controls.Add(this.t_nama);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 311);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nol
            // 
            this.nol.AutoSize = true;
            this.nol.Location = new System.Drawing.Point(117, 216);
            this.nol.Name = "nol";
            this.nol.Size = new System.Drawing.Size(31, 17);
            this.nol.TabIndex = 12;
            this.nol.TabStop = true;
            this.nol.Text = "0";
            this.nol.UseVisualStyleBackColor = true;
            this.nol.CheckedChanged += new System.EventHandler(this.nol_CheckedChanged);
            // 
            // satu
            // 
            this.satu.AutoSize = true;
            this.satu.Location = new System.Drawing.Point(80, 216);
            this.satu.Name = "satu";
            this.satu.Size = new System.Drawing.Size(31, 17);
            this.satu.TabIndex = 11;
            this.satu.TabStop = true;
            this.satu.Text = "1";
            this.satu.UseVisualStyleBackColor = true;
            this.satu.CheckedChanged += new System.EventHandler(this.satu_CheckedChanged);
            // 
            // t_alamat
            // 
            this.t_alamat.Location = new System.Drawing.Point(80, 68);
            this.t_alamat.Name = "t_alamat";
            this.t_alamat.Size = new System.Drawing.Size(149, 96);
            this.t_alamat.TabIndex = 10;
            this.t_alamat.Text = "";
            // 
            // t_pass
            // 
            this.t_pass.Location = new System.Drawing.Point(80, 280);
            this.t_pass.Name = "t_pass";
            this.t_pass.Size = new System.Drawing.Size(149, 20);
            this.t_pass.TabIndex = 9;
            // 
            // t_uname
            // 
            this.t_uname.Location = new System.Drawing.Point(80, 244);
            this.t_uname.Name = "t_uname";
            this.t_uname.Size = new System.Drawing.Size(149, 20);
            this.t_uname.TabIndex = 8;
            // 
            // t_telp
            // 
            this.t_telp.Location = new System.Drawing.Point(80, 185);
            this.t_telp.Name = "t_telp";
            this.t_telp.Size = new System.Drawing.Size(149, 20);
            this.t_telp.TabIndex = 7;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(80, 25);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(149, 20);
            this.t_nama.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telepon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_ubah);
            this.groupBox2.Controls.Add(this.b_bersih);
            this.groupBox2.Controls.Add(this.b_hapus);
            this.groupBox2.Controls.Add(this.b_simpan);
            this.groupBox2.Controls.Add(this.b_tambah);
            this.groupBox2.Location = new System.Drawing.Point(13, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 108);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "::Action::";
            // 
            // b_ubah
            // 
            this.b_ubah.Location = new System.Drawing.Point(173, 21);
            this.b_ubah.Name = "b_ubah";
            this.b_ubah.Size = new System.Drawing.Size(75, 23);
            this.b_ubah.TabIndex = 17;
            this.b_ubah.Text = "Ubah";
            this.b_ubah.UseVisualStyleBackColor = true;
            this.b_ubah.Click += new System.EventHandler(this.b_ubah_Click);
            // 
            // b_bersih
            // 
            this.b_bersih.Location = new System.Drawing.Point(124, 62);
            this.b_bersih.Name = "b_bersih";
            this.b_bersih.Size = new System.Drawing.Size(75, 23);
            this.b_bersih.TabIndex = 16;
            this.b_bersih.Text = "Bersih";
            this.b_bersih.UseVisualStyleBackColor = true;
            this.b_bersih.Click += new System.EventHandler(this.b_bersih_Click);
            // 
            // b_hapus
            // 
            this.b_hapus.Location = new System.Drawing.Point(33, 62);
            this.b_hapus.Name = "b_hapus";
            this.b_hapus.Size = new System.Drawing.Size(75, 23);
            this.b_hapus.TabIndex = 15;
            this.b_hapus.Text = "Hapus";
            this.b_hapus.UseVisualStyleBackColor = true;
            this.b_hapus.Click += new System.EventHandler(this.b_hapus_Click);
            // 
            // b_simpan
            // 
            this.b_simpan.Location = new System.Drawing.Point(87, 21);
            this.b_simpan.Name = "b_simpan";
            this.b_simpan.Size = new System.Drawing.Size(75, 23);
            this.b_simpan.TabIndex = 14;
            this.b_simpan.Text = "Simpan";
            this.b_simpan.UseVisualStyleBackColor = true;
            this.b_simpan.Click += new System.EventHandler(this.b_simpan_Click);
            // 
            // b_tambah
            // 
            this.b_tambah.Location = new System.Drawing.Point(1, 21);
            this.b_tambah.Name = "b_tambah";
            this.b_tambah.Size = new System.Drawing.Size(75, 23);
            this.b_tambah.TabIndex = 13;
            this.b_tambah.Text = "Tambah";
            this.b_tambah.UseVisualStyleBackColor = true;
            this.b_tambah.Click += new System.EventHandler(this.b_tambah_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cari);
            this.groupBox3.Location = new System.Drawing.Point(671, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 55);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pencarian";
            // 
            // cari
            // 
            this.cari.Location = new System.Drawing.Point(7, 20);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(145, 20);
            this.cari.TabIndex = 0;
            this.cari.TextChanged += new System.EventHandler(this.cari_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(289, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 341);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 301);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(289, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kasir";
            this.Load += new System.EventHandler(this.Kasir_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.TextBox t_uname;
        private System.Windows.Forms.TextBox t_telp;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton nol;
        private System.Windows.Forms.RadioButton satu;
        private System.Windows.Forms.RichTextBox t_alamat;
        private System.ComponentModel.BackgroundWorker po;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_ubah;
        private System.Windows.Forms.Button b_bersih;
        private System.Windows.Forms.Button b_hapus;
        private System.Windows.Forms.Button b_simpan;
        private System.Windows.Forms.Button b_tambah;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cari;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}