using System;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem

namespace Hacker_rank_in_a_String
{
    public static class AppHelper
    {
        public static void HRankInString(String input)
        {
            input = Convert.ToString(input.ToLower());
            Char[] array = { 'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k' };
            List<Char> lst = new List<Char>(array);
            Int32 count = 0;
            foreach (Char character in input)
            {
                if (count < lst.Count())
                {
                    if (character.Equals(array[count]))
                    {
                        count++;
                    }
                }
            }
            if (count == 10)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32 n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                String str = Console.ReadLine();
                AppHelper.HRankInString(str);
                n = n - 1;
            }
        }
    }

}
