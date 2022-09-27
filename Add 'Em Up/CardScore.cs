using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add__Em_Up
{
    public class CardScore
    {  
        public int GetCardScore(string[] cards)
        {
            var CardList  = new Card();
            var Total = 0;
            foreach (var card in cards)
            {

                Total += CardList.GetCards().Where(x => x.Key == card.Substring(0, 1)).FirstOrDefault().Value;

            }
            return Total;
        }
    }
}
