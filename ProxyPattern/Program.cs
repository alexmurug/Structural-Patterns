using System;
using System.Linq;
using ProxyPattern.Proxy;

namespace ProxyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repository = new ProxyOrderRepository();

            var order = repository.GetOrder(2);

            Console.WriteLine("Order Id: {0}", order.Id);
            Console.WriteLine("Date: {0}", order.OrderDate);
            Console.WriteLine("Customer: {0}, {1}", order.Customer.LastName, order.Customer.FirstName);
            Console.WriteLine("# of items: {0}", order.Details.Count());

            Console.ReadKey();
        }
    }
}