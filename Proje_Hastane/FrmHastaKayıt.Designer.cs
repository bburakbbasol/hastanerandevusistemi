namespace Proje_Hastane
{
    partial class FrmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayıt));
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcins = new System.Windows.Forms.ComboBox();
            this.btnkayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(171, 221);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(258, 29);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 53);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hasta Kayıt Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 331);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC Kimlik:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(171, 107);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(258, 29);
            this.txtad.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefon:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(171, 331);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(258, 29);
            this.txtsifre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Soyad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(171, 167);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(258, 29);
            this.txtsoyad.TabIndex = 1;
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(171, 272);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(258, 29);
            this.msktel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 379);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cinsiyet:";
            // 
            // cmbcins
            // 
            this.cmbcins.FormattingEnabled = true;
            this.cmbcins.ItemHeight = 24;
            this.cmbcins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcins.Location = new System.Drawing.Point(171, 381);
            this.cmbcins.Name = "cmbcins";
            this.cmbcins.Size = new System.Drawing.Size(258, 32);
            this.cmbcins.TabIndex = 21;
            // 
            // btnkayit
            // 
            this.btnkayit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnkayit.Location = new System.Drawing.Point(253, 430);
            this.btnkayit.Name = "btnkayit";
            this.btnkayit.Size = new System.Drawing.Size(176, 45);
            this.btnkayit.TabIndex = 25;
            this.btnkayit.Text = "Kayıt Yap";
            this.btnkayit.UseVisualStyleBackColor = false;
            this.btnkayit.Click += new System.EventHandler(this.btnkayit_Click);
            // 
            // FrmHastaKayıt
            // 
            this.AcceptButton = this.btnkayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(556, 545);
            this.Controls.Add(this.btnkayit);
            this.Controls.Add(this.cmbcins);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayıt";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbcins;
        private System.Windows.Forms.Button btnkayit;
    }
}