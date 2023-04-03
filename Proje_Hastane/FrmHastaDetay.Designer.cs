namespace Proje_Hastane
{
    partial class FrmHastaDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.labeladsoyad = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.labeltc = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkbilgiduzen = new System.Windows.Forms.LinkLabel();
            this.btnrandevu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextsikayet = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.labeladsoyad);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.labeltc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladsoyad.Location = new System.Drawing.Point(181, 127);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(92, 25);
            this.lbladsoyad.TabIndex = 3;
            this.lbladsoyad.Text = "Null Null";
            // 
            // labeladsoyad
            // 
            this.labeladsoyad.AutoSize = true;
            this.labeladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladsoyad.Location = new System.Drawing.Point(40, 127);
            this.labeladsoyad.Name = "labeladsoyad";
            this.labeladsoyad.Size = new System.Drawing.Size(111, 25);
            this.labeladsoyad.TabIndex = 2;
            this.labeladsoyad.Text = "Ad Soyad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(181, 58);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(144, 25);
            this.lbltc.TabIndex = 1;
            this.lbltc.Text = "00000000000";
            // 
            // labeltc
            // 
            this.labeltc.AutoSize = true;
            this.labeltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltc.Location = new System.Drawing.Point(68, 58);
            this.labeltc.Name = "labeltc";
            this.labeltc.Size = new System.Drawing.Size(83, 25);
            this.labeltc.TabIndex = 0;
            this.labeltc.Text = "TC NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lnkbilgiduzen);
            this.groupBox2.Controls.Add(this.btnrandevu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.richTextsikayet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbdoktor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbbrans);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(3, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // textid
            // 
            this.textid.Enabled = false;
            this.textid.Location = new System.Drawing.Point(125, 50);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(269, 29);
            this.textid.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id:";
            // 
            // lnkbilgiduzen
            // 
            this.lnkbilgiduzen.AutoSize = true;
            this.lnkbilgiduzen.Location = new System.Drawing.Point(330, 366);
            this.lnkbilgiduzen.Name = "lnkbilgiduzen";
            this.lnkbilgiduzen.Size = new System.Drawing.Size(160, 24);
            this.lnkbilgiduzen.TabIndex = 8;
            this.lnkbilgiduzen.TabStop = true;
            this.lnkbilgiduzen.Text = "Bilgilerini Düzenle";
            this.lnkbilgiduzen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkbilgiduzen_LinkClicked);
            // 
            // btnrandevu
            // 
            this.btnrandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrandevu.Location = new System.Drawing.Point(125, 308);
            this.btnrandevu.Name = "btnrandevu";
            this.btnrandevu.Size = new System.Drawing.Size(269, 43);
            this.btnrandevu.TabIndex = 3;
            this.btnrandevu.Text = "Randevu Al";
            this.btnrandevu.UseVisualStyleBackColor = true;
            this.btnrandevu.Click += new System.EventHandler(this.btnrandevu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şikayet:";
            // 
            // richTextsikayet
            // 
            this.richTextsikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextsikayet.Location = new System.Drawing.Point(125, 185);
            this.richTextsikayet.Name = "richTextsikayet";
            this.richTextsikayet.Size = new System.Drawing.Size(269, 117);
            this.richTextsikayet.TabIndex = 2;
            this.richTextsikayet.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(33, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Doktor:";
            // 
            // cmbdoktor
            // 
            this.cmbdoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbdoktor.FormattingEnabled = true;
            this.cmbdoktor.Location = new System.Drawing.Point(125, 142);
            this.cmbdoktor.Name = "cmbdoktor";
            this.cmbdoktor.Size = new System.Drawing.Size(269, 32);
            this.cmbdoktor.TabIndex = 5;
            this.cmbdoktor.SelectedIndexChanged += new System.EventHandler(this.cmbdoktor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbbrans
            // 
            this.cmbbrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(125, 97);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(269, 32);
            this.cmbbrans.TabIndex = 2;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(499, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 422);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(502, 427);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(814, 293);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            this.groupBox4.UseCompatibleTextRendering = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(808, 265);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1319, 751);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHastaDetay";
            this.Text = "HastaDetay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label labeladsoyad;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label labeltc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbdoktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.RichTextBox richTextsikayet;
        private System.Windows.Forms.Button btnrandevu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkbilgiduzen;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label1;
    }
}