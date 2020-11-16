using System;
using System.Numerics;

namespace Implementation_1
{
    class Program
    {
        public static int INF = 999999;     //Placeholder for infinity
        public static int V = 7;            //Number of vertices
        static void Main(string[] args)
        {
            /*Directed graph A
            int[,] WA = { {  0,   5, INF,  11, INF, INF },
                          {  7,   0,   1, INF, INF, INF },
                          {INF, INF,   0, INF,   1, INF },
                          {INF, INF, INF,   0, INF,  20 },
                          {INF,   1,   3,   1,   0,   6 },
                          {INF, INF, INF, INF, INF,   0 } };
            int[,] DA = WA;

            //Undirected graph B
            int[,] WB = { {  0,   5, INF,   1,   3, INF },
                          {  5,   0,  11,   5,   7, INF },
                          {INF,  11,   0, INF,   4,  13 },
                          {  1,   5, INF,   0, INF,   4 },
                          {  3,   7,   4, INF,   0,   4 },
                          {INF, INF,  13,   4,   4,   0 } };
            int[,] DB = WB;*/

            //Undirected graph C
            int[,] WC = { {  0,   4, INF, INF, INF,  10, INF },
                          {  3,   0, INF,  18, INF, INF, INF },
                          {INF,   6,   0, INF, INF, INF, INF },
                          {INF,   5,  15,   0,   2,  19,   5 },
                          {INF, INF,  12,   1,   0, INF, INF },
                          {INF, INF, INF, INF, INF,   0,  10 },
                          {INF, INF, INF,   8, INF, INF,   0 } };
            int[,] DC = WC;


            /*
            int[,] PA = floyd(WA);
            printPath(PA, 0, 4);
            Console.WriteLine();

            //Print DA to check values
            for (int i = 0; i < V; ++i)
            {
                for (int j = 0; j < V; ++j)
                {
                    if (DA[i, j] == INF)
                    {
                        Console.Write("INF ");
                    }
                    else
                    {
                        Console.Write(DA[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] PB = floyd(WB);
            printPath(PB, 2, 5);
            Console.WriteLine();

            //Print DB to check values
            for (int i = 0; i < V; ++i)
            {
                for (int j = 0; j < V; ++j)
                {
                    if (DB[i, j] == INF)
                    {
                        Console.Write("INF ");
                    }
                    else
                    {
                        Console.Write(DB[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }*/

            int[,] PC = floyd(WC);
            Console.WriteLine();

            //Print DC to check values
            for (int i = 0; i < V; ++i)
            {
                for (int j = 0; j < V; ++j)
                {
                    if (DC[i, j] == INF)
                    {
                        Console.Write("INF ");
                    }
                    else
                    {
                        Console.Write(DC[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            //Print all values in PC
            for (int i = 0; i < V; ++i)
            {
                for (int j = 0; j < V; ++j)
                {
                    Console.Write(PC[i, j] + " ");
                }

                Console.WriteLine();
            }

        }

        static int[,] floyd(int[,] W)
        {
            int[,] D = W;               //Used to hold shortest paths
            int[,] P = new int[V, V];   //Used to print shortest paths

            //Initialize print path
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    P[i, j] = 0;
                }
            }

            //Find shortest paths
            for (int k = 0; k < V; k++)
            {
                for (int i = 0; i < V; i++)
                {
                    for (int j = 0; j < V; j++)
                    {
                        if (D[i, k] + D[k, j] < D[i, j])
                        {
                            D[i, j] = D[i, k] + D[k, j];
                            P[i, j] = k;
                        }
                    }
                }
            }
            return P;
        }

        static void printPath (int[,] P, int q, int r)
        {
            if (P[q, r] != 0)
            {
                printPath(P, q, P[q, r]);
                Console.WriteLine("v" + P[q, r]);
                printPath(P, P[q, r], r);
            }
        }
    }
}
