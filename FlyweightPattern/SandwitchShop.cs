using System.Collections.Generic;
using DecoratorPattern.Component;
using FlyweightPattern.FlyweightFactory;

namespace FlyweightPattern
{
    internal class SandwitchShop
    {
        private readonly OrderFactory _menu = new OrderFactory();
        private readonly List<Order> _orders = new List<Order>();

        public void TakeOrder(Sandwich sandwich, int table)
        {
            var sandwich1 = _menu.GetSandwich(sandwich);
            var order = new Order(table, sandwich1);
            _orders.Add(order);
        }

        public void Service()
        {
            foreach (var order in _orders)
                order.Serve();
        }

        public string Report()
        {
            return "\ntotal Sandwiches objects made: " + _menu.TotalOrders();
        }
    }
}