using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public struct AllInfo
    {
        public string customerName, contactNo, address, order, quantity;
    }

    public partial class Home : Form
    {

        int cuIndex = 0;
        string allCustomerData = "";
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void saveButton2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void saveButton2_Click_1(object sender, EventArgs e)
        {
            AllInfo allInfo;
            AllInfo[] ara = new AllInfo[20];

            


            int quantity, unitPrice, totalBill;
            bool isNum;
            string temp, item, order;

            order = orderComboBox.Text;


            if (order == "" || quantityTextBox.Text == "")
            {
                MessageBox.Show("Select order and quantity");
            }
            else
            {
                ara[cuIndex].customerName = customerNameTextBox.Text;
                ara[cuIndex].contactNo = contactNoTextBox.Text;
                ara[cuIndex].address = addressTextBox.Text;
                ara[cuIndex].order = orderComboBox.Text;
                ara[cuIndex].quantity = quantityTextBox.Text;

                quantity = Convert.ToInt32(quantityTextBox.Text);

                temp = ""; isNum = false; item = "";
                for (int a_i = 0; a_i < order.Length; a_i++)
                {
                    if (isNum) temp += order[a_i];
                    if (!isNum && order[a_i] != '-') item += order[a_i];
                    if (order[a_i] == '-') isNum = true;
                }

                unitPrice = Convert.ToInt32(temp);

                totalBill = unitPrice * quantity;

                allCustomerData += quantity + " cup of " + item + " Coffee\nTotal bill : " + totalBill.ToString() + " Taka\n\nCustomer : "+ara[cuIndex].customerName+"\nContact : "+ ara[cuIndex].contactNo +"\nAddress : "+ ara[cuIndex].address + "\n\n-------------o--------------\n\n";

                showInfoRichTextBox.Text = allCustomerData;

                customerNameTextBox.Text = "";
                contactNoTextBox.Text = "";
                addressTextBox.Text = "";
                orderComboBox.Text = "";
                quantityTextBox.Text = "";
            }
        }
    }
}
