using System;

namespace Implementation_2
{
    class Program
    {
        static Random rand = new Random();
        static int n = 100;

        static void Main(string[] args)
        {
            int[] arr = permutation(n);
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            int[] data = new int[2];
            smallestlargest(arr, data);

            Console.WriteLine("Min: {0}, Max: {1}", data[0], data[1]);
        }

        //Find largest and smallest element of array
        static int[] smallestlargest(int[] arr, int[] data)
        {
            int max = 0;
            int min = 100;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i + 1] < min)
                    {
                        min = arr[i+1];
                    }
                }
                else
                {
                    if (arr[i + 1] > max)
                    {
                        max = arr[i + 1];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }

                data[0] = min;
                data[1] = max;
            }

            return data;
        }

        //Generate random array of size n
        static int[] permutation(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                arr[i] = rand.Next(500);
            }

            return arr;
        }
    }
}
