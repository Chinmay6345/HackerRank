using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//https://www.hackerrank.com/challenges/minimum-distances/problem
namespace Minimum_Distances
{
    public static class AppHelper
    {
        public static Int64 ReturnMin(int[] array)
        {
            try
            {
                if (array.Length == 1)
                {
                    return -1;
                }
                if (array.All(g => g == array.First()))
                {
                    return array[0];
                }
                var s = array.Select((t, i) => new { Index = i, Key = t }).GroupBy(g => g.Key).Where(g => g.Count() == 2);
                if (s.Count() > 0)
                {
                    List<Int64> lstIntg = new List<Int64>();
                    List<Int64> lstoutput = new List<Int64>();
                    foreach (var item in s)
                    {
                        foreach (var index in item)
                        {
                            lstIntg.Add(index.Index);
                        }
                        lstoutput.Add(Math.Abs(lstIntg[1] - lstIntg[0]));
                        if (lstIntg.Count == 2)
                        {
                            lstIntg = new List<Int64>();
                        }
                    }
                    return lstoutput.Min();
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[262144];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
            Int32 NoOfArrayElements = Int32.Parse(Console.ReadLine());
            Int32[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(element => Int32.Parse(element)).ToArray<Int32>();
            Console.WriteLine(AppHelper.ReturnMin(array));
            Console.ReadLine();
        }
    }

}
