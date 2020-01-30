using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/icecream-parlor/problem

namespace Ice_cream_parlor
{
    public static class AppHelper
    {
        public static void Pairs(Int32[] array, Int32 m)
        {
            Int32 low = 0;
            int[] tempArray = new Int32[array.Length];
            Array.Copy(array, tempArray, array.Length);
            List<Int32> lst = new List<Int32>();
            Int32 high = array.Length - 1;
            Array.Sort(array);
            Boolean allUnique = (array.Length == array.Distinct().Count());
            while (low < high)
            {
                if (array[low] + array[high] == m)
                {
                    if (allUnique)
                    {
                        Int32 k = Array.FindIndex(tempArray, g => g == array[low]) + 1;
                        Int32 k1 = Array.FindIndex(tempArray, g => g == array[high]) + 1;
                        if (k < k1)
                        {
                            Console.WriteLine(k + " " + k1);
                        }
                        else
                        {
                            Console.WriteLine(k1 + " " + k);
                        }
                    }
                    else
                    {
                        if (array[low] == array[high])
                        {
                            var duplicates = tempArray
                                           .Select((t, i) => new { Index = i, Text = t })
                                           .GroupBy(g => g.Text)
                                           .Where(g => g.Count() > 1);
                            foreach (var i in duplicates.SelectMany(p => p))
                            {
                                lst.Add((Convert.ToInt32(i.Index.ToString())));
                            }
                            Console.WriteLine(String.Join(" ", lst.Select(a => a + 1)));
                        }
                        else
                        {
                            Int32 k = Array.FindIndex(tempArray, g => g == array[low]) + 1;
                            Int32 k1 = Array.FindIndex(tempArray, g => g == array[high]) + 1;
                            if (k < k1)
                            {
                                Console.WriteLine(k + " " + k1);
                            }
                            else
                            {
                                Console.WriteLine(k1 + " " + k);
                            }
                        }
                    }
                }
                if (array[low] + array[high] > m)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
            Array.Clear(tempArray, 0, array.Length);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                Int32 m = Convert.ToInt32(Console.ReadLine());
                Int32 arrayLength = Convert.ToInt32(Console.ReadLine());
                Int32[] array = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => Convert.ToInt32(a)).ToArray<Int32>();
                AppHelper.Pairs(array, m);
                n = n - 1;
            }
        }
    }

}
