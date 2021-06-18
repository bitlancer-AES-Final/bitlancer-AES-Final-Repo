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
    public partial class Transfer : Form
    {
        int userID = 0;
        public Transfer(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        private void Transfer_Load(object sender, EventArgs e)
        {
            cbmParaBirimi.DataSource = SingletonDB.GetInstance.getItemBitlancer();
            cbmParaBirimi.DisplayMember="itemName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value!=0)
            {
                if (SingletonDB.GetInstance.setItemTransfer(userID, ((item)cbmParaBirimi.SelectedItem).id, Convert.ToInt32(numericUpDown1.Value)))
                {
                    MessageBox.Show(numericUpDown1.Value.ToString() + " Adet " + cbmParaBirimi.Text + " Yükleme Başarılı");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Giriş Yapın");
            }
        }
    }
}
