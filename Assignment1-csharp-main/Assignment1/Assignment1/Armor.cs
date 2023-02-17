using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }

    class Armor : Item
    {
        public ArmorType ArmorType { get; set; }
        public HeroAttribute ArmorAttribute { get; set; }

        public Armor(string name, int requiredLevel, ArmorType armorType, Slot slot, HeroAttribute armorAttribute) : base(name, requiredLevel, Slot.Body)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            ArmorType = armorType;
            Slot = slot;
            ArmorAttribute = armorAttribute;

        }

    }
}
