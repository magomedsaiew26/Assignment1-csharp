using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Rogue : Hero
    {

        public Rogue(string name)
            : base(name)
        {
            classtype = "Rogue";

            // Sets HeroAttribute for Rogue:
            LevelAttributes = new HeroAttribute(2, 6, 1); // Strength, Dexterity, Intelligence

            // Adds ValidWeaponTypes for Rogue:
            ValidWeaponTypes.Add(WeaponType.Dagger);
            ValidWeaponTypes.Add(WeaponType.Sword);

            // Adds ValidArmorTypes for Rogue:
            ValidArmorTypes.Add(ArmorType.Leather);
            ValidArmorTypes.Add(ArmorType.Mail);
        }


        public override void LevelUp()
        {
            Level++;
            // Increase the level attributes
            LevelAttributes.increase(1, 4, 1);
        }
        public override  float TotalDamage()
        {
            int weaponDamage = TotalWeaponDamage();
            HeroAttribute totalattributes = TotalAttributes();
            int damagingAttribute = totalattributes.Dexterity;

            float HeroDamage = (float)(weaponDamage *(1 + damagingAttribute / 100.0));
            return HeroDamage;

        }
    }
}
