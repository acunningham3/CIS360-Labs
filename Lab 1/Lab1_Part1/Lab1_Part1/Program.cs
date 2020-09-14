using System;

namespace Lab1
{
    
    class PartA
    {
        static void Main()
        {
            int n = 10;
            int counter = 0;
            double i, j;

            for (i = 1; i<=n; i++)
            {
                j = n;

                while(j >= 1)
                {
                    counter++;
                    j = Math.Floor(j / 2);
                }
            }

            Console.WriteLine("Number of times while loop is executed: {0}", counter);
        }
    }

    class PartB
    {
        static void Main()
        {
            int n = 5;
            int[] A = { 2, 5, 3, 7, 8 };
            int i, j, k, result;

            j = 0;

            for (i = 0; i <= n - 1; i++)
            {
                j = j + A[i];
            }

            k = 1;

            for (i = 1; i<=n; i++)
            {
                k = k + k;
            }

            result = j + k;
            Console.WriteLine("Output: {0}", result);
        }
    }
    
    class PartB_Simplified
    {
        static void Main()
        {
            int n = 5;
            int[] A = { 2, 5, 3, 7, 8 };
            int i, j, k, result;

            j = 0;
            k = 1;

            for (i = 0; i <= n - 1; i++)
            {
                j = j + A[i];
                k = k + k;
            }

            result = j + k;
            Console.WriteLine("Output: {0}", result);
        }
    }
}
