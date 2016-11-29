using System;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponents;
using DecoratorPattern.ConcreteDecorators;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sandwich mySandwich = new VeggieSandwich();
            Console.WriteLine(mySandwich.GetPrize());
            Console.WriteLine(mySandwich.GetDescription());
            mySandwich = new Cheese(mySandwich);
            Console.WriteLine(mySandwich.GetPrize());
            Console.WriteLine(mySandwich.GetDescription());
            mySandwich = new Corn(mySandwich);
            Console.WriteLine(mySandwich.GetPrize());
            Console.WriteLine(mySandwich.GetDescription());
            mySandwich = new Olives(mySandwich);
            Console.WriteLine(mySandwich.GetPrize());
            Console.WriteLine(mySandwich.GetDescription());
        }
    }
}