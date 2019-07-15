namespace toko_buku
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nama = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.data = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPasokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanDistributorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluar = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.nama});
            this.statusStrip1.Location = new System.Drawing.Point(0, 291);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(404, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "zeref.weismann 2017";
            // 
            // nama
            // 
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(118, 17);
            this.nama.Text = "toolStripStatusLabel2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.data,
            this.laporan,
            this.keluar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // data
            // 
            this.data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataKasirToolStripMenuItem});
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(43, 20);
            this.data.Text = "&Data";
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // dataKasirToolStripMenuItem
            // 
            this.dataKasirToolStripMenuItem.Name = "dataKasirToolStripMenuItem";
            this.dataKasirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.dataKasirToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dataKasirToolStripMenuItem.Text = "Data Kasir";
            this.dataKasirToolStripMenuItem.Click += new System.EventHandler(this.dataKasirToolStripMenuItem_Click);
            // 
            // laporan
            // 
            this.laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanBukuToolStripMenuItem,
            this.laporanPenjualanToolStripMenuItem,
            this.laporanPasokToolStripMenuItem,
            this.laporanDistributorToolStripMenuItem});
            this.laporan.Name = "laporan";
            this.laporan.Size = new System.Drawing.Size(62, 20);
            this.laporan.Text = "&Laporan";
            this.laporan.Click += new System.EventHandler(this.laporan_Click);
            // 
            // laporanBukuToolStripMenuItem
            // 
            this.laporanBukuToolStripMenuItem.Name = "laporanBukuToolStripMenuItem";
            this.laporanBukuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.laporanBukuToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.laporanBukuToolStripMenuItem.Text = "Laporan Buku";
            this.laporanBukuToolStripMenuItem.Click += new System.EventHandler(this.laporanBukuToolStripMenuItem_Click);
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            this.laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            this.laporanPenjualanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.laporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.laporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            this.laporanPenjualanToolStripMenuItem.Click += new System.EventHandler(this.laporanPenjualanToolStripMenuItem_Click);
            // 
            // laporanPasokToolStripMenuItem
            // 
            this.laporanPasokToolStripMenuItem.Name = "laporanPasokToolStripMenuItem";
            this.laporanPasokToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.laporanPasokToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.laporanPasokToolStripMenuItem.Text = "Laporan Pasok";
            this.laporanPasokToolStripMenuItem.Click += new System.EventHandler(this.laporanPasokToolStripMenuItem_Click);
            // 
            // laporanDistributorToolStripMenuItem
            // 
            this.laporanDistributorToolStripMenuItem.Name = "laporanDistributorToolStripMenuItem";
            this.laporanDistributorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F6)));
            this.laporanDistributorToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.laporanDistributorToolStripMenuItem.Text = "Laporan Distributor";
            this.laporanDistributorToolStripMenuItem.Click += new System.EventHandler(this.laporanDistributorToolStripMenuItem_Click);
            // 
            // keluar
            // 
            this.keluar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(52, 20);
            this.keluar.Text = "&Keluar";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.logOutToolStripMenuItem.Text = "&LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 59);
            this.panel1.TabIndex = 9;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 313);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maca Book ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel nama;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem data;
        public System.Windows.Forms.ToolStripMenuItem dataKasirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem laporan;
        public System.Windows.Forms.ToolStripMenuItem laporanBukuToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem laporanPenjualanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem laporanPasokToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem laporanDistributorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem keluar;
        public System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}