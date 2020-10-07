using System;
using AbstractAndInterfaces.Interfaces;

namespace AbstractAndInterfaces.Bases
{
    public abstract class BaseCharacter
    {
        IWeaponBehavior weapon;

        public abstract void fight();
        
        public void setWeapon(IWeaponBehavior w) {
            this.weapon = w;
            
        }
        
    }
}
