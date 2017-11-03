using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis;

namespace Tennis
{
    class Game
    {
        private static Player p1 = new Player("Player 1");
        private static Player p2 = new Player("Player 2");
        private static Player AdvantagePlayer = new Player("");
        private static bool isDeuce = false;
        static void Main(string[] args)
        {
            while (true) {
                printScore();
                //check which player score here p1 or p2
                p1.AddScore();
                setAdvantagePlayer();
                checkDeuce();
                isGotWinner();
                break;
            }
        }

        static void printScore() {
            Console.WriteLine(p1.Name + " " + p1.GetScoreName() + " - " + p2.GetScoreName() + " " + p2.Name);
        }

        static void checkDeuce() {
            isDeuce = p1.Index == p2.Index && p1.Index >= 2;
        }

        static void setAdvantagePlayer() {
            AdvantagePlayer = p1.Index > p2.Index ? p1 : p2;
        }

        static bool isGotWinner() {
            if (isDeuce)
                return false;
            return ((p1.Index - p2.Index >=2 && AdvantagePlayer.Name == p1.Name) || (p2.Index - p1.Index >= 2 && AdvantagePlayer.Name == p2.Name));
        }
    }
}
