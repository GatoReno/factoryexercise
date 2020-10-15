using System;
using Decorator.interfaces;

namespace Decorator.implementations
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "Hawaian";
        }
    }
}
