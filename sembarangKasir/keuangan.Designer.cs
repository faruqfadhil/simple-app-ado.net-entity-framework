namespace sembarangKasir
{
    partial class keuangan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(keuangan));
            this.sembarangkasirDataSet = new sembarangKasir.sembarangkasirDataSet();
            this.uang_transaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uang_transaksiTableAdapter = new sembarangKasir.sembarangkasirDataSetTableAdapters.uang_transaksiTableAdapter();
            this.tableAdapterManager = new sembarangKasir.sembarangkasirDataSetTableAdapters.TableAdapterManager();
            this.uang_transaksiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sembarangkasirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uang_transaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uang_transaksiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sembarangkasirDataSet
            // 
            this.sembarangkasirDataSet.DataSetName = "sembarangkasirDataSet";
            this.sembarangkasirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uang_transaksiBindingSource
            // 
            this.uang_transaksiBindingSource.DataMember = "uang_transaksi";
            this.uang_transaksiBindingSource.DataSource = this.sembarangkasirDataSet;
            // 
            // uang_transaksiTableAdapter
            // 
            this.uang_transaksiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.master_barangTableAdapter = null;
            this.tableAdapterManager.master_restockTableAdapter = null;
            this.tableAdapterManager.master_userTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = null;
            this.tableAdapterManager.uang_transaksiTableAdapter = this.uang_transaksiTableAdapter;
            this.tableAdapterManager.UpdateOrder = sembarangKasir.sembarangkasirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uang_transaksiDataGridView
            // 
            this.uang_transaksiDataGridView.AutoGenerateColumns = false;
            this.uang_transaksiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uang_transaksiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.uang_transaksiDataGridView.DataSource = this.uang_transaksiBindingSource;
            this.uang_transaksiDataGridView.Location = new System.Drawing.Point(0, 61);
            this.uang_transaksiDataGridView.Name = "uang_transaksiDataGridView";
            this.uang_transaksiDataGridView.RowHeadersWidth = 286;
            this.uang_transaksiDataGridView.Size = new System.Drawing.Size(588, 281);
            this.uang_transaksiDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_transaksi";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_transaksi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "income";
            this.dataGridViewTextBoxColumn3.HeaderText = "income";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(533, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pemasukan";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_total.Location = new System.Drawing.Point(120, 19);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(19, 20);
            this.lb_total.TabIndex = 15;
            this.lb_total.Text = "d";
            // 
            // keuangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(588, 411);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uang_transaksiDataGridView);
            this.Name = "keuangan";
            this.Text = "keuangan";
            this.Load += new System.EventHandler(this.keuangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sembarangkasirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uang_transaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uang_transaksiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sembarangkasirDataSet sembarangkasirDataSet;
        private System.Windows.Forms.BindingSource uang_transaksiBindingSource;
        private sembarangkasirDataSetTableAdapters.uang_transaksiTableAdapter uang_transaksiTableAdapter;
        private sembarangkasirDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView uang_transaksiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_total;
    }
}