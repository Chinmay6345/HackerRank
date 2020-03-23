using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Rotation
{
    public static class AppHelper
    {
        public static void CircularRotation(Int32[] arr, List<Int32> lst, Int32 k)
        {
            List<Int32> lstIntg = arr.ToList();
            for (Int32 i = 0; i < k; i++)
            {
                Int32 last = lstIntg.Last();
                lstIntg.Remove(last);
                lstIntg.Insert(0, last);

            }
            foreach (Int32 element in lst)
            {
                Console.WriteLine(lstIntg[element]);
            }
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            Int32[] params_arr = "3 2 3"
                            .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(a => Int32.Parse(a))
                            .ToArray<Int32>();
            Int32[] arr = "4 5 6"
                        .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(a => Int32.Parse(a))
                        .ToArray<Int32>();
            Int32 q = params_arr[2];
            List<Int32> lst = new List<Int32>();
            //for (Int32 i = 0; i < q; i++)
            //{
            lst.AddRange(new Int32[] { 0, 1, 2 });
            // }
            AppHelper.CircularRotation(arr, lst, 2);
            Console.ReadLine();
        }
    }

}
