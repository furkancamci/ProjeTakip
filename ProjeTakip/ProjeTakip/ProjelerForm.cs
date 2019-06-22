using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeTakip
{
    public partial class ProjelerForm : Form
    {       
        SqlCommandBuilder cbProje;        
        SqlDataAdapter daProje;
        DataSet ds;
        SqlConnection sqlcon;
        string sqlStr = @"Data Source=DESKTOP-RUU0N3H;Initial Catalog=ProjeTakip;Integrated Security=SSPI;";
        string sqlCmd = "select Projeler.ID,Projeler.Ad,Projeler.Miktar,Musteriler.Ad,Malzemeler.Tür "+"from Projeler, Musteriler, Malzemeler "+
            "where Projeler.MusteriID=Musteriler.ID And Projeler.MalzemeID= Malzemeler.ID";
        public ProjelerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tüm Projeler Yazdırılacak", "Yazdır", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
                MessageBox.Show("Yazdırılıyor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProjelerForm_Load(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(sqlStr);
            daProje = new SqlDataAdapter(sqlCmd, sqlcon);
            ds = new DataSet();
            daProje.Fill(ds, "Projeler");


            DataColumn[] dcPk = new DataColumn[1];

            dcPk[0] = ds.Tables["Projeler"].Columns["ID"];
            dcPk[0].AutoIncrement = true;
            dcPk[0].AllowDBNull = false;
            ds.Tables["Projeler"].PrimaryKey = dcPk;

            cbProje = new SqlCommandBuilder(daProje);

            dataGridView1.DataSource = ds.Tables["Projeler"];
            dataGridView1.ReadOnly = true;
        }

        private void projelerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }
    }
}
