using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Strings
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    public static class IEnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>> MakeGroupsOf<T>(this IEnumerable<T> source, int count)
        {
            var grouping = new List<T>();
            foreach (var item in source)
            {
                grouping.Add(item);
                if (grouping.Count == count)
                {
                    yield return grouping;
                    grouping = new List<T>();
                }
            }

            if (grouping.Count != 0)
            {
                yield return grouping;
            }
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 n = Int32.Parse(Console.ReadLine());
            n = n + n;
            List<String> lst = new List<String>();
            for (int i = 0; i < n; i++)
            {
                String input = Console.ReadLine();
                lst.Add(input);
            }
            foreach (var element in lst.MakeGroupsOf(2).ToList())
            {
                if ((element.ElementAt(0).ToCharArray().Intersect(element.ElementAt(1).ToCharArray()).Any()) ||
                    (element.ElementAt(1).ToCharArray().Intersect(element.ElementAt(0).ToCharArray()).Any())
                   )
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            Console.ReadLine();
        }
    }

}
