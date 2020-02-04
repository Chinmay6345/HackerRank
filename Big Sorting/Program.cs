using System;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerrank.com/challenges/big-sorting/problem

namespace Big_Sorting
{
    public static class AppHelper
    {
        public static Int32 CompareDinosByLength(String x, String y)
        {

            Int32 retval = x.Length.CompareTo(y.Length);
            if (retval != 0)
                return retval;
            else
                return String.CompareOrdinal(x, y);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 NoOfElements = Convert.ToInt32(Console.ReadLine());
            String[] array = new String[NoOfElements];
            for (Int32 i = 0; i < NoOfElements; i++)
            {
                array[i] = Console.ReadLine();
            }
            Array.Sort(array, AppHelper.CompareDinosByLength);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

}
