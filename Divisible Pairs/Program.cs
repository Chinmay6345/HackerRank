using System;
using System.Linq;

//https://www.hackerrank.com/challenges/divisible-sum-pairs/problem

namespace Divisible_Pairs
{
    public static class AppHelper
    {
        public static void Pairs(Int32 k, Int32[] arr)
        {
            try
            {
                Int32[] pairsArr = new Int32[k];
                Int32 count = 0;
                foreach (Int32 value in arr)
                {
                    Int32 mod = value % k;
                    count += pairsArr[(k - mod) % k];
                    pairsArr[mod]++;

                }
                Console.WriteLine(count);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32[] arr = Console.ReadLine()
                            .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(g => Convert.ToInt32(g))
                            .ToArray<Int32>();
            Int32[] arr1 = Console.ReadLine()
                            .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(g => Convert.ToInt32(g))
                            .ToArray<Int32>();
            AppHelper.Pairs(arr[1], arr1);
        }
    }

}
