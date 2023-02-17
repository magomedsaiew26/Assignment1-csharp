# Assignment1-csharp

RPG Heroes


Purpose:

Create a C# framework for Role-Playing Game applications.

Data types:

* Heroes
* Weapons
* Armor
* UnitTest


Heroes

Heroes have an attribute

* Level

and three HeroAttributes:

* Strength
* Dexterity
* Intelligence

* ValidWeaponTypes
* ValidArmortypes

A hero starts at level 1 with a given set of values for Strength, Dexterity
and Intelligence. When a hero's level advances, the values of his
HeroAttributes are increased. 

A hero may be equipped with a weapon and three types of armor (for Head, Body
and Legs). The attribute ValidWeaponTypes is a list of weapons that the hero
can be equipped with. The attribute ValidArmortypes is a list of armor types
that the hero can be equipped with.

The performance of a hero in a fight is set by the amount of damage he can do.
This damage is based on the hero's weapon and is increased by the hero's
TotalDamage attribute. The damaging attribute is calculated from the
HeroAttributes.


Heroes can be one of four classes:

- Mage
- Ranger
- Rogue
- Warrior

Each of these classes have its own set of initial HeroAttributes,
HeroAttribute increments (when advancing to a new level). and method of
calculating TotalDamage. 

A Hero may be equipped with with a weapon and several types of armor
(for Head, Body and Legs).


The UnitTest class

This class have no fields, but contain a number of methods for performing unit
tests:

- TestHeroAttributes

     for testing the values (Strength, Dexterity, Intelligence) of a specific
     HeroAttribute object


For testing the constructors of the Hero types:

- TestMageConstructor
- TestRangerConstructor
- TestRogueConstructor
- TestWarriorConstructor


For testing advancing the level of the Hero types.

- TestMageLevelIncrease
- TestRangerLevelIncrease
- TestRogueLevelIncrease
- TestWarriorLevelIncrease


For testing the construction of a Weapon object:

- TestWeaponConstructor


For testing the construction of an Armor object:

- TestArmorConstructor


For testing equiooing a Hero:

- TestHeroEquipWeapon
- TestHeroEquipArmor


For testing a Hero damage calculation:

- testHeroDamage


These tests are performed in the main routine of the Program class: the program
creates an UnitTest object and calls the various testing methods that UnitTest
offers.

In programming the unit test methods, I used the Xunit Assert class object
by checking values using the Assert.Equal method. For some of the tests, the
testing procedure relies on Assert.Throws catching an exception raised by the
program to be tested. For example, equipping a warrier with a Staff raises an
InvalidWeaponsException since a Staff is not among the allowed weapons for a
warrior.

I could not get the Assert.Throws method to catch the exceptions that the Equip
method raises. This means that the program crashes when I try these test. I
therefore had to comment out the tests involving Exceptions.

