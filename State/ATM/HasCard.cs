using State.Interfaces;

namespace State.ATM
{
    internal class HasCard : IATMStates
    {
        private ATMMAchine aTMMAchine;

        public HasCard(ATMMAchine aTMMAchine)
        {
            this.aTMMAchine = aTMMAchine;
        }

        public void EjectCard()
        {
            System.Console.WriteLine("u can't enter more that one card");
        }

        public void InsertCard()
        {
            System.Console.WriteLine("card ejected");
            aTMMAchine.setATMState(aTMMAchine.getNoCardState());
        }

        public void InsertPin(int pin)
        {
            if (pin == 1234)
            {
                System.Console.WriteLine("correct pin");
                aTMMAchine.correctPinEntered = true;
                aTMMAchine.setATMState(aTMMAchine.getHasPin());
            }
            else
            {
                System.Console.WriteLine("Incorrect pin try again");
                aTMMAchine.correctPinEntered = false;
                aTMMAchine.setATMState(aTMMAchine.getNoCardState());
            }
        }

        public void RequestChas(int amount)
        {
            System.Console.WriteLine("Enter pin please ");
        }
    }
}