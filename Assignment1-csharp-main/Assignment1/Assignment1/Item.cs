using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    enum Slot
    {
        Weapon,
        Head,
        Body,
        Legs
    }
    class Item
    {

        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slot Slot { get; set; }

        public Item(string name, int requiredLevel, Slot slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }
    }
}
