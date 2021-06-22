namespace bitlancer
{
    partial class FrmGiris
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
            this.pnlArkaPlan = new System.Windows.Forms.Panel();
            this.lblKullaniciGirisPaneli = new System.Windows.Forms.Label();
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.linkLabelKayitOl = new System.Windows.Forms.LinkLabel();
            this.userpassword_textbox = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.pnlArkaPlan.SuspendLayout();
            this.pnlGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlArkaPlan
            // 
            this.pnlArkaPlan.BackgroundImage = global::bitlancer.Properties.Resources.sss;
            this.pnlArkaPlan.Controls.Add(this.lblKullaniciGirisPaneli);
            this.pnlArkaPlan.Controls.Add(this.pnlGiris);
            this.pnlArkaPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArkaPlan.Location = new System.Drawing.Point(0, 0);
            this.pnlArkaPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlArkaPlan.Name = "pnlArkaPlan";
            this.pnlArkaPlan.Size = new System.Drawing.Size(918, 571);
            this.pnlArkaPlan.TabIndex = 0;
            // 
            // lblKullaniciGirisPaneli
            // 
            this.lblKullaniciGirisPaneli.AutoSize = true;
            this.lblKullaniciGirisPaneli.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciGirisPaneli.Font = new System.Drawing.Font("Monotype Corsiva", 40F, System.Drawing.FontStyle.Italic);
            this.lblKullaniciGirisPaneli.Location = new System.Drawing.Point(149, 35);
            this.lblKullaniciGirisPaneli.Name = "lblKullaniciGirisPaneli";
            this.lblKullaniciGirisPaneli.Size = new System.Drawing.Size(551, 82);
            this.lblKullaniciGirisPaneli.TabIndex = 7;
            this.lblKullaniciGirisPaneli.Text = "Kullanıcı Giriş Paneli";
            // 
            // pnlGiris
            // 
            this.pnlGiris.BackColor = System.Drawing.Color.Transparent;
            this.pnlGiris.Controls.Add(this.btnGirisYap);
            this.pnlGiris.Controls.Add(this.linkLabelKayitOl);
            this.pnlGiris.Controls.Add(this.userpassword_textbox);
            this.pnlGiris.Controls.Add(this.lblSifre);
            this.pnlGiris.Controls.Add(this.username_textbox);
            this.pnlGiris.Controls.Add(this.lblKullaniciAdi);
            this.pnlGiris.Location = new System.Drawing.Point(189, 148);
            this.pnlGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(475, 374);
            this.pnlGiris.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.MediumPurple;
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnGirisYap.Location = new System.Drawing.Point(173, 238);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(269, 42);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click_1);
            // 
            // linkLabelKayitOl
            // 
            this.linkLabelKayitOl.AutoSize = true;
            this.linkLabelKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.linkLabelKayitOl.Location = new System.Drawing.Point(266, 304);
            this.linkLabelKayitOl.Name = "linkLabelKayitOl";
            this.linkLabelKayitOl.Size = new System.Drawing.Size(73, 24);
            this.linkLabelKayitOl.TabIndex = 5;
            this.linkLabelKayitOl.TabStop = true;
            this.linkLabelKayitOl.Text = "Kayıt Ol";
            this.linkLabelKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKayitOl_LinkClicked_1);
            // 
            // userpassword_textbox
            // 
            this.userpassword_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userpassword_textbox.Location = new System.Drawing.Point(211, 161);
            this.userpassword_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userpassword_textbox.Name = "userpassword_textbox";
            this.userpassword_textbox.PasswordChar = '*';
            this.userpassword_textbox.Size = new System.Drawing.Size(231, 36);
            this.userpassword_textbox.TabIndex = 4;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSifre.Location = new System.Drawing.Point(109, 164);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(72, 29);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre:";
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.username_textbox.Location = new System.Drawing.Point(211, 103);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(231, 36);
            this.username_textbox.TabIndex = 2;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(21, 107);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(160, 29);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 571);
            this.Controls.Add(this.pnlArkaPlan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.pnlArkaPlan.ResumeLayout(false);
            this.pnlArkaPlan.PerformLayout();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlArkaPlan;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel linkLabelKayitOl;
        private System.Windows.Forms.TextBox userpassword_textbox;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciGirisPaneli;
    }
}

