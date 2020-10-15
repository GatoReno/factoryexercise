using System;
namespace State.Interfaces
{
    public interface IATMStates
    {
        void InsertCard();
        void EjectCard();
        void InsertPin(int pin);
        void RequestChas(int amount);
    }
}
