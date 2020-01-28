using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.hackerrank.com/challenges/reduced-string/problem

namespace Super_reduced_string
{
    public class Program
    {
        public static void Main(String[] args)
        {
            String inputstring = Console.ReadLine();
            for (int i = 1; i < inputstring.Length; i++)
            {
                char ith = inputstring[i];
                char ithplusonlst = inputstring[i - 1];
                if (ith.Equals(ithplusonlst))
                {
                    inputstring = inputstring.Substring(0, i - 1) + inputstring.Substring(i + 1);
                    i = 0;
                }
            }
            Console.WriteLine(inputstring.Length == 0 ? "Empty String" : inputstring);
        }
    }
}
