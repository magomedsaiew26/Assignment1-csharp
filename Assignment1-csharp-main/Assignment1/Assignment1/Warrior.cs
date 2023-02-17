using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Warrior : Hero
    {

        public Warrior(string name)
            : base(name)
        {
            classtype = "Warrior";
            // Sets HeroAttribute for Warrior:
            LevelAttributes = new HeroAttribute(5, 2, 1); // Strength, Dexterity, Intelligence

            // Adds ValidWeaponTypes for Warrior:
            ValidWeaponTypes.Add(WeaponType.Axe);
            ValidWeaponTypes.Add(WeaponType.Hammer);
            ValidWeaponTypes.Add(WeaponType.Sword);

            // Adds ValidArmorTypes for Warrior:
            ValidArmorTypes.Add(ArmorType.Mail);
            ValidArmorTypes.Add(ArmorType.Plate);

        }

        public override void LevelUp()
        {
            Level++;
            // Increase the level attributes
            LevelAttributes.increase(3, 2, 1);
        }

        public override float TotalDamage()
        {
            int weaponDamage = TotalWeaponDamage();
            HeroAttribute totalattributes = TotalAttributes();
            int damagingAttribute = totalattributes.Strength;

            float HeroDamage = (float)(weaponDamage *(1 + damagingAttribute / 100.0));
            return HeroDamage;

        }

    }
}
