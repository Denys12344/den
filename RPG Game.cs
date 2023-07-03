using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        private string A;
        private string B;
        private string C;
        private string D;
        private int damage1;
        private int damage2;

        public void Tournament() // Podawanie imion dla bohaterów
        {
            Console.WriteLine("Podaj imię Bohatera A: ");
            A = Console.ReadLine();
            Console.WriteLine("Podaj imię Bohatera B: ");
            B = Console.ReadLine();
            Console.WriteLine("Podaj imię Bohatera C: ");
            C = Console.ReadLine();
            Console.WriteLine("Podaj imię Bohatera D: ");
            D = Console.ReadLine();
        }

        private void HeroA() // Bohater A
        {
            Console.WriteLine(" - Hey! " +
                " - My name is - " + A + ". I am the strongest warrior of the Kingdom! " +
                " - It's time for a battle! " +
                " - Ha-ha!" +
                "");
            Console.WriteLine("Autor: The " + A + " has 2 skills. First skill is Battle Hunger, that can give 1 more damage and the second one is Battle Call, that can dodge 1 damage from the enemies.");
        }

        private void HeroB() // Bohater B
        {
            Console.WriteLine("- Hi! My name is - " + B +
                "- I am the best Archer in the World!");
            Console.WriteLine("Autor: The " + B + " has 2 skills. First one is Arrow Rain, that gives him +1 to damage and the second one is PowerShot, that gives him +2 to damage.");
        }

        private void HeroC() // Bohater C
        {
            Console.WriteLine(" - Hello! - I am " + C + "!- I will smash all the enemies on my way! - I promised my family to protect the honor of our Kingdom!");
            Console.WriteLine("Autor: The Herald has 2 skills. One of them is Magic Chakra, which can freeze the enemy, that means he can dodge the attack! Also, he has a second skill, Ice Blast, that skill can deal critical +1 damage in 30%.");
        }

        private void HeroD() // Bohater D
        {
            Console.WriteLine(" - Greetings! My name is the " + D + "- If somebody stands in my way, I will CRUSH YOU DOWN...");
            Console.WriteLine("Autor: The Wraith King has 2 skills. First one is Wraith Punch, that skill can make one +1 more damage to his attack. The second is SHIELD OF THE MASTER!!! That skill can dodge 3 damage from the other hero.");
        }

        private void Battle() // Początek bitwy
        {
            Console.WriteLine("Autor: In the left red corner is... The " + A + ". In the right blue corner is... The '" + B + "'. Applause for the 2 Heroes!");
            Console.WriteLine("3");
            Console.WriteLine("2!");
            Console.WriteLine("1!");
            Console.WriteLine("Fight!");
        }

        private void MatchAB() // Bitwa A z B
        {
            Random random = new Random();
            damage1 = random.Next(11);
            damage2 = random.Next(11);
            int battlehunger1 = random.Next(11);
            int battlecall1 = random.Next(11);
            int arrowrain1 = random.Next(11);
            int powershot1 = random.Next(11);

            Console.WriteLine("Damage of the first hero is: " + damage1);
            Console.WriteLine("Damage of the second hero is: " + damage2);

            if (battlehunger1 > 5)
            {
                Console.WriteLine("The hero in the red corner gives +1 damage.");
                damage1 += 1;
            }
            else
            {
                Console.WriteLine("The hero in the red corner didn't dodge the attack.");
            }

            if (battlecall1 > 4)
            {
                Console.WriteLine("The " + A + " dodged the attack, which gives him 1 more armor. So he dodged 1 damage.");
                damage2 -= 1;
            }
            else
            {
                Console.WriteLine("The " + A + " didn't dodge the damage.");
            }

            if (arrowrain1 > 4)
            {
                Console.WriteLine("The " + B + " provides +1 damage.");
                damage2 += 1;
            }
            else
            {
                Console.WriteLine("The " + B + " didn't give +1 damage.");
            }

            if (powershot1 > 4)
            {
                Console.WriteLine("The " + B + " makes +2 damage to his enemy.");
                damage2 += 2;
            }
            else
            {
                Console.WriteLine("The " + B + " doesn't make +2 damage to his enemy.");
            }

            if (damage1 > damage2)
            {
                Console.WriteLine("The hero " + A + " in the red corner won!");
            }
            else
            {
                Console.WriteLine("The hero in the blue corner won!");
            }
        }

        private void MatchCD() // Bitwa C z D
        {
            Random random = new Random();
            int damage3 = random.Next(11);
            int damage4 = random.Next(11);
            int chakra1 = random.Next(11);
            int iceblast1 = random.Next(11);
            int punch1 = random.Next(11);
            int shield1 = random.Next(11);

            Console.WriteLine("Damage of the first hero is: " + damage3);
            Console.WriteLine("Damage of the second hero is: " + damage4);

            if (chakra1 > 5)
            {
                Console.WriteLine("The " + C + " dodged the attack!");
                damage4 = 0;
            }
            else
            {
                Console.WriteLine("The " + C + " didn't dodge the attack.");
            }

            if (iceblast1 > 6)
            {
                Console.WriteLine("The Herald gives +1 more damage.");
                damage3 += 1;
            }
            else
            {
                Console.WriteLine("The Herald doesn't give +1 damage.");
            }

            if (punch1 > 5)
            {
                Console.WriteLine("The " + D + " gives +1 more damage.");
                damage4 += 1;
            }
            else
            {
                Console.WriteLine("The " + D + " doesn't give +1 damage.");
            }

            if (shield1 > 3)
            {
                Console.WriteLine("The " + D + " SHIELD WORKED AND HE DODGED 3 DAMAGE!!!");
                damage3 -= 3;
            }
            else
            {
                Console.WriteLine(D + " Shield didn't work");
            }

            if (damage3 > damage4)
            {
                Console.WriteLine("The hero in the red corner won!");
            }
            else
            {
                Console.WriteLine("The hero in the blue corner won!");
            }
        }

        public void Fight() 
        {
            Battle();
            MatchAB();
            MatchCD();
        }

        public void Result() // Rezultat główny
        {
            Console.WriteLine("As we had 2 winners from the 1st round, now we can match the damage of the Heroes!");

            if (damage1 > damage2)
            {
                Console.WriteLine("The winner is... " + A + "!!! CONGRATULATIONS!!!");
            }
            else
            {
                Console.WriteLine("The Winner is..." + C + "!!! CONGRATULATIONS!!!");
            }

            if (damage2 > damage1)
            {
                Console.WriteLine("The Winner is... " + B + "!!! CONGRATULATIONS!!!");
            }
            else
            {
                Console.WriteLine("The Winner is..." + D + "!!! CONGRATULATIONS!!!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Tournament();
            game.Fight();
            game.Result();

            Console.ReadLine();
        }
    }
}

