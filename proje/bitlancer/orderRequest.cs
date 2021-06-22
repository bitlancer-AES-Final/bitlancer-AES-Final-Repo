using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bitlancer
{
    public partial class orderRequest : Form
    {
        int _userID;
        int _item_id;
        public orderRequest(int userID, int item_id)
        {
            _userID = userID;
            _item_id = item_id;
            InitializeComponent();
        }
        
        private void btnOnay_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            command = SingletonDB.GetInstance.refOrderRequest(_item_id,_userID, txtDesiredPrice.Text, txtDesiredQuantity.Text);
            txtDesiredPrice.Text = "";
            txtDesiredQuantity.Text = "";
            MessageBox.Show("İstek Onaylandı!");
        }

        private void orderRequest_Load(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand();
            item DesiredItem = new item();
            DesiredItem = SingletonDB.GetInstance.getItem(_item_id);
            lblDesiredItem.Text = DesiredItem.itemName;            
        }
    }
}
