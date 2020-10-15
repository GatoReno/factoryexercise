using State.Interfaces;

namespace State.ATM
{
    internal class HasPin : IATMStates
    {
        private ATMMAchine aTMMAchine;

        public HasPin(ATMMAchine aTMMAchine)
        {
            this.aTMMAchine = aTMMAchine;
        }

        public void EjectCard()
        {
            System.Console.WriteLine("Card ejected");
            aTMMAchine.setATMState(aTMMAchine.getNoCardState());
        }

        public void InsertCard()
        {
            System.Console.WriteLine("You can't have more that one card");
        }

        public void InsertPin(int pin)
        {
            System.Console.WriteLine("al ready have pin");
        }

        public void RequestChas(int amount)
        {
            if (amount > aTMMAchine.cashInMachinbe)
            {
                System.Console.WriteLine("don't have cash");
                System.Console.WriteLine("card ejected");
                aTMMAchine.setATMState(aTMMAchine.getNoCardState());
            }
            else {
                System.Console.WriteLine(" $ "+amount.ToString() + " is provided by the machine");
                aTMMAchine.setCashInMachine(aTMMAchine.cashInMachinbe - amount);
                System.Console.WriteLine("card ejected");
                aTMMAchine.setATMState(aTMMAchine.getNoCardState());
                if (aTMMAchine.cashInMachinbe <= 0)
                {
                    aTMMAchine.setATMState(aTMMAchine.getNoCashState());
                }
            }
        }
    }
}