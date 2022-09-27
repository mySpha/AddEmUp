

using Add__Em_Up;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


var suitScore = new SuitScore();
var cardScore = new CardScore();
var vaildation = new Vaildation();
string winner = "";
List<GameTable> table = new List<GameTable>();


//Console.WriteLine("Players\t Cards\t\t Suit point\t\t Card point");

string[] gameList = File.ReadAllLines("abc.txt");

Console.WriteLine("Processing File");
if (!vaildation.checkGame(gameList))
{
    winner = "ERROR";
}
else
{

    foreach (string game in gameList)
    {
        string[] cards = game.Split(':')[1].Split(',');

        table.Add(new GameTable
        {
            Player = game.Split(':')[0],
            Cards = cards,
            CardScore = cardScore.GetCardScore(cards),
            SuitScore = suitScore.GetSuitScore(cards)
        });
    }

    var orderedTableByCardScore = table.OrderByDescending(x => x.CardScore).ToList();

    var highestScore = orderedTableByCardScore.FirstOrDefault().CardScore;

    var highScorePlay = orderedTableByCardScore.Where(x => x.CardScore == highestScore);

    if (highScorePlay.Count() > 1)
    {
        highestScore = highScorePlay.OrderByDescending(x => x.SuitScore).FirstOrDefault().SuitScore;
        var playerList = orderedTableByCardScore.Where(x => x.SuitScore == highestScore).Select(x => x.Player);

        winner = String.Join(",", playerList) + ":" + highestScore;
    }
    else
    {
        var player = highScorePlay.FirstOrDefault();
        winner = player.Player + ":" + player.CardScore;
    }



    //foreach (var item in orderedTable)
    //{
    //    Console.WriteLine(item.Player
    //        + "\t" + String.Join(",", item.Cards) +
    //       "\t\t" + item.SuitScore.ToString() +
    //       "\t\t" + item.CardScore.ToString());
    //}

    //Console.WriteLine();
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

//Console.WriteLine(String.Format("Winner : {0}", output.ToString()));
// Suspend the screen.  
System.Console.ReadLine();
