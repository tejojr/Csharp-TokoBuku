namespace toko_buku
{
    partial class penjualan
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_jum = new System.Windows.Forms.TextBox();
            this.t_harga = new System.Windows.Forms.TextBox();
            this.b_tambah = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_beli = new System.Windows.Forms.TextBox();
            this.t_subtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.c_judul = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_hapus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.t_kembalian = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.t_bayar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.TextBox();
            this.b_selesai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(731, 79);
            this.panel1.TabIndex = 1;
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
            this.label12.Location = new System.Drawing.Point(700, 3);
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
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENJUALAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "No.Kuitansi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Judul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jumlah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Harga";
            // 
            // t_id
            // 
            this.t_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id.Location = new System.Drawing.Point(99, 19);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(193, 21);
            this.t_id.TabIndex = 8;
            // 
            // t_jum
            // 
            this.t_jum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_jum.Location = new System.Drawing.Point(98, 89);
            this.t_jum.Name = "t_jum";
            this.t_jum.Size = new System.Drawing.Size(193, 21);
            this.t_jum.TabIndex = 10;
            // 
            // t_harga
            // 
            this.t_harga.Enabled = false;
            this.t_harga.Location = new System.Drawing.Point(364, 53);
            this.t_harga.Name = "t_harga";
            this.t_harga.Size = new System.Drawing.Size(180, 20);
            this.t_harga.TabIndex = 12;
            // 
            // b_tambah
            // 
            this.b_tambah.Location = new System.Drawing.Point(16, 24);
            this.b_tambah.Name = "b_tambah";
            this.b_tambah.Size = new System.Drawing.Size(107, 39);
            this.b_tambah.TabIndex = 13;
            this.b_tambah.Text = "Tambah";
            this.b_tambah.UseVisualStyleBackColor = true;
            this.b_tambah.Click += new System.EventHandler(this.b_tambah_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_beli);
            this.groupBox1.Controls.Add(this.t_subtotal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.c_judul);
            this.groupBox1.Controls.Add(this.t_id);
            this.groupBox1.Controls.Add(this.t_harga);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.t_jum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 125);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "::Form::";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // t_beli
            // 
            this.t_beli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_beli.Location = new System.Drawing.Point(363, 16);
            this.t_beli.Name = "t_beli";
            this.t_beli.Size = new System.Drawing.Size(181, 21);
            this.t_beli.TabIndex = 16;
            // 
            // t_subtotal
            // 
            this.t_subtotal.Enabled = false;
            this.t_subtotal.Location = new System.Drawing.Point(364, 93);
            this.t_subtotal.Name = "t_subtotal";
            this.t_subtotal.Size = new System.Drawing.Size(180, 20);
            this.t_subtotal.TabIndex = 15;
            this.t_subtotal.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total";
            // 
            // c_judul
            // 
            this.c_judul.FormattingEnabled = true;
            this.c_judul.Location = new System.Drawing.Point(99, 52);
            this.c_judul.Name = "c_judul";
            this.c_judul.Size = new System.Drawing.Size(192, 21);
            this.c_judul.TabIndex = 13;
            this.c_judul.SelectedIndexChanged += new System.EventHandler(this.c_judul_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_hapus);
            this.groupBox2.Controls.Add(this.b_tambah);
            this.groupBox2.Location = new System.Drawing.Point(574, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 120);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "::Aksi::";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // b_hapus
            // 
            this.b_hapus.Location = new System.Drawing.Point(16, 69);
            this.b_hapus.Name = "b_hapus";
            this.b_hapus.Size = new System.Drawing.Size(107, 39);
            this.b_hapus.TabIndex = 14;
            this.b_hapus.Text = "Hapus";
            this.b_hapus.UseVisualStyleBackColor = true;
            this.b_hapus.Click += new System.EventHandler(this.b_hapus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 181);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "::Data::";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 146);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.t_kembalian);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(13, 404);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 113);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kembalian";
            // 
            // t_kembalian
            // 
            this.t_kembalian.AutoSize = true;
            this.t_kembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_kembalian.Location = new System.Drawing.Point(144, 44);
            this.t_kembalian.Name = "t_kembalian";
            this.t_kembalian.Size = new System.Drawing.Size(16, 16);
            this.t_kembalian.TabIndex = 2;
            this.t_kembalian.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(106, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Rp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kembalian:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.t_bayar);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.t_total);
            this.groupBox5.Location = new System.Drawing.Point(309, 404);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(275, 113);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Dibayar Rp.";
            // 
            // t_bayar
            // 
            this.t_bayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_bayar.Location = new System.Drawing.Point(99, 68);
            this.t_bayar.Name = "t_bayar";
            this.t_bayar.Size = new System.Drawing.Size(160, 21);
            this.t_bayar.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total   Rp.";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // t_total
            // 
            this.t_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_total.Location = new System.Drawing.Point(99, 28);
            this.t_total.Name = "t_total";
            this.t_total.Size = new System.Drawing.Size(160, 21);
            this.t_total.TabIndex = 14;
            // 
            // b_selesai
            // 
            this.b_selesai.Location = new System.Drawing.Point(590, 422);
            this.b_selesai.Name = "b_selesai";
            this.b_selesai.Size = new System.Drawing.Size(128, 84);
            this.b_selesai.TabIndex = 15;
            this.b_selesai.Text = "Selesai";
            this.b_selesai.UseVisualStyleBackColor = true;
            this.b_selesai.Click += new System.EventHandler(this.b_selesai_Click);
            // 
            // penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 529);
            this.Controls.Add(this.b_selesai);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "penjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "penjualan";
            this.Load += new System.EventHandler(this.penjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.TextBox t_jum;
        private System.Windows.Forms.TextBox t_harga;
        private System.Windows.Forms.Button b_tambah;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_hapus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button b_selesai;
        private System.Windows.Forms.Label t_kembalian;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t_bayar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.ComboBox c_judul;
        private System.Windows.Forms.TextBox t_subtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox t_beli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}