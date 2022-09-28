using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add__Em_Up
{
    public class GamePlay
    {

        public List<GameTable>Play(string[] gameList)
        {
            var table = new List<GameTable>();
            var suitScore = new SuitScore();
            var cardScore = new CardScore();
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
