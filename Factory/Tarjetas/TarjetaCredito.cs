using System;
using Factory.Interfaces;

namespace Factory.Classes
{
    public class TarjetaCredito : ITarjeta
    {
        public string ConsultarNombreTarjetaHabiente()
        {
            return "Etho Rawrdriguez";
        }

        public decimal ConsultarSaldo()
        {
            return 120000.02m;
        }
    }
}
