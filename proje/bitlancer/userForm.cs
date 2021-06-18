using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitlancer
{
    public partial class userForm : Form
    {
        User MyUser;
        public userForm(User user)
        {
            InitializeComponent();
            MyUser = user;
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            setUI();
        }
        void setUI()
        {
            fullname_textbox.Text = MyUser.fullName;
            username_textbox.Text = MyUser.userName;
            mskTel.Text = MyUser.userTel;
            address_richtextbox.Text = MyUser.address;
            email_textbox.Text = MyUser.userMail;
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (btnDuzenle.Text == "Düzenle")
            {
                btnDuzenle.Text = "Kaydet";
                btnDuzenle.BackColor = Color.Green;
                btnDuzenle.ForeColor = Color.White;
                fullname_textbox.Enabled = true;
                username_textbox.Enabled = true;
                userpassword_textbox.Enabled = true;
                mskTel.Enabled = true;
                address_richtextbox.Enabled = true;
                email_textbox.Enabled = true;
            }
            else
            {
                if (userpassword_textbox.Text != "" && username_textbox.Text != "" && mskTel.Text != "" && address_richtextbox.Text != "" && email_textbox.Text != "" && fullname_textbox.Text != "")
                {

                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Değişiklikler Kaydedilsin Mi?", "UYARI", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        bool islem = SingletonDB.GetInstance.updateUser(MyUser.id, username_textbox.Text, fullname_textbox.Text, userpassword_textbox.Text, mskTel.Text, email_textbox.Text, address_richtextbox.Text);
                        if (islem)
                        {
                            MessageBox.Show("Başarıyla Güncellendi!");
                        }
                        else
                        {
                            MessageBox.Show("Maalesef Güncellenemedi!");
                        }
                    }
                    else
                    {
                        setUI();
                    }
                    btnDuzenle.Text = "Düzenle";
                    btnDuzenle.ForeColor = Color.Black;
                    btnDuzenle.BackColor = Color.FromArgb(128, 128, 255);
                    fullname_textbox.Enabled = false;
                    username_textbox.Enabled = false;
                    mskTel.Enabled = false;
                    address_richtextbox.Enabled = false;
                    userpassword_textbox.Enabled = false;
                    email_textbox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli Giriş Yapın");
                }
            }
        }
    }
}
