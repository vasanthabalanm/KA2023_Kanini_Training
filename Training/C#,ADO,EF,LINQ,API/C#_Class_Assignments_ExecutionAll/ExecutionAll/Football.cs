using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionAll
{
    internal class Football
    {
        private int wins;
        private int draws;
        private int losses;

        public Football(int wins, int draws, int losses)
        {
            this.Wins = wins;
            this.Draws = draws;
            this.Losses = losses;
        }

        public int Wins { get => wins; set => wins = value; }
        public int Draws { get => draws; set => draws = value; }
        public int Losses { get => losses; set => losses = value; }

        public int scores()
        {
            int points = this.Wins * 3 +this.Draws * 1 +this.Losses * 0;
            return points;
        }
    }
}
