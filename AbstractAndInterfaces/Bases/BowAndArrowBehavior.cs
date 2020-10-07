using System;
using AbstractAndInterfaces.Interfaces;

namespace AbstractAndInterfaces.Bases
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Swing Sowrd! 🗡");
        }
    }
}
