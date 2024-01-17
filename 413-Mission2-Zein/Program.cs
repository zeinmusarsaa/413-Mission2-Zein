using System;
//Zein Mosarsaa 4-3, Dice rolling simulator that portrays astrisks that represent 1% of the total num of rolls.

namespace DiceRollingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.Write("How many dice rolls would you like to simulate? ");


            int numberOfRolls = int.Parse(Console.ReadLine());
            var results = DiceRoller.RollDices(numberOfRolls);

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");

            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");

            Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

            for (int i = 2; i <= 12; i++)
            {
                Console.Write($"{i}: ");
                // I found that having one united one results in different asterisks that don't seem compatible
                //with the number of rolls. For example I was getting over 100 asterisks for a dice roll of 5
                // For those with less than 100:
                if (numberOfRolls < 100)
                {
                    // For fewer rolls, display asterisks corresponding to the actual count
                    Console.WriteLine(new String('*', results[i]));
                }
                else //those more than 100
                {
                    int asterisksCount = (results[i] * 100) / numberOfRolls;
                    Console.WriteLine(new String('*', asterisksCount));
                }
            }



            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }

        public static class DiceRoller
        {
            public static int[] RollDices(int numberOfRolls)
            {
                Random random = new Random();
                //indexes 0 and 1 are ignored
                int[] results = new int[13]; 

                for (int i = 0; i < numberOfRolls; i++)
                {
                    int rollOne = random.Next(1, 7);
                    int rollTwo = random.Next(1, 7);
                    results[rollOne + rollTwo]++;
                }

                return results;
            }
        }
    }
}





