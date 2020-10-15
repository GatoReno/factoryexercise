using System;
using Decorator.interfaces;

namespace Decorator.decorator
{
    public class OnionDecorator : PizzaDEcorator
    {
       
        public OnionDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n  with Onion  ";
            return type;
        }
    
    }
}
