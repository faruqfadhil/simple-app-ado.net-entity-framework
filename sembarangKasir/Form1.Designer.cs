namespace sembarangKasir
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nama_barangLabel;
            System.Windows.Forms.Label jenis_barangLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label hargaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sembarangkasirDataSet = new sembarangKasir.sembarangkasirDataSet();
            this.masterbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_barangTableAdapter = new sembarangKasir.sembarangkasirDataSetTableAdapters.master_barangTableAdapter();
            this.tableAdapterManager = new sembarangKasir.sembarangkasirDataSetTableAdapters.TableAdapterManager();
            this.master_barangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_qty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_beli = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nama_barangTextBox = new System.Windows.Forms.TextBox();
            this.jenis_barangTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.hargaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nama_barangLabel = new System.Windows.Forms.Label();
            jenis_barangLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            hargaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sembarangkasirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_barangDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(13, 373);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 15;
            idLabel.Text = "id:";
            // 
            // nama_barangLabel
            // 
            nama_barangLabel.AutoSize = true;
            nama_barangLabel.Location = new System.Drawing.Point(13, 399);
            nama_barangLabel.Name = "nama_barangLabel";
            nama_barangLabel.Size = new System.Drawing.Size(72, 13);
            nama_barangLabel.TabIndex = 17;
            nama_barangLabel.Text = "nama barang:";
            // 
            // jenis_barangLabel
            // 
            jenis_barangLabel.AutoSize = true;
            jenis_barangLabel.Location = new System.Drawing.Point(200, 373);
            jenis_barangLabel.Name = "jenis_barangLabel";
            jenis_barangLabel.Size = new System.Drawing.Size(67, 13);
            jenis_barangLabel.TabIndex = 19;
            jenis_barangLabel.Text = "jenis barang:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(200, 399);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(36, 13);
            stockLabel.TabIndex = 21;
            stockLabel.Text = "stock:";
            // 
            // hargaLabel
            // 
            hargaLabel.AutoSize = true;
            hargaLabel.Location = new System.Drawing.Point(13, 425);
            hargaLabel.Name = "hargaLabel";
            hargaLabel.Size = new System.Drawing.Size(37, 13);
            hargaLabel.TabIndex = 23;
            hargaLabel.Text = "harga:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PT SEMBARANG KASIR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sembarangkasirDataSet
            // 
            this.sembarangkasirDataSet.DataSetName = "sembarangkasirDataSet";
            this.sembarangkasirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterbarangBindingSource
            // 
            this.masterbarangBindingSource.DataMember = "master_barang";
            this.masterbarangBindingSource.DataSource = this.sembarangkasirDataSet;
            // 
            // master_barangTableAdapter
            // 
            this.master_barangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.master_barangTableAdapter = this.master_barangTableAdapter;
            this.tableAdapterManager.master_restockTableAdapter = null;
            this.tableAdapterManager.master_userTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = null;
            this.tableAdapterManager.uang_transaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sembarangKasir.sembarangkasirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // master_barangDataGridView
            // 
            this.master_barangDataGridView.AutoGenerateColumns = false;
            this.master_barangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.master_barangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.master_barangDataGridView.DataSource = this.masterbarangBindingSource;
            this.master_barangDataGridView.Location = new System.Drawing.Point(0, 94);
            this.master_barangDataGridView.Name = "master_barangDataGridView";
            this.master_barangDataGridView.RowHeadersWidth = 142;
            this.master_barangDataGridView.Size = new System.Drawing.Size(644, 250);
            this.master_barangDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nama_barang";
            this.dataGridViewTextBoxColumn2.HeaderText = "nama_barang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "jenis_barang";
            this.dataGridViewTextBoxColumn3.HeaderText = "jenis_barang";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "stock";
            this.dataGridViewTextBoxColumn4.HeaderText = "stock";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "harga";
            this.dataGridViewTextBoxColumn5.HeaderText = "harga";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cb_qty
            // 
            this.cb_qty.FormattingEnabled = true;
            this.cb_qty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_qty.Location = new System.Drawing.Point(465, 369);
            this.cb_qty.Name = "cb_qty";
            this.cb_qty.Size = new System.Drawing.Size(121, 21);
            this.cb_qty.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Qty";
            // 
            // btn_beli
            // 
            this.btn_beli.BackColor = System.Drawing.Color.Orange;
            this.btn_beli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_beli.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_beli.Location = new System.Drawing.Point(434, 399);
            this.btn_beli.Name = "btn_beli";
            this.btn_beli.Size = new System.Drawing.Size(152, 23);
            this.btn_beli.TabIndex = 15;
            this.btn_beli.Text = "Beli";
            this.btn_beli.UseVisualStyleBackColor = false;
            this.btn_beli.Click += new System.EventHandler(this.btn_beli_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterbarangBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(91, 370);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 16;
            // 
            // nama_barangTextBox
            // 
            this.nama_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterbarangBindingSource, "nama_barang", true));
            this.nama_barangTextBox.Location = new System.Drawing.Point(91, 396);
            this.nama_barangTextBox.Name = "nama_barangTextBox";
            this.nama_barangTextBox.ReadOnly = true;
            this.nama_barangTextBox.Size = new System.Drawing.Size(100, 20);
            this.nama_barangTextBox.TabIndex = 18;
            // 
            // jenis_barangTextBox
            // 
            this.jenis_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterbarangBindingSource, "jenis_barang", true));
            this.jenis_barangTextBox.Location = new System.Drawing.Point(278, 370);
            this.jenis_barangTextBox.Name = "jenis_barangTextBox";
            this.jenis_barangTextBox.ReadOnly = true;
            this.jenis_barangTextBox.Size = new System.Drawing.Size(100, 20);
            this.jenis_barangTextBox.TabIndex = 20;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterbarangBindingSource, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(278, 396);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockTextBox.TabIndex = 22;
            // 
            // hargaTextBox
            // 
            this.hargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterbarangBindingSource, "harga", true));
            this.hargaTextBox.Location = new System.Drawing.Point(91, 422);
            this.hargaTextBox.Name = "hargaTextBox";
            this.hargaTextBox.ReadOnly = true;
            this.hargaTextBox.Size = new System.Drawing.Size(100, 20);
            this.hargaTextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Informasi Barang";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pilih barang untuk membeli";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 488);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nama_barangLabel);
            this.Controls.Add(this.nama_barangTextBox);
            this.Controls.Add(jenis_barangLabel);
            this.Controls.Add(this.jenis_barangTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(hargaLabel);
            this.Controls.Add(this.hargaTextBox);
            this.Controls.Add(this.btn_beli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_qty);
            this.Controls.Add(this.master_barangDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sembarangkasirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_barangDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private sembarangkasirDataSet sembarangkasirDataSet;
        private System.Windows.Forms.BindingSource masterbarangBindingSource;
        private sembarangkasirDataSetTableAdapters.master_barangTableAdapter master_barangTableAdapter;
        private sembarangkasirDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView master_barangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cb_qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_beli;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nama_barangTextBox;
        private System.Windows.Forms.TextBox jenis_barangTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox hargaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

