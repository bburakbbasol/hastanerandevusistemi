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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi con=new Sqlbaglantisi();
        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt frm = new FrmHastaKayıt();
            frm.Show();
            
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", msktc.Text);
            cmd.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                FrmHastaDetay fr=new FrmHastaDetay();
                fr.tc=msktc.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış Şifre Veya Yanlış TC girdiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }
            con.baglanti().Close();
        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
