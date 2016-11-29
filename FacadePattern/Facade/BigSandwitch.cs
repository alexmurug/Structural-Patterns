using System;
using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponents;
using DecoratorPattern.ConcreteDecorators;
using FacadePattern.Subsystems;

namespace FacadePattern.Facade
{
    public class BigSandwitch
    {
        private readonly Bread _bread;
        private readonly Cheese _cheese;
        private readonly Olives _olivie;


        public BigSandwitch()
        {
            Sandwich sandwich = new TunaSandwich();
            _bread = new Bread();
            _cheese = new Cheese(sandwich);
            _olivie = new Olives(sandwich);
        }

        public void Coock()
        {
            _bread.Cut();
            _cheese.AddToBread();
            _olivie.AddToBread();
            InsertIntoMicroware();
        }


        public void InsertIntoMicroware()
        {
            Console.WriteLine("\ninsert Into microwave");
        }
    }
}