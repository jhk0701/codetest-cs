using System.Linq;
using System.Collections.Generic;
using CodeTest;
using System.Collections;
using System.Text;

namespace Test
{
    internal partial class Program
    {

        static void Main(string[] args) 
        {
            int n = 7;
            int k = 3;
            int[] enemy = { 4, 2, 4, 5, 3, 3, 1 };
            int answer = 0;

            for(int i = 0; i < enemy.Length; i++) 
            {
                if(n < enemy[i])
                    if(k > 0) 
                    {
                        answer++;
                        k--;
                        continue;
                    }
                    else 
                        break;

                n -= enemy[i];
                answer++;
            }

            Console.WriteLine(answer);
        }

    }
}
