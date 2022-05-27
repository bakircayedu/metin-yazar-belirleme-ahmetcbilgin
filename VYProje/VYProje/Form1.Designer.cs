namespace VYProje
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
            this.btnMetinGoster = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnStackeOku = new System.Windows.Forms.Button();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnAgacaAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMetinGoster
            // 
            this.btnMetinGoster.Location = new System.Drawing.Point(48, 12);
            this.btnMetinGoster.Name = "btnMetinGoster";
            this.btnMetinGoster.Size = new System.Drawing.Size(75, 23);
            this.btnMetinGoster.TabIndex = 0;
            this.btnMetinGoster.Text = "Metin Göster";
            this.btnMetinGoster.UseVisualStyleBackColor = true;
            this.btnMetinGoster.Click += new System.EventHandler(this.btnMetinGoster_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(133, 88);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(309, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnStackeOku
            // 
            this.btnStackeOku.Location = new System.Drawing.Point(48, 161);
            this.btnStackeOku.Name = "btnStackeOku";
            this.btnStackeOku.Size = new System.Drawing.Size(75, 23);
            this.btnStackeOku.TabIndex = 2;
            this.btnStackeOku.Text = "Stack\'e Oku";
            this.btnStackeOku.UseVisualStyleBackColor = true;
            this.btnStackeOku.Click += new System.EventHandler(this.btnStackeOku_Click);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Location = new System.Drawing.Point(48, 235);
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(394, 168);
            this.txtBilgi.TabIndex = 3;
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Location = new System.Drawing.Point(68, 50);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(55, 13);
            this.lblDosyaAdi.TabIndex = 4;
            this.lblDosyaAdi.Text = "Dosya Adı";
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(62, 91);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(61, 13);
            this.lblDosyaYolu.TabIndex = 5;
            this.lblDosyaYolu.Text = "Dosya Yolu";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(133, 47);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(309, 20);
            this.txtFileName.TabIndex = 6;
            // 
            // btnAgacaAktar
            // 
            this.btnAgacaAktar.Location = new System.Drawing.Point(483, 12);
            this.btnAgacaAktar.Name = "btnAgacaAktar";
            this.btnAgacaAktar.Size = new System.Drawing.Size(75, 23);
            this.btnAgacaAktar.TabIndex = 7;
            this.btnAgacaAktar.Text = "Ağaca Aktar";
            this.btnAgacaAktar.UseVisualStyleBackColor = true;
            this.btnAgacaAktar.Click += new System.EventHandler(this.btnAgacaAktar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgacaAktar);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblDosyaYolu);
            this.Controls.Add(this.lblDosyaAdi);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.btnStackeOku);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnMetinGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetinGoster;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnStackeOku;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnAgacaAktar;
    }
}

