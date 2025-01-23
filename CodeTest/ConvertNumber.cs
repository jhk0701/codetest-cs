using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    internal class ConvertNumber
    {
        Func<int, int, int>[] func;
        int searchResult = -1;

        public ConvertNumber()
        {
            func = new Func<int, int, int>[3];
            func[0] = (int a, int b) => { return a * 3; };
            func[1] = (int a, int b) => { return a * 2; };
            func[2] = (int a, int b) => { return a + b; };

        }

        public void Sol(int x, int y, int n, int cnt)
        {
            int result = 0;
            cnt += 1;

            // 그래프 탐색
            for (int i = 0; i < func.Length; i++)
            {
                result = func[i].Invoke(x, n);

                if (result == y)
                {
                    if (searchResult == -1 || searchResult > cnt)
                        searchResult = cnt;
                }
                else if (result < y)
                    Sol(result, y, n, cnt);
            }
        }
        
        public int GetResult()
        {
            return searchResult;
        }
    }
}
