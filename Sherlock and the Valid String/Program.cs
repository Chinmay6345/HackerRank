using System;
using System.Collections.Generic;
using System.Linq;

//https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings

/*
Sherlock considers a string to be valid if all characters of the string appear the same number of times. It is also valid if he can remove just  character at  index in the string, and the remaining characters will occur the same number of times. Given a string , determine if it is valid. If so, return YES, otherwise return NO.

For example, if , it is a valid string because frequencies are . So is  because we can remove one  and have  of each character in the remaining string. If  however, the string is not valid as we can only remove  occurrence of . That would leave character frequencies of .

Function Description

Complete the isValid function in the editor below. It should return either the string YES or the string NO.

isValid has the following parameter(s):

s: a string
Input Format

A single string .

Constraints

Each character 
Output Format

Print YES if string  is valid, otherwise, print NO.

Sample Input 0

aabbcd
Sample Output 0

NO
Explanation 0

Given , we would need to remove two characters, both c and d  aabb or a and b  abcd, to make it valid. We are limited to removing only one character, so  is invalid.

Sample Input 1

aabbccddeefghi
Sample Output 1

NO
Explanation 1

Frequency counts for the letters are as follows:

{'a': 2, 'b': 2, 'c': 2, 'd': 2, 'e': 2, 'f': 1, 'g': 1, 'h': 1, 'i': 1}

There are two ways to make the valid string:

Remove  characters with a frequency of : .
Remove  characters of frequency : .
Neither of these is an option.

Sample Input 2

abcdefghhgfedecba
Sample Output 2

YES
Explanation 2

All characters occur twice except for  which occurs  times. We can delete one instance of  to have a valid string. 
     
*/

namespace Sherlock_and_the_Valid_String
{
    public static class AppHelper
    {
        public static void SherlockString(String str)
        {
            if (str.Length == 1)
            {
                Console.WriteLine("YES");
                return;
            }
            else
            {
                Dictionary<String, Int32> map = new Dictionary<String, Int32>();
                for (int k = 0; k < str.Length; k++)
                {
                    if (map.ContainsKey(str[k].ToString()))
                    {
                        map[str[k].ToString()]++;
                    }
                    else
                    {
                        map[str[k].ToString()] = 1;
                    }
                }
                Int32 previous = -999;
                var r = map.GetEnumerator();
                Int32 i = 1;
                Int32 valueOfFirstKey = Int32.MinValue;
                foreach (Int32 val in map.Values)
                {
                    valueOfFirstKey = val;
                    break;
                }
                if (map.All(a => a.Value == valueOfFirstKey))
                {
                    Console.WriteLine("YES");
                    return;
                }
                while (r.MoveNext())
                {
                    if (i == 1)
                    {
                        previous = r.Current.Value;
                        i = 0;
                        continue;
                    }
                    if (r.Current.Value == previous)
                    {
                        continue;
                    }
                    else
                    {
                        map.Remove(r.Current.Key);
                        if (map.All(g => g.Value == previous))
                        {
                            Console.WriteLine("YES");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            break;
                        }
                    }
                }
            }
        }
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            String str = Console.ReadLine();
            AppHelper.SherlockString(str);
        }
    }
}
