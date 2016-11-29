namespace DecoratorPattern.Component
{
    //Used and for Flyweight Pattern
    public abstract class Sandwich
    {
        public string Description { get; set; }
        public abstract string GetDescription();

        public abstract double GetPrize();
    }
}