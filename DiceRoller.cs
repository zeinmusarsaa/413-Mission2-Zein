using System;

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