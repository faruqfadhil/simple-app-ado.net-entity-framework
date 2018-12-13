namespace sembarangKasir
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_transaksi = new System.Windows.Forms.Button();
            this.bt_stock = new System.Windows.Forms.Button();
            this.bt_keuangan = new System.Windows.Forms.Button();
            this.bt_barang = new System.Windows.Forms.Button();
            this.bt_logout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PT SEMBARANG KASIR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_transaksi);
            this.groupBox1.Controls.Add(this.bt_stock);
            this.groupBox1.Controls.Add(this.bt_keuangan);
            this.groupBox1.Controls.Add(this.bt_barang);
            this.groupBox1.Location = new System.Drawing.Point(-2, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // bt_transaksi
            // 
            this.bt_transaksi.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.bt_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_transaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_transaksi.ForeColor = System.Drawing.Color.White;
            this.bt_transaksi.Location = new System.Drawing.Point(296, 0);
            this.bt_transaksi.Name = "bt_transaksi";
            this.bt_transaksi.Size = new System.Drawing.Size(291, 101);
            this.bt_transaksi.TabIndex = 4;
            this.bt_transaksi.Text = "Transaksi";
            this.bt_transaksi.UseVisualStyleBackColor = false;
            this.bt_transaksi.Click += new System.EventHandler(this.bt_transaksi_Click);
            // 
            // bt_stock
            // 
            this.bt_stock.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bt_stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stock.ForeColor = System.Drawing.Color.White;
            this.bt_stock.Location = new System.Drawing.Point(296, 99);
            this.bt_stock.Name = "bt_stock";
            this.bt_stock.Size = new System.Drawing.Size(291, 101);
            this.bt_stock.TabIndex = 3;
            this.bt_stock.Text = "Stock";
            this.bt_stock.UseVisualStyleBackColor = false;
            this.bt_stock.Click += new System.EventHandler(this.bt_stock_Click);
            // 
            // bt_keuangan
            // 
            this.bt_keuangan.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_keuangan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_keuangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_keuangan.ForeColor = System.Drawing.Color.White;
            this.bt_keuangan.Location = new System.Drawing.Point(0, 100);
            this.bt_keuangan.Name = "bt_keuangan";
            this.bt_keuangan.Size = new System.Drawing.Size(298, 101);
            this.bt_keuangan.TabIndex = 2;
            this.bt_keuangan.Text = "Keuangan";
            this.bt_keuangan.UseVisualStyleBackColor = false;
            this.bt_keuangan.Click += new System.EventHandler(this.bt_keuangan_Click);
            // 
            // bt_barang
            // 
            this.bt_barang.BackColor = System.Drawing.Color.DimGray;
            this.bt_barang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_barang.ForeColor = System.Drawing.Color.White;
            this.bt_barang.Location = new System.Drawing.Point(0, 0);
            this.bt_barang.Name = "bt_barang";
            this.bt_barang.Size = new System.Drawing.Size(299, 101);
            this.bt_barang.TabIndex = 0;
            this.bt_barang.Text = "Barang";
            this.bt_barang.UseVisualStyleBackColor = false;
            this.bt_barang.Click += new System.EventHandler(this.bt_barang_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.SystemColors.Control;
            this.bt_logout.Location = new System.Drawing.Point(508, 0);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(75, 23);
            this.bt_logout.TabIndex = 2;
            this.bt_logout.Text = "Logout";
            this.bt_logout.UseVisualStyleBackColor = false;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_stock;
        private System.Windows.Forms.Button bt_keuangan;
        private System.Windows.Forms.Button bt_barang;
        private System.Windows.Forms.Button bt_transaksi;
        private System.Windows.Forms.Button bt_logout;
    }
}