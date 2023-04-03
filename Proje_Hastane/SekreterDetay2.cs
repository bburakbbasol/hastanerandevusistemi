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
    public partial class SekreterDetay2 : Form
    {
        public SekreterDetay2()
        {
            InitializeComponent();
        }
        public string tcno,adsoy;
        Sqlbaglantisi con =new Sqlbaglantisi();

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd=new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevurBrans,RandevuDoktor)values(@r1,@r2,@r3,@r4)",con.baglanti());
            cmd.Parameters.AddWithValue("@r1", msktarih.Text);
            cmd.Parameters.AddWithValue("@r2", msksaat.Text);
            cmd.Parameters.AddWithValue("@r3", combobrans.Text);
            cmd.Parameters.AddWithValue("@r4",combodoktor.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Randevu Başarılı bir şekilde Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void combobrans_SelectedIndexChanged(object sender, EventArgs e)
        {   
            combodoktor.Items.Clear();
            SqlCommand cmdb = new SqlCommand(" Select DoktorAd,DoktorSoyAd From Tbl_Doktorlar where DoktorBrans=@p1", con.baglanti());
            cmdb.Parameters.AddWithValue("@p1",combobrans.Text);
            SqlDataReader drb= cmdb.ExecuteReader();
            while (drb.Read())
            {
                combodoktor.Items.Add(drb[0] + " " + drb[1]);

            }
            con.baglanti().Close();


        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Duyurular (duyurular)values (@d1)", con.baglanti());
            cmd.Parameters.AddWithValue("@d1", richTextBox1.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();


        }

        private void btndoktorpan_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli2 frm = new FrmDoktorPaneli2();
            frm.Show();
        }

        private void btnbranspan_Click(object sender, EventArgs e)
        {
            FrmBrans2 frm=new FrmBrans2();
            frm.Show();
        }

        private void btnrandevupan_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi2 frm=new FrmRandevuListesi2();
            frm.Show();
          
        }
        
        private void btnguncel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd=new SqlCommand("Update Tbl_Randevular Set RandevuTarih=@p1,RandevuSaat=@p2,RandevurBrans=@p3,RandevuDoktor=@p4,HastaTC=@p5 where Randevuid=@p0", con.baglanti());
            cmd.Parameters.AddWithValue("@p0", txtid.Text);
            cmd.Parameters.AddWithValue("@p1", msktarih.Text);
            cmd.Parameters.AddWithValue("@p2", msksaat.Text);
            cmd.Parameters.AddWithValue("@p3", combobrans.Text);
            cmd.Parameters.AddWithValue("@p4", combodoktor.Text);
            cmd.Parameters.AddWithValue("@p5",msktcno.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Randevu Başarılı bir şekilde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmRandevuListesi2 fr=new FrmRandevuListesi2();
           
            fr.Show();

        }

        private void dataGridViewDoktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public string rid , rtarih , rsaat, rbrans , rdoktor, rtc;

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDUyurular2 fr=new FrmDUyurular2();
            fr.Show();
        }

        private void SekreterDetay2_Load(object sender, EventArgs e)
        {
            txtid.Text = rid;
            msktarih.Text = rtarih;
            msksaat.Text = rsaat;
            combobrans.Text = rbrans;
            combodoktor.Text = rdoktor;
            msktcno.Text = rtc;



            labeltc.Text = tcno;
            SqlCommand cmd = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1",labeltc.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                labeladsoy.Text = dr[0].ToString();
            }
            con.baglanti().Close();

            
            //Ad Brans Tablosu
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Brans",con.baglanti());
            da.Fill(dt);
            dataGridViewBrans.DataSource = dt;
            // Doktor veri çekme
            DataTable dt2=new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as ' Doktorlar ',DoktorBrans From Tbl_Doktorlar", con.baglanti());
            da2.Fill(dt2);
            dataGridViewDoktor.DataSource = dt2;

            //ComboBox a Branş ekleme
            SqlCommand cmdbrans = new SqlCommand("Select(BransAd) From Table_Brans ", con.baglanti());
            SqlDataReader drbrans = cmdbrans.ExecuteReader();
            while (drbrans.Read())
            {

                combobrans.Items.Add(drbrans[0]);


            }

            con.baglanti().Close();
        }
    }
}
