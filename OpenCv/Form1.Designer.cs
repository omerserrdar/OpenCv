using System;

namespace YeniSansurProjesi
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
            this.btnResimAc = new System.Windows.Forms.Button();
            this.btnSansurle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResimAc
            // 
            this.btnResimAc.Location = new System.Drawing.Point(112, 354);
            this.btnResimAc.Name = "btnResimAc";
            this.btnResimAc.Size = new System.Drawing.Size(190, 57);
            this.btnResimAc.TabIndex = 0;
            this.btnResimAc.Text = "Resim Aç";
            this.btnResimAc.UseVisualStyleBackColor = true;
            this.btnResimAc.Click += new System.EventHandler(this.btnResimAc_Click_1);
            // 
            // btnSansurle
            // 
            this.btnSansurle.Location = new System.Drawing.Point(369, 354);
            this.btnSansurle.Name = "btnSansurle";
            this.btnSansurle.Size = new System.Drawing.Size(172, 57);
            this.btnSansurle.TabIndex = 1;
            this.btnSansurle.Text = "Yüzleri Sansürle";
            this.btnSansurle.UseVisualStyleBackColor = true;
            this.btnSansurle.Click += new System.EventHandler(this.btnSansurle_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(112, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSansurle);
            this.Controls.Add(this.btnResimAc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnResimAc;
        private System.Windows.Forms.Button btnSansurle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EventHandler Form1_Load;

        public Form1(EventHandler form1_Load)
        {
            Form1_Load = form1_Load;
        }
    }
}


