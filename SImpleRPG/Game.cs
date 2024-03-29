﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleRPG
{
    class Game
    {
        string playerName = "";
        int playerMaxHealth = 125;
        int playerHealth = 125;
        int playerDamage = 25;
        int playerHealing = 50;
        public void Start()
        {
            Welcome();

            int monsterRemaining = 5;
            bool alive = true;
            
            //fight until you lose
            while (alive && monsterRemaining > 0)
            {
                Console.WriteLine("There are " + monsterRemaining + " monsters remaining.");
                alive = Encounter(20, 20);
                monsterRemaining--;
            }

            Console.ReadKey();
        }
        void Welcome()
        {
            //Welcome the player
            Console.Write("What is your name? ");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome, " + playerName + ".");
        }

        bool Encounter(int monsterDamage, int monsterHealth)
        {
            Console.WriteLine("");
            Console.WriteLine("Hey Chief there is a monster in front of you");


            string action = "";
            bool survived = true;
            while (playerHealth > 0 && monsterHealth > 0)
            {
                Console.Write("What will you do? (fight/flee/heal) ");
                action = Console.ReadLine();
                if (action == "fight" || action == "Fight")
                {
                    survived = fight(ref monsterHealth, ref monsterDamage);
                    if (!survived)
                    {
                        return false;
                    }
                }
                else if (action == "flee" || action == "Flee")
                {
                    //escape
                    survived = flee();
                    if (survived)
                    {
                        return true;
                    }
                }
                else if (action == "heal" || action == "Heal")
                {
                    survived = heal(ref playerHealth, ref playerHealing, ref monsterHealth, ref monsterDamage);
                    if (survived)
                    {
                        return true;
                    }
                }
            }
            return survived;
        }

        bool  fight(ref int monsterHealth, ref int monsterDamage)
        {
            //monster attack
            Console.WriteLine("The monster attacks! " + playerName + " takes " + monsterDamage + " damage!");
            playerHealth = playerHealth - monsterDamage;
            Console.WriteLine(playerName + " has " + playerHealth + " health remaining.");
            if (playerHealth <= 0)
            {
                //player defeat!
                Console.WriteLine(playerName + " was defeated...");
                return false;
            }
            //player attack
            Console.WriteLine(playerName + " attacks! The monster takes " + playerDamage + " damage.");
            monsterHealth -= playerDamage;
            Console.WriteLine("The monster has " + monsterHealth + " health remaining.");
            if (monsterHealth <= 0)
            {
                //monster defeat
                Console.WriteLine("Monster was yeeted");
                return true;
            }
            return true;
        }

        bool flee()
        {
            //escape
            Console.WriteLine("Pussy...");
            return true;
        }

        bool heal(ref int playerHealth, ref int playerHealing, ref int monsterHealth, ref int monsterDamage)
        {
            //player heal
            Console.WriteLine(playerName + " uses sparking blast " + playerName + " recovers " + playerHealing + " health.");
            playerHealth += playerHealing;
            if (playerHealth > playerMaxHealth)
            {
                playerHealth = playerMaxHealth;
            }
            Console.WriteLine("You have " + playerHealth + " remaining.");
            return true;
        }
    }
}
