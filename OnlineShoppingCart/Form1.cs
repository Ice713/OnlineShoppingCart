using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product(textBoxProductName.Text, Convert.ToInt32(textBoxPrice.Text), Convert.ToInt32(textBoxQuantity.Text));

            MessageBox.Show($"{ product.ShowProduct() }\n{ product.CalculateTotalPrice() }");
        }
    }
}
