using System;
using AbstractAndInterfaces.Bases;

namespace AbstractAndInterfaces.Characters
{
    public class Rogue : BaseCharacter
    {
        KnifeBehavior w = new KnifeBehavior();
        public Rogue() {
            setWeapon(w);
        }
        public override void fight()
        {
            w.useWeapon();
        }
    }
}
