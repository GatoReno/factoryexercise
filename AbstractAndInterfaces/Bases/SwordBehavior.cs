using System;
using AbstractAndInterfaces.Interfaces;

namespace AbstractAndInterfaces.Bases
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Swing Sowrd! 🗡");
        }
    }
}
