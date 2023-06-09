using System;

enum LetterPoints
{
    A = 1,
    B = 3,
    C = 3,
    D = 2,
    E = 1,
    F = 4,
    G = 2,
    H = 4,
    I = 1,
    J = 8,
    K = 5,
    L = 1,
    M = 3,
    N = 1,
    O = 1,
    P = 3,
    Q = 10,
    R = 1,
    S = 1,
    T = 1,
    U = 1,
    V = 4,
    W = 4,
    X = 8,
    Y = 4,
    Z = 10
}

class Program
{
    static void Main()
    {
        int rows = 15;
        int columns = 15;

        char[,] board = new char[rows, columns];
        int score = 0;

        Console.WriteLine("Scramble Board:");
        Console.WriteLine();
        Console.Write("   ");
        for (int column = 0; column < columns; column++)
        {
            Console.Write($" {column.ToString().PadLeft(2)} ");
        }
        Console.WriteLine();

        for (int row = 0; row < rows; row++)
        {
            Console.Write($"{row.ToString().PadLeft(2)} ");
            for (int column = 0; column < columns; column++)
            {
                Console.Write("[ ] ");
                board[row, column] = ' ';
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Enter coordinates and letters to fill in the scramble board:");
        while (true)
        {
            Console.Write("Enter X coordinate (-1 to exit): ");
            string inputX = Console.ReadLine();
            int coordinateX;

            if (!int.TryParse(inputX, out coordinateX) || coordinateX == -1)
                break;

            Console.Write("Enter Y coordinate (-1 to exit): ");
            string inputY = Console.ReadLine();
            int coordinateY;

            if (!int.TryParse(inputY, out coordinateY) || coordinateY == -1)
                break;

            Console.Write("Enter letter: ");
            string inputLetter = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputLetter))
            {
                char letter = inputLetter[0];

                if (coordinateX >= 0 && coordinateX < columns && coordinateY >= 0 && coordinateY < rows)
                {
                    board[coordinateY, coordinateX] = letter;
                }
                else
                {
                    Console.WriteLine("Invalid coordinate!");
                    continue;
                }

                Console.WriteLine();

                Console.WriteLine("Updated Scramble Board:");
                Console.WriteLine();
                Console.Write("   ");
                for (int column = 0; column < columns; column++)
                {
                    Console.Write($" {column.ToString().PadLeft(2)} ");
                }
                Console.WriteLine();

                for (int row = 0; row < rows; row++)
                {
                    Console.Write($"{row.ToString().PadLeft(2)} ");
                    for (int column = 0; column < columns; column++)
                    {
                        Console.Write($"[{board[row, column]}] ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                int points = GetLetterPoints(letter);
                Console.WriteLine($"Letter '{letter}' is worth {points} points.");

                score += points;

                Console.WriteLine($"Score: {score} points");
            }
        }

        Console.WriteLine();

        Console.WriteLine("Final Scramble Board:");
        Console.WriteLine();
        Console.Write("   ");
        for (int column = 0; column < columns; column++)
        {
            Console.Write($" {column.ToString().PadLeft(2)} ");
        }
        Console.WriteLine();

        for (int row = 0; row < rows; row++)
        {
            Console.Write($"{row.ToString().PadLeft(2)} ");
            for (int column = 0; column < columns; column++)
            {
                Console.Write($"[{board[row, column]}] ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine($"Final Score: {score} points");
    }

    static int GetLetterPoints(char letter)
    {
        if (Enum.TryParse(letter.ToString().ToUpper(), out LetterPoints letterPoints))
        {
            return (int)letterPoints;
        }
        else
        {
            Console.WriteLine("Invalid letter! Assigning 0 points.");
            return 0;
        }
    }
}
