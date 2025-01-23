using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    internal class GraphSearch
    {
        class Graph
        {
            private int V;
            private List<int>[] adj;

            public Graph(int v)
            {
                V = v;
                adj = new List<int>[V];

                for (int i = 0; i < V; i++)
                    adj[i] = new List<int>(); //이 버텍스와 연결된 점들이 들어올 곳
            }

            public void AddEdge(int v, int w)
            {
                adj[v].Add(w);
            }

            public void DFS(int startVertex)
            {
                // 방문 여부 체크
                bool[] visited = new bool[V];
                DFSUtil(startVertex, ref visited);
            }

            void DFSUtil(int visitVertex, ref bool[] visited)
            {
                visited[visitVertex] = true;
                Console.Write($"{visitVertex} ");

                foreach (int v in adj[visitVertex])
                {
                    if (!visited[v])
                        DFSUtil(v, ref visited);
                }
            }

            public void BFS(int startVerex)
            {
                bool[] visited = new bool[V];
                Queue<int> qu = new Queue<int>();

                visited[startVerex] = true;
                qu.Enqueue(startVerex);

                while (qu.Count > 0)
                {
                    int v = qu.Dequeue();
                    Console.Write($"{v} ");

                    foreach (int next in adj[v])
                    {
                        if (!visited[next])
                        {
                            visited[next] = true;
                            qu.Enqueue(next);
                        }
                    }
                }
            }
        }

        public void Show()
        {
            Graph g = new Graph(6);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 3);
            g.AddEdge(2, 4);
            g.AddEdge(3, 4);
            g.AddEdge(3, 5);
            g.AddEdge(4, 5);

            Console.WriteLine("DFS : ");
            g.DFS(0);
            Console.WriteLine();

            Console.WriteLine("BFS : ");
            g.BFS(0);
            Console.WriteLine();
        }
    }
}
