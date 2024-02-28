using System;
namespace MainMethods;
using Newtonsoft.Json;
public class Registration
{
    public static void Register(out string[] playerNames, out int[] blitz, out int[] field, out int targetSum)
    {
        Console.Write("Write amount of players: ");
        int playerCount;
        while (!int.TryParse(Console.ReadLine(), out playerCount) || playerCount <= 0)
            Console.Write("Invalid input. Please enter right number: ");

        playerNames = new string[playerCount];
        blitz = new int[playerCount];
        field = new int[playerCount];
        Console.Write("Write winner Sum: ");
        while (!int.TryParse(Console.ReadLine(), out targetSum) || targetSum <= 0)
            Console.Write("Invalid input. Please enter right number: ");

        for (var i = 0; i < playerCount; i++)
        {
            Console.WriteLine($"Write player name {i + 1}: ");
            var name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid input. Please enter real name without numbers!:");
                Console.WriteLine($"Write player name {i + 1}: ");
                name = Console.ReadLine();
            }

            playerNames[i] = name;
        }
    }
}