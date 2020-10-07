using System;
using Factory.Classes;
using Factory.Interfaces;

namespace Factory.Tarjetas
{
    public class FactoryTarjetas
    { 

        ITarjeta tarjeta;
        public void ConsultarInfo(TarjetaTypes tarjetaTypes)
        {
            switch (tarjetaTypes)
            {
                case TarjetaTypes.DEBITO:
                    tarjeta = new TarjetaCredito();
                    break;
                case TarjetaTypes.CREDITO:
                    tarjeta = new TarjetaDebito();
                    break;
            }

            Console.WriteLine(tarjeta.ConsultarNombreTarjetaHabiente());
            Console.WriteLine(tarjeta.ConsultarSaldo());
        }
    }

    public enum TarjetaTypes {
        CREDITO,
        DEBITO
    }
}
