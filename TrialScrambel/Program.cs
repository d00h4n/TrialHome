using System;

interface ICoordinate
{
    int X { get; }
    int Y { get; }
}

class Coordinate : ICoordinate
{
    public int X { get; }
    public int Y { get; }

    public Coordinate(int x, int y)
    {
        X = x;
        Y = y;
    }
}

class Program
{
    static void Main()
    {
        ICoordinate[,] board = GenerateScrambleBoard(10, 10);
        DisplayBoard(board);
    }

    static ICoordinate[,] GenerateScrambleBoard(int rows, int columns)
    {
        ICoordinate[,] board = new ICoordinate[rows, columns];
        Random random = new Random();

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                board[row, column] = new Coordinate(column, row);
            }
        }

        return board;
    }

    static void DisplayBoard(ICoordinate[,] board)
    {
        int rows = board.GetLength(0);
        int columns = board.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write($"[{board[row, column].X},{board[row, column].Y}] ");
            }
            Console.WriteLine();
        }
    }
}
