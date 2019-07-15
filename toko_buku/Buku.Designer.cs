namespace toko_buku
{
    partial class Buku
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cari = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_diskon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.t_ppn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.t_Harju = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.t_Harpok = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t_stok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.t_tahun = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_penerbit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_penulis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_ubah = new System.Windows.Forms.Button();
            this.b_bersih = new System.Windows.Forms.Button();
            this.b_hapus = new System.Windows.Forms.Button();
            this.b_simpan = new System.Windows.Forms.Button();
            this.b_tambah = new System.Windows.Forms.Button();
            this.t_no = new System.Windows.Forms.TextBox();
            this.t_judul = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cari);
            this.groupBox3.Location = new System.Drawing.Point(314, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 42);
            this.groupBox3.TabIndex = 13;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(314, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 409);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(17, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.t_diskon);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.t_ppn);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.t_Harju);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.t_Harpok);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.t_stok);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.t_tahun);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.t_penerbit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.t_penulis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.b_ubah);
            this.groupBox1.Controls.Add(this.b_bersih);
            this.groupBox1.Controls.Add(this.b_hapus);
            this.groupBox1.Controls.Add(this.b_simpan);
            this.groupBox1.Controls.Add(this.b_tambah);
            this.groupBox1.Controls.Add(this.t_no);
            this.groupBox1.Controls.Add(this.t_judul);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 459);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // t_id
            // 
            this.t_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id.Location = new System.Drawing.Point(115, 18);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(160, 22);
            this.t_id.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Id";
            // 
            // t_diskon
            // 
            this.t_diskon.Location = new System.Drawing.Point(115, 343);
            this.t_diskon.Name = "t_diskon";
            this.t_diskon.Size = new System.Drawing.Size(160, 20);
            this.t_diskon.TabIndex = 26;
            this.t_diskon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_diskon_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Diskon";
            // 
            // t_ppn
            // 
            this.t_ppn.Location = new System.Drawing.Point(115, 313);
            this.t_ppn.Name = "t_ppn";
            this.t_ppn.Size = new System.Drawing.Size(160, 20);
            this.t_ppn.TabIndex = 24;
            this.t_ppn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_ppn_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "PPN";
            // 
            // t_Harju
            // 
            this.t_Harju.Location = new System.Drawing.Point(115, 284);
            this.t_Harju.Name = "t_Harju";
            this.t_Harju.Size = new System.Drawing.Size(160, 20);
            this.t_Harju.TabIndex = 22;
            this.t_Harju.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_Harju_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Harga Jual";
            // 
            // t_Harpok
            // 
            this.t_Harpok.Location = new System.Drawing.Point(115, 250);
            this.t_Harpok.Name = "t_Harpok";
            this.t_Harpok.Size = new System.Drawing.Size(160, 20);
            this.t_Harpok.TabIndex = 22;
            this.t_Harpok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_Harpok_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Harga Pokok";
            // 
            // t_stok
            // 
            this.t_stok.Location = new System.Drawing.Point(115, 214);
            this.t_stok.Name = "t_stok";
            this.t_stok.Size = new System.Drawing.Size(160, 20);
            this.t_stok.TabIndex = 20;
            this.t_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_stok_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stok";
            // 
            // t_tahun
            // 
            this.t_tahun.Location = new System.Drawing.Point(115, 179);
            this.t_tahun.Name = "t_tahun";
            this.t_tahun.Size = new System.Drawing.Size(160, 20);
            this.t_tahun.TabIndex = 18;
            this.t_tahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_tahun_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tahun";
            // 
            // t_penerbit
            // 
            this.t_penerbit.Location = new System.Drawing.Point(115, 150);
            this.t_penerbit.Name = "t_penerbit";
            this.t_penerbit.Size = new System.Drawing.Size(160, 20);
            this.t_penerbit.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Penerbit";
            // 
            // t_penulis
            // 
            this.t_penulis.Location = new System.Drawing.Point(115, 118);
            this.t_penulis.Name = "t_penulis";
            this.t_penulis.Size = new System.Drawing.Size(160, 20);
            this.t_penulis.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Penulis";
            // 
            // b_ubah
            // 
            this.b_ubah.Location = new System.Drawing.Point(200, 375);
            this.b_ubah.Name = "b_ubah";
            this.b_ubah.Size = new System.Drawing.Size(75, 23);
            this.b_ubah.TabIndex = 12;
            this.b_ubah.Text = "Ubah";
            this.b_ubah.UseVisualStyleBackColor = true;
            this.b_ubah.Click += new System.EventHandler(this.b_ubah_Click);
            // 
            // b_bersih
            // 
            this.b_bersih.Location = new System.Drawing.Point(151, 416);
            this.b_bersih.Name = "b_bersih";
            this.b_bersih.Size = new System.Drawing.Size(75, 23);
            this.b_bersih.TabIndex = 11;
            this.b_bersih.Text = "Bersih";
            this.b_bersih.UseVisualStyleBackColor = true;
            this.b_bersih.Click += new System.EventHandler(this.b_bersih_Click);
            // 
            // b_hapus
            // 
            this.b_hapus.Location = new System.Drawing.Point(60, 416);
            this.b_hapus.Name = "b_hapus";
            this.b_hapus.Size = new System.Drawing.Size(75, 23);
            this.b_hapus.TabIndex = 10;
            this.b_hapus.Text = "Hapus";
            this.b_hapus.UseVisualStyleBackColor = true;
            this.b_hapus.Click += new System.EventHandler(this.b_hapus_Click);
            // 
            // b_simpan
            // 
            this.b_simpan.Location = new System.Drawing.Point(114, 375);
            this.b_simpan.Name = "b_simpan";
            this.b_simpan.Size = new System.Drawing.Size(75, 23);
            this.b_simpan.TabIndex = 9;
            this.b_simpan.Text = "Simpan";
            this.b_simpan.UseVisualStyleBackColor = true;
            this.b_simpan.Click += new System.EventHandler(this.b_simpan_Click);
            // 
            // b_tambah
            // 
            this.b_tambah.Location = new System.Drawing.Point(28, 375);
            this.b_tambah.Name = "b_tambah";
            this.b_tambah.Size = new System.Drawing.Size(75, 23);
            this.b_tambah.TabIndex = 8;
            this.b_tambah.Text = "Tambah";
            this.b_tambah.UseVisualStyleBackColor = true;
            this.b_tambah.Click += new System.EventHandler(this.b_tambah_Click);
            // 
            // t_no
            // 
            this.t_no.Location = new System.Drawing.Point(115, 86);
            this.t_no.Name = "t_no";
            this.t_no.Size = new System.Drawing.Size(160, 20);
            this.t_no.TabIndex = 7;
            this.t_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_no_KeyPress);
            // 
            // t_judul
            // 
            this.t_judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_judul.Location = new System.Drawing.Point(115, 51);
            this.t_judul.Name = "t_judul";
            this.t_judul.Size = new System.Drawing.Size(160, 22);
            this.t_judul.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "No.ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Judul";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 79);
            this.panel1.TabIndex = 14;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(241, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(244, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "FORM PENJUALAN";
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
            // Column1
            // 
            this.Column1.HeaderText = "Delete";
            this.Column1.Name = "Column1";
            // 
            // Buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Buku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Buku_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox cari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_ubah;
        private System.Windows.Forms.Button b_bersih;
        private System.Windows.Forms.Button b_hapus;
        private System.Windows.Forms.Button b_simpan;
        private System.Windows.Forms.Button b_tambah;
        private System.Windows.Forms.TextBox t_no;
        private System.Windows.Forms.TextBox t_judul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_penulis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_stok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox t_tahun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_penerbit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_Harpok;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t_diskon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t_ppn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox t_Harju;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}