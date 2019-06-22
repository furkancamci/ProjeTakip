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
    public partial class Projetakip : Form
    {
        public Projetakip()
        {
            InitializeComponent();
        }

        private void CıkısButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Close();
        }

        private void Girisbutton_Click(object sender, EventArgs e)
        {
            KullanıcıGirisForm kg = new KullanıcıGirisForm();
            kg.ShowDialog();
        }

        private void Projetakip_Load(object sender, EventArgs e)
        {
            HakkımızdaTextbox.Enabled = false;
            HakkımızdaTextbox.Visible = false;
            HakkımızdaTextbox.Text = "Güler Peyzaj olarak 2013 yılından bu yana İstanbul'un asya ve avrupa yakasında hizmet veren bir şirketiz." +
                " 6 yıldır müşterilerimiz daha güzel ortamlarda hayatlarını sürdürsünler diye çalışıyoruz. " +
                " Sizin isteklerinize göre çevrenizi güzelleştirmeye çalışıyor ve sizlere daha yaşanabilir ortamlar hazırlıyoruz." +
                " Ayrıca düzenlediğimiz bahçelerinizi, parklarınızı vb. belirli periyotlarla kontrol ederek bakımlarını yapıyoruz."+
                " Kaliteli projeler ve çözümler üreten bir firmayız. İletişim Adresimiz : gülerpeyzaj@gmail.com";
        }

        private void Hakkımızda_Click(object sender, EventArgs e)
        {
            if (HakkımızdaTextbox.Visible == false)
                HakkımızdaTextbox.Visible = true;
            else
                HakkımızdaTextbox.Visible = false;
        }
    }
}
