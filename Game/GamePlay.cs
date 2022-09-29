
namespace Game
{
    public class GamePlay
    {
        public List<GameTable> Table = new();
        public Suit SuitScore = new();
        public Card CardScore = new();

        public List<GameTable>Play(string[] gameList)
        {
            foreach (var game in gameList)
            {
                var cards = game.Split(':')[1].Split(',');

                Table.Add(new GameTable
                {
                    Player = game.Split(':')[0],
                    Cards = cards,
                    CardScore = CardScore.GetCardScore(cards),
                    SuitScore = SuitScore.GetSuitScore(cards)
                });
            }
            return Table;
        }
    }
}
