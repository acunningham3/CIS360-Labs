using System;

namespace Implementation_1
{
    class Program
    {
        public static readonly int N = 5;
        public static readonly int diag = 2 * N - 1;
        public static int[] col = new int[N];
        public static bool[] cCol = new bool[N];
        public static bool[] cRD = new bool[diag];
        public static bool[] cLD = new bool[diag];
        public static int[,] solution = new int[N, N];
        static void Main(string[] args)
        {
            //Check all top nodes
            for (int i = 0; i < N; i++)
            {
                Queens(i);
            }
        }

        public static void Queens(int i)
        {
            int RD = (N - 1) + i - col[i];      //Find which right diag to change
            int LD = (2 * N - 2) - col[i] - i;  //Find which left diag to change

            if (Promising(i, RD, LD))
            {
                //Set control
                cCol[i] = true;
                cRD[RD] = true;
                cLD[LD] = true;
                solution[i, col[i]] = 1;

                if (col[i] == N - 1)
                {
                    Console.WriteLine("{0} x {1} solution: ", N, N);
                    
                    for(int k = 0; k < N; k++)
                    {
                        for(int l = 0; l < N; l++)
                        {
                            if (solution[k, l] == 1)
                                Console.WriteLine("{0}, {1}", k, l);
                        }
                    }

                    return;
                }
                else
                {
                    //Move to next row
                    for(int j = 0; j < N; j++)
                    {
                        col[j] += 1;
                    }
                    //Check all columns of next row (will return solution)
                    for (int j = 0; j < N; j++)
                    {
                        Queens(j);      //Check jth column
                    }

                    //Backtrack to previous row
                    for (int j = 0; j < N; j++)
                    {
                        col[j] -= 1;
                    }
                    //Backtracking
                    cCol[i] = false;
                    cRD[RD] = false;
                    cLD[LD] = false;
                    solution[i, col[i]] = 0;
                }
            }
        }

        public static bool Promising(int i, int RD, int LD)
        {
            //int k = 0;
            bool result = true;

            if (cCol[i] || cRD[RD] || cLD[LD])
                result = false;

            /*while (k < i && result)
            {
               
                if (col[i] == col[k] || Math.Abs(col[i] - col[k]) == i - k)
                    result = false;
                k++;
            }*/
            return result;
        }

        public static void PrintSolution()
        {

        }
    }
}
