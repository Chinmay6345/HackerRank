using System;

//https://www.hackerrank.com/challenges/alternating-characters/problem?h_r=profile

/*
 You are given a string containing characters  and  only. Your task is to change it into a string such that there are no matching adjacent characters. To do this, you are allowed to delete zero or more characters in the string.

Your task is to find the minimum number of required deletions.

For example, given the string , remove an  at positions  and  to make  in  deletions.

Function Description

Complete the alternatingCharacters function in the editor below. It must return an integer representing the minimum number of deletions to make the alternating string.

alternatingCharacters has the following parameter(s):

s: a string
Input Format

The first line contains an integer , the number of queries.
The next  lines each contain a string .

Constraints

Each string  will consist only of characters  and 
Output Format

For each query, print the minimum number of deletions required on a new line.

Sample Input

5
AAAA
BBBBB
ABABABAB
BABABA
AAABBB
Sample Output

3
4
0
0
4
*/
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
