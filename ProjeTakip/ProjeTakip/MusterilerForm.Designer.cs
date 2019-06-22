namespace ProjeTakip
{
    partial class MusterilerForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label adLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label adresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusterilerForm));
            this.projeTakipDataSet = new ProjeTakip.ProjeTakipDataSet();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerTableAdapter = new ProjeTakip.ProjeTakipDataSetTableAdapters.MusterilerTableAdapter();
            this.tableAdapterManager = new ProjeTakip.ProjeTakipDataSetTableAdapters.TableAdapterManager();
            this.musterilerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.musterilerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            iDLabel = new System.Windows.Forms.Label();
            adLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projeTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingNavigator)).BeginInit();
            this.musterilerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(47, 51);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.Location = new System.Drawing.Point(47, 77);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(23, 13);
            adLabel.TabIndex = 3;
            adLabel.Text = "Ad:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(47, 103);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(46, 13);
            telefonLabel.TabIndex = 5;
            telefonLabel.Text = "Telefon:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(47, 129);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(37, 13);
            adresLabel.TabIndex = 7;
            adresLabel.Text = "Adres:";
            // 
            // projeTakipDataSet
            // 
            this.projeTakipDataSet.DataSetName = "ProjeTakipDataSet";
            this.projeTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "Musteriler";
            this.musterilerBindingSource.DataSource = this.projeTakipDataSet;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MalzemelerTableAdapter = null;
            this.tableAdapterManager.MusterilerTableAdapter = this.musterilerTableAdapter;
            this.tableAdapterManager.ProjelerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjeTakip.ProjeTakipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // musterilerBindingNavigator
            // 
            this.musterilerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.musterilerBindingNavigator.BindingSource = this.musterilerBindingSource;
            this.musterilerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.musterilerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.musterilerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.musterilerBindingNavigatorSaveItem});
            this.musterilerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.musterilerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.musterilerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.musterilerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.musterilerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.musterilerBindingNavigator.Name = "musterilerBindingNavigator";
            this.musterilerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.musterilerBindingNavigator.Size = new System.Drawing.Size(512, 25);
            this.musterilerBindingNavigator.TabIndex = 0;
            this.musterilerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
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
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // musterilerBindingNavigatorSaveItem
            // 
            this.musterilerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.musterilerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("musterilerBindingNavigatorSaveItem.Image")));
            this.musterilerBindingNavigatorSaveItem.Name = "musterilerBindingNavigatorSaveItem";
            this.musterilerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.musterilerBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.musterilerBindingNavigatorSaveItem.Click += new System.EventHandler(this.musterilerBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(99, 48);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // adTextBox
            // 
            this.adTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Ad", true));
            this.adTextBox.Location = new System.Drawing.Point(99, 74);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 20);
            this.adTextBox.TabIndex = 4;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(99, 100);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonTextBox.TabIndex = 6;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.musterilerBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(99, 126);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 169);
            this.dataGridView1.TabIndex = 10;
            // 
            // MusterilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 333);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(adLabel);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.musterilerBindingNavigator);
            this.Name = "MusterilerForm";
            this.Text = "MusterilerForm";
            this.Load += new System.EventHandler(this.MusterilerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingNavigator)).EndInit();
            this.musterilerBindingNavigator.ResumeLayout(false);
            this.musterilerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjeTakipDataSet projeTakipDataSet;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private ProjeTakipDataSetTableAdapters.MusterilerTableAdapter musterilerTableAdapter;
        private ProjeTakipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator musterilerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton musterilerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}