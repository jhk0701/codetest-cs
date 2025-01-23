using System.Collections;
using System.Collections.Generic;

public class Fivonaci
{
    List<long> list = new List<long>() { 0, 1 };

    public long GetFiv(int n)
    {
        if (n == 0) 
            return list[0];
        else if(n == 1) 
            return list[1];

        if (list.Count - 1 < n)
        {
            long subFiv = GetFiv(n - 1) + GetFiv(n - 2);
            list.Add(subFiv);
            return subFiv;
        }
        else
        {

            return list[n - 1] + list[n - 2];
        }
    }
}