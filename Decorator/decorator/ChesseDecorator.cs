using System;
using Decorator.interfaces;

namespace Decorator.decorator
{
    public class ChesseDecorator : PizzaDEcorator
    {
        public ChesseDecorator(IPizza pizza) : base(pizza) { }
        
        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n  with Chesse ";
            return type;
        }
    
    }
}
