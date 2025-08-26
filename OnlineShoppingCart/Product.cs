using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingCart
{
    internal class Product
    {
        private string productName;
        private int price;
        private int quantity;

        public Product(string productName, int price, int quantity)
        {
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public string ShowProduct()
        {
            return $"Product: { productName } \nPrice: ${ price } \nQuantity: { quantity }";
        }

        public string CalculateTotalPrice() 
        {
            return $"Total Price: ${price * quantity}";   
        }
    }
}
