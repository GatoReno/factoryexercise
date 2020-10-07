using System;
using AbstractAndInterfaces.Characters;
using AbstractAndInterfaces.Objects;

namespace AbstractAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Characters!");
            King xk = new King();
            Rogue xr = new Rogue();
            Console.WriteLine("king interaction ");
            xk.fight();
            Console.WriteLine("rogue interaction ");
            xr.fight();
            Console.ReadLine();
        }
    }
}
