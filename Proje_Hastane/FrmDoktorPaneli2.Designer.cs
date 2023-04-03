namespace Proje_Hastane
{
    partial class FrmDoktorPaneli2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli2));
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonguncel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labeliid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(53, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(100, 11);
            this.txtad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(213, 29);
            this.txtad.TabIndex = 1;
            // 
            // buttonekle
            // 
            this.buttonekle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonekle.Location = new System.Drawing.Point(100, 248);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(93, 34);
            this.buttonekle.TabIndex = 6;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonsil.Location = new System.Drawing.Point(224, 248);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(89, 34);
            this.buttonsil.TabIndex = 7;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonguncel
            // 
            this.buttonguncel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonguncel.Location = new System.Drawing.Point(100, 288);
            this.buttonguncel.Name = "buttonguncel";
            this.buttonguncel.Size = new System.Drawing.Size(213, 34);
            this.buttonguncel.TabIndex = 8;
            this.buttonguncel.Text = "Güncelle";
            this.buttonguncel.UseVisualStyleBackColor = true;
            this.buttonguncel.Click += new System.EventHandler(this.buttonguncel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(319, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 322);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(52, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(40, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "Şifre:";
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(100, 60);
            this.textsoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(213, 29);
            this.textsoyad.TabIndex = 2;
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(100, 210);
            this.textsifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(213, 29);
            this.textsifre.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(100, 157);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(213, 29);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // labeliid
            // 
            this.labeliid.AutoSize = true;
            this.labeliid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeliid.Location = new System.Drawing.Point(0, 309);
            this.labeliid.Name = "labeliid";
            this.labeliid.Size = new System.Drawing.Size(35, 13);
            this.labeliid.TabIndex = 53;
            this.labeliid.Text = "label5";
            this.labeliid.Visible = false;
            // 
            // FrmDoktorPaneli2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1019, 326);
            this.Controls.Add(this.labeliid);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonguncel);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli2";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonguncel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labeliid;
    }
}