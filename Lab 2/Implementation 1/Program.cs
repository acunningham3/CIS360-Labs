using System;
using System.Diagnostics;
using System.Linq;

namespace Lab_2
{
    class Program
    {
        static Random rand = new Random();
        static int fibn = 10;
        static int fib2n = 60;

        static void Main(string[] args)
        {
            #region part 1
            int n = 10;
            int m = 5;

            int []array = permutation(n);   //Generate random array size n

            int[] smallarray = smallArr(array, m, n);

            Console.WriteLine("Array: {0}", String.Join(",", array));
            Console.Write("Smallest {0}: ", m);
            for (int i = 0; i <= m - 1; i++)
            {
                Console.Write("{0}, ", smallarray[i]);
            }
            Console.WriteLine("");
            #endregion

            #region part 2
            Stopwatch timer1 = new Stopwatch();

            timer1.Start();
            decimal fib = fibonacci(fibn);
            timer1.Stop();

            Console.WriteLine("{0}th term: {1}", fibn, fib);
            Console.WriteLine("T = {0:F4}", timer1.Elapsed.TotalMilliseconds);
            #endregion

            #region part 3
            Stopwatch timer2 = new Stopwatch();

            timer2.Start();
            decimal[] fibarr = fibonacci2(fib2n);
            timer2.Stop();

            Console.WriteLine("{0}th term: {1}", fib2n, fibarr[fib2n]);
            Console.WriteLine("T = {0:F4}", timer2.Elapsed.TotalMilliseconds);
            #endregion

        }
        static int[] permutation(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i <= n-1; i++)
            {
                arr[i] = rand.Next(100);
            }

            return arr;
        }
        
        static int[] smallArr(int []arr, int m, int n)
        {
            int minVal = 0, temp = 0, index = 0;
            int[] temparr = new int[n];
            Array.Copy(arr, temparr, n);

            // Search for three smallest numbers
            for (int i = 0; i <= m - 1; i++)
            {
                index = i;
                minVal = temparr[i];
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (arr[j] < minVal)
                    {
                        index = j;
                        minVal = temparr[j];
                        temp = temparr[i];
                        temparr[i] = temparr[index];
                        temparr[index] = temp;
                    }

                }
            }
            return temparr;
        }

        static decimal fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }

        static decimal[] fibonacci2(int n)
        {
            decimal[] f = new decimal[n + 1];   // +1 so it starts at index 1 instead of 0

            f[0] = 0;
            if (n > 0)
            {
                f[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    f[i] = f[i - 1] + f[i - 2];
                }
                return f;
            }
            else return f;
        }
    }
}
