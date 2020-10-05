using System;

namespace Implementation_1
{
    class Program
    {
        static Random rand = new Random();
        static int n = 6;
        static int m = 3;

        static void Main(string[] args)
        {
            int[] arr = permutation(n);
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            int[] sets = new int[m];
            subset(arr, n, m, 0, 0, sets);
        }

        //Print all subsets of length m from array arr of size n
        static void subset(int[] arr, int n, int m, int index, int i, int[] sets)
        {
            if (i >= n)
            {
                return;
            }

            if (index == m)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(sets[j] + " ");
                }
                Console.WriteLine(" ");
                return;
            }

            //Print set with current location included
            sets[index] = arr[i];
            subset(arr, n, m, index + 1, i + 1, sets);

            //Print set without current location
            subset(arr, n, m, index, i + 1, sets);
        }

        //Generate random array of size n
        static int[] permutation(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                arr[i] = rand.Next(100);
            }

            return arr;
        }
    }
}
