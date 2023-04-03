using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        Sqlbaglantisi con=new Sqlbaglantisi();
        public string drtc;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1", con.baglanti());
            cmd.Parameters.AddWithValue("@p1", drtc);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label2.Text = dr[4].ToString();
                label4.Text = dr[1] + " " + dr[2];
            }
            con.baglanti().Close();
            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+label4.Text+"'",con.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnbilgidüzen_Click(object sender, EventArgs e)
        {
            FrmDokotorBilgiDüzenle2 frm=new FrmDokotorBilgiDüzenle2();
            frm.TCNO = drtc;
            frm.ShowDialog();
             
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDUyurular2 frm =new FrmDUyurular2();
            frm.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rcvhsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();  
         }
    }
}
