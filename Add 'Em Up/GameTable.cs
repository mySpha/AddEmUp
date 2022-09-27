using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add__Em_Up
{
    public class GameTable
    {
        public string Player { get; set; }
        public string[] Cards { get; set; }
        public int CardScore { get; set; }
        public int SuitScore { get; set; }
    }
}
