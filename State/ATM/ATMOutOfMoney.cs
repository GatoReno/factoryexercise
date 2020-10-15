using State.Interfaces;

namespace State.ATM
{
    internal class ATMOutOfMoney : IATMStates
    {
        private ATMMAchine aTMMAchine;

        public ATMOutOfMoney(ATMMAchine aTMMAchine)
        {
            this.aTMMAchine = aTMMAchine;
        }

        public void EjectCard()
        {
            System.Console.WriteLine("thanks come back later");
            aTMMAchine.setATMState(aTMMAchine.getNoCardState());
        }

        public void InsertCard()
        {
            System.Console.WriteLine("we don't have money");
            aTMMAchine.setATMState(aTMMAchine.getYesCardState());
        }

        public void InsertPin(int pin)
        {
            System.Console.WriteLine("we don't have money");
        }

        public void RequestChas(int amount)
        {
            System.Console.WriteLine("we don't have money");
        }
    }
}