using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add__Em_Up
{
    public class Card
    {


       public List<KeyValuePair<string, int>> GetCards()
        {
            List<KeyValuePair<string, int>> cards = new List<KeyValuePair<string, int>>(){
                new KeyValuePair<string, int>("A", 1),
                new KeyValuePair<string, int>("2", 2),
                new KeyValuePair<string, int>("3", 3),
                new KeyValuePair<string, int>("4", 4),
                new KeyValuePair<string, int>("5", 5),
                new KeyValuePair<string, int>("6", 6),
                new KeyValuePair<string, int>("7", 7),
                new KeyValuePair<string, int>("8", 8),
                new KeyValuePair<string, int>("9", 9),
                new KeyValuePair<string, int>("10", 10),
                new KeyValuePair<string, int>("J", 11),
                new KeyValuePair<string, int>("Q", 12),
                new KeyValuePair<string, int>("K", 13)
            };
            return cards;
   
        }
        
    }
}

