namespace Game
{
  public class Suit
  {
    private IEnumerable<KeyValuePair<string, int>> Suits => GetSuitList();
    
    public List<KeyValuePair<string, int>> GetSuitList()
    {
      return new List<KeyValuePair<string, int>>()
      {
        new("D", 2), new("H", 3), new("S", 4), new("C", 1)
      };
    }

    public int GetSuitScore(string[] cards)
    { 
      return cards.Sum(card => Suits.FirstOrDefault(x => x.Key == card.Substring(1, 1)).Value);
    }
  }
}
