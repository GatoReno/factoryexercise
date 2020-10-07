using System;
using AbstractAndInterfaces.Interfaces;

namespace AbstractAndInterfaces.Bases
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Stab knife! 🗡");
        }
    }
}
