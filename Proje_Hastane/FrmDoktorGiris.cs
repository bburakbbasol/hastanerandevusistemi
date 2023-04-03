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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi con=new Sqlbaglantisi();
        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

            

        }

        private void btngiris_Click(object sender, EventArgs e)
        {



            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", msktc.Text);
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.drtc=msktc.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.baglanti().Close();
        }
    }
}
