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
    public partial class FrmSekreterGiris2 : Form
    {
        public FrmSekreterGiris2()
        {
            InitializeComponent();
        }
        Sqlbaglantisi con=new Sqlbaglantisi();
        string adısoyadı = "";
        private void btngiris_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd=new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", msktc.Text);
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);
           // cmd.Parameters.AddWithValue("@p3", adısoyadı);
            SqlDataReader dr=cmd.ExecuteReader();
           
            
            if (dr.Read())
            {
                SekreterDetay2 frm=new SekreterDetay2();
                frm.tcno = msktc.Text;
               //frm.adsoy = adısoyadı;
                
                
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void FrmSekreterGiris2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
