// C# program to find the maximum 
// j – i such that arr[j] > arr[i] 
using Stringoperation;
using System;
using System.Collections.Generic;
using System.Linq;

class GFG
{

    static int max(int x, int y)
    {
        return x > y ? x : y;
    }

    static int min(int x, int y)
    {
        return x < y ? x : y;
    }


    static int maxIndexDiff(List<int> arr)
    {
        int maxDiff;
        int i, j;
        int n = arr.Count();
        int[] RMax = new int[n];
        int[] LMin = new int[n];


        LMin[0] = arr[0];
        for (i = 1; i < n; ++i)
            LMin[i] = min(arr[i], LMin[i - 1]);

        RMax[n - 1] = arr[n - 1];
        for (j = n - 2; j >= 0; --j)
            RMax[j] = max(arr[j], RMax[j + 1]);


        i = 0; j = 0; maxDiff = -1;
        while (j < n && i < n)
        {
            if (LMin[i] < RMax[j])
            {
                maxDiff = max(maxDiff, j - i);
                j = j + 1;
            }
            else
                i = i + 1;
        }

        return maxDiff;
    }

    // Driver program 
    public static void Main()
    {

        int[] arr = { 9, 2, 3, 4, 5, 6, 7, 8, 18, 0 };
        int n = arr.Length;
        // MinumArrayDublicate.getMinimumUniqueSum()
        // int maxDiff = maxIndexDiff(arr, n);
        //Console.Write(maxDiff);
        //var list = new List<int>(new[] { 1, 2, 4, 7, 9 });
        //var result = Enumerable.Range(0, 10).Except(list);
    }

    public static void PrintNextCharacter(int n)
    {
        List<string> Letter = new List<string>();
        Letter.Add("a");
        Letter.Add("b");
        Letter.Add("c");

     
    }
}
// This Code is Contributed by Sam007 
