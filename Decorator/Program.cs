using System;
using Decorator.decorator;
using Decorator.implementations;
using Decorator.interfaces;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             allow us to attach features in run time
             we can decore an object to extend it usage

            1 base interface
            2 concrete class
            3 base decortor class
            4 derived decorator class

             */

            IPizza pizza = new Pizza();
            IPizza chesseDec = new ChesseDecorator(pizza);
            IPizza tomatoDec = new TomatoDecorator(chesseDec);
            IPizza onionDec = new OnionDecorator(tomatoDec);
            Console.WriteLine(onionDec.GetPizzaType());
            Console.WriteLine("Hello decorator!");
            Console.ReadLine();
        }
    }
}
