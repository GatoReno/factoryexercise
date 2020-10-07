using System;
using AbstractAndInterfaces.Bases;

namespace AbstractAndInterfaces.Objects
{
    public class King : BaseCharacter
    {

        SwordBehavior w = new SwordBehavior();
        public King() {
            setWeapon(w);
        }
        public override void fight()
        {
            w.useWeapon();
        }

        
    }
}
