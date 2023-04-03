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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        Sqlbaglantisi con=new Sqlbaglantisi();
        private void btnkayit_Click(object sender, EventArgs e)
        {       
            SqlCommand cmd = new SqlCommand("Insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtad.Text);
            cmd.Parameters.AddWithValue("@p2",txtsoyad.Text);
            cmd.Parameters.AddWithValue("@p3", msktc.Text);
            cmd.Parameters.AddWithValue("@p4",msktel.Text);
            cmd.Parameters.AddWithValue("@p5", txtsifre.Text);
            cmd.Parameters.AddWithValue("@p6",cmbcins.Text);   
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Kayıdınız Başarıyla Gerçekleşmişdir Şifreniz bu : "+txtsifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
