using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

//https://www.hackerrank.com/challenges/array-left-rotation/problem

namespace Left_rotation
{
    public static class AppHelper
    {
        public static void LeftRotation(Int32[] arr, Int32 d)
        {
            List<Int32> lst = arr.ToList<Int32>();
            for (int i = 0; i < d; i++)
            {
                int k = lst[0];
                lst.RemoveAt(0);
                lst.Add(k);
            }
            Console.WriteLine(String.Join(" ", lst.Select(a => a)));
        }
        public static void LeftRotateArray(Int32[] arr, Int32 n, Int32 d)
        {
            Int32[] nums = new Int32[n];
            for (int i = 0; i < n; i++)
            {
                nums[(i + (n - d)) % n] = arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                arr[i] = nums[i];
            }
            Console.WriteLine(String.Join(" ", arr.Select(g => g)));
        }
        public static void LRotate(Int32 [] arr,Int32 d)
        {
            Int32 n = arr.Length;
            Int32[] temp = new int[d];
            for(Int32 i=0;i<d;i++)
            {
                temp[i] = arr[i];
            }
            for(Int32 j=d;j<n;j++)
            {
                arr[j - d] = arr[j];
            }
            for(Int32 k=0;k<d;k++)
            {
                arr[n - d + k] = temp[k];
            }
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
