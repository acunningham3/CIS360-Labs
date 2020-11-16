using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Implementation_1
{
    class Program
    {
        static readonly int INF = 999;
        static void Main(string[] args)
        {
            #region Graph1
            int[,] W1 = {   {  0,  32, INF,  17, INF, INF, INF, INF, INF, INF },
                            { 32,   0, INF, INF,  45, INF, INF, INF, INF, INF },
                            {INF, INF,   0,  18, INF, INF,   5, INF, INF, INF },
                            { 17, INF,  18,   0,  10, INF, INF,   3, INF, INF },
                            {INF,  45, INF,  10,   0,  28, INF, INF,  25, INF },
                            {INF, INF, INF, INF,  28,   0, INF, INF, INF,   6 },
                            {INF, INF,   5, INF, INF, INF,   0,  59, INF, INF },
                            {INF, INF, INF,   3, INF, INF,  59,   0,   4, INF },
                            {INF, INF, INF, INF,  25, INF, INF,   4,   0,  12 },
                            {INF, INF, INF, INF, INF,   6, INF, INF,  12,   0 } };
            int N1 = 10;

            Stopwatch timer1 = new Stopwatch();

            timer1.Start();
                List<int[]> U1 = new List<int[]>();  //Use list of arrays to hold disjoin sets
                InitializeU(U1, N1);

                List<Edge> Edges1 = new List<Edge>();    //Use list of objects to hold edge data (src, dest, weight)
                EdgeInitialize(Edges1, W1, N1);  //Initialize the edges with the graph and then sort them in non-decreasing order
                List<Edge> SortedEdges1 = Edges1.OrderBy(o => o.weight).ToList(); //Sort edges by weight in non-decreasing order

                List<Edge> ChosenEdges1 = new List<Edge>();  //Store the edges that kruskal will pick for the MST
                Kruskal(U1, SortedEdges1, ChosenEdges1, N1);
            timer1.Stop();

            Console.WriteLine("Graph 1");
            Console.WriteLine(" ");

            foreach(Edge edge in ChosenEdges1)
            {
                Console.WriteLine("Source: {0}, Dest: {1}, Weight: {2}", edge.source, edge.dest, edge.weight);
            }
            Console.WriteLine("Time(ms) = {0:F4}", timer1.ElapsedMilliseconds);
            Console.WriteLine(" ");

            #endregion

            #region Graph2
            int[,] W2 = {   {0, 12, INF, INF, INF, INF, INF, INF, INF, 25, INF, 95, INF, INF, INF},
                            {INF, 0, INF, INF, INF, 60, INF, INF, INF, INF, INF, 66, INF, INF, INF},
                            {91, INF, 0, INF, INF, INF, INF, 46, INF, 30, INF, INF, 58, INF, INF},
                            {INF, INF, 87, 0, INF, 69, 31, INF, INF, INF, INF, INF, INF, INF, INF},
                            {INF, INF, INF, INF, 0, INF, INF, INF, INF, 48, INF, INF, INF, INF, INF},
                            {INF, INF, 49, INF, 21, 0, 6, INF, INF, INF, INF, INF, INF, INF, 92},
                            {INF, INF, INF, INF, INF, INF, 0, INF, INF, INF, 8, INF, INF, INF, INF},
                            {INF, INF, INF, 84, INF, INF, INF, 0, INF, INF, INF, INF, INF, 48, INF},
                            {INF, INF, INF, INF, INF, INF, INF, INF, 0, INF, INF, INF, INF, 33, INF},
                            {INF, INF, INF, 12, INF, INF, INF, INF, INF, 0, INF, 55, 44, INF, INF},
                            {INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, 0, INF, 60, INF, INF},
                            {INF, INF, 13, INF, INF, INF, INF, 19, INF, 72, INF, 0, 8, INF, 5},
                            {INF, INF, INF, INF, 16, INF, INF, INF, INF, INF, INF, INF, 0, INF, INF},
                            {INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, 0, INF},
                            {INF, INF, INF, 11, INF, INF, INF, INF, INF, INF, INF, INF, INF, INF, 0}};
            int N2 = 15;

            Stopwatch timer2 = new Stopwatch();

            timer2.Start();
                List<int[]> U2 = new List<int[]>();  //Use list of arrays to hold disjoin sets
                InitializeU(U2, N2);

                List<Edge> Edges2 = new List<Edge>();    //Use list of objects to hold edge data (src, dest, weight)
                EdgeInitialize(Edges2, W2, N2);  //Initialize the edges with the graph and then sort them in non-decreasing order
                List<Edge> SortedEdges2 = Edges2.OrderBy(o => o.weight).ToList(); //Sort edges by weight in non-decreasing order

                List<Edge> ChosenEdges2 = new List<Edge>();  //Store the edges that kruskal will pick for the MST
                Kruskal(U2, SortedEdges2, ChosenEdges2, N2);
            timer2.Start();

            Console.WriteLine("Graph 2");
            Console.WriteLine(" ");

            foreach (Edge edge in ChosenEdges2)
            {
                Console.WriteLine("Source: {0}, Dest: {1}, Weight: {2}", edge.source, edge.dest, edge.weight);
            }
            Console.WriteLine("Time(ms) = {0:F4}", timer2.ElapsedMilliseconds);
            Console.WriteLine(" ");

            #endregion

            #region Graph3
            int[,] W3 = {   {0, INF, 40, INF, 77, 30, INF, 73, INF, INF, INF, 33, 13, 48, 25},
                            {INF, 0, 57, 35, 95, 65, 38, INF, 19, INF, INF, 26, 5, INF, 60},
                            {INF, 94, 0, 68, INF, 18, INF, INF, 80, INF, INF, INF, 28, INF, INF},
                            {INF, INF, 16, 0, INF, 64, 2, 95, INF, INF, 60, INF, INF, 53, INF},
                            {13, 14, INF, INF, 0, INF, INF, 19, INF, INF, 69, 63, 18, INF, INF},
                            {34, INF, 57, 25, INF, 0, INF, 91, 14, 99, INF, 10, 22, 98, INF},
                            {INF, INF, 73, 29, INF, 83, 0, 96, 43, 20, 83, INF, 46, 91, INF},
                            {48, INF, 4, 32, INF, INF, INF, 0, INF, 97, INF, INF, 96, INF, 63},
                            {61, INF, INF, 52, INF, 81, 97, 39, 0, INF, 28, 52, INF, 84, INF},
                            {32, 80, 96, 26, 16, INF, INF, 20, 96, 0, INF, 7, INF, 93, INF},
                            {INF, 76, INF, 95, INF, 71, 16, INF, 57, INF, 0, 16, 41, 6, INF},
                            {INF, 28, INF, INF, 8, INF, INF, INF, 9, INF, INF, 0, 16, 79, 42},
                            {INF, 3, INF, 61, INF, INF, INF, 91, INF, INF, 71, INF, 0, 35, INF},
                            {31, 37, 62, 35, INF, 31, INF, 49, 45, INF, INF, 6, INF, 0, 93},
                            {INF, 43, INF, 98, 27, INF, INF, 64, 99, INF, INF, 19, 31, INF, 0}};
            int N3 = 15;

            Stopwatch timer3 = new Stopwatch();

            timer3.Start();
                List<int[]> U3 = new List<int[]>();  //Use list of arrays to hold disjoin sets
                InitializeU(U3, N2);

                List<Edge> Edges3 = new List<Edge>();    //Use list of objects to hold edge data (src, dest, weight)
                EdgeInitialize(Edges3, W3, N3);  //Initialize the edges with the graph and then sort them in non-decreasing order
                List<Edge> SortedEdges3 = Edges3.OrderBy(o => o.weight).ToList(); //Sort edges by weight in non-decreasing order

                List<Edge> ChosenEdges3 = new List<Edge>();  //Store the edges that kruskal will pick for the MST
                Kruskal(U3, SortedEdges3, ChosenEdges3, N3);
            timer3.Stop();

            Console.WriteLine("Graph 3");
            Console.WriteLine(" ");

            foreach (Edge edge in ChosenEdges3)
            {
                Console.WriteLine("Source: {0}, Dest: {1}, Weight: {2}", edge.source, edge.dest, edge.weight);
            }
            Console.WriteLine("Time(ms) = {0:F4}", timer3.ElapsedMilliseconds);
            Console.WriteLine(" ");

            #endregion
        }

        #region Initialize
        //Initialize disjoint sets with each individual vertex 0 -> N - 1
        static void InitializeU(List<int[]> U, int n)
        {
            for(int i = 0; i < n; i++)
            {
                int[] temp = { i };
                U.Add(temp);
            }
        }
        #endregion

        #region Find
        //Returns index of the set that contains k
        static int Find(List<int[]> U, int k)
        {
            foreach(int[] i in U)
            {
                if(U.IndexOf(i) == k)
                {
                    return U[U.IndexOf(i)][0];
                }
            }
            return 0;
        }
        #endregion

        #region Merge
        //Merge p and q into subset by changing the value of the disjoint subset
        static void Merge(List<int[]> U, int p, int q)
        {
            if(p < q)
            {
                foreach(int[] i in U)
                {
                    if (U[U.IndexOf(i)][0] == p)
                    {
                        U[U.IndexOf(i)][0] = q;
                    }
                }
            }
            else
            {
                foreach (int[] i in U)
                {
                    if (U[U.IndexOf(i)][0] == q)
                    {
                        U[U.IndexOf(i)][0] = p;
                    }
                }
            }
        }
        #endregion

        #region Equal
        static bool Equal(int p, int q)
        {
            if (p == q)
                return true;

            return false;
        }
        #endregion

        #region Edge Initialize
        // Store all the edges from W
        public static void EdgeInitialize(List<Edge> Edges, int[,] W, int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (W[i, j] != 0)
                    {
                        Edges.Add(new Edge() { source = i, dest = j, weight = W[i, j] });
                    }
                }
            }
        }
        #endregion

        #region Kruskal
        public static void Kruskal(List<int[]> U, List<Edge> SortedEdges, List<Edge> ChosenEdges, int n)
        {
            while(ChosenEdges.Count < n - 1)
            {
                for(int i = 0; i < SortedEdges.Count; i++)  //Keep track of which edge to look at
                {
                    int source = SortedEdges[i].source;
                    int dest = SortedEdges[i].dest;

                    int p = Find(U, source);
                    int q = Find(U, dest);

                    if(!Equal(p, q))
                    {
                        Merge(U, p, q);
                        ChosenEdges.Add(SortedEdges[i]);
                    }
                }
            }
        }
        #endregion
    }

    #region Edge Object
    public class Edge
    {
        public int source
        { get; set; }
        public int dest
        { get; set; }
        public int weight
        { get; set; }
    }
    #endregion
}
