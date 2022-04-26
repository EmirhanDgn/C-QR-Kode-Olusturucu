namespace QR_Kod_Olusturucu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQRKodOlustur = new System.Windows.Forms.Button();
            this.txtQrKodMetini = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQrKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQRKodOlustur
            // 
            this.btnQRKodOlustur.Location = new System.Drawing.Point(207, 38);
            this.btnQRKodOlustur.Name = "btnQRKodOlustur";
            this.btnQRKodOlustur.Size = new System.Drawing.Size(100, 23);
            this.btnQRKodOlustur.TabIndex = 0;
            this.btnQRKodOlustur.Text = "QR Kod Oluştur";
            this.btnQRKodOlustur.UseVisualStyleBackColor = true;
            this.btnQRKodOlustur.Click += new System.EventHandler(this.btnQRKodOlustur_Click);
            // 
            // txtQrKodMetini
            // 
            this.txtQrKodMetini.Location = new System.Drawing.Point(178, 12);
            this.txtQrKodMetini.Name = "txtQrKodMetini";
            this.txtQrKodMetini.Size = new System.Drawing.Size(159, 20);
            this.txtQrKodMetini.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oluşturmak İstediğiniz QR Kod";
            // 
            // btnQrKaydet
            // 
            this.btnQrKaydet.Location = new System.Drawing.Point(191, 243);
            this.btnQrKaydet.Name = "btnQrKaydet";
            this.btnQrKaydet.Size = new System.Drawing.Size(104, 23);
            this.btnQrKaydet.TabIndex = 4;
            this.btnQrKaydet.Text = "QR Kod Kaydet";
            this.btnQrKaydet.UseVisualStyleBackColor = true;
            this.btnQrKaydet.Visible = false;
            this.btnQrKaydet.Click += new System.EventHandler(this.btnQrKaydet_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnQRKodOlustur;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 307);
            this.Controls.Add(this.btnQrKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtQrKodMetini);
            this.Controls.Add(this.btnQRKodOlustur);
            this.Name = "Form1";
            this.Text = "QR Kod Oluşturucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQRKodOlustur;
        private System.Windows.Forms.TextBox txtQrKodMetini;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQrKaydet;
    }
}

