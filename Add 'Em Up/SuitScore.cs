﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add__Em_Up
{
    public class SuitScore
    {

        public int GetSuitScore(string[] cards)
        {
            var Suitlist = new Suit();
            var Total = 0;
            foreach (string card in cards)
            {
                int CardValue = 

                Total += Suitlist.GetSuit().Where(x => x.Key == card.Substring(1, 1)).FirstOrDefault().Value;
          
            }
            return Total;
        }
    }
}