﻿using System;
using System.Collections.Concurrent;

namespace Implementation_2
{
    class Program
    {
        static Random rand = new Random();
        static int n = 100000;
        static int count = 0;
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) //Run 5 times and get average for count
            {
                int[] arr = permutation(n);
                quicksort(arr, 0, n - 1);
            }
            Console.WriteLine("Num of Quicksort calls: {0}", count / 5);
        }

        //Generate random array of size n
        static int[] permutation(int n)
        {
            int[] arr = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                arr[i] = rand.Next(1000);
            }

            return arr;
        }

        static void quicksort(int[] arr, int low, int high)
        {
            count++;
            int pivot;

            if (high > low)
            {
                pivot = partition(arr, low, high);
                quicksort(arr, low, pivot - 1);
                quicksort(arr, pivot + 1, high);
            }
        }

        static int partition(int[] arr, int low, int high)
        {
            int i, j, temp;

            int pivotlow, pivothigh, pivotmid;

            //Select left, right, and mid pivots
            int[] pivots = {    pivotlow = arr[low],
                                pivothigh = arr[high],
                                pivotmid = arr[(low + high) / 2]
                            };

            //Take median
            Array.Sort(pivots);
            int pivotitem = pivots[1];

            //Swap median to front of array
            for (i = low; i <= high; i++)
            {
                if (arr[i] == pivotitem)
                {
                    temp = arr[low];
                    arr[low] = pivotitem;
                    arr[i] = temp;
                    break;
                }
            }

            j = low;

            for (i = low + 1; i <= high; i++)
            {
                if (arr[i] < pivotitem)
                {
                    j++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
            temp = arr[low];
            arr[low] = arr[j];
            arr[j] = temp;

            return j;
        }
    }
}
