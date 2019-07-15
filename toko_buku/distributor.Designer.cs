namespace toko_buku
{
    partial class distributor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_ubah = new System.Windows.Forms.Button();
            this.b_bersih = new System.Windows.Forms.Button();
            this.b_hapus = new System.Windows.Forms.Button();
            this.b_simpan = new System.Windows.Forms.Button();
            this.b_tambah = new System.Windows.Forms.Button();
            this.t_telepon = new System.Windows.Forms.TextBox();
            this.t_alamat = new System.Windows.Forms.RichTextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cari = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_ubah);
            this.groupBox1.Controls.Add(this.b_bersih);
            this.groupBox1.Controls.Add(this.b_hapus);
            this.groupBox1.Controls.Add(this.b_simpan);
            this.groupBox1.Controls.Add(this.b_tambah);
            this.groupBox1.Controls.Add(this.t_telepon);
            this.groupBox1.Controls.Add(this.t_alamat);
            this.groupBox1.Controls.Add(this.t_nama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 318);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // b_ubah
            // 
            this.b_ubah.Location = new System.Drawing.Point(187, 236);
            this.b_ubah.Name = "b_ubah";
            this.b_ubah.Size = new System.Drawing.Size(75, 23);
            this.b_ubah.TabIndex = 12;
            this.b_ubah.Text = "Ubah";
            this.b_ubah.UseVisualStyleBackColor = true;
            this.b_ubah.Click += new System.EventHandler(this.b_ubah_Click);
            // 
            // b_bersih
            // 
            this.b_bersih.Location = new System.Drawing.Point(138, 277);
            this.b_bersih.Name = "b_bersih";
            this.b_bersih.Size = new System.Drawing.Size(75, 23);
            this.b_bersih.TabIndex = 11;
            this.b_bersih.Text = "Bersih";
            this.b_bersih.UseVisualStyleBackColor = true;
            this.b_bersih.Click += new System.EventHandler(this.b_bersih_Click);
            // 
            // b_hapus
            // 
            this.b_hapus.Location = new System.Drawing.Point(47, 277);
            this.b_hapus.Name = "b_hapus";
            this.b_hapus.Size = new System.Drawing.Size(75, 23);
            this.b_hapus.TabIndex = 10;
            this.b_hapus.Text = "Hapus";
            this.b_hapus.UseVisualStyleBackColor = true;
            this.b_hapus.Click += new System.EventHandler(this.b_hapus_Click);
            // 
            // b_simpan
            // 
            this.b_simpan.Location = new System.Drawing.Point(101, 236);
            this.b_simpan.Name = "b_simpan";
            this.b_simpan.Size = new System.Drawing.Size(75, 23);
            this.b_simpan.TabIndex = 9;
            this.b_simpan.Text = "Simpan";
            this.b_simpan.UseVisualStyleBackColor = true;
            this.b_simpan.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_tambah
            // 
            this.b_tambah.Location = new System.Drawing.Point(15, 236);
            this.b_tambah.Name = "b_tambah";
            this.b_tambah.Size = new System.Drawing.Size(75, 23);
            this.b_tambah.TabIndex = 8;
            this.b_tambah.Text = "Tambah";
            this.b_tambah.UseVisualStyleBackColor = true;
            this.b_tambah.Click += new System.EventHandler(this.b_tambah_Click);
            // 
            // t_telepon
            // 
            this.t_telepon.Location = new System.Drawing.Point(81, 142);
            this.t_telepon.Name = "t_telepon";
            this.t_telepon.Size = new System.Drawing.Size(160, 20);
            this.t_telepon.TabIndex = 7;
            this.t_telepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_telepon_KeyPress);
            // 
            // t_alamat
            // 
            this.t_alamat.Location = new System.Drawing.Point(81, 61);
            this.t_alamat.Name = "t_alamat";
            this.t_alamat.Size = new System.Drawing.Size(160, 59);
            this.t_alamat.TabIndex = 6;
            this.t_alamat.Text = "";
            // 
            // t_nama
            // 
            this.t_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_nama.Location = new System.Drawing.Point(81, 20);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(160, 22);
            this.t_nama.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(295, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 270);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cari);
            this.groupBox3.Location = new System.Drawing.Point(295, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 42);
            this.groupBox3.TabIndex = 9;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 79);
            this.panel1.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Batik Gangster", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(357, 35);
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
            this.label14.Location = new System.Drawing.Point(287, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 31);
            this.label14.TabIndex = 18;
            this.label14.Text = "Maca";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(756, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA DISTRIBUTOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::toko_buku.Properties.Resources._643676_book_512x512;
            this.pictureBox1.Image = global::toko_buku.Properties.Resources._643676_book_512x512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "distributor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Distributor";
            this.Load += new System.EventHandler(this.distributor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_telepon;
        private System.Windows.Forms.RichTextBox t_alamat;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cari;
        private System.Windows.Forms.Button b_ubah;
        private System.Windows.Forms.Button b_bersih;
        private System.Windows.Forms.Button b_hapus;
        private System.Windows.Forms.Button b_simpan;
        private System.Windows.Forms.Button b_tambah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}