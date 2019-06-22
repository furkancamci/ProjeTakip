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
    public partial class MusterilerForm : Form
    {
        int musteriID = 0;
        SqlCommandBuilder cbProje;
        SqlDataAdapter daProje;
        DataSet ds;
        SqlConnection sqlcon;
        string sqlStr = @"Data Source=DESKTOP-RUU0N3H;Initial Catalog=ProjeTakip;Integrated Security=SSPI;";
        
        
        public MusterilerForm()
        {
            InitializeComponent();
        }

        private void musterilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musterilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projeTakipDataSet);
            daProje.Update(ds, "Projeler");
            ds.Tables["Projeler"].AcceptChanges();
            projeler();
        }

        private void MusterilerForm_Load(object sender, EventArgs e)
        {
           
            // TODO: Bu kod satırı 'projeTakipDataSet.Musteriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musterilerTableAdapter.Fill(this.projeTakipDataSet.Musteriler);
            projeler();
        }
        public void projeler()
        {
            sqlcon = new SqlConnection(sqlStr);
            musteriID = int.Parse(iDTextBox.Text);
            daProje = new SqlDataAdapter("select Projeler.ID,Projeler.Ad,Projeler.Miktar,Musteriler.Ad,Malzemeler.Tür " + "from Projeler, Musteriler, Malzemeler " +
            $"where Projeler.MusteriID='{musteriID}' And Projeler.MalzemeID= Malzemeler.ID", sqlcon);
            ds = new DataSet();
            daProje.Fill(ds, "Projeler");


            dataGridView1.DataSource = ds.Tables["Projeler"];
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            projeler();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            projeler();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            projeler();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            projeler();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
