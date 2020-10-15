using State.Interfaces;

namespace State.ATM
{
    internal class NoCard : IATMStates
    {
        private ATMMAchine aTMMAchine;

        public NoCard(ATMMAchine aTMMAchine)
        {
            this.aTMMAchine = aTMMAchine;
        }

        public void EjectCard()
        {
            System.Console.WriteLine("No card");
        }

        public void InsertCard()
        {
            System.Console.WriteLine("Inset Card");
            aTMMAchine.setATMState(aTMMAchine.getYesCardState());
        }

        public void InsertPin(int pin)
        {
            System.Console.WriteLine("Enter card first");
        }

        public void RequestChas(int amount)
        {
            System.Console.WriteLine("Enter card first");
        }
    }
}