﻿using System;
using System.Linq;

namespace StatisticArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("count=" + OptionsManager.CountLess100(arr));
            Console.WriteLine($"Max={OptionsManager.MaxNum(arr)}");
            arr = OptionsManager.ReverseArr(arr);
            OptionsManager.PrintArr(arr);
            OptionsManager.SortArr(arr);

        }
        public static int CountOddNumbers(int[] arr)
        {
            return arr.Where(x => x % 2 == 1).Count();
        
        }
    }
}
