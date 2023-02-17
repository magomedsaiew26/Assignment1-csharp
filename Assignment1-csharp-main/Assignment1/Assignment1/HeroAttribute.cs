using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public HeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void increase(int d_strength, int d_dexterity, int d_intelligence)
        {
            Strength += d_strength;
            Dexterity += d_dexterity;
            Intelligence += d_intelligence;

        }
    }
}
