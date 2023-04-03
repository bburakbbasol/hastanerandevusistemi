using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje_Hastane
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCNO;
        Sqlbaglantisi con=new  Sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {   
            msktc.Text = TCNO;
            SqlCommand cmd = new SqlCommand("Select * From tbl_Hastalar where HastaTC=@p1",con.baglanti());
            cmd.Parameters.AddWithValue("@p1",msktc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktel.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();   
                cmbcins.Text = dr[6].ToString();
            }
            con.baglanti().Close();
        }

        private void txtsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void msktc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Hastalar Set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6  ", con.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtad.Text);
            cmd.Parameters.AddWithValue("@p2", txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3",msktel.Text);
            cmd.Parameters.AddWithValue("@p4",txtsifre.Text);
            cmd.Parameters.AddWithValue("@p5", cmbcins.Text);
            cmd.Parameters.AddWithValue("@p6", msktc.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
