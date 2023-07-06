using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments_3
{
    internal class BallColor
    {
        int n;
        public BallColor(int n) 
        {
            this.N = n;
        }

        public int N { get => n; set => n = value; }

        static bool IsFullOfColors(string sequence)
        {
            int redCount = 0;
            int greenCount = 0;
            int yellowCount = 0;
            int blueCount = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                switch (sequence[i])
                {
                    case 'R':
                        redCount++;
                        break;
                    case 'G':
                        greenCount++;
                        break;
                    case 'Y':
                        yellowCount++;
                        break;
                    case 'B':
                        blueCount++;
                        break;
                }

                if (Math.Abs(redCount - greenCount) > 1 || Math.Abs(yellowCount - blueCount) > 1)
                {
                    return false;
                }
            }

            return redCount == greenCount && yellowCount == blueCount;
        }
        public void res()
        {
            for (int i = 0; i < N; i++)
            {
                string sequence = Console.ReadLine();
                Console.WriteLine(IsFullOfColors(sequence) ? "True" : "False");
            }
        }
    }
}
