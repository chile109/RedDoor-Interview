using System;
using System.Text;
using System.Diagnostics;

namespace RedDoor
{
    public class NQueensSolver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome! This is NQueensSolver that try solving the problem of placing N chess queens on an N×N chessboard so that no two queens threaten each other. I will answer the solution count~");

            var draw = false;
            Console.WriteLine("Do you want to print solutions in graph? (key in y for Yes or just answer solutions count");
            if (Console.ReadLine() == "y")
            {
                draw = true;
            }

            Console.WriteLine("Enter the number of N: ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("===========================");

            int[,] board = new int[n, n];

            var watch = Stopwatch.StartNew();
            int numSolutions = SolveNQueens(board, 0, n, draw);
            watch.Stop();

            Console.WriteLine($"Number of solutions: {numSolutions}, runtime:{watch.Elapsed} ");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static int graphIndex = 1;
        public static int SolveNQueens(int[,] board, int col, int n, bool canPrint = false)
        {
            int numSolutions = 0;

            if (col >= n)
            {
                // Base case: all queens have been placed, solution found
                if (canPrint)
                {
                    var graph = GetBoardGraph(board);
                    Console.WriteLine($"===Graph {graphIndex++}===");
                    Console.WriteLine(graph);
                }
                return 1;
            }

            for (int row = 0; row < n; row++)
            {
                if (IsSafe(board, row, col, n))
                {
                    // Place a queen in the current cell
                    board[row, col] = 1;

                    // Recursively search for solutions with this queen placement
                    numSolutions += SolveNQueens(board, col + 1, n, canPrint);

                    // Remove the queen from the current cell and backtrack
                    board[row, col] = 0;
                }
            }

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

