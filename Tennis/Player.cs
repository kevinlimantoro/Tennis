using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Index = 0;
        public int[] ScoreIndex = new int[4] { 0, 15, 30, 40 };
        public string[] ScoreNameIndex = new string[4] { "Love", "Fifty", "Thirty", "Forty" };
        public Player(string name) {
            Name = name;
            Index = 0;
            Score = ScoreIndex[Index];
        }
        public void AddScore() {
            Index++;
            Score = ScoreIndex[Index > 3 ? 3 : Index];
        }

        public string GetScoreName() {
            return ScoreNameIndex[Index];
        }
    }
}
