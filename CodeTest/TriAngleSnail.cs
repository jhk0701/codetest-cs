using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;

public class TriAngleSnail
{
    int[][] snail;
    int count = 0;
    int level = 0;

    //static void Main(string[] args)
    //{
    //    TriAngleSnail snail = new TriAngleSnail(4);
    //    int[] result = snail.Serialize();

    //    Console.WriteLine(string.Join(", ", result));
    //}


    public TriAngleSnail(int n) 
    {
        snail = new int[n][];
        count = 0;
        level = n;

        for (int i = 0; i < level; i++)
        {
            snail[i] = new int[i + 1];
            count += i + 1;
        }

        Fill();
    }

    public void Fill()
    {
        int cycle = level;
        int num = 1;
        int index1 = 0, index2 = 0;

        while (cycle > 0) 
        {
            int type = (level - cycle) % 3;

            switch (type) 
            {
                case 0:
                    FillCycle1(cycle, ref num, ref index1, ref index2);
                    break;
                case 1:
                    FillCycle2(cycle, ref num, ref index1, ref index2);
                    break;
                case 2:
                    FillCycle3(cycle, ref num, ref index1, ref index2);
                    break;
            }

            cycle--;
        }
    }

    void FillCycle1(int count, ref int num, ref int index1, ref int index2)
    {
        for (int i = 0; i < count; i++) 
        {
            snail[index1][index2] = num;
            num++;
            index1++;
        }

        // index1 += count - 1;    // 0 + 4 - 1 = 3 [4]
        index1--;
        index2++;   // 0 => 1
    }


    void FillCycle2(int count, ref int num, ref int index1, ref int index2) 
    {
        for (int i = 0; i < count; i++) 
        {
            snail[index1][index2] = num;
            num++;
            index2++;
        }

        // index2 += count - 1; // 1 + 3 - 1 = 3
        index1--;
        index2 -= 2;
    }

    void FillCycle3(int count, ref int num, ref int index1, ref int index2) 
    {
        for (int i = 0; i < count; i++) 
        {
            snail[index1][index2] = num;

            num++;
            index1--;
            index2--;
        }

        index1 += 2;
        index2++;
    }

    public int[] Serialize() 
    {
        int[] result = new int[count];
        int n = 0;

        for (int i = 0; i < level; i++) 
        { 
            for(int j = 0; j < snail[i].Length; j++) 
            {
                result[n] = snail[i][j];
                n++;
            }
        }

        return result;
    }
}