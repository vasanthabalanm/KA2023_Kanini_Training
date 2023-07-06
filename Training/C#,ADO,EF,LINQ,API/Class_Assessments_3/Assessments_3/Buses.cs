using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments_3
{
    internal class Buses
    {
        static int[] parent;
        static int[] size;
        private int n;
        private int m;

        public Buses(int n, int m)
        {
            this.N = n;
            this.M = m;
        }

        public static int[] Parent { get => parent; set => parent = value; }
        public static int[] Size { get => size; set => size = value; }
        public int N { get => n; set => n = value; }
        public int M { get => m; set => m = value; }

        static int Find(int x)
        {
            if (Parent[x] == x)
            {
                return x;
            }
            return Parent[x] = Find(Parent[x]);
        }

        static void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
            {
                if (Size[rootX] < Size[rootY])
                {
                    int temp = rootX;
                    rootX = rootY;
                    rootY = temp;
                }
                Parent[rootY] = rootX;
                Size[rootX] += Size[rootY];
            }
        }
        public void fetchs()
        {
            parent = new int[n + 1];
            size = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine().Split();
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                Union(x, y);
            }
            int[] groupSize = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                groupSize[Find(i)]++;
            }
            int cost = 0;
            int remaining = n;
            for (int i = 1; i <= n; i++)
            {
                if (groupSize[i] > 0)
                {
                    int k = (int)Math.Ceiling(Math.Sqrt(groupSize[i]));
                    cost += k;
                    remaining -= k * k;
                }
            }
            if (remaining > 0)
            {
                cost += (int)Math.Ceiling((double)remaining / Math.Sqrt(remaining));
            }
            Console.WriteLine(cost);
        }

    }


}

