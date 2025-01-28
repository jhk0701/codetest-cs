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

            /*
                [6, 10, 2]	"6210"
                [3, 30, 34, 5, 9]	"9534330"
             */

            int[] numbers = { 3, 30, 34, 5, 9 };
            // { 6, 10, 2 }; // 
            string[] strs = new string[numbers.Length];

            for (int i = 0; i < strs.Length; i++)
                strs[i] = numbers[i].ToString();

            Array.Sort(strs, (a, b) => (b + a).CompareTo(a + b));

            string answer = string.Join("", strs);
            Console.WriteLine(answer[0] == '0' ? "0" : answer);

            bool Compare(string a, string b)
            {
                string ab = a + b;
                string ba = b + a;

                for (int i = 0; i < ab.Length; i++) 
                {
                    int numA = int.Parse(ab[i] + "");
                    int numB = int.Parse(ba[i] + "");

                    if (numA == numB) continue;
                    else
                        return numA < numB;
                }

                return false;
            }

            void Swap(int idx1, int idx2, ref string[] arr) 
            {
                string temp = arr[idx1];
                arr[idx1] = arr[idx2];
                arr[idx2] = temp;
            }
        }
    }
}
