using System;
using DecoratorPattern.ConcreteComponents;

namespace FlyweightPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shop = new SandwitchShop();
            var tunaSandwich = new TunaSandwich();
            var veggieSandwich = new VeggieSandwich();

            shop.TakeOrder(tunaSandwich, 2);
            shop.TakeOrder(veggieSandwich, 1);
            shop.TakeOrder(tunaSandwich, 1);
            shop.TakeOrder(tunaSandwich, 24);
            shop.TakeOrder(veggieSandwich, 798);
            shop.TakeOrder(tunaSandwich, 41);
            shop.TakeOrder(tunaSandwich, 17);
            shop.TakeOrder(tunaSandwich, 115);
            shop.TakeOrder(tunaSandwich, 15);

            shop.Service();
            Console.WriteLine(shop.Report());

            Console.ReadKey();
        }
    }
}