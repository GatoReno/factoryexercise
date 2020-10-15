using System;
using State.ATM;

namespace State
{
    // Allows an object to alter its behavior when its internal state changes
    //the object will appear to change it class
    //state defines an interface for encapsulating the behavior associated with a
    //particular state of the context

    class Program
    {
        // este ejemplo 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello atm!");
            ATMMAchine aTMMAchine = new ATMMAchine();
            aTMMAchine.insertCard();
     
            aTMMAchine.insertPin(1234);
            aTMMAchine.requestCash(300);



            Console.ReadLine();
        }
    }
}
