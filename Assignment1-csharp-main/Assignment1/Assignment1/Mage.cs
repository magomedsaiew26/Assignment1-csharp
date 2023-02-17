using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Mage : Hero
    {

        public Mage(string name)
            : base(name)
        {
            classtype = "Mage";
            // Sets HeroAttribute for Mage:
            LevelAttributes = new HeroAttribute(1, 1, 8); // Strength, Dexterity, Intelligence
            ValidWeaponTypes = new List<WeaponType>();

            // Sets ValidWeaponTypes Mage:
            ValidWeaponTypes.Add(WeaponType.Staff);
            ValidWeaponTypes.Add(WeaponType.Wand);

            // Sets ValidArmorTypes Mage:
            ValidArmorTypes.Add(ArmorType.Cloth);

        }
        public override void LevelUp()
        {
            Level++;
            // Increase the level attributes
            LevelAttributes.increase(1, 1, 5);
        }
        public override float TotalDamage()
        {
            int weaponDamage = TotalWeaponDamage();
            HeroAttribute totalattributes = TotalAttributes();
            int damagingAttribute = totalattributes.Intelligence;

            float HeroDamage = (float)(weaponDamage *(1 + damagingAttribute / 100.0));
            return HeroDamage;

        }

    }

}
