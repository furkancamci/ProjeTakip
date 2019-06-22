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
    public partial class AnaMenu : Form
    {
        public AnaMenu(string kullanıcıTur)
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            DateTime trh = DateTime.Now;
            DateTime saat = DateTime.Now;
            string tarihvesaat = trh.ToLongDateString()+" "+saat.ToLongTimeString();
            
            label1.Text = tarihvesaat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
                Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjelerForm pf = new ProjelerForm();
            pf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusterilerForm mf = new MusterilerForm();
            mf.ShowDialog();
        }
    }
}
