using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerrank.com/challenges/between-two-sets/problem
//reference taken for finding LCM from geeksforgeeks https://www.geeksforgeeks.org/finding-lcm-two-array-numbers-without-using-gcd/
namespace Between_two_sets
{
    public static class AppHelper
    {
        public static Int32 Convert(String s)
        {
            return Int32.Parse(s);
        }
        public static Int32 LCM(Int32[] arr, int n)
        {
            int max_num = arr.Max();
            Int32 res = 1;
            int x = 2;
            while (x <= max_num)
            {
                ArrayList indexes = new ArrayList();
                for (Int32 j = 0; j < n; j++)
                {
                    if (arr[j] % x == 0)
                    {
                        indexes.Add(j);
                    }
                }
                if (indexes.Count >= 2)
                {
                    for (Int32 j = 0; j < indexes.Count; j++)
                    {
                        arr[(Int32)indexes[j]] = arr[(Int32)indexes[j]] / x;
                    }

                    res = res * x;
                }
                else
                {
                    x++;
                }
            }
            for (Int32 i = 0; i < n; i++)
            {
                res = res * arr[i];
            }

            return res;
        }

        public static void BetweenTwoSets(Int32 LCM,Int32 Min,Int32 [] b)
        {
            List<Int32> lst = new List<Int32>();
            for(Int32 i=1;i<=Min;i++)
            {
                int k = LCM * i;
                if(k>Min)
                {
                    break;
                }
                else
                {                 
                   lst.Add(k);
                }
            }
            Int32 count = 0;
            foreach(Int32 element in lst)
            {
                if(b.All(v=>v % element==0))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            String arraylengths = Console.ReadLine();
            Int32[] a = Array.ConvertAll<String, Int32>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray(), new Converter<String, Int32>(AppHelper.Convert));
            Int32[] b = Array.ConvertAll<String, Int32>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray(), new Converter<String, Int32>(AppHelper.Convert));
            Int32 LCM = AppHelper.LCM(a, a.Length);
            AppHelper.BetweenTwoSets(LCM,b.Min(),b);
        }
    }
}
