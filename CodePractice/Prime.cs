using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    internal class Prime
    {

        public bool IsPrime(int n)
        {
            if (n == 0 || n == 1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}
