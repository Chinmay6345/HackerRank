using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_rotation
{
    public class AppHelper
    {
        public static void LeftRotation(Int32[] arr, Int32 d)
        {
            List<Int32> lst = arr.ToList<Int32>();
            for(int i=0;i<d;i++)
            {
                int k = lst[0];
                lst.RemoveAt(0);
                lst.Add(k);
            }
             Console.WriteLine(String.Join(" ", lst.Select(a => a)));
        }
    }


    public class Program
    {
        public static void Main(String[] args)
        {
            String[] ip = Console.ReadLine()
                         .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Int32[] array = Console.ReadLine()
                            .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(a => Convert.ToInt32(a))
                            .ToArray<Int32>();
            AppHelper.LeftRotation(array, Convert.ToInt32(ip[1]));
            Console.ReadLine();
        }
    }

}
