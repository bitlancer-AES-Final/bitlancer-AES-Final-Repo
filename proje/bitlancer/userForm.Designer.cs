namespace bitlancer
{
    partial class userForm
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
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.address_richtextbox = new System.Windows.Forms.RichTextBox();
            this.userpassword_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.fullname_textbox = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mskTel
            // 
            this.mskTel.Enabled = false;
            this.mskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.mskTel.Location = new System.Drawing.Point(15, 192);
            this.mskTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(509, 32);
            this.mskTel.TabIndex = 29;
            // 
            // address_richtextbox
            // 
            this.address_richtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_richtextbox.Enabled = false;
            this.address_richtextbox.Location = new System.Drawing.Point(15, 302);
            this.address_richtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.address_richtextbox.Name = "address_richtextbox";
            this.address_richtextbox.Size = new System.Drawing.Size(509, 191);
            this.address_richtextbox.TabIndex = 28;
            this.address_richtextbox.Text = "";
            // 
            // userpassword_textbox
            // 
            this.userpassword_textbox.Enabled = false;
            this.userpassword_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.userpassword_textbox.Location = new System.Drawing.Point(15, 138);
            this.userpassword_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userpassword_textbox.Name = "userpassword_textbox";
            this.userpassword_textbox.PasswordChar = '*';
            this.userpassword_textbox.Size = new System.Drawing.Size(509, 32);
            this.userpassword_textbox.TabIndex = 26;
            // 
            // username_textbox
            // 
            this.username_textbox.Enabled = false;
            this.username_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.username_textbox.Location = new System.Drawing.Point(15, 84);
            this.username_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(509, 32);
            this.username_textbox.TabIndex = 25;
            // 
            // fullname_textbox
            // 
            this.fullname_textbox.Enabled = false;
            this.fullname_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.fullname_textbox.Location = new System.Drawing.Point(15, 30);
            this.fullname_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullname_textbox.Name = "fullname_textbox";
            this.fullname_textbox.Size = new System.Drawing.Size(509, 32);
            this.fullname_textbox.TabIndex = 24;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAdres.Location = new System.Drawing.Point(11, 282);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(49, 17);
            this.lblAdres.TabIndex = 23;
            this.lblAdres.Text = "Adres:";
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEMail.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblEMail.Location = new System.Drawing.Point(11, 228);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(46, 17);
            this.lblEMail.TabIndex = 22;
            this.lblEMail.Text = "Email:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTelefon.Location = new System.Drawing.Point(11, 174);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(57, 17);
            this.lblTelefon.TabIndex = 21;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblSifre.Location = new System.Drawing.Point(11, 119);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(42, 17);
            this.lblSifre.TabIndex = 20;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(11, 65);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(91, 17);
            this.lblKullaniciAdi.TabIndex = 19;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblAdSoyad.Location = new System.Drawing.Point(11, 11);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(71, 17);
            this.lblAdSoyad.TabIndex = 18;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(15, 554);
            this.btnDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(511, 57);
            this.btnDuzenle.TabIndex = 32;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            // 
            // email_textbox
            // 
            this.email_textbox.Enabled = false;
            this.email_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.email_textbox.Location = new System.Drawing.Point(15, 246);
            this.email_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(509, 32);
            this.email_textbox.TabIndex = 27;
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 620);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.address_richtextbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.userpassword_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.fullname_textbox);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "userForm";
            this.Load += new System.EventHandler(this.userForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.RichTextBox address_richtextbox;
        private System.Windows.Forms.TextBox userpassword_textbox;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox fullname_textbox;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox email_textbox;
    }
}