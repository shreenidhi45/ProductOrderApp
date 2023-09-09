using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class LineItem
    {
        private int id;
        private int quantity;
        private Product product;

        public LineItem(int id, int quantity, Product product)
        {
            this.id = id;
            this.quantity = quantity;
            this.product = product;
        }

        public double CalculateLineItemCost()
        {
            return quantity * product.CalculateDiscountedPrice();
        }
        public int Id { get { return id; } }
        public int Quantity { get { return quantity; } }
        public Product Product { get { return product; } }
    }
}

