using System;

namespace Implementation_3
{
    class Program
    {
        static Random rand = new Random();
        static int n = 10;
        static int key = 30;

        //Use defined array to make sure we know what is inside the array
        //Could also use permutation and sort but don't know for sure that key is inside of arr
        static int[] arr = { 1, 4, 7, 12, 15, 22, 30};

        static void Main(string[] args)
        {
            int low = 0;
            int high = arr.Length - 1;
            int index = ternary(low, high, key, arr);

            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine("Key: {0} \n Index: {1}", key, index);
        }

        //Perform ternary search to find key in arr
        static int ternary(int low, int high, int key, int[] arr)
        {

            int mid1 = (low + (high - low) / 3);
            int mid2 = (high - (high - low) / 3);

            //Console.WriteLine("Mid1: {0} \n Mid2: {1}", mid1, mid2);

            if (arr[mid1] == key)
                return mid1;

            if (arr[mid2] == key)
                return mid2;

            if (key < arr[mid1])
            {
                return ternary(low, mid1 - 1, key, arr);
            }
            else if (key > arr[mid2])
            {
                return ternary(mid2 + 1, high, key, arr);
            }
            else
            {
                return ternary(mid1 + 1, mid2 - 1, key, arr);
            }
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
