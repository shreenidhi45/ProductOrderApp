using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Customer
    {
        private int id;
        private string name;
        private List<Order> orders;

        public Customer(int id, string name, List<Order> orders)
        {
            this.id = id;
            this.name = name;
            this.orders = orders;
        }

        public int Id { get { return id; } }
        public string Name { get { return name; } }
        public List<Order> Orders { get { return orders; } }
    }
}

