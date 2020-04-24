using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.hackerrank.com/challenges/the-hurdle-race/problem?h_r=internal-search
namespace The_hurdle_race
{
    public static class AppHelper
    {
        public static void Hurdle(Int32[] arr, Int32 height)
        {
            if (arr.All(g => g < height))
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(arr.Max() - height);
            }
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32[] parameters = Console.ReadLine()
                               .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(g => Convert.ToInt32(g))
                               .ToArray<Int32>();
            Int32[] arr = Console.ReadLine()
                               .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(g => Convert.ToInt32(g))
                               .ToArray<Int32>();
            AppHelper.Hurdle(arr, parameters[1]);
        }
    }
}
