namespace sembarangKasir
{
    partial class barang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barang));
            System.Windows.Forms.Label nama_barangLabel;
            System.Windows.Forms.Label jenis_barangLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label hargaLabel;
            this.sembarangkasirDataSet = new sembarangKasir.sembarangkasirDataSet();
            this.master_barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_barangTableAdapter = new sembarangKasir.sembarangkasirDataSetTableAdapters.master_barangTableAdapter();
            this.tableAdapterManager = new sembarangKasir.sembarangkasirDataSetTableAdapters.TableAdapterManager();
            this.master_barangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.master_barangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.master_barangDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barangTextBox = new System.Windows.Forms.TextBox();
            this.jenis_barangTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.hargaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            nama_barangLabel = new System.Windows.Forms.Label();
            jenis_barangLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            hargaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sembarangkasirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_barangBindingNavigator)).BeginInit();
            this.master_barangBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_barangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sembarangkasirDataSet
            // 
            this.sembarangkasirDataSet.DataSetName = "sembarangkasirDataSet";
            this.sembarangkasirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // master_barangBindingSource
            // 
            this.master_barangBindingSource.DataMember = "master_barang";
            this.master_barangBindingSource.DataSource = this.sembarangkasirDataSet;
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
            // master_barangBindingNavigator
            // 
            this.master_barangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.master_barangBindingNavigator.BindingSource = this.master_barangBindingSource;
            this.master_barangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.master_barangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.master_barangBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.master_barangBindingNavigatorSaveItem});
            this.master_barangBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.master_barangBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.master_barangBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.master_barangBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.master_barangBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.master_barangBindingNavigator.Name = "master_barangBindingNavigator";
            this.master_barangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.master_barangBindingNavigator.Size = new System.Drawing.Size(604, 25);
            this.master_barangBindingNavigator.TabIndex = 0;
            this.master_barangBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // master_barangBindingNavigatorSaveItem
            // 
            this.master_barangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.master_barangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("master_barangBindingNavigatorSaveItem.Image")));
            this.master_barangBindingNavigatorSaveItem.Name = "master_barangBindingNavigatorSaveItem";
            this.master_barangBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.master_barangBindingNavigatorSaveItem.Text = "Save Data";
            this.master_barangBindingNavigatorSaveItem.Click += new System.EventHandler(this.master_barangBindingNavigatorSaveItem_Click);
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
            this.master_barangDataGridView.DataSource = this.master_barangBindingSource;
            this.master_barangDataGridView.Location = new System.Drawing.Point(0, 23);
            this.master_barangDataGridView.Name = "master_barangDataGridView";
            this.master_barangDataGridView.RowHeadersWidth = 100;
            this.master_barangDataGridView.Size = new System.Drawing.Size(604, 242);
            this.master_barangDataGridView.TabIndex = 1;
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
            // nama_barangLabel
            // 
            nama_barangLabel.AutoSize = true;
            nama_barangLabel.ForeColor = System.Drawing.SystemColors.Control;
            nama_barangLabel.Location = new System.Drawing.Point(5, 290);
            nama_barangLabel.Name = "nama_barangLabel";
            nama_barangLabel.Size = new System.Drawing.Size(72, 13);
            nama_barangLabel.TabIndex = 4;
            nama_barangLabel.Text = "nama barang:";
            // 
            // nama_barangTextBox
            // 
            this.nama_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_barangBindingSource, "nama_barang", true));
            this.nama_barangTextBox.Location = new System.Drawing.Point(83, 287);
            this.nama_barangTextBox.Name = "nama_barangTextBox";
            this.nama_barangTextBox.Size = new System.Drawing.Size(186, 20);
            this.nama_barangTextBox.TabIndex = 5;
            // 
            // jenis_barangLabel
            // 
            jenis_barangLabel.AutoSize = true;
            jenis_barangLabel.ForeColor = System.Drawing.SystemColors.Control;
            jenis_barangLabel.Location = new System.Drawing.Point(5, 316);
            jenis_barangLabel.Name = "jenis_barangLabel";
            jenis_barangLabel.Size = new System.Drawing.Size(67, 13);
            jenis_barangLabel.TabIndex = 6;
            jenis_barangLabel.Text = "jenis barang:";
            // 
            // jenis_barangTextBox
            // 
            this.jenis_barangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_barangBindingSource, "jenis_barang", true));
            this.jenis_barangTextBox.Location = new System.Drawing.Point(83, 313);
            this.jenis_barangTextBox.Name = "jenis_barangTextBox";
            this.jenis_barangTextBox.Size = new System.Drawing.Size(186, 20);
            this.jenis_barangTextBox.TabIndex = 7;
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.ForeColor = System.Drawing.SystemColors.Control;
            stockLabel.Location = new System.Drawing.Point(294, 290);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(36, 13);
            stockLabel.TabIndex = 8;
            stockLabel.Text = "stock:";
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_barangBindingSource, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(372, 287);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(220, 20);
            this.stockTextBox.TabIndex = 9;
            // 
            // hargaLabel
            // 
            hargaLabel.AutoSize = true;
            hargaLabel.ForeColor = System.Drawing.SystemColors.Control;
            hargaLabel.Location = new System.Drawing.Point(294, 316);
            hargaLabel.Name = "hargaLabel";
            hargaLabel.Size = new System.Drawing.Size(37, 13);
            hargaLabel.TabIndex = 10;
            hargaLabel.Text = "harga:";
            // 
            // hargaTextBox
            // 
            this.hargaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_barangBindingSource, "harga", true));
            this.hargaTextBox.Location = new System.Drawing.Point(372, 313);
            this.hargaTextBox.Name = "hargaTextBox";
            this.hargaTextBox.Size = new System.Drawing.Size(220, 20);
            this.hargaTextBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(548, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(604, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(nama_barangLabel);
            this.Controls.Add(this.nama_barangTextBox);
            this.Controls.Add(jenis_barangLabel);
            this.Controls.Add(this.jenis_barangTextBox);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(hargaLabel);
            this.Controls.Add(this.hargaTextBox);
            this.Controls.Add(this.master_barangDataGridView);
            this.Controls.Add(this.master_barangBindingNavigator);
            this.Name = "barang";
            this.Text = "barang";
            this.Load += new System.EventHandler(this.barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sembarangkasirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_barangBindingNavigator)).EndInit();
            this.master_barangBindingNavigator.ResumeLayout(false);
            this.master_barangBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_barangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sembarangkasirDataSet sembarangkasirDataSet;
        private System.Windows.Forms.BindingSource master_barangBindingSource;
        private sembarangkasirDataSetTableAdapters.master_barangTableAdapter master_barangTableAdapter;
        private sembarangkasirDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator master_barangBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton master_barangBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView master_barangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox nama_barangTextBox;
        private System.Windows.Forms.TextBox jenis_barangTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox hargaTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}