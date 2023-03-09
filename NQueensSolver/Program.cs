﻿using System;
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
            return true;
        }
    }
}

