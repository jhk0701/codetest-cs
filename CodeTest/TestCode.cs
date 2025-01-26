namespace Test
{
    public class TestCode
    {
        public void Where()
        {
            int[] array = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            int start = commands[0, 0] - 1;
            int end = commands[0, 1];

            // 인덱스 받기
            int[] result = array.Where((n, id) => id >= start && id < end).OrderBy(n => n).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }

        public void Orderby()
        {
            int[] arr = [1, 3, 2, 5, 4];
            int b = 9;
            int[] arr2 = arr.Where(n => { b -= n; return b > 0; }).ToArray();
            Console.WriteLine(arr2.Length);
        }

        public void SortArray()
        {
            Console.Write("배열을 입력해주세요 :");
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        void SearchingMap()
        {
            int sr = 1, sc = 1;
            int color = 2;
            int[][] map = [
                [1,1,1],[1,1,0],[1,0,1]
            ];
            bool[][] visited = new bool[map.Length][];
            //for (int i = 0; i < map.Length; i++) 
            //{
            //    map[i] = new int[map[]];
            //}

            Search(sr, sc, map[sc][sr], color, ref map);
        }

        static int[] dx = { 1, -1, 0, 0 };
        static int[] dy = { 0, 0, 1, -1 };
        public static void Search(int x, int y, int origin, int col, ref int[][] map)
        {
            if (x < 0 || x >= map[0].Length || y < 0 || y >= map.Length)
                return;

            if (map[y][x] == origin)
                map[y][x] = col;
            else
                return;

            Console.WriteLine($"{x}, {y} : changed.");

            for (int i = 0; i < 4; i++)
                Search(x + dx[i], y + dy[i], origin, col, ref map);
        }

        public static void SwapChar()
        {
            string my_string = "hello";
            int num1 = 1, num2 = 2;
            char[] arr = my_string.ToCharArray();
            char t = arr[num1];
            arr[num1] = arr[num2];
            arr[num2] = t;

            Console.WriteLine(new String(arr));
        }

        public static void Log10()
        {
            int num = 29423;
            int digit = (int)MathF.Log10(num);
            int div = (int)MathF.Pow(10, digit);

            while (div > 0)
            {
                int r = num / div;

                div /= 10;
            }
        }

        public void GetGCD()
        {
            int n = 4;
            List<int> arrPiece = new List<int>() { 2, 3 };
            List<int> arrNum = new List<int>();

            int num = 2;
            while (n > 1)
            {
                if (n % num == 0)
                {
                    arrNum.Add(num);
                    n /= num;
                }
                else
                    num++;
            }

            for (int i = 0; i < arrPiece.Count; i++)
            {
                if (arrNum.Contains(arrPiece[i]))
                    arrNum.Remove(arrPiece[i]);
            }

            int answer = 1;
            for (int i = 0; i < arrPiece.Count; i++)
                answer *= arrPiece[i];

            for (int i = 0; i < arrNum.Count; i++)
                answer *= arrNum[i];

            Console.WriteLine(answer / 6);
        }

        public void Sqrt()
        {
            int num = 1324;
            float sqrt = MathF.Sqrt(num);
            int iSqrt = (int)MathF.Sqrt(num);
            Console.WriteLine("{0}, {1}, {2}", sqrt, iSqrt, iSqrt * iSqrt);

            return;
            int n = 15;
            Console.WriteLine(n / 7 + n % 7 > 0 ? 1 : 0);
            return;

            Console.WriteLine("!@#$%^&*(\\\'\"<>?:;");
        }

        public void GetArray2()
        {
            // 	[[],[]]
            int[,] arr1 = new int[2, 2] { { 1, 2 }, { 2, 3 } };
            int[,] arr2 = new int[2, 2] { { 3, 4 }, { 5, 6 } };


            Console.WriteLine(arr1.GetLength(0));
            Console.WriteLine(arr1.GetLength(1));

            int[,] matrix = new int[arr1.Length, arr1[0, 0]];

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {

                }
            }
        }
    }
}


