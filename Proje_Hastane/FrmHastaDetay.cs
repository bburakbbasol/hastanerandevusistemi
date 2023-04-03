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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            /*SqlDataAdapter ve SqlDataReader, C# ile SQL Server veritabanları arasında veri alışverişi yapmak için kullanılan iki farklı sınıftır. 
             * Bu sınıfların kullanım amaçları ve özellikleri farklıdır. İşte farklılıklar:

            Kullanım Amacı: SqlDataAdapter, veritabanından veri çekme ve DataTable, DataSet vb. veri yapılarına doldurma işlemlerinde kullanılır.
            SqlDataReader ise bir veri okuyucusudur ve bir SQL sorgusunun sonuçlarını okumak için kullanılır.

            Veri Doldurma: SqlDataAdapter, veritabanından verileri çekerek DataTable, DataSet vb.veri yapılarına doldurur.
            SqlDataReader ise veri okuyucusu olduğu için, sorgunun sonuçlarını tek tek okur.

            Bağlantı: SqlDataAdapter, bir SqlConnection nesnesine ihtiyaç duyar ve bu nesneyi yönetir.SqlDataReader ise bir SqlCommand nesnesine ihtiyaç duyar 
            ve bu nesne tarafından yönetilir.

            Veri Güncelleme: SqlDataAdapter, veri yapılarında değişiklik yapıldığında veritabanındaki verileri güncelleme işlemlerinde kullanılabilir.
            Ancak SqlDataReader, sadece veri okumak için kullanılabilir, verileri güncelleme işlemi yapamaz.

            Performans: SqlDataReader, verileri tek tek okuduğu için, çok büyük veri kümelerinde performanslı bir şekilde çalışır. SqlDataAdapter,
            tüm verileri bir veri yapısına yüklediği için, büyük veri kümelerinde performans sorunlarına neden olabilir.

            Özetle, SqlDataAdapter veritabanından veri çekme ve veri yapılarına doldurma işlemleri için kullanılırken, 
            SqlDataReader sadece veri okuma işlemleri için kullanılır.SqlDataAdapter, bir veritabanı bağlantısı yönetirken SqlDataReader, 
            bir SQL sorgusu sonucu dönen verileri tek tek okur.*/

        }
        public string tc;//değişken tanımladık evrensel 
        Sqlbaglantisi con=new Sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {   
            //Ad Soyad çekme
            lbltc.Text = tc;
            SqlCommand cmd = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1 ", con.baglanti());
            cmd.Parameters.AddWithValue("@p1",tc);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];//Bir tane string ifade olduğu için stringe çevirme ihtiyaci duymadık

            }
            con.baglanti().Close();
            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=@p1",con.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", tc);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //Brans Listesi
            SqlCommand cmd2 = new SqlCommand(" Select BransAd From Table_Brans",con.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read()) 
            {
                cmbdoktor.Items.Add( dr[0] + " " + dr[1]);
            
            
            }
            con.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevurBrans='"+cmbbrans.Text+"'"+"and RandevuDoktor='"+cmbdoktor.Text+"'and RandevuDurum=0",con.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkbilgiduzen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr=new FrmBilgiDuzenle();
           
            fr.TCNO = lbltc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where Randevuid=@p3",con.baglanti());
            cmd.Parameters.AddWithValue("@p1", tc);
            cmd.Parameters.AddWithValue("@p2",richTextsikayet.Text);
            cmd.Parameters.AddWithValue("@P3", textid.Text);
            cmd.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Randevu alınmıştır","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
