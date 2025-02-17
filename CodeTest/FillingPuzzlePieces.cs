namespace Test
{
    public class FillingPuzzlePieces
    {
        public int Answer { get; private set; }
        int[,] dir = { { 1, -1, 0, 0 }, { 0, 0, 1, -1 } };
        int size = 0;

        public FillingPuzzlePieces(ref int[,] game_board, ref int[,] table) 
        {

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
                        DFS(x, y, 0, ref newSpace, ref game_board);

                        Normalize(ref newSpace);
                        spaces.Add(newSpace);
                    }

                    if (table[y, x] == 1)
                    {
                        List<int[]> newPiece = new List<int[]>();
                        DFS(x, y, 1, ref newPiece, ref table);

                        Normalize(ref newPiece);
                        pieces.Add(newPiece);
                    }
                }
            }
        }

        void DFS(int x, int y, int target, ref List<int[]> collected, ref int[,] map)
        {
            if (map[y, x] != target)
                return;

            int[] next = { x, y };
            collected.Add(next);

            map[y, x] = -1; // 방문 처리

            for (int i = 0; i < dir.GetLength(1); i++)
            {
                int nextX = x + dir[0, i];
                int nextY = y + dir[1, i];

                if (nextX < 0 || nextX >= size || nextY < 0 || nextY >= size)
                    continue;

                DFS(nextX, nextY, target, ref collected, ref map);
            }
        }

        void Normalize(ref List<int[]> collected)
        {
            int minX = -1;
            int minY = -1;

            collected = collected.OrderBy(n => n[0])
                .ThenBy(n => n[1])
                .Select(n =>
                {
                    if (minX == -1)
                        minX = n[0];
                    else
                        minX = Math.Min(minX, n[0]);

                    if (minY == -1)
                        minY = n[1];
                    else
                        minY = Math.Min(minY, n[1]);

                    return n;
                })
                .ToList();

            collected = collected.Select(n => { n[0] -= minX; n[1] -= minY; return n; }).ToList();

            Console.WriteLine($"-----{collected.Count}");
            foreach (var el in collected)
            {
                Console.WriteLine($"{el[0]}, {el[1]}");
            }
        }

        bool IsMatched(List<int[]> piece, List<int[]> space)
        {
            if (piece.Count != space.Count)
                return false;

            return true;
        }
    }
}
