using System;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorators
{
    public class Cheese : SandwichDecorator
    {
        public Cheese(Sandwich sandwich) : base(sandwich)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription() + ", " + Description;
        }

        public override double GetPrize()
        {
            return Sandwich.GetPrize() + 1.23;
        }

        public void AddToBread()
        {
            Console.WriteLine("Add Cheese to cuted bread");
        }
    }
}