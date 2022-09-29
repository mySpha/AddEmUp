namespace Game
{
  public class Card
  {
    public List<KeyValuePair<string, int>> Cards => GetCards();

    public List<KeyValuePair<string, int>> GetCards()
    {
      return new List<KeyValuePair<string, int>>()
      {
        new ("A", 1), new ("2", 2), new ("3", 3), new ("4", 4),
        new ("5", 5), new ("6", 6), new ("7", 7), new ("8", 8),
        new ("9", 9), new ("10", 10), new ("J", 11), new ("Q", 12),
        new ("K", 13)
      };
    }

    public int GetCardScore(string[] cards) => cards.Sum(card => Cards.FirstOrDefault(x => x.Key == card[..1]).Value);
  }
}

