using System;
using Decorator.interfaces;

namespace Decorator.decorator
{
    public class PizzaDEcorator : IPizza
    {
        private IPizza _pizza;
        public PizzaDEcorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetPizzaType()
        {
            
            return _pizza.GetPizzaType();
        }
    }
}
