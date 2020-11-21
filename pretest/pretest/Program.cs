using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pretest
{
    class Program
    {
        static void Main(string[] args)
        {


            //1.Write a function that accepts an array of non-negative integers and returns the second largest integer in the array. Return - 1 if there is no second largest.
            //The signature of the function is
            //int f(int[ ] a)
            // int[] a = { 1, 2, 3, 4 };
            //int[] a =  { 4, 1, 2, 3 } ;
            //int[] a = { };
            //            f(a);



            //2.Write a function that takes an array of integers as an argument and returns a value based on the sums of the even and odd numbers in the array. Let X = the sum of the odd numbers in the array and let Y = the sum of the even numbers.The function should return X - Y
            //The signature of the function is:
            //int f(int[] a)
            // int[] a = { 1, 2, 3, 4 };
            //int[] a =  { 4, 1, 2, 3 } ;
            //int[] a = { };
            //            f(a);

            //3. Write a function that accepts a character array, a zero-based start position and a length.It should return a character array containing containing length characters starting with the start character of the input array. The function should do error checking on the start position and the length and return null if the either value is not legal.
            //The function signature is:

            char[] a = { 'a', 'b', 'c' };
            int start = 0;
            int len = 3;

            f(a, start, len);


            
        }
        


        public static int b(int[] a)
        {
            int ans = -1;

            foreach (var item in a)
            {
                if (item < 0)
                {
                    return ans;
                }
            }

            Array.Sort(a);
            Array.Reverse(a);
            int largest  = a[0];
         
            foreach (var i in a)
            {
                if (i < largest) {

                    ans = i;
                    return ans;
                }
           
            }
            return ans;
        }


        public static int f(int [] a)
        {
            int x =0;
            int y = 0;
            int ans;

            foreach (var item in a)
            {
                if (item % 2 == 1)
                {
                    x += item;
                }
                else
                {
                    y += item;
                }
            }

            ans = x - y;
           
            return ans ;

        }


        


        public static char[] f(char[] a, int start, int len)
        {

            char [] ans = { };

            if (start != 0 )
            {
                return null;
            }


            for (int i = start, j = 0;  i < len; i++, j++)
            {
                ans[j] = a[i];

            }
            return ans;
        }


    }
}
