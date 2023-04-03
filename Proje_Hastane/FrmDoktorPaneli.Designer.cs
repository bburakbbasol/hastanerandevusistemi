namespace Proje_Hastane
{
    partial class FrmDoktorPaneli
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
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(126, 152);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(258, 32);
            this.cmbbrans.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "Branş:";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Honeydew;
            this.btnsil.Location = new System.Drawing.Point(261, 300);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(123, 35);
            this.btnsil.TabIndex = 60;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 59;
            this.label6.Text = "Soyad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(126, 101);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(258, 29);
            this.txtsoyad.TabIndex = 58;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(126, 260);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(258, 29);
            this.txtsifre.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 24);
            this.label4.TabIndex = 56;
            this.label4.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(126, 41);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(258, 29);
            this.txtad.TabIndex = 55;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(126, 206);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(258, 29);
            this.msktc.TabIndex = 54;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Sifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "TC Kimlik:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(418, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(583, 335);
            this.dataGridView1.TabIndex = 63;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Honeydew;
            this.btnekle.Location = new System.Drawing.Point(126, 300);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(124, 35);
            this.btnekle.TabIndex = 64;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Honeydew;
            this.btnguncelle.Location = new System.Drawing.Point(126, 341);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(258, 35);
            this.btnguncelle.TabIndex = 65;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 442);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmDoktorPaneli";
            this.Text = "FrmDoktorPaneli";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
    }
}