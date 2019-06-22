namespace ProjeTakip
{
    partial class ProjelerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.projeTakipDataSet = new ProjeTakip.ProjeTakipDataSet();
            this.projelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projelerTableAdapter = new ProjeTakip.ProjeTakipDataSetTableAdapters.ProjelerTableAdapter();
            this.tableAdapterManager = new ProjeTakip.ProjeTakipDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.projeTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Geri Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // projeTakipDataSet
            // 
            this.projeTakipDataSet.DataSetName = "ProjeTakipDataSet";
            this.projeTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projelerBindingSource
            // 
            this.projelerBindingSource.DataMember = "Projeler";
            this.projelerBindingSource.DataSource = this.projeTakipDataSet;
            // 
            // projelerTableAdapter
            // 
            this.projelerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MalzemelerTableAdapter = null;
            this.tableAdapterManager.MusterilerTableAdapter = null;
            this.tableAdapterManager.ProjelerTableAdapter = this.projelerTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjeTakip.ProjeTakipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 263);
            this.dataGridView1.TabIndex = 2;
            // 
            // ProjelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 348);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ProjelerForm";
            this.Text = "ProjelerForm";
            this.Load += new System.EventHandler(this.ProjelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projeTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private ProjeTakipDataSet projeTakipDataSet;
        private System.Windows.Forms.BindingSource projelerBindingSource;
        private ProjeTakipDataSetTableAdapters.ProjelerTableAdapter projelerTableAdapter;
        private ProjeTakipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}