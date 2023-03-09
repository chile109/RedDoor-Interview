using System;
using System.Text;
using System.Diagnostics;

namespace RedDoor
{
    public class NQueensSolver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of queens: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you want to print solutions: true/false");
            bool draw = bool.Parse(Console.ReadLine());


            int[,] board = new int[n, n];

            var watch = Stopwatch.StartNew();
            int numSolutions = SolveNQueens(board, 0, n, draw);
            watch.Stop();

            Console.WriteLine($"Number of solutions: {numSolutions}, runtime:{watch.Elapsed} ");
        }

        public static int SolveNQueens(int[,] board, int col, int n, bool canPrint = false)
        {
            int numSolutions = 0;

            // Return the total number of solutions found
            return numSolutions;
        }

        public static bool IsSafe(int[,] board, int row, int col, int n)
        {
            // Check row on the left
            for (int i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                {
                    return false;
                }
            }

            // Check upper diagonal on left side
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            // Check lower diagonal on left side
            for (int i = row, j = col; i < n && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static string GetBoardGraph(int[,] board)
        {
            int n = board.GetLength(0);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sb.Append(board[i, j] + " ");
                }

                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

