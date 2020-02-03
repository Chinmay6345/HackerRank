using System;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerrank.com/challenges/migratory-birds/problem

namespace Migratory_Birds
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = int.Parse(Console.ReadLine());
            Int32[] array = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
            Int32 max = 0;
            List<Int32> lstIntegers = new List<Int32>();
            var p = array.GroupBy(a => a).Where(a => a.Count<int>() > 1).Select(a => new { key = a.Key, Count = a.Count() }).OrderByDescending(a => a.Count);
            foreach (var item in p)
            {
                if (item.Count >= max)
                {
                    lstIntegers.Add(item.key);
                    max = item.Count;
                }
            }
            if (lstIntegers.Count > 1)
            {
                Console.WriteLine(lstIntegers.Min());
            }
            else
            {
                Console.WriteLine(lstIntegers[0]);
            }
        }
    }

}
