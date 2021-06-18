
namespace bitlancer
{
    partial class FrmKullaniciKayit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlKayıtOlma = new System.Windows.Forms.Panel();
            this.tc_textbox = new System.Windows.Forms.TextBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.logup_button = new System.Windows.Forms.Button();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.address_richtextbox = new System.Windows.Forms.RichTextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.userpassword_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.fullname_textbox = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlKayıtOlma.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::bitlancer.Properties.Resources.sss1;
            this.panel1.Controls.Add(this.pnlKayıtOlma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 562);
            this.panel1.TabIndex = 0;
            // 
            // pnlKayıtOlma
            // 
            this.pnlKayıtOlma.BackColor = System.Drawing.Color.Transparent;
            this.pnlKayıtOlma.Controls.Add(this.tc_textbox);
            this.pnlKayıtOlma.Controls.Add(this.lblTCNo);
            this.pnlKayıtOlma.Controls.Add(this.logup_button);
            this.pnlKayıtOlma.Controls.Add(this.mskTel);
            this.pnlKayıtOlma.Controls.Add(this.address_richtextbox);
            this.pnlKayıtOlma.Controls.Add(this.email_textbox);
            this.pnlKayıtOlma.Controls.Add(this.userpassword_textbox);
            this.pnlKayıtOlma.Controls.Add(this.username_textbox);
            this.pnlKayıtOlma.Controls.Add(this.fullname_textbox);
            this.pnlKayıtOlma.Controls.Add(this.lblAdres);
            this.pnlKayıtOlma.Controls.Add(this.lblEMail);
            this.pnlKayıtOlma.Controls.Add(this.lblTelefon);
            this.pnlKayıtOlma.Controls.Add(this.lblSifre);
            this.pnlKayıtOlma.Controls.Add(this.lblKullaniciAdi);
            this.pnlKayıtOlma.Controls.Add(this.lblAdSoyad);
            this.pnlKayıtOlma.Location = new System.Drawing.Point(270, 32);
            this.pnlKayıtOlma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlKayıtOlma.Name = "pnlKayıtOlma";
            this.pnlKayıtOlma.Size = new System.Drawing.Size(403, 519);
            this.pnlKayıtOlma.TabIndex = 0;
            // 
            // tc_textbox
            // 
            this.tc_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tc_textbox.Location = new System.Drawing.Point(147, 187);
            this.tc_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_textbox.Name = "tc_textbox";
            this.tc_textbox.Size = new System.Drawing.Size(205, 32);
            this.tc_textbox.TabIndex = 17;
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTCNo.Location = new System.Drawing.Point(60, 190);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(80, 26);
            this.lblTCNo.TabIndex = 16;
            this.lblTCNo.Text = "TC No:";
            // 
            // logup_button
            // 
            this.logup_button.BackColor = System.Drawing.Color.MediumPurple;
            this.logup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.logup_button.ForeColor = System.Drawing.Color.Black;
            this.logup_button.Location = new System.Drawing.Point(133, 441);
            this.logup_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logup_button.Name = "logup_button";
            this.logup_button.Size = new System.Drawing.Size(219, 42);
            this.logup_button.TabIndex = 15;
            this.logup_button.Text = "KAYIT OL";
            this.logup_button.UseVisualStyleBackColor = false;
            this.logup_button.Click += new System.EventHandler(this.logup_button_Click);
            // 
            // mskTel
            // 
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.mskTel.Location = new System.Drawing.Point(147, 225);
            this.mskTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(205, 32);
            this.mskTel.TabIndex = 14;
            // 
            // address_richtextbox
            // 
            this.address_richtextbox.Location = new System.Drawing.Point(147, 300);
            this.address_richtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_richtextbox.Name = "address_richtextbox";
            this.address_richtextbox.Size = new System.Drawing.Size(205, 109);
            this.address_richtextbox.TabIndex = 13;
            this.address_richtextbox.Text = "";
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.email_textbox.Location = new System.Drawing.Point(147, 262);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(205, 32);
            this.email_textbox.TabIndex = 12;
            // 
            // userpassword_textbox
            // 
            this.userpassword_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.userpassword_textbox.Location = new System.Drawing.Point(147, 150);
            this.userpassword_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userpassword_textbox.Name = "userpassword_textbox";
            this.userpassword_textbox.PasswordChar = '*';
            this.userpassword_textbox.Size = new System.Drawing.Size(205, 32);
            this.userpassword_textbox.TabIndex = 11;
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.username_textbox.Location = new System.Drawing.Point(147, 113);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(205, 32);
            this.username_textbox.TabIndex = 10;
            // 
            // fullname_textbox
            // 
            this.fullname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.fullname_textbox.Location = new System.Drawing.Point(147, 76);
            this.fullname_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullname_textbox.Name = "fullname_textbox";
            this.fullname_textbox.Size = new System.Drawing.Size(205, 32);
            this.fullname_textbox.TabIndex = 9;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAdres.Location = new System.Drawing.Point(68, 302);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(75, 26);
            this.lblAdres.TabIndex = 7;
            this.lblAdres.Text = "Adres:";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEMail.Location = new System.Drawing.Point(69, 265);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(74, 26);
            this.lblEMail.TabIndex = 6;
            this.lblEMail.Text = "Email:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTelefon.Location = new System.Drawing.Point(53, 228);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(89, 26);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblSifre.Location = new System.Drawing.Point(80, 153);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(63, 26);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblKullaniciAdi.Location = new System.Drawing.Point(5, 116);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(138, 26);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAdSoyad.Location = new System.Drawing.Point(29, 79);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(113, 26);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // FrmKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 562);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmKullaniciKayit";
            this.panel1.ResumeLayout(false);
            this.pnlKayıtOlma.ResumeLayout(false);
            this.pnlKayıtOlma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlKayıtOlma;
        private System.Windows.Forms.Button logup_button;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.RichTextBox address_richtextbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox userpassword_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox fullname_textbox;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox tc_textbox;
        private System.Windows.Forms.Label lblTCNo;
    }
}