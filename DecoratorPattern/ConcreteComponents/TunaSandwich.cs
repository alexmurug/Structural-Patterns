using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponents
{
    public class TunaSandwich : Sandwich
    {
        public TunaSandwich()
        {
            Description = "Tuna Sandwich";
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrize()
        {
            return 4.10;
        }
    }
}