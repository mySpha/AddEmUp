namespace Game
{
  public class Validation
  {
    public static bool CheckGame(string[] gameList)
    {
      if (!CheckNumberOfRows(gameList) || !CheckForColon(gameList) || !CheckNumberOfCards(gameList))
        return false;

      return CheckForComma(gameList) && CheckForCardLength(gameList) && CheckForCardSuits(gameList);
    }

    private static bool CheckNumberOfRows(IReadOnlyCollection<string> gameList)
    {
      return gameList.Count == 5;
    }

    private static bool CheckNumberOfCards(IReadOnlyList<string> gameList)
    {
      var flag = true;
      for (var i = 0; (i < gameList.Count && flag); i++)
      {
        var cards = gameList[i].Split(':')[1].Split(',');

        flag = cards.Length == 5;
      }

      return flag; 
    }

    private static bool CheckForColon(IReadOnlyList<string> gameList)
    {
      var flag = true;
      for (var i = 0; (i < gameList.Count && flag); i++)
      {
        var players = gameList[i].Split(':');

        flag = players.Length != 1;
      }

      return flag;
    }

    private static bool CheckForComma(IReadOnlyList<string> gameList)
    {
      var flag = true;
      for (var i = 0; (i < gameList.Count && flag); i++)
      {
        var cards = gameList[i].Split(':')[1].Split(',');

        flag = cards.Length != 1;
      }

      return flag;
    }

    private static bool CheckForCardLength(IReadOnlyList<string> gameList)
    {
      var flag = true;
      for (var j = 0; (j < gameList.Count && flag); j++)
      {
        var cards = gameList[j].Split(':')[1].Split(',');

        for (var i = 0; (i < cards.Length && flag); i++)
        {
          flag = cards[i].Length is >= 2 and <= 3;
        }
      }

      return flag;
    }

    private static bool CheckForCardSuits(IReadOnlyList<string> gameList)
    {
      var flag = true;
      for (var j = 0; (j < gameList.Count && flag); j++)
      {
        var cards = gameList[j].Split(':')[1].Split(',');

        for (var i = 0; (i < cards.Length && flag); i++)
        {
          var suit = cards[i].Substring(cards[i].Length - 1);

          flag = suit.ToLower() switch
          {
            "s" => true,
            "h" => true,
            "d" => true,
            "c" => true,
            _   => false
          };
        }
      }

      return flag;
    }
  }
}
