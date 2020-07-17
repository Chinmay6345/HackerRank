using System;
using System.Linq;

//https://www.hackerrank.com/challenges/kangaroo/problem

namespace Kangaroos
{
    public static class AppHelper
    {
        public static void WillMeet(Int32[] arr)
        {
            Int32 x1 = arr[0];
            Int32 v1 = arr[1];
            Int32 x2 = arr[2];
            Int32 v2 = arr[3];
            Boolean flag = false;
            if (x2 > x1 && v2 > v1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Int32 newDistance = 0;
                Int32 newDistance1 = 0;
                Int32 i = 0;
                while (i < 10000)
                {
                    if (i == 0)
                    {
                        newDistance = v1 + x1;
                        newDistance1 = x2 + v2;
                        if (newDistance1.Equals(newDistance))
                        {
                            Console.WriteLine("YES");
                            flag = true;
                            break;
                        }
                    }
                    else
                    {
                        newDistance1 += v2;
                        newDistance += v1;
                        if (newDistance1.Equals(newDistance))
                        {
                            Console.WriteLine("YES");
                            flag = true;
                            break;
                        }
                    }
                    i++;
                }
                if (!flag)
                {
                    Console.WriteLine("NO");
                }
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
            AppHelper.WillMeet(arr);
        }
    }

}
