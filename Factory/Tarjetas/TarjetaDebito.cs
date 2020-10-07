using System;
using Factory.Interfaces;

namespace Factory.Classes
{
    public class TarjetaDebito :ITarjeta
    {
        

        public string ConsultarNombreTarjetaHabiente()
        {
            return "Etho Rawr";
        }

        public decimal ConsultarSaldo()
        {
            return 6000m;
        }
    }
}
