using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Anagrams
{
    public static class AppHelper
    {
        public static Int32 CountToMakeAnagram(String A, String B)
        {
            try
            {
                Int32[] array1 = new Int32[26];
                Int32[] array2 = new Int32[26];
                Int32 i, result = 0;
                if (!String.IsNullOrEmpty(A) && !String.IsNullOrEmpty(B))
                {
                    for (i = 0; i < 26; i++)
                    {
                        array1[i] = array2[i] = 0;
                    }
                    for (i = 0; i < A.Length; i++)
                    {
                        array1[(Int32)(A[i] - 'a')]++;
                    }
                    for (i = 0; i < B.Length; i++)
                    {
                        array2[(Int32)(B[i] - 'a')]++;
                    }
                    for (i = 0; i < 26; i++)
                    {
                        result = (result + array1[i] + array2[i]) - 2 * Math.Min(array1[i], array2[i]);
                    }
                }
                return result;
            }
            catch (Exception ex)
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
                List<Int32> lst = new List<Int32>();
                String A = Console.ReadLine();
                String B = Console.ReadLine();
                lst.Add(AppHelper.CountToMakeAnagram(A, B));
                foreach (Int32 k in lst)
                {
                    Console.WriteLine(k);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }

}
