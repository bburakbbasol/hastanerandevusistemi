namespace Proje_Hastane
{
    partial class FrmBrans
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
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Honeydew;
            this.btnguncelle.Location = new System.Drawing.Point(129, 208);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(258, 59);
            this.btnguncelle.TabIndex = 79;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Honeydew;
            this.btnekle.Location = new System.Drawing.Point(129, 157);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(124, 45);
            this.btnekle.TabIndex = 78;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 239);
            this.dataGridView1.TabIndex = 77;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Honeydew;
            this.btnsil.Location = new System.Drawing.Point(264, 157);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(123, 45);
            this.btnsil.TabIndex = 74;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 24);
            this.label6.TabIndex = 73;
            this.label6.Text = "Branş Soyad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(129, 108);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(258, 29);
            this.txtsoyad.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Branş id:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(129, 31);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(258, 29);
            this.txtad.TabIndex = 69;
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 360);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmBrans";
            this.Text = "FrmBrans";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtad;
    }      
}