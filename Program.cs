// Crew Manwaring, Section 02

namespace Mission02;
// First class below, which provides some statements to the user as well as an opportunity to input how many rolls
public class DiceSimulator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throw simulation\nHow many dice rolls do you want to do?");

        if (!int.TryParse(Console.ReadLine(), out int numRolls) || numRolls <= 0)
        {
            Console.WriteLine("Please enter a valid number"); // Place where user inputs/types valid dice roll number
            return;
        }

        DiceRoller roller = new DiceRoller();
        int[] rollCounts = roller.SimulateRolls(numRolls);

        Console.WriteLine(
            "\nDICE ROLLING SIMULATION\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " +
            numRolls);
// Code below to offer the histogram via asterisks and percentages
        for (int i = 2; i <= 12; i++)
        {
            double percentage = (double)rollCounts[i - 2] / numRolls * 100;
            int numStars = (int)Math.Round(percentage);

            Console.WriteLine($"{1}: {new string('*', numStars)} ({percentage:F2}%)");
        }

        Console.WriteLine("\nThank you for using the dice simulator! Bye");
    }
}

// Second class for dice rolling functionality 
public class DiceRoller
{
    public int[] SimulateRolls(int numRolls)
    {
        int[] rollCounts = new int[11]; // Array to store counts of every combo 2-12
        Random random = new Random();
        
        for (int i = 0; i < numRolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            rollCounts[die1 + die2 - 2]++; // Corresponding indexes (0 to sum 2, 1 to sum 3, etc.)
        }
        // Returning rollCounts below

        return rollCounts;
    }
}    

    