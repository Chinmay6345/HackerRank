using System;
using System.Linq;

//https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

namespace Breaking_Records
{
    public static class AppHelper
    {
        public static void BreakingRecord(Int32[] arr)
        {
            Int32 highest = arr[0];
            Int32 lowest = arr[0];
            Int32 countHighest = 0;
            Int32 countLowest = 0;
            for (Int32 i = 1; i < arr.Length; i++)
            {
                if (arr[i] > highest)
                {
                    highest = arr[i];
                    countHighest++;
                }
                if (arr[i] < lowest)
                {
                    lowest = arr[i];
                    countLowest++;
                }
            }
            Console.WriteLine(countHighest + " " + countLowest);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Int32[] arr = Console.ReadLine()
                        .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(g => Convert.ToInt32(g))
                        .ToArray<Int32>();
            AppHelper.BreakingRecord(arr);
        }

    }
}
