using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitTest ut = new UnitTest();

            // Testing hero construction
            ut.TestMageConstructor();
            ut.TestRangerConstructor();
            ut.TestRogueConstructor();
            ut.TestWarriorConstructor();

            // Testing hero add one level
            ut.TestMageLevelIncrease();
            ut.TestRangerLevelIncrease();
            ut.TestRogueLevelIncrease();
            ut.TestWarriorLevelIncrease();

            // Testing equipment construction
            ut.TestWeaponConstructor();
            ut.TestArmorConstructor();

            // Testing hero Equip
            ut.TestHeroEquipWeapon();
            ut.TestHeroEquipArmor();

            // Testing Hero action
            ut.TestHeroDamage();
        }
    }
}
