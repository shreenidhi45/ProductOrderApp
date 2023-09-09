using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrderApp.Model
{
    internal class Order
    {
        private int id;
        private DateTime date;
        private List<LineItem> items;

        public Order(int id, DateTime date, List<LineItem> items)
        {
            this.id = id;
            this.date = date;
            this.items = items;
        }

        public double CalculateOrderPrice()
        {
            double total = 0;
            foreach (LineItem item in items)
            {
                total += item.CalculateLineItemCost();
            }
            return total;
        }
        public int Id { get { return id; } }
        public DateTime Date { get { return date; } }
        public List<LineItem> Items { get { return items; } }
    }
}
