using static System.Console;
using Game;

var card = new Card();
var suit = new Suit();
var validation = new Validation();

var gameTable = new List<GameTable>();
var gameList = File.ReadAllLines("abc.txt");

WriteLine("Processing File");
if (!Validation.CheckGame(gameList))
{
  DisplayResults("An error has occurred.");
  return;
}

foreach (var game in gameList)
{
  var listOfCards = game.Split(':')[1].Split(',');

  gameTable.Add(new GameTable
  {
    Player = game.Split(':')[0],
    Cards = listOfCards,
    CardScore = card.GetCardScore(listOfCards),
    SuitScore = suit.GetSuitScore(listOfCards)
  });
}

var cardScore = gameTable.Max(x => x.CardScore);
var suitScore = gameTable.Max(x => x.SuitScore);
var playerList = gameTable.Where(x => x.SuitScore == suitScore && x.CardScore == cardScore).Select(x => x.Player);

DisplayResults(string.Join(",", playerList) + ":" + cardScore);

void DisplayResults(string listOfWinners)
{
  File.WriteAllText("xyz.txt", string.Empty);

  using (var writer = new StreamWriter("xyz.txt"))
  {
    writer.WriteLine(listOfWinners);
  }

  Thread.Sleep(3000);

  WriteLine("\n Processing Completed. Please check output file");

  ReadLine();
}
