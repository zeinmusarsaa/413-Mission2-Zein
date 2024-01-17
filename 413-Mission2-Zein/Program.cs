

using System;
//Zein Mosarsaa 4-3, Dice rolling simulator that portrays astrisks that represent 1% of the total num of rolls.

namespace DiceRollingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //According to requirements
            Console.WriteLine("Welcome to the dice throwing simulator!");

            //Asking for an input
            Console.Write("How many dice rolls would you like to simulate? ");

            //assigning that input (after converting it) to an integer variable
            int numberOfRolls = int.Parse(Console.ReadLine());

            //calling second DiceRoller class to simulate dice rolling and assigning it to the results variable
            var results = DiceRoller.RollDices(numberOfRolls);

            //header
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");

            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

            Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

            //loop through dice roll outcomes
            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");

                //calculation for asterisks and displaying it
                double percentage = (double)results[i] / numberOfRolls * 100;

                int asterisksCount = (int)Math.Round(percentage);

                Console.WriteLine(new String('*', asterisksCount));

            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

        public static class DiceRoller
        {
            public static int[] RollDices(int numberOfRolls)
            {
                //create random object for new numbers
                Random random = new Random();
                //indexes 0 and 1 are ignored
                //storing the results of each possible roll
                int[] results = new int[13]; 

                //loop through numberofrolls
                for (int i = 0; i < numberOfRolls; i++)
                {
                    //roll 2 dice & generate random numbers for dice rolls
                    int rollOne = random.Next(1, 7);
                    int rollTwo = random.Next(1, 7);
                    //add both of them to the results
                    results[rollOne + rollTwo]++;
                }

                return results;
            }
        }
    }
}




