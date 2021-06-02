using System;

namespace DNDCombatSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Creature skeleton = new Creature("a skeleton", 13, 13, 4, 6, 2, 2);
            Creature zombie = new Creature("a zombie", 22, 8, 3, 6, 1, -1);

            Battle1v1(skeleton, zombie);
        }

        static void Battle1v1(Creature creature1, Creature creature2)
        {
            int initiative1 = roll(20, creature1.initiativeBonus);
            int initiative2 = roll(20, creature2.initiativeBonus);

            Creature combatant1 = null;
            Creature combatant2 = null;

            if (initiative1 >= initiative2) //initative ties go to combatant1
            {
                combatant1 = creature1;
                combatant2 = creature2;
            }
            else
            {
                combatant1 = creature2;
                combatant2 = creature1;
            }

            for (int round = 1; round <= 10; round++)    //battle ends after 10 rounds
            {
                if (attack(combatant1, combatant2))
                {
                    Console.WriteLine(combatant1.name + " emerges victorious!");
                    return;
                }

                if (attack(combatant2, combatant1))
                {
                    Console.WriteLine(combatant2.name + " emerges victorious!");
                    return;
                }
            }

            Console.WriteLine("Both " + combatant1.name + " and " + combatant2.name + "survive!");
        }

        static bool attack(Creature attacker, Creature target)
        {
            int attackRoll = roll(20, attacker.attackBonus);
            if (attackRoll >= target.armorClass)
            {
                int damage = roll(attacker.damageDie, attacker.damageDie);
                target.currentHP -= damage;
                Console.WriteLine(attacker.name + " hits " + target.name + " with an attack dealing " + damage + " damage!");
                if (target.currentHP <= 0)
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine(attacker.name + " misses " + target.name + " with an attack.");
            }

            return false;
        }

        //TODO: add capitalization modification;

        /*TODO
        static int roll(string rollString)
        {
            //TODO: use regex?
        }
        */

        static int roll(int die, int bonus)
        {
            Random random = new System.Random();
            return random.Next(1, die + 1) + bonus;
        }
    }
}
