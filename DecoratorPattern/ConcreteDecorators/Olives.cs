using System;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorators
{
    public class Olives : SandwichDecorator
    {
        public Olives(Sandwich sandwich)
            : base(sandwich)
        {
            Description = "Olives";
        }

        public override string GetDescription()
        {
            return Sandwich.GetDescription() + ", " + Description;
        }

        public override double GetPrize()
        {
            return Sandwich.GetPrize() + 0.89;
        }

        public void AddToBread()
        {
            Console.Write("Add Olive to cuted Bread");
        }
    }
}