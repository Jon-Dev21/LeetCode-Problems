using System;

namespace Min_Cost_to_Connect_All_Points // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many points you want to enter: ");
            string pointCnt = Console.ReadLine();
            int[][] points = new int[][] {
                new int[] {0, 0},
                new int[] {2, 2},
                new int[] {3, 10},
                new int[] {5, 2},
                new int[] {7, 0}
            };
        }


        public static int MinCostConnectPoints(int[][] points)
        {
            int minCost = 0;
            return minCost;
        }
    }
}