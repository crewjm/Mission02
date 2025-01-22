namespace Mission02;

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
        // Testing to see if gitHub updates my changes ignore
    }
}    