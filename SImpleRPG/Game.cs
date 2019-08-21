using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SImpleRPG
{
    class Game
    {
        string playerName = "";
        int playerHealth = 100;
        public void Start()
        {
            Welcome();

            int monsterRemaining = 5;
            bool alive = true;
            
            //fight until you lose
            while (alive && monsterRemaining > 0)
            {
                Console.WriteLine("There are " + monsterRemaining + " monsters remaining.");
                alive = Encounter(20);
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

        bool Encounter(int monsterDamage)
        {
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
                if (playerHealth <= 0)
                {
                    //player defeat!
                    Console.WriteLine(playerName + " was defeated...");
                    return false;
                }
                //player attack
                Console.WriteLine(playerName + " attacks! The monster got yeeted!");

            }
            else if (action == "flee" || action == "Flee")
            {
                //escape
                Console.WriteLine("Pussy...");
            }
            return true;
        }
    }
}
