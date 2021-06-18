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
    public partial class adminOnay : Form
    {
        public adminOnay()
        {
            InitializeComponent();
        }

        private void adminOnay_Load(object sender, EventArgs e)
        {
            veriReset();

        }

        public void veriReset()
        {
            adminOnayDataGrid.DataSource = SingletonDB.GetInstance.GetTable("SELECT i.id as 'İşlem No:',i.user_id as 'Kişi No:',(select user_full_name from users where id = i.user_id) as 'Kişi:',i.item_id as 'P.B. No:',(select item_name from items where id = i.item_id) as 'Para Birimi:',quantity as 'Miktar:',date as 'Tarih:',state as 'Durum:',description as 'Açıklama:'from item_adds i where state = 0");
            adminOnayDataGrid2.DataSource = SingletonDB.GetInstance.GetTable("SELECT i.id as 'İşlem No:',i.user_id as 'Kişi No:',(select user_full_name from users where id = i.user_id) as 'Kişi:',i.item_id as 'P.B. No:',(select item_name from items where id = i.item_id) as 'Para Birimi:',quantity as 'Miktar:',date as 'Tarih:',state as 'Durum:',description as 'Açıklama:'from item_adds i where state = 1");
            orderGrid.DataSource = SingletonDB.GetInstance.getLastOrders();
        }

        private void btnAdminOnay_Click(object sender, EventArgs e)
        {
            int _id = Convert.ToInt32(adminOnayDataGrid.CurrentRow.Cells[0].Value);
            int user_id = Convert.ToInt32(adminOnayDataGrid.CurrentRow.Cells[1].Value);
            int item_id = Convert.ToInt32(adminOnayDataGrid.CurrentRow.Cells[3].Value);
            int quantity = Convert.ToInt32(adminOnayDataGrid.CurrentRow.Cells[5].Value);
            int state = cbAdminOnay.Checked ? 1 : 0;
            string description = txtAdminOnay.Text;
            int itemQuantity = SingletonDB.GetInstance.getId("select quantity from item_user_infos where  selling=0 and (item_id=" + item_id + " and user_id=" + user_id + ")");

            SingletonDB.GetInstance.uptadeAdminOnayDataGrid(_id, state,description);
            SingletonDB.GetInstance.updateAfterOrder(0, user_id, item_id,(itemQuantity + quantity));
            veriReset();
        }
    }
}
