using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterWithWeaponBehavior
{
    public abstract class Character
    {
        public IWeaponBehavior WeaponBehavior
        {
            get;
            set;
        }

        public void Fight()
        {
            Console.WriteLine("Default Character Fight.");
        }

        public void SetWeapon(IWeaponBehavior weapon)
        {
            WeaponBehavior = weapon;
        }
    }
}