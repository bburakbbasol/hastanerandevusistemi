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
using System.Data.Common;
using System.Security.Cryptography;

namespace Proje_Hastane
{
    public partial class FrmRandevuListesi2 : Form
    {
        public FrmRandevuListesi2()
        {
            InitializeComponent();
        }
            Sqlbaglantisi con=new Sqlbaglantisi();
        private void FrmRandevuListesi2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular ", con.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
         
       
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            SekreterDetay2 fr = new SekreterDetay2();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            fr.rid = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.rtarih = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.rsaat = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.rbrans = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.rdoktor = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.rtc = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            
            fr.Hide();
            fr.ShowDialog();
           

            




        }
    }
}
