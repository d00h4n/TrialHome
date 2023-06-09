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

        for (int row = 1; row <= rows; row++)
        {
            for (int column = 1; column <= columns; column++)
            {
                Console.Write("[ ] ");
                board[row - 1, column - 1] = ' ';
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Enter coordinates and letters to fill in the scramble board:");
        while (true)
        {
            Console.Write("Enter X coordinate (1-15, 0 to exit): ");
            string inputX = Console.ReadLine();
            int coordinateX;

            if (!int.TryParse(inputX, out coordinateX) || coordinateX == 0)
                break;

            Console.Write("Enter Y coordinate (1-15, 0 to exit): ");
            string inputY = Console.ReadLine();
            int coordinateY;

            if (!int.TryParse(inputY, out coordinateY) || coordinateY == 0)
                break;

            Console.Write("Enter letter: ");
            string inputLetter = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputLetter))
            {
                char letter = inputLetter[0];

                if (coordinateX >= 1 && coordinateX <= columns && coordinateY >= 1 && coordinateY <= rows)
                {
                    board[coordinateY - 1, coordinateX - 1] = letter;
                }
                else
                {
                    Console.WriteLine("Invalid coordinate!");
                    continue;
                }

                Console.WriteLine();

                Console.WriteLine("Updated Scramble Board:");
                Console.WriteLine();

                for (int row = 1; row <= rows; row++)
                {
                    for (int column = 1; column <= columns; column++)
                    {
                        Console.Write($"[{board[row - 1, column - 1]}] ");
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

        for (int row = 1; row <= rows; row++)
        {
            for (int column = 1; column <= columns; column++)
            {
                Console.Write($"[{board[row - 1, column - 1]}] ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine($"Final Score: {score} points");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
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
