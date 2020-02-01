using System;
using System.Linq;
//https://www.hackerrank.com/challenges/cut-the-sticks/problem
namespace Cut_the_sticks
{
    public class AppHelper
    {
        public static void CutSticks(Int32[] arr)
        {
            Console.WriteLine(arr.Length);
            for (Int32 i = 0; i < arr.Length; i++)
            {
                int min = arr.Where(a => a > 0).ToArray().Min();
                arr = arr.Select(a => a - min < 0 ? 0 : a - min).ToArray();
                if (arr.All(a => a == 0))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(arr.Where(a => a != 0).Count());
                }

            }
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Int32[] array = Console.ReadLine()
                            .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(a => Convert.ToInt32(a))
                            .ToArray<Int32>();
            AppHelper.CutSticks(array);
        }
    }

}
