
namespace Add__Em_Up
{
    public class GamePlay
    {
        List<GameTable> table = new List<GameTable>();
        SuitScore suitScore = new SuitScore();
        CardScore cardScore = new CardScore();
        public List<GameTable>Play(string[] gameList)
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
            return table;
        }
    }
}
