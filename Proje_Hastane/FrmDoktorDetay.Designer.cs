namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labeltc = new System.Windows.Forms.Label();
            this.labeladsoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rcvhsikayet = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnduyuru = new System.Windows.Forms.Button();
            this.btnbilgidüzen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labeltc);
            this.groupBox1.Controls.Add(this.labeladsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(123, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Null Null";
            // 
            // labeltc
            // 
            this.labeltc.AutoSize = true;
            this.labeltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltc.Location = new System.Drawing.Point(34, 40);
            this.labeltc.Name = "labeltc";
            this.labeltc.Size = new System.Drawing.Size(83, 25);
            this.labeltc.TabIndex = 4;
            this.labeltc.Text = "TC NO:";
            // 
            // labeladsoyad
            // 
            this.labeladsoyad.AutoSize = true;
            this.labeladsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeladsoyad.Location = new System.Drawing.Point(6, 109);
            this.labeladsoyad.Name = "labeladsoyad";
            this.labeladsoyad.Size = new System.Drawing.Size(111, 25);
            this.labeladsoyad.TabIndex = 6;
            this.labeladsoyad.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rcvhsikayet);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 247);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rcvhsikayet
            // 
            this.rcvhsikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rcvhsikayet.Location = new System.Drawing.Point(3, 25);
            this.rcvhsikayet.Name = "rcvhsikayet";
            this.rcvhsikayet.Size = new System.Drawing.Size(482, 219);
            this.rcvhsikayet.TabIndex = 0;
            this.rcvhsikayet.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(506, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(743, 606);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 578);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btncıkıs);
            this.groupBox4.Controls.Add(this.btnduyuru);
            this.groupBox4.Controls.Add(this.btnbilgidüzen);
            this.groupBox4.Location = new System.Drawing.Point(15, 443);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 166);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(18, 96);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(458, 62);
            this.btncıkıs.TabIndex = 3;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnduyuru
            // 
            this.btnduyuru.Location = new System.Drawing.Point(250, 28);
            this.btnduyuru.Name = "btnduyuru";
            this.btnduyuru.Size = new System.Drawing.Size(226, 62);
            this.btnduyuru.TabIndex = 1;
            this.btnduyuru.Text = "Duyurular";
            this.btnduyuru.UseVisualStyleBackColor = true;
            this.btnduyuru.Click += new System.EventHandler(this.btnduyuru_Click);
            // 
            // btnbilgidüzen
            // 
            this.btnbilgidüzen.Location = new System.Drawing.Point(18, 28);
            this.btnbilgidüzen.Name = "btnbilgidüzen";
            this.btnbilgidüzen.Size = new System.Drawing.Size(226, 62);
            this.btnbilgidüzen.TabIndex = 0;
            this.btnbilgidüzen.Text = "Bilgi Düzenle";
            this.btnbilgidüzen.UseVisualStyleBackColor = true;
            this.btnbilgidüzen.Click += new System.EventHandler(this.btnbilgidüzen_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1261, 614);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labeltc;
        private System.Windows.Forms.Label labeladsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rcvhsikayet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnduyuru;
        private System.Windows.Forms.Button btnbilgidüzen;
    }
}