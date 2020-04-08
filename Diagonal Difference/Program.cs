using System;
//https://www.hackerrank.com/challenges/diagonal-difference/problem
/*Given a square matrix, calculate the absolute difference between the sums of its diagonals.

For example, the square matrix  is shown below:

1 2 3
4 5 6
9 8 9  
The left-to-right diagonal = . The right to left diagonal = . Their absolute difference is .

Function description

Complete the  function in the editor below. It must return an integer representing the absolute diagonal difference.

diagonalDifference takes the following parameter:

arr: an array of integers .
Input Format

The first line contains a single integer, , the number of rows and columns in the matrix .
Each of the next  lines describes a row, , and consists of  space-separated integers .

Constraints

Output Format

Print the absolute difference between the sums of the matrix's two diagonals as a single integer.

Sample Input

3
11 2 4
4 5 6
10 8 -12
Sample Output

15
Explanation

The primary diagonal is:

11
   5
     -12
Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:

     4
   5
10
Sum across the secondary diagonal: 4 + 5 + 10 = 19
Difference: |4 - 19| = 15

Note: |x| is the absolute value of x  */
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
