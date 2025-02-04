using System.Linq;
using System.Collections.Generic;
using CodeTest;
using System.Collections;
using System.Text;
using System;
using System.Numerics;
using System.Net.NetworkInformation;

namespace Test
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int[,] sizes = { {60, 50}, {30, 70}, {60, 30}, {80, 40} };
            
            for (int i = 0; i < sizes.GetLength(0); i++) 
            {
                var a = sizes[i, 0];
                Console.WriteLine(a);
            }

            int answer = 0;
            void DFS(int k, int idx, bool[] visited, ref int[,] dungeons)
            {
                if (idx >= dungeons.GetLength(0))
                {
                    answer = Math.Max(answer, idx);
                    return;
                }

                for (int i = 0; i < dungeons.GetLength(0); i++)
                {
                    if (visited[i] || dungeons[i, 0] > k)
                        continue;

                    bool[] dirty = new bool[visited.Length];
                    Array.Copy(visited, dirty, visited.Length);

                    dirty[i] = true;
                    DFS(k - dungeons[i, 1], idx + 1, dirty, ref dungeons);
                }
            }
        }
    }
}
