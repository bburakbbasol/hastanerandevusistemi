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

namespace Proje_Hastane
{
    public partial class FrmDokotorBilgiDüzenle2 : Form
    {
        public FrmDokotorBilgiDüzenle2()
        {
            InitializeComponent();
        }
        public string TCNO;
        Sqlbaglantisi con=new Sqlbaglantisi();
        private void FrmDokotorBilgiDüzenle2_Load(object sender, EventArgs e)
        {
            
            msktc.Text=TCNO;  
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc="+msktc.Text,con.baglanti());
            SqlDataReader dr = cmd.ExecuteReader(); 
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                comboBrans.Text= dr[3].ToString();
                txtsifre.Text= dr[5].ToString();

            }
            con.baglanti().Close();

        }

        private void btnkayit_Click(object sender, EventArgs e)
        {
            SqlCommand cmd=new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc="+msktc.Text,con.baglanti());
            cmd.Parameters.AddWithValue("@p1",txtad.Text);
            cmd.Parameters.AddWithValue("@p2",txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3",comboBrans.Text);
            cmd.Parameters.AddWithValue("@p4",txtsifre.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
