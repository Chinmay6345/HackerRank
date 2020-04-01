using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.hackerrank.com/challenges/library-fine/problem
/*
Your local library needs your help! Given the expected and actual return dates for a library book, create a program that calculates the fine (if any). The fee structure is as follows:

If the book is returned on or before the expected return date, no fine will be charged (i.e.: .
If the book is returned after the expected return day but still within the same calendar month and year as the expected return date, .
If the book is returned after the expected return month but still within the same calendar year as the expected return date, the .
If the book is returned after the calendar year in which it was expected, there is a fixed fine of .
Charges are based only on the least precise measure of lateness. For example, whether a book is due January 1, 2017 or December 31, 2017, if it is returned January 1, 2018, that is a year late and the fine would be .

Function Description

Complete the libraryFine function in the editor below. It must return an integer representing the fine due.

libraryFine has the following parameter(s):

d1, m1, y1: returned date day, month and year
d2, m2, y2: due date day, month and year
Input Format

The first line contains  space-separated integers, , denoting the respective , , and  on which the book was returned.
The second line contains  space-separated integers, , denoting the respective , , and  on which the book was due to be returned.

Constraints

Output Format

Print a single integer denoting the library fine for the book received as input.

Sample Input

9 6 2015
6 6 2015
Sample Output

45
Explanation

Given the following dates:
Returned: 
Due: 

Because , we know it is less than a year late.
Because , we know it's less than a month late.
Because , we know that it was returned late (but still within the same month and year).

Per the library's fee structure, we know that our fine will be . We then print the result of  as our output. 
*/
namespace Library_fine
{
    public static class AppHelper
    {
        public static Int32 FineAmount(Int32 returnyear, Int32 returnmonth, Int32 returnday, Int32 dueyear, Int32 duemonth, Int32 dueday)
        {
            Int32 fine = 0;
            if ((returnyear.Equals(dueyear) && returnmonth.Equals(duemonth) && returnday.Equals(dueday)) ||
                (returnyear.Equals(dueyear) && (returnmonth < duemonth || returnmonth.Equals(duemonth)) && (returnday < dueday || returnday.Equals(dueday))) 
               )
            {
                fine = 0;
            }
            else if ((returnday > dueday) && (returnmonth.Equals(duemonth) && returnyear.Equals(dueyear)))
            {
                fine = 15 * (returnday - dueday);
            }
            else if ((returnmonth > duemonth) && (returnyear.Equals(dueyear)))
            {
                fine = 500 * (returnmonth - duemonth);
            }
            else if (returnyear > dueyear)
            {
                fine = 10000;
            }
            return fine;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 [] returnString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a=>Int32.Parse(a)).ToArray<Int32>();
            Int32 [] DueDteString = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a=>Int32.Parse(a)).ToArray<Int32>();
            int fine = AppHelper.FineAmount(returnString[2], returnString[1], returnString[0], DueDteString[2], DueDteString[1], DueDteString[0]);
            Console.WriteLine(fine);
        }
    }

}
