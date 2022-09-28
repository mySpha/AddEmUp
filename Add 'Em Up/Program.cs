

using Add__Em_Up;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


public class Program
{
    private static void Main(string[] args)
    {
        var vaildation = new Vaildation();
        string winner = "";
        var gameTable = new List<GameTable>();
        var gamePlay = new GamePlay();
        var bestHand = new BestHand();

        string[] gameList = File.ReadAllLines("abc.txt");

        Console.WriteLine("Processing File");
        if (!vaildation.checkGame(gameList))
        {
            winner = "ERROR";
        }
        else
        {
            gameTable = gamePlay.Play(gameList);
            winner = bestHand.CompareScores(gameTable);
            Console.WriteLine();
        }

        File.WriteAllText("xyz.txt", string.Empty);
        using (StreamWriter writer = new StreamWriter("xyz.txt"))
        {
            writer.WriteLine(winner);
        }

        int milliseconds = 3000;
        Thread.Sleep(milliseconds);
        Console.WriteLine();
        Console.WriteLine("Processing Completed. Please check output file");
        // Suspend the screen.  
        Console.ReadLine();
    }
}