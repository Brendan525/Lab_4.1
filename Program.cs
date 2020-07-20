using System;

namespace Lab_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.WriteLine("How many sides should each die have?");

            int sides = Convert.ToInt32(Console.ReadLine());

            if (sides == 6)
            {
                GetMessages();
            }
            else
            {
                OtherDice(ref sides);
            }
            
        }

        static int GetRoll(out int dice, out int dice2, out int total)
        {
            Random rand = new Random();

            dice = rand.Next(1, 7);

            Random rand2 = new Random();

            dice2 = rand2.Next(1, 7);

            total = dice + dice2;

            Console.WriteLine($"You rolled a {dice} and {dice2} ({total} total)");

            return total;
        }

        static void GetMessages()
        {
            bool reRoll = true;
            do
            { 

            GetRoll(out int dice, out int dice2, out int total);

            if (total == 7 || total == 11)
            {
               Console.WriteLine("Win!");
            }

            else if (dice == 1 && dice2 == 1)
            {
                Console.WriteLine("Snake Eyes");
                Console.WriteLine("Craps!");
            }

            else if (dice == 1 && dice2 == 2 || dice == 2 && dice2 == 1)
            {
                Console.WriteLine("Ace Deuce");
                Console.WriteLine("Craps!");
            }

            else if (dice == 6 && dice2 == 6)
            {
                Console.WriteLine("Box Cars");
                Console.WriteLine("Craps!");
            }

            Console.WriteLine();

            Console.WriteLine("Roll Again? (y/n)");

            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                Console.WriteLine();
                reRoll = true;
            }
            else if (playAgain == "n")
            {
                Console.WriteLine("Thanks for playing");
                reRoll = false;
            }
        } while (reRoll);
        
        }



        static void OtherDice(ref int sides)
        {
            int num = sides + 1;
            bool reRoll = true;
            do
            {

                Random rand = new Random();

                int dice = rand.Next(1, num);

                Random rand2 = new Random();

                int dice2 = rand2.Next(1, num);

                int total = dice + dice2;

                Console.WriteLine($"You rolled a {dice} and {dice2} ({total} total)");

                Console.WriteLine();

                Console.WriteLine("Roll Again? (y/n)");

                string playAgain = Console.ReadLine();

                if (playAgain == "y")
                {
                    Console.WriteLine();
                    reRoll = true;
                }
                else if (playAgain == "n")
                {
                    Console.WriteLine("Thanks for playing");
                    reRoll = false;
                }

            } while (reRoll);
        }
    }
}
