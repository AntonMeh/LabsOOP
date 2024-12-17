using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O
{
    internal class Program
    {
        const int UNREACHABLE = 987654321;

        static int[] BFS(List<int>[] adjacencyList, int start, int n)
        {
            int[] distances = new int[n];
            for (int i = 0; i < n; i++)
                distances[i] = UNREACHABLE;

            Queue<int> queue = new Queue<int>();
            distances[start] = 0;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();

                foreach (int neighbor in adjacencyList[current])
                {
                    if (distances[neighbor] == UNREACHABLE)
                    {
                        distances[neighbor] = distances[current] + 1;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return distances;
        }

        static void Main()
        {
            int numGraphs = int.Parse(Console.ReadLine());
            List<string> results = new List<string>();

            for (int g = 0; g < numGraphs; g++)
            {
                string[] graphInfo = Console.ReadLine().Split();
                int n = int.Parse(graphInfo[0]);
                int m = int.Parse(graphInfo[1]);

                List<int>[] adjacencyList = new List<int>[n];
                for (int i = 0; i < n; i++)
                    adjacencyList[i] = new List<int>();

                for (int i = 0; i < m; i++)
                {
                    string[] edge = Console.ReadLine().Split();
                    int u = int.Parse(edge[0]);
                    int v = int.Parse(edge[1]);
                    adjacencyList[u].Add(v);
                }

                int start = int.Parse(Console.ReadLine());

                int[] distances = BFS(adjacencyList, start, n);

                results.Add(string.Join(" ", distances));
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
