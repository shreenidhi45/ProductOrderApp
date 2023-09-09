using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;
        private double discountPercent;

        public Product(int id, string name, double price, double discountPercent)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.discountPercent = discountPercent;
        }

        public double CalculateDiscountedPrice()
        {
            return price * (1 - discountPercent / 100);
        }

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public decimal Price { get { return (decimal)price; } }
        public decimal DiscountPercent { get { return (decimal)discountPercent; } }
    }
}

