using System;
using Factory.Tarjetas;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello tarjetas!");
            FactoryTarjetas t = new FactoryTarjetas();
            t.ConsultarInfo(TarjetaTypes.CREDITO);
            Console.WriteLine(" -------------- ");
            t.ConsultarInfo(TarjetaTypes.DEBITO);
            Console.ReadLine();
        }
    }
}
