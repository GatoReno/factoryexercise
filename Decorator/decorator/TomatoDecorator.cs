using System;
using Decorator.interfaces;

namespace Decorator.decorator
{
    public class TomatoDecorator : PizzaDEcorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += " \r\n with Tomaote  ";
            return type;
        }

    }
}
