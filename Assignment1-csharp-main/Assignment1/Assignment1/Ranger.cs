using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Ranger : Hero
    {

        public Ranger(string name)
            : base(name)
        {
            classtype = "Ranger";
            // Sets HeroAttribute for Ranger:
            LevelAttributes = new HeroAttribute(1, 7, 1); // Strength, Dexterity, Intelligence

            // Adds ValidWeaponTypes for Ranger:
            ValidWeaponTypes.Add(WeaponType.Bow);

            // Adds ValidArmorTypes for Ranger:
            ValidArmorTypes.Add(ArmorType.Leather);
            ValidArmorTypes.Add(ArmorType.Mail);
        }

        public override void LevelUp()
        {
            Level++;
            // Increase the level attributes;
            LevelAttributes.increase(1, 5, 1);
        }

        public override float TotalDamage()
        {
            int weaponDamage = TotalWeaponDamage();
            HeroAttribute totalattributes = TotalAttributes();
            int damagingAttribute = totalattributes.Dexterity;

            float HeroDamage = (float)(weaponDamage * (1 + damagingAttribute / 100.0));
            return HeroDamage;

        }

    }
}
