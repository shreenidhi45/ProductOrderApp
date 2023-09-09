using ProductOrderApp.Model;

namespace ProductOrderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Product 1", 10, 10);
            Product product2 = new Product(2, "Product 2", 20, 20);

            LineItem lineItem1 = new LineItem(1, 2, product1);
            LineItem lineItem2 = new LineItem(2, 3, product2);

            List<LineItem> orderItems = new List<LineItem>();
            orderItems.Add(lineItem1);
            orderItems.Add(lineItem2);

            Order order1 = new Order(1, DateTime.Now, orderItems);
            Order order2 = new Order(2, DateTime.Now, orderItems);

            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);

            Customer customer = new Customer(1, "Shree", orders);

            

            Console.WriteLine("Customer Id: {0}", customer.Id);
            Console.WriteLine("Customer Name: {0}", customer.Name);

            Console.WriteLine("Order Count: {0}", customer.Orders.Count);

            for (int i = 0; i < customer.Orders.Count; i++)
            {

                Order order = customer.Orders[i];

                Console.WriteLine("Order No: {0}", i + 1);
                Console.WriteLine("Order Id: {0}", order.Id);
                Console.WriteLine("Order Date: {0}", order.Date);

                foreach (LineItem lineItem in order.Items)
                {

                    double discountedPrice = lineItem.Product.CalculateDiscountedPrice();

                    Console.WriteLine("Line Item Id: {0}", lineItem.Id);
                    Console.WriteLine("Product Id: {0}", lineItem.Product.Id);
                    Console.WriteLine("Product Name: {0}", lineItem.Product.Name);
                    Console.WriteLine("Quantity: {0}", lineItem.Quantity);
                    Console.WriteLine("Unit Price: {0}", lineItem.Product.Price);
                    Console.WriteLine("Discount %: {0}", lineItem.Product.DiscountPercent);
                    Console.WriteLine("Unit Cost After Discount: {0}", discountedPrice);
                    Console.WriteLine("Total Line Item Cost: {0}", lineItem.CalculateLineItemCost());

                }

                Console.WriteLine("Order Cost: {0}", order.CalculateOrderPrice());

            }
        }
    }
}