namespace Test
{
    public class ShortestDistance
    {
        public int Answer { get; private set; }

        public struct Coord
        {
            public int X;
            public int Y;

            public Coord(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public ShortestDistance(int[,] maps)
        {
            int answer = 0;
            int[,] dir = new int[,] { { 1, -1, 0, 0 }, { 0, 0, 1, -1 } };

            Queue<Coord> next = new Queue<Coord>();
            Dictionary<Coord, bool> visited = new Dictionary<Coord, bool>();
            Coord start = new Coord(0, 0);
            Coord end = new Coord(maps.GetLength(0) - 1, maps.GetLength(1) - 1);

            // BFS
            next.Enqueue(start);
            maps[start.X, start.Y] = 0;

            while (next.Count > 0)
            {
                Coord curCoord = next.Dequeue();
                int search = maps[curCoord.X, curCoord.Y];

                if (answer > 0 && answer < -search)
                    break;

                if (end.X == curCoord.X && end.Y == curCoord.Y)
                {
                    if (answer == 0)
                        answer = -search;
                    else
                        answer = Math.Min(answer, -search);

                    continue;
                }

                for (int i = 0; i < dir.GetLength(1); i++)
                {
                    int newX = curCoord.X + dir[0, i];
                    int newY = curCoord.Y + dir[1, i];

                    if (newX < 0 || newX > end.X || newY < 0 || newY > end.Y)
                        continue;
                    if (maps[newX, newY] <= 0)
                        continue;

                    maps[newX, newY] = search - 1;
                    next.Enqueue(new Coord(newX, newY));
                }
            }

            Answer = answer == 0 ? -1 : answer + 1;
        }
    }
}
