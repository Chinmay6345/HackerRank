using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

//https://www.hackerrank.com/challenges/array-left-rotation/problem

namespace Left_rotation
{
    public static class AppHelper
    {
        public static void LeftRotation(Int32[] arr, Int32 d)
        {
            List<Int32> lst = arr.ToList<Int32>();
            for (int i = 0; i < d; i++)
            {
                int k = lst[0];
                lst.RemoveAt(0);
                lst.Add(k);
            }
            Console.WriteLine(String.Join(" ", lst.Select(a => a)));
        }
        public static int Push<T>(this T[] source, T value)
        {
            var index = Array.IndexOf(source, default(T));

            if (index != -1)
            {
                source[index] = value;
            }

            return index;
        }
    }


    public class Program
    {
        public static void Main(String[] args)
        {
            //String[] ip = Console.ReadLine()
            //             .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Int32[] array = Console.ReadLine()
            //                .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //                .Select(a => Convert.ToInt32(a))
            //                .ToArray<Int32>();
            //AppHelper.LeftRotation(array, Convert.ToInt32(ip[1]));
            int[] myArray = { 1, 2, 3 };
            Array.Resize(ref myArray, myArray.Length + 1);
myArray[myArray.GetUpperBound(0)] = 5;
            Console.ReadLine();
        }
    }

}
