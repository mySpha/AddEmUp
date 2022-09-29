namespace Game
{
    public class BestHand
    {
        string winningHand;
        public string CompareScores(List<GameTable> gameTable)
        {
            var orderedTableByCardScore = gameTable.OrderByDescending(x => x.CardScore).ToList();

            var highestScore = orderedTableByCardScore.FirstOrDefault().CardScore;

            var highScorePlay = orderedTableByCardScore.Where(x => x.CardScore == highestScore);

            if (highScorePlay.Count() > 1)
            {
                highestScore = highScorePlay.OrderByDescending(x => x.SuitScore).FirstOrDefault().SuitScore;
                var playerList = orderedTableByCardScore.Where(x => x.SuitScore == highestScore).Select(x => x.Player);

                winningHand = string.Join(",", playerList) + ":" + highestScore;
            }
            else
            {
                var player = highScorePlay.FirstOrDefault();
                winningHand = player.Player + ":" + player.CardScore;
            }
            return winningHand;
        }
    }
}
