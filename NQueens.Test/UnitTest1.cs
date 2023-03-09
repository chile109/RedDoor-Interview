using NUnit.Framework;

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
}