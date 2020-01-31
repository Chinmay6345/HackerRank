using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.hackerrank.com/challenges/library-fine/problem
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
