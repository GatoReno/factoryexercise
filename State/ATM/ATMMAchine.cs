using System;
using State.Interfaces;

namespace State.ATM
{
    public class ATMMAchine
    {
        IATMStates hasCard;
        IATMStates noCard;
        IATMStates hasCorrectPin;
        IATMStates atmOutOfMoney;

        IATMStates atmState;


        public int cashInMachinbe = 2000;
        public Boolean correctPinEntered = false;

        public ATMMAchine() {


            hasCard = new HasCard(this);
            noCard = new NoCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new ATMOutOfMoney(this);

            atmState = noCard;
            if (cashInMachinbe < 0)
            {
                atmState = atmOutOfMoney;
            }
        }

        public void setATMState(IATMStates newATMState)
        {
            atmState = newATMState;
        }

        public void setCashInMachine(int newCashInMachine)
        {
            cashInMachinbe += newCashInMachine;
        }

        public void insertCard()
        {
            atmState.InsertCard();
        }

        public void ejectCard()
        {
            atmState.EjectCard();
        }

        public void insertPin(int pin)
        {
            atmState.InsertPin(pin);
        }

        public void requestCash(int cashToWithdraw)
        {
            atmState.RequestChas(cashToWithdraw);
        }

        public IATMStates getYesCardState() { return hasCard; }
        public IATMStates getNoCardState() { return noCard; }
        public IATMStates getHasPin() { return hasCorrectPin; }
        public IATMStates getNoCashState() { return atmOutOfMoney; }

    }  
}
