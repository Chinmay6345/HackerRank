using System;
using System.Linq;
//https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
namespace Cats_and_Mouse
{
    public static class AppHelper
    {
        public static void Result(Int32[] arr)
        {
            Int32 CatA = arr[0];
            Int32 CatB = arr[1];
            Int32 mouse = arr[2];

            if (Math.Abs(CatA - mouse) < Math.Abs(CatB - mouse))
            {
                Console.WriteLine("Cat A");
            }
            else if (Math.Abs(CatA - mouse) > Math.Abs(CatB - mouse))
            {
                Console.WriteLine("Cat B");
            }
            else
            {
                Console.WriteLine("Mouse C");
            }
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            while (n != 0)
            {
                Int32[] arr = Console.ReadLine()
                          .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(a => Convert.ToInt32(a))
                          .ToArray<Int32>();
                AppHelper.Result(arr);
                n = n - 1;
            }
        }
    }

}
