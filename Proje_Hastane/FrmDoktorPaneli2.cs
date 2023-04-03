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
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmDoktorPaneli2 : Form
    {
        public FrmDoktorPaneli2()
        {
            InitializeComponent();
        }
        Sqlbaglantisi con=new Sqlbaglantisi();
        void listele()
        {

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Doktorlar", con.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void FrmDoktorPaneli2_Load(object sender, EventArgs e)
        {
            listele();
            con.baglanti().Close();


            //ComboBox'a Branş ekleme
            
            comboBox1.Items.Clear();

            SqlCommand cmdx=new SqlCommand("Select * From Table_Brans",con.baglanti());
            SqlDataReader drx = cmdx.ExecuteReader();
            while (drx.Read())
            {
                comboBox1.Items.Add(drx[1].ToString());
            }
            con.baglanti().Close();
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar(DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values(@dr1,@dr2,@dr3,@dr4,@dr5)",con.baglanti());
            cmd.Parameters.AddWithValue("@dr1", txtad.Text);
            cmd.Parameters.AddWithValue("@dr2",textsoyad.Text);
            cmd.Parameters.AddWithValue("@dr3", comboBox1.Text);
            cmd.Parameters.AddWithValue("@dr4",maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@dr5",textsifre.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC=@dr1", con.baglanti());
            cmd.Parameters.AddWithValue("@dr1", maskedTextBox1.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            labeliid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            
            

        }

        private void buttonguncel_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@dr1,DoktorSoyad=@dr2,DoktorBrans=@dr3,DoktorTc=@dr4,DoktorSifre=@dr5 where Doktorid=@dr6 ", con.baglanti());
            cmd.Parameters.AddWithValue("@dr1", txtad.Text);
            cmd.Parameters.AddWithValue("@dr2", textsoyad.Text);
            cmd.Parameters.AddWithValue("@dr3", comboBox1.Text);
            cmd.Parameters.AddWithValue("@dr4", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@dr5", textsifre.Text);
            cmd.Parameters.AddWithValue("@dr6",labeliid.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
