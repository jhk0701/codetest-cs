using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    internal class ConvertArray2
    {
        public ConvertArray2() 
        {
            int[] arr = { 1, 2, 3, 100, 99, 98 };

            // 50 <= n && n % 2 == 0 : n /= 2 
            // 멈추는 조건 : 50 이상인데 홀수
            // 50 > n && n % 2 == 1 : n *= 2, n++
            // 멈추는 조건 : 50 미만인데 짝수

            int maxN = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                while (IsInCondition(arr[i], out int type))
                {
                    count++;

                    if (type == 1)
                        arr[i] /= 2;
                    else if (type == 2)
                    {
                        arr[i] *= 2;
                        arr[i]++;
                    }
                }

                maxN = Math.Max(maxN, count);
            }

            Console.WriteLine(maxN);
        }

        static bool IsInCondition(int num, out int result)
        {
            result = 0;
            if (num >= 50 && num % 2 == 0)
            {
                result = 1;
                return true;
            }
            else if (num < 50 && num % 2 == 1)
            {
                result = 2;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
