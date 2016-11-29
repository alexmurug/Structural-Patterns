using System.Collections.Concurrent;
using DecoratorPattern.Component;

namespace FlyweightPattern.FlyweightFactory
{
    public class OrderFactory
    {
        private readonly ConcurrentDictionary<string, Sandwich> _orders = new ConcurrentDictionary<string, Sandwich>();

        public Sandwich GetSandwich(Sandwich type)
        {
            if (!_orders.ContainsKey(type.GetType().Name))
                _orders.TryAdd(type.ToString(), type);
            return _orders.GetOrAdd(type.ToString(), type);
        }

        public int TotalOrders()
        {
            return _orders.Count;
        }
    }
}