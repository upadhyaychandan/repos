using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDuplicate
{
    class Program
    {
        static void printRepeating(int[] arr,
                            int size)
        {
            int i;

            Console.Write("The repeating" +
                           " elements are : ");

            for (i = 0; i < size; i++)
            {
                if (arr[Math.Abs(arr[i])] >= 0)
                    arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
                else
                    Console.Write(Math.Abs(arr[i]) + " ");
            }
        }
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 1, 3, 6, 6 };
            int arr_size = arr.Length;

            printRepeating(arr, arr_size);
            Console.ReadLine();
        }
    }
}
