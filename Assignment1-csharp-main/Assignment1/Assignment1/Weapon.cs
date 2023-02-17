using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    enum WeaponType
    {
        Axe,
        Bow,
        Dagger,
        Hammer,
        Staff,
        Sword,
        Wand
    }
    class Weapon : Item
    {
        public WeaponType WeaponType { get; set; }
        public int WeaponDamage { get; set; }

        public Weapon(string name, int requiredLevel, WeaponType weaponType, int weaponDamage) : base(name, requiredLevel, Slot.Weapon)
        {
            Slot = Slot.Weapon;
            RequiredLevel = requiredLevel;
            WeaponType = weaponType;
            WeaponDamage = weaponDamage;

        }
    }
}
