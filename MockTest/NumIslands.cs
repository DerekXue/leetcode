using System;

namespace ConsoleApp74
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int NumIslands(char[][] grid)
        {
            if (grid == null) return 0;
            int answer = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    answer += dps(i,j,grid);
                }
            }
            return answer;
        }
        public static int dps(int i,int j, char[][] grid)
        {
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length) return 0;
            else if (grid[i][j] == '0') return 0;
            else grid[i][j] = '0'; //sink the iland
            dps(i-1, j, grid);
            dps(i+1, j, grid);
            dps(i, j-1, grid);
            dps(i, j+1, grid);
            return 1;
        }
    }
}
