using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CodeTest;
using System.Drawing;

namespace Test
{
    internal partial class Program
    {
        static int[,] dir = { { 1, -1, 0, 0 }, { 0, 0, 1, -1 } };
        static int size = 0;

        static void Main(string[] args)
        {
            int[,] game_board = {
                {1, 1, 0, 0, 1, 0}, 
                {0, 0, 1, 0, 1, 0}, 
                {0, 1, 1, 0, 0, 1}, 
                {1, 1, 0, 1, 1, 1}, 
                {1, 0, 0, 0, 1, 0}, 
                {0, 1, 1, 1, 0, 0}};

            int[,] table = {
                {1, 0, 0, 1, 1, 0}, 
                {1, 0, 1, 0, 1, 0}, 
                {0, 1, 1, 0, 1, 1}, 
                {0, 0, 1, 0, 0, 0},
                {1, 1, 0, 1, 1, 0},
                {0, 1, 0, 0, 0, 0}};

            int answer = 0;
            size = table.GetLength(0);

            List<List<int[]>> spaces = new List<List<int[]>>();
            List<List<int[]>> pieces = new List<List<int[]>>();

            // 조각 및 공간 확인
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (game_board[y, x] == 0)
                    {
                        List<int[]> newSpace = new List<int[]>();
                        DFS(y, x, 0, ref newSpace, ref game_board);

                        // 정규화 필요

                        spaces.Add(newSpace);
                    }

                    if (table[y, x] == 1)
                    {
                        List<int[]> newPiece = new List<int[]>();
                        DFS(y, x, 1, ref newPiece, ref table);

                        // 정규화 필요

                        pieces.Add(newPiece);
                    }
                }
            }

            Console.WriteLine($"spaces : {spaces.Count}, pieces : {pieces.Count}");

        }

        static void DFS(int x, int y, int target, ref List<int[]> collected, ref int[,] map)
        {
            if (map[y, x] != target)
                return;

            int[] next = { x, y };
            collected.Add(next);

            map[y, x] = -1; // 방문 처리

            for (int i = 0; i < dir.GetLength(0); i++)
            {
                int nextX = x + dir[0, i];
                int nextY = y + dir[1, i];
                if (nextX < 0 || nextX >= size || nextY < 0 || nextY >= size)
                    continue;

                DFS(nextX, nextY, target, ref collected, ref map);
            }
        }
    }
}
