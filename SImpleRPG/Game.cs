using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleRPG
{
    class Game
    {
        public void Start()
        {
            string playerName = "";
            int playerHealth = 100;

            //Welcome the player
            Console.Write("What is your name? ");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome, " + playerName + ".");

            //Monster encounter!
            int monsterDamage = 13;
            Console.WriteLine("");
            Console.WriteLine("There is a monster in front of you");


            string action = "";
            Console.Write("What will you do? (fight/flee) ");
            action = Console.ReadLine();
            if (action == "fight" || action == "Fight")
            {
                //monster attack
                Console.WriteLine("THe monster attacks! " + playerName + " takes " + monsterDamage + " damage!");
                playerHealth = playerHealth - monsterDamage;
                Console.WriteLine(playerName + " has " + playerHealth + " health remaining.");
                //player attack
                Console.WriteLine(playerName + " attacks! The monster is defeated!");

            }
            else if (action == "flee" || action == "Flee")
            {
                //escape
                Console.WriteLine("Got away safely...");
            }

            Console.ReadKey();
        }
    }
}
