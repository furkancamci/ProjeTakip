namespace ProjeTakip
{
    partial class Projetakip
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.HakkımızdaTextbox = new System.Windows.Forms.TextBox();
            this.CıkısButton = new System.Windows.Forms.Button();
            this.Girisbutton = new System.Windows.Forms.Button();
            this.Hakkımızda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HakkımızdaTextbox
            // 
            this.HakkımızdaTextbox.Location = new System.Drawing.Point(31, 91);
            this.HakkımızdaTextbox.Multiline = true;
            this.HakkımızdaTextbox.Name = "HakkımızdaTextbox";
            this.HakkımızdaTextbox.ReadOnly = true;
            this.HakkımızdaTextbox.Size = new System.Drawing.Size(422, 92);
            this.HakkımızdaTextbox.TabIndex = 0;
            this.HakkımızdaTextbox.Text = "Hakkımızda";
            // 
            // CıkısButton
            // 
            this.CıkısButton.Location = new System.Drawing.Point(281, 12);
            this.CıkısButton.Name = "CıkısButton";
            this.CıkısButton.Size = new System.Drawing.Size(75, 23);
            this.CıkısButton.TabIndex = 2;
            this.CıkısButton.Text = "Çıkış";
            this.CıkısButton.UseVisualStyleBackColor = true;
            this.CıkısButton.Click += new System.EventHandler(this.CıkısButton_Click);
            // 
            // Girisbutton
            // 
            this.Girisbutton.Location = new System.Drawing.Point(94, 12);
            this.Girisbutton.Name = "Girisbutton";
            this.Girisbutton.Size = new System.Drawing.Size(75, 23);
            this.Girisbutton.TabIndex = 3;
            this.Girisbutton.Text = "Giriş";
            this.Girisbutton.UseVisualStyleBackColor = true;
            this.Girisbutton.Click += new System.EventHandler(this.Girisbutton_Click);
            // 
            // Hakkımızda
            // 
            this.Hakkımızda.Location = new System.Drawing.Point(190, 12);
            this.Hakkımızda.Name = "Hakkımızda";
            this.Hakkımızda.Size = new System.Drawing.Size(75, 23);
            this.Hakkımızda.TabIndex = 4;
            this.Hakkımızda.Text = "Hakkımızda";
            this.Hakkımızda.UseVisualStyleBackColor = true;
            this.Hakkımızda.Click += new System.EventHandler(this.Hakkımızda_Click);
            // 
            // Projetakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(478, 220);
            this.Controls.Add(this.Hakkımızda);
            this.Controls.Add(this.Girisbutton);
            this.Controls.Add(this.CıkısButton);
            this.Controls.Add(this.HakkımızdaTextbox);
            this.Name = "Projetakip";
            this.Text = "Proje Takip";
            this.Load += new System.EventHandler(this.Projetakip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HakkımızdaTextbox;
        private System.Windows.Forms.Button CıkısButton;
        private System.Windows.Forms.Button Girisbutton;
        private System.Windows.Forms.Button Hakkımızda;
    }
}

