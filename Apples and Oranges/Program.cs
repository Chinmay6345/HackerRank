using System;
using System.Linq;

//https://www.hackerrank.com/challenges/apple-and-orange/problem

namespace Apples_and_Oranges
{

    public static class AppHelper
    {
        public static void InDistance(Int32[] houses,
                                      Int32[] locations,
                                      Int32[] apples,
                                      Int32[] oranges)
        {
            Int32 s = houses[0];
            Int32 t = houses[1];
            Int32 m = locations[0];
            Int32 n = locations[1];
            Int32 count = 0;
            Int32 count1 = 0;
            foreach (Int32 element in apples)
            {
                if (m + element >= s && m + element <= t)
                {
                    count++;
                }
            }
            foreach (Int32 element in oranges)
            {
                if (n + element >= s && n + element <= t)
                {
                    count1++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(count1);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32[] houses = Console.ReadLine()
                           .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(g => Convert.ToInt32(g))
                           .ToArray<Int32>();
            Int32[] locations = Console.ReadLine()
                           .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(g => Convert.ToInt32(g))
                           .ToArray<Int32>();
            Int32[] lengths = Console.ReadLine()
                           .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(g => Convert.ToInt32(g))
                           .ToArray<Int32>();
            Int32[] apples = Console.ReadLine()
                           .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(g => Convert.ToInt32(g))
                           .ToArray<Int32>();
            Int32[] oranges = Console.ReadLine()
                           .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(g => Convert.ToInt32(g))
                           .ToArray<Int32>();
            AppHelper.InDistance(houses, locations, apples, oranges);
        }
    }
}
