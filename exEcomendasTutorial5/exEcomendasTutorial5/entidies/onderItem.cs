using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exEcomendasTutorial5.entidies
{
    internal class onderItem
    {
        private Product product;
        private int quantity;
        private double price;

        public onderItem(Product product, int quantity, double price)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = price;
        }

        public double subtotal()
        {
            return quantity * price;
        }

        public override string ToString()
        {
            return $"\nDados do item ecomendado: \n{product.ToString()}\nQuantidade:{quantity}\nSubTotal:{subtotal().ToString("F2")}Euros";
        }
        
    }
}

