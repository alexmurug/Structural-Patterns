using System;
using DecoratorPattern.Component;

namespace FlyweightPattern
{
    // Order is the context of the Sandwitch flyweight.
    public class Order
    {
        private readonly Sandwich _sandwich;
        private readonly int _tableNumber;

        public Order(int tableNumber, Sandwich sandwich)
        {
            _tableNumber = tableNumber;
            _sandwich = sandwich;
        }

        public void Serve()
        {
            Console.WriteLine("Serving " + _sandwich.GetType().Name + " to table " + _tableNumber);
        }
    }
}