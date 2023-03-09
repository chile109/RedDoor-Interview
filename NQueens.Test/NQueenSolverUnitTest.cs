using NUnit.Framework;
using System.Collections.Generic;

namespace NQueens.Test;

public class Tests
{
    [Test]
    public void SolveNQueens_Input8_GetAnswer92()
    {
        // Arrange
        var inputN = 8;
        int[,] board = new int[inputN, inputN];

        // Act
        int numSolutions = RedDoor.NQueensSolver.SolveNQueens(board, 0, inputN, false);

        // Assert
        Assert.AreEqual(92, numSolutions);
    }

    [Test]
    public void IsSafe_NoQueen_ReturnTrue()
    {
        // Arrange
        int[,] stubBoard = {
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

        // Act
        var result = RedDoor.NQueensSolver.IsSafe(stubBoard, 1, 1, 4);

        // Assert
        Assert.AreEqual(true, result);
    }

    [Test]
    public void IsSafe_HasQueenOnLeft_ReturnFalse()
    {
        // Arrange
        int[,] stubBoard = {
                { 0, 0, 0, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

        // Act
        var result = RedDoor.NQueensSolver.IsSafe(stubBoard, 1, 1, 4);

        // Assert
        Assert.AreEqual(false, result);
    }

    [Test]
    public void IsSafe_HasQueenOnLeftTop_ReturnFalse()
    {
        // Arrange
        int[,] stubBoard = {
                { 0, 0, 0, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

        // Act
        var result = RedDoor.NQueensSolver.IsSafe(stubBoard, 1, 0, 4);

        // Assert
        Assert.AreEqual(false, result);
    }

    [Test]
    public void IsSafe_HasQueenOnLeftDown_ReturnFalse()
    {
        // Arrange
        int[,] stubBoard = {
                { 0, 0, 0, 0 },
                { 1, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };

        // Act
        var result = RedDoor.NQueensSolver.IsSafe(stubBoard, 1, 3, 4);

        // Assert
        Assert.AreEqual(false, result);
    }

    [Test]
    public void GetBoardGraph_Input4_GetBoard()
    {
        // Arrange
        int[,] stubBoard = {
                { 0, 1, 0, 0 },
                { 0, 0, 0, 1 },
                { 1, 0, 0, 0 },
                { 0, 0, 1, 0 }
            };

        // Act
        var actualprint = RedDoor.NQueensSolver.GetBoardGraph(stubBoard);

        // Assert
        Assert.AreEqual(actualprint, "0 1 0 0 \r\n0 0 0 1 \r\n1 0 0 0 \r\n0 0 1 0 \r\n");
    }
}