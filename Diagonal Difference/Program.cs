using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    public static class AppHelper
    {
        public static void DiagonalDifference(Int32[,] arr, Int32 n)
        {
            try
            {
                Int32 d1 = 0, d2 = 0;
                for (Int32 i = 0; i < n; i++)
                {
                    d1 = d1 + arr[i, i];
                    d2 = d2 + arr[i, n - i - 1];
                }
                Console.WriteLine(Math.Abs(d1 - d2));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            try
            {
                Int32 n = Convert.ToInt32(Console.ReadLine());
                Int32[,] arr = new Int32[n, n];
                for (int i = 0; i < n; i++)
                {
                    String input = Console.ReadLine();
                    String[] inputs = input.Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = Convert.ToInt32(inputs[j]);
                    }
                }
                AppHelper.DiagonalDifference(arr, n);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }
    }

}
