public class Solution
{
    static int[] dx = { 1, -1, 0, 0 };
    static int[] dy = { 0, 0, 1, -1 };

    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        bool[][] vi = new bool[image.Length][];
        for (int i = 0; i < image.Length; i++)
            vi[i] = new bool[image[0].Length];

        Search(sc, sr, image[sr][sc], color, ref image, ref vi);

        return image;
    }

    public static void Search(int x, int y, int origin, int col, ref int[][] map, ref bool[][] visited)
    {
        if (x < 0 || x >= map[0].Length || y < 0 || y >= map.Length)
            return;

        if (visited[y][x])
            return;

        visited[y][x] = true;

        if (map[y][x] == origin)
            map[y][x] = col;
        else
            return;

        for (int i = 0; i < 4; i++)
            Search(x + dx[i], y + dy[i], origin, col, ref map, ref visited);
    }
}