using System;

namespace Min_Cost_to_Connect_All_Points // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many points you want to enter: ");
            //string pointCnt = Console.ReadLine();
            //int[][] points = new int[][] {
            //    new int[] {0, 0},
            //    new int[] {2, 2},
            //    new int[] {3, 10},
            //    new int[] {5, 2},
            //    new int[] {7, 0}
            //};
        }


        public static int MinCostConnectPoints(int[][] points)
        {
            // Find the leftmost point.
            
            int minCost = 0;

            for (int i = 0; i < points.Length; i++)
            {
                if (i + 1 < points.Length) // Prevent from going out of bounds.
                {
                    if (points[i][0] > points[i + 1][0]) // Check if X1 is greater than x2 to determine if I have to add or subtract.
                    {
                        // Need to subtract
                    }
                    else
                    {
                        // Need to add.
                    }
                }
                else
                    break;
                
            }
            
            return minCost;
        }
    }
}