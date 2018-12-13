namespace sembarangKasir
{
    partial class restock
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
            System.Windows.Forms.Label tanggalLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label id_barangLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(restock));
            this.sembarangkasirDataSet = new sembarangKasir.sembarangkasirDataSet();
            this.master_restockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_restockTableAdapter = new sembarangKasir.sembarangkasirDataSetTableAdapters.master_restockTableAdapter();
            this.tableAdapterManager = new sembarangKasir.sembarangkasirDataSetTableAdapters.TableAdapterManager();
            this.master_barangTableAdapter = new sembarangKasir.sembarangkasirDataSetTableAdapters.master_barangTableAdapter();
            this.master_restockBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.master_restockBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.master_restockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.id_barangComboBox = new System.Windows.Forms.ComboBox();
            this.masterbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterrestockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            tanggalLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            id_barangLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sembarangkasirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_restockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_restockBindingNavigator)).BeginInit();
            this.master_restockBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_restockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterrestockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tanggalLabel
            // 
            tanggalLabel.AutoSize = true;
            tanggalLabel.ForeColor = System.Drawing.SystemColors.Control;
            tanggalLabel.Location = new System.Drawing.Point(7, 420);
            tanggalLabel.Name = "tanggalLabel";
            tanggalLabel.Size = new System.Drawing.Size(45, 13);
            tanggalLabel.TabIndex = 6;
            tanggalLabel.Text = "tanggal:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.ForeColor = System.Drawing.SystemColors.Control;
            qtyLabel.Location = new System.Drawing.Point(7, 445);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(24, 13);
            qtyLabel.TabIndex = 8;
            qtyLabel.Text = "qty:";
            // 
            // id_barangLabel
            // 
            id_barangLabel.AutoSize = true;
            id_barangLabel.ForeColor = System.Drawing.SystemColors.Control;
            id_barangLabel.Location = new System.Drawing.Point(7, 390);
            id_barangLabel.Name = "id_barangLabel";
            id_barangLabel.Size = new System.Drawing.Size(54, 13);
            id_barangLabel.TabIndex = 9;
            id_barangLabel.Text = "id barang:";
            // 
            // sembarangkasirDataSet
            // 
            this.sembarangkasirDataSet.DataSetName = "sembarangkasirDataSet";
            this.sembarangkasirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // master_restockBindingSource
            // 
            this.master_restockBindingSource.DataMember = "master_restock";
            this.master_restockBindingSource.DataSource = this.sembarangkasirDataSet;
            // 
            // master_restockTableAdapter
            // 
            this.master_restockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.master_barangTableAdapter = this.master_barangTableAdapter;
            this.tableAdapterManager.master_restockTableAdapter = this.master_restockTableAdapter;
            this.tableAdapterManager.master_userTableAdapter = null;
            this.tableAdapterManager.transaksiTableAdapter = null;
            this.tableAdapterManager.uang_transaksiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sembarangKasir.sembarangkasirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // master_barangTableAdapter
            // 
            this.master_barangTableAdapter.ClearBeforeFill = true;
            // 
            // master_restockBindingNavigator
            // 
            this.master_restockBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.master_restockBindingNavigator.BindingSource = this.master_restockBindingSource;
            this.master_restockBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.master_restockBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.master_restockBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.master_restockBindingNavigatorSaveItem});
            this.master_restockBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.master_restockBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.master_restockBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.master_restockBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.master_restockBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.master_restockBindingNavigator.Name = "master_restockBindingNavigator";
            this.master_restockBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.master_restockBindingNavigator.Size = new System.Drawing.Size(604, 25);
            this.master_restockBindingNavigator.TabIndex = 0;
            this.master_restockBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // master_restockBindingNavigatorSaveItem
            // 
            this.master_restockBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.master_restockBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("master_restockBindingNavigatorSaveItem.Image")));
            this.master_restockBindingNavigatorSaveItem.Name = "master_restockBindingNavigatorSaveItem";
            this.master_restockBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.master_restockBindingNavigatorSaveItem.Text = "Save Data";
            this.master_restockBindingNavigatorSaveItem.Click += new System.EventHandler(this.master_restockBindingNavigatorSaveItem_Click);
            // 
            // master_restockDataGridView
            // 
            this.master_restockDataGridView.AutoGenerateColumns = false;
            this.master_restockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.master_restockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.master_restockDataGridView.DataSource = this.master_restockBindingSource;
            this.master_restockDataGridView.Location = new System.Drawing.Point(0, 23);
            this.master_restockDataGridView.Name = "master_restockDataGridView";
            this.master_restockDataGridView.RowHeadersWidth = 200;
            this.master_restockDataGridView.Size = new System.Drawing.Size(604, 345);
            this.master_restockDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_barang";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_barang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tanggal";
            this.dataGridViewTextBoxColumn3.HeaderText = "tanggal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tanggalDateTimePicker
            // 
            this.tanggalDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.master_restockBindingSource, "tanggal", true));
            this.tanggalDateTimePicker.Location = new System.Drawing.Point(67, 416);
            this.tanggalDateTimePicker.Name = "tanggalDateTimePicker";
            this.tanggalDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.tanggalDateTimePicker.TabIndex = 7;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.master_restockBindingSource, "qty", true));
            this.qtyTextBox.Location = new System.Drawing.Point(67, 442);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(200, 20);
            this.qtyTextBox.TabIndex = 9;
            // 
            // id_barangComboBox
            // 
            this.id_barangComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.master_restockBindingSource, "id_barang", true));
            this.id_barangComboBox.DataSource = this.masterbarangBindingSource;
            this.id_barangComboBox.DisplayMember = "nama_barang";
            this.id_barangComboBox.FormattingEnabled = true;
            this.id_barangComboBox.Location = new System.Drawing.Point(67, 387);
            this.id_barangComboBox.Name = "id_barangComboBox";
            this.id_barangComboBox.Size = new System.Drawing.Size(200, 21);
            this.id_barangComboBox.TabIndex = 10;
            this.id_barangComboBox.ValueMember = "id";
            // 
            // masterbarangBindingSource
            // 
            this.masterbarangBindingSource.DataMember = "master_barang";
            this.masterbarangBindingSource.DataSource = this.sembarangkasirDataSet;
            // 
            // masterrestockBindingSource
            // 
            this.masterrestockBindingSource.DataMember = "master_restock";
            this.masterrestockBindingSource.DataSource = this.sembarangkasirDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(549, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(604, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(id_barangLabel);
            this.Controls.Add(this.id_barangComboBox);
            this.Controls.Add(tanggalLabel);
            this.Controls.Add(this.tanggalDateTimePicker);
            this.Controls.Add(qtyLabel);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.master_restockDataGridView);
            this.Controls.Add(this.master_restockBindingNavigator);
            this.Name = "restock";
            this.Text = "restock";
            this.Load += new System.EventHandler(this.restock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sembarangkasirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_restockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.master_restockBindingNavigator)).EndInit();
            this.master_restockBindingNavigator.ResumeLayout(false);
            this.master_restockBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.master_restockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterrestockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sembarangkasirDataSet sembarangkasirDataSet;
        private System.Windows.Forms.BindingSource master_restockBindingSource;
        private sembarangkasirDataSetTableAdapters.master_restockTableAdapter master_restockTableAdapter;
        private sembarangkasirDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator master_restockBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton master_restockBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView master_restockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private sembarangkasirDataSetTableAdapters.master_barangTableAdapter master_barangTableAdapter;
        private System.Windows.Forms.DateTimePicker tanggalDateTimePicker;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.ComboBox id_barangComboBox;
        private System.Windows.Forms.BindingSource masterbarangBindingSource;
        private System.Windows.Forms.BindingSource masterrestockBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}