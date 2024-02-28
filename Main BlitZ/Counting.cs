using ConsoleTables;

namespace MainMethods;

public class Counting
{
    public static void Count(string[] playerNames, int[] blitz, int[] field, int targetSum)
    {
        var targetReached = false;
        var total = new int[playerNames.Length];
        var table = new ConsoleTable("Player", "Blitz", "Field", "Total");

        while (!targetReached)
        {
            for (var i = 0; i < playerNames.Length; i++)
            {
                Console.Write($"Enter blitz for {playerNames[i]}: ");
                while (!int.TryParse(Console.ReadLine(), out blitz[i]) || blitz[i] < 0)
                    Console.Write("Invalid input. Please enter number!: ");

                Console.Write($"Enter field for {playerNames[i]}: ");
                while (!int.TryParse(Console.ReadLine(), out field[i]) || field[i] < 0)
                    Console.Write("Invalid input. Please enter number!: ");

                total[i] += blitz[i] * -2 + field[i];

                if (total[i] >= targetSum)
                {
                    Console.WriteLine($"{playerNames[i]} has reached the target sum!");
                    targetReached = true;
                    break;
                }
            }
            Console.Clear();
            for (var i = 0; i < playerNames.Length; i++) table.AddRow(playerNames[i], blitz[i], field[i], total[i]);
            table.Write();
        }
    }
}