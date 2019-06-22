using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeTakip
{
    public partial class KullanıcıGirisForm : Form
    {
        List<Kisi> kisiler = new List<Kisi>();
        string ad = "";
        string sifre = "";
        string kullanıcıTur = "";
        int sayac = 0;
        public KullanıcıGirisForm()
        {
            InitializeComponent();
            Kisi yönetici = new Kisi("Furkan Camcı",001,"1234");
            Kisi çalışan = new Kisi("Ahmet Genç", 101, "12345");
            kisiler.Add(yönetici);
            kisiler.Add(çalışan);



        }

        private void VazgecButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yönetici")
                kullanıcıTur = comboBox1.Text;


        }

        private void KullanıcıGirisForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Yönetici");
            comboBox1.Items.Add("Çalışan");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad = textBox1.Text;
            textBox1.MaxLength = 25;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sifre = textBox2.Text;
            textBox2.MaxLength = 10;
            textBox2.PasswordChar = '*';

        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
             sayac++;
            bool find = false;
            if (sayac == 3)
            {
                MessageBox.Show("3 Defa Hatalı Giriş Yapıldı");
                Close();
            }
            else
            {
                foreach (Kisi ks in kisiler)
                {
                    if (ks.Ad.ToLower() == textBox1.Text.ToLower()
                        && ks.Sifre == textBox2.Text)
                    {
                        MessageBox.Show("Hoşgeldiniz", ks.Ad,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AnaMenu AnaMenu = new AnaMenu(kullanıcıTur);
                        AnaMenu.ShowDialog();
                        find = true;
                    }


                }
                if (find == false)
                    MessageBox.Show($"{sayac}. Hatalı Kullanıcı adı veya Şifre\nKalan Hakkınız: {3 - sayac}",
                  "HATA",
                 MessageBoxButtons.RetryCancel,
                 MessageBoxIcon.Hand);


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }
    }
}
