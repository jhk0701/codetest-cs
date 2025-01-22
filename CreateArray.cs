using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class CreateArray
    {
        char[] num = { '0', '5' };

        int start, end;

        public CreateArray(int s, int e) 
        { 
            start = s;
            end = e;
        }

        public void Search(string str, int length, ref List<int> list)
        {
            if (str.Length == length)
            {
                Console.WriteLine($"is matched");
                int number = int.Parse(str);

                if(number >= start && number <= end)
                    list.Add(number);

                return;
            }

            Console.WriteLine($"keep searching : {str}, target : {length}, {str.Length}");

            for (int i = 0; i < num.Length; i++)
            {
                string newStr = str + num[i];
                Search(newStr, length, ref list);
            }
        }
    }
}
