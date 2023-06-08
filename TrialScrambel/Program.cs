using System;
using System.Collections.Generic;




class Program
{
    static void Main()
    {
        int rows = 15;
        int columns = 15;

        DisplayBoard(rows, columns);
    }

    static void DisplayBoard(int rows, int columns)
    {
        char[,] board = new char[rows, columns];
        int score = 0;

        Console.WriteLine("Scramble Board:");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write("[ ] ");
                board[row, column] = ' ';
            }
            Console.WriteLine();
        }

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

                Console.WriteLine("Updated Scramble Board:");
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        Console.Write($"[{board[row, column]}] ");
                    }
                    Console.WriteLine();
                }

                int points = GetLetterPoints(letter);
                Console.WriteLine($"Letter '{letter}' is worth {points} points.");

                score += points;

                Console.WriteLine($"Score: {score} points");
            }
        }

        Console.WriteLine("Final Scramble Board:");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write($"[{board[row, column]}] ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Final Score: {score} points");
    }

    static int GetLetterPoints(char letter)
    {
        LetterPoints letterPoints = (LetterPoints)Enum.Parse(typeof(LetterPoints), letter.ToString());
        return (int)letterPoints;
    }
}
