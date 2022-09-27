using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add__Em_Up
{
    public class Vaildation
    {
        public bool checkGame(string[] gameLst)
        {
            //reminder: use recursion 
            var a = CheckNumberOfRows(gameLst);

            if(a)
            {
                var c = CheckForColon(gameLst);

                if(c)
                {
                    var b = CheckNumberOfCards(gameLst);

                    if(b)
                    {
                        var d = CheckForcomma(gameLst);
                        var e = CheckForCardLength(gameLst);
                        var f = CheckForCardSuits(gameLst);

                        if(d && e && f)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

                
            }
            else
            {
                return false;
            }

            

           

           

  
            
        }

        private bool CheckNumberOfRows(string[] gameLst)
        {
            if(gameLst.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private bool CheckNumberOfCards(string[] gameLst)
        {
            var flag = true;
            for( int i =0; (i < gameLst.Length && flag) ; i++)
            {
                string[] cards = gameLst[i].Split(':')[1].Split(',');

                if (cards.Length == 5)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;

        }

        private bool CheckForColon(string[] gameLst)
        {
            var flag = true;
            for (int i = 0; (i < gameLst.Length && flag); i++)
            {
                string[] players = gameLst[i].Split(':');

                if (players.Length == 1)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }

        private bool CheckForcomma(string[] gameLst)
        {
            var flag = true;
            for (int i = 0; (i < gameLst.Length && flag); i++)
            {
                string[] cards = gameLst[i].Split(':')[1].Split(',');

                if (cards.Length == 1)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            return flag;
        }

        private bool CheckForCardLength(string[] gameLst)
        {
            var flag = true;
            for (int j = 0; (j < gameLst.Length && flag); j++)
            {
                string[] cards = gameLst[j].Split(':')[1].Split(',');

                for (int i = 0; (i < cards.Length && flag); i++)
                {

                    if (cards[i].Length >=2 && cards[i].Length <=3)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
               
            return flag;
        }

        private bool CheckForCardSuits(string[] gameLst)
        {
            var flag = true;
            for (int j = 0; (j < gameLst.Length && flag); j++)
            {
                string[] cards = gameLst[j].Split(':')[1].Split(',');

                for (int i = 0; (i < cards.Length && flag); i++)
                {

                    var suit = cards[i].Substring(cards[i].Length-1);

                    switch (suit.ToLower())
                    {
                        case "s":
                        case "h":
                        case "d":
                        case "c":
                            flag = true;
                            break;
                        default:
                            flag = false;
                            break;
                    }
                }
            }
            return flag;
        }
    }
}
