using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            Game();
        }

        static void Game ()
        {
            while (true)

            {
                //ask user for dice sides
                Console.WriteLine("How many sides? ");

                string sides = Console.ReadLine();
                int numberSides = int.Parse(sides);


                //prompt user for dice roll
                Console.WriteLine("Do you want to roll the dice or exit?");
                string response = Console.ReadLine();

                if (response == "exit")
                {
                    return;
                }

                int rolledNum = RollDice(numberSides);
                int rolledNumTwo = RollDice(numberSides);

                //display what they have rolled
                Console.WriteLine($"1st number {rolledNum} 2nd number {rolledNumTwo}");

                //ask if user wants to continue
                Console.WriteLine("Play again? (Y/N)");
                response = Console.ReadLine().ToUpper();
                if (response != "Y")
                    return;

            }
        }

        static int RollDice(int numberSides)
        {

            int num = rnd.Next(1, numberSides);

            return num;
        }
    }
}
