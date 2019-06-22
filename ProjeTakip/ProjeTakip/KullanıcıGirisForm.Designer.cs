namespace ProjeTakip
{
    partial class KullanıcıGirisForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.KullaniciTurLabel = new System.Windows.Forms.Label();
            this.KullaniciLabel = new System.Windows.Forms.Label();
            this.SifreLabel = new System.Windows.Forms.Label();
            this.GirisButton = new System.Windows.Forms.Button();
            this.VazgecButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // KullaniciTurLabel
            // 
            this.KullaniciTurLabel.AutoSize = true;
            this.KullaniciTurLabel.Location = new System.Drawing.Point(170, 12);
            this.KullaniciTurLabel.Name = "KullaniciTurLabel";
            this.KullaniciTurLabel.Size = new System.Drawing.Size(70, 13);
            this.KullaniciTurLabel.TabIndex = 1;
            this.KullaniciTurLabel.Text = "Kullanıcı       :";
            // 
            // KullaniciLabel
            // 
            this.KullaniciLabel.AutoSize = true;
            this.KullaniciLabel.Location = new System.Drawing.Point(170, 47);
            this.KullaniciLabel.Name = "KullaniciLabel";
            this.KullaniciLabel.Size = new System.Drawing.Size(70, 13);
            this.KullaniciLabel.TabIndex = 2;
            this.KullaniciLabel.Text = "Kullanıcı Adı :";
            // 
            // SifreLabel
            // 
            this.SifreLabel.AutoSize = true;
            this.SifreLabel.Location = new System.Drawing.Point(170, 80);
            this.SifreLabel.Name = "SifreLabel";
            this.SifreLabel.Size = new System.Drawing.Size(73, 13);
            this.SifreLabel.TabIndex = 3;
            this.SifreLabel.Text = "Şifre             : ";
            // 
            // GirisButton
            // 
            this.GirisButton.BackColor = System.Drawing.Color.LimeGreen;
            this.GirisButton.Location = new System.Drawing.Point(173, 129);
            this.GirisButton.Name = "GirisButton";
            this.GirisButton.Size = new System.Drawing.Size(75, 23);
            this.GirisButton.TabIndex = 4;
            this.GirisButton.Text = "Giriş Yap";
            this.GirisButton.UseVisualStyleBackColor = false;
            this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
            // 
            // VazgecButton
            // 
            this.VazgecButton.BackColor = System.Drawing.Color.Red;
            this.VazgecButton.Location = new System.Drawing.Point(300, 129);
            this.VazgecButton.Name = "VazgecButton";
            this.VazgecButton.Size = new System.Drawing.Size(75, 23);
            this.VazgecButton.TabIndex = 5;
            this.VazgecButton.Text = "Vazgeç";
            this.VazgecButton.UseVisualStyleBackColor = false;
            this.VazgecButton.Click += new System.EventHandler(this.VazgecButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjeTakip.Properties.Resources.index;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(294, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Şifre Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KullanıcıGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 220);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VazgecButton);
            this.Controls.Add(this.GirisButton);
            this.Controls.Add(this.SifreLabel);
            this.Controls.Add(this.KullaniciLabel);
            this.Controls.Add(this.KullaniciTurLabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "KullanıcıGirisForm";
            this.Text = "KullanıcıGirisForm";
            this.Load += new System.EventHandler(this.KullanıcıGirisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label KullaniciTurLabel;
        private System.Windows.Forms.Label KullaniciLabel;
        private System.Windows.Forms.Label SifreLabel;
        private System.Windows.Forms.Button GirisButton;
        private System.Windows.Forms.Button VazgecButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}