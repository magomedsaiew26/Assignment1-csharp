using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public string classtype { get; set; }

        public HeroAttribute LevelAttributes { get; set; }
        public Dictionary<Slot, Item> Equipment { get; set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute(0, 0, 0);
            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
            Equipment = new Dictionary<Slot, Item>()
            {
                { Slot.Head, null },
                { Slot.Body, null },
                { Slot.Legs, null },
                { Slot.Weapon, null }
            };
        }


        public abstract void LevelUp();
        public abstract float TotalDamage();

        public void Equip(Weapon weapon)
        {
            if (!ValidWeaponTypes.Contains(weapon.WeaponType) || weapon.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"{Name} cannot equip {weapon.Name} as it is either an invalid weapon type or its required level is higher than the hero's current level.");
            }

            Equipment[Slot.Weapon] = weapon;
        }

        public void Equip(Slot slot, Armor armor)
        {
            if (!ValidArmorTypes.Contains(armor.ArmorType) || armor.RequiredLevel > Level)
            {
                throw new InvalidWeaponException($"{Name} cannot equip {armor.Name} as it is either an invalid armor type or its required level.");
            }
            Equipment[slot] = armor;
        }
        public HeroAttribute TotalAttributes()
        {
            int strength, dexterity, intelligence;

            strength = LevelAttributes.Strength;
            dexterity = LevelAttributes.Dexterity;
            intelligence = LevelAttributes.Intelligence;


            Armor bodyArmor = (Armor) Equipment[Slot.Body];
            if ( !(bodyArmor is null))
            {
                strength += bodyArmor.ArmorAttribute.Strength;
                dexterity += bodyArmor.ArmorAttribute.Dexterity;
                intelligence += bodyArmor.ArmorAttribute.Intelligence;
            }

            Armor headArmor = (Armor) Equipment[Slot.Head];
            if (!(headArmor is null))
            {
                strength += headArmor.ArmorAttribute.Strength;
                dexterity += headArmor.ArmorAttribute.Dexterity;
                intelligence += headArmor.ArmorAttribute.Intelligence;
            }

            Armor legsArmor = (Armor) Equipment[Slot.Legs];
            if (!(legsArmor is null))
            {
                strength += legsArmor.ArmorAttribute.Strength;
                dexterity += legsArmor.ArmorAttribute.Dexterity;
                intelligence += legsArmor.ArmorAttribute.Intelligence;
            }

            HeroAttribute total = new HeroAttribute(strength, dexterity, intelligence);
            return total;
        }
        public int TotalWeaponDamage()
        {
            int damage;


            Weapon weapon = (Weapon) Equipment[Slot.Weapon];
            if ( !(weapon is null))
            {
                damage = weapon.WeaponDamage;
            }
            else
                // No weapon equipped
                damage = 1;

            return damage;
        }
        //public float TotalDamage()
        //{
        //    return damage;
        //}

        public string Display()
        {
            HeroAttribute totalattributes = TotalAttributes();

            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + Name + "\n");
            sb.Append("Class: " + classtype + "\n");
            sb.Append("Level: " + Level + "\n");
            sb.Append("Total strength: " + totalattributes.Strength + "\n");
            sb.Append("Total dexterity: " + totalattributes.Dexterity + "\n");
            sb.Append("Total intelligence: " + totalattributes.Intelligence + "\n");
            sb.Append("Damage: " + TotalWeaponDamage() + "\n");

            return sb.ToString();
        }
    }


}
