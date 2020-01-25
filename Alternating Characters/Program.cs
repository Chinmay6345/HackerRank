using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternating_Characters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String input = "beabeefeab";
            char[] array = input.ToCharArray();

            int count = 0;
            for (int i = 1, j = 0; i < input.Length; i++, j++)
            {

                if(array[i]==array[j])
                {
                    count++;
                }
            }
                Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
