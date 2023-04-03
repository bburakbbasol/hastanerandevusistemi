using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmBrans2 : Form
    {
        public FrmBrans2()
        {
            InitializeComponent();
        }
        Sqlbaglantisi con=new Sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter("Select * From Table_Brans",con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;  
            con.baglanti().Close();
        }
        private void FrmBrans2_Load(object sender, EventArgs e)

        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Table_Brans(BransAd) values(@p1)",con.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtbransad.Text);
            cmd.ExecuteNonQuery();
            listele();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete  From Table_Brans where BransId=@p1 ", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtad.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Table_Brans Set BransAd=@p1 where BransId=@p2",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtbransad.Text);
            cmd.Parameters.AddWithValue("@p2", txtad.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close(); 
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
