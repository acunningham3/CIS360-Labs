using System;
using System.Diagnostics;

namespace Implementation_1
{
    class Program
    {
        static int INF = 9999;
        static void Main(string[] args)
        {
            #region Graph 1
            int[,] W1 = {   {  0, INF,  45, INF,  10,  28, INF, INF,  25, INF },
                            {INF,   0,  32, INF,  17, INF, INF, INF, INF, INF },
                            { 45,  32,   0, INF, INF, INF, INF, INF, INF, INF },
                            {INF, INF, INF,   0,  18, INF,   5, INF, INF, INF },
                            { 10,  17, INF,  18,   0, INF, INF,   3, INF, INF },
                            { 28, INF, INF, INF, INF,   0, INF, INF, INF,   6 },
                            {INF, INF, INF,   5, INF, INF,   0,  59, INF, INF },
                            {INF, INF, INF, INF,   3, INF,  59,   0,   4, INF },
                            { 25, INF, INF, INF, INF, INF, INF,   4,   0,  12 },
                            {INF, INF, INF, INF, INF,   6, INF, INF,  12,   0 } };

            Stopwatch timer1 = new Stopwatch();

            Console.WriteLine("Graph 1, Source: v{0}", 1);

            timer1.Start();
            dijkstra(10, W1);
            timer1.Stop();

            Console.WriteLine("T(ms) = {0:F4}", timer1.ElapsedMilliseconds);
            Console.WriteLine();

            #endregion

            #region Graph 2
            int[,] W2 = {       {  0, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,  95, INF, INF, INF },
                                {INF,   0, INF, INF, INF,  60, INF, INF, INF, INF, INF,  66, INF, INF, INF },
                                { 91, INF,   0, INF, INF, INF, INF,  46, INF,  30, INF, INF,  58, INF, INF },
                                {INF, INF,  87,   0, INF,  69,  31, INF, INF, INF, INF, INF, INF, INF, INF },
                                {INF, INF, INF, INF,   0, INF, INF, INF, INF,  48, INF, INF, INF, INF, INF },
                                {INF, INF,  49, INF,  21,   0,   6, INF, INF, INF, INF, INF, INF, INF,  92 },
                                {INF, INF, INF, INF, INF, INF,   0, INF, INF, INF,   8, INF, INF, INF, INF },
                                {INF, INF, INF,  84, INF, INF, INF,   0, INF, INF, INF, INF, INF,  48, INF },
                                {INF, INF, INF, INF, INF, INF, INF, INF,   0, INF, INF, INF, INF,  33, INF },
                                {INF, INF, INF,  12, INF, INF, INF, INF, INF,   0, INF,  55,  44, INF, INF },
                                {INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   0, INF,  60, INF, INF },
                                {INF, INF,  13, INF, INF, INF, INF,  19, INF,  72, INF,   0,   8, INF,   5 },
                                {INF, INF, INF, INF,  16, INF, INF, INF, INF, INF, INF, INF,   0, INF, INF },
                                {INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   0, INF },
                                {INF, INF, INF,  11, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF,   0 } };

            Stopwatch timer2 = new Stopwatch();

            Console.WriteLine("Graph 2, Source: v{0}", 1);

            timer2.Start();
            dijkstra(15, W2);
            timer2.Stop();

            Console.WriteLine("T(ms) = {0:F4}", timer2.ElapsedMilliseconds);
            Console.WriteLine();
            #endregion

            #region Graph 3
            int[,] W3 = {   {  0, INF,  40, INF,  77,  30, INF,  73, INF, INF, INF,  33,  13,  48,  25 },
                            {INF,   0,  57,  35,  95,  65,  38, INF,  19, INF, INF,  26,   5, INF,  60 },
                            {INF,  94,   0,  68, INF,  18, INF, INF,  80, INF, INF, INF,  28, INF, INF },
                            {INF, INF,  16,   0, INF,  64,   2,  95, INF, INF,  60, INF, INF,  53, INF },
                            { 13,  14, INF, INF,   0, INF, INF,  19, INF, INF,  69,  63,  18, INF, INF },
                            { 34, INF,  57,  25, INF,   0, INF,  91,  14,  99, INF,  10,  22,  98, INF },
                            {INF, INF,  73,  29, INF,  83,   0,  96,  43,  20,  83, INF,  46,  91, INF },
                            { 48, INF,   4,  32, INF, INF, INF,   0, INF,  97, INF, INF,  96, INF,  63 },
                            { 61, INF, INF,  52, INF,  81,  97,  39,   0, INF,  28,  52, INF,  84, INF },
                            { 32,  80,  96,  26,  16, INF, INF,  20,  96,   0, INF,   7, INF,  93, INF },
                            {INF,  76, INF,  95, INF,  71,  16, INF,  57, INF,   0,  16,  41,   6, INF },
                            {INF,  28, INF, INF,   8, INF, INF, INF,   9, INF, INF,   0,  16,  79,  42 },
                            {INF,   3, INF,  61, INF, INF, INF,  91, INF, INF,  71, INF,   0,  35, INF },
                            { 31,  37,  62,  35, INF,  31, INF,  49,  45, INF, INF,   6, INF,   0,  93 },
                            {INF,  43, INF,  98,  27, INF, INF,  64,  99, INF, INF,  19,  31, INF,   0 } };

            Stopwatch timer3 = new Stopwatch();

            Console.WriteLine("Graph 3, Source: v{0}", 1);

            timer3.Start();
            dijkstra(15, W3);
            timer3.Stop();

            Console.WriteLine("T(ms) = {0:F4}", timer3.ElapsedMilliseconds);
            Console.WriteLine();

            #endregion
        }

        static void dijkstra(int N, int[,] W)
        {
            int i, j = 0, min, vnear = 0;
            int[] touch     = new int[N];
            int[] length    = new int[N];
            int[] shortest  = new int[N];

            for(i = 1; i < N; i++)
            {
                touch[i] = 0;
                length[i] = W[0, i];
            }

            while(j < N - 1)
            {
                min = INF + 1;
                for(i = 1; i < N; i++)
                {
                    if(length[i] >= 0 && length[i] < min)
                    {
                        min = length[i];
                        vnear = i;
                    }
                }

                for(i = 1; i < N; i++)
                {
                    if(length[vnear] + W[vnear, i] < length[i])
                    {
                        length[i] = length[vnear] + W[vnear, i];
                        touch[i] = vnear;
                    }
                }

                shortest[vnear] = length[vnear];
                length[vnear] = -1;
                j++;
            }

            //Print touch array
            Console.WriteLine("Touch Array:");
            printArray(touch);

            //Print shortest array
            Console.WriteLine("Shortest Array:");
            printArray(shortest);
        }

        static void printArray(int[] P)
        {
            for(int i = 0; i < P.Length; i++)
            {
                Console.Write(P[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
