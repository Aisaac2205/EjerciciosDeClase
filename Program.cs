using System;

class Program
{
    static void Main(string[] args)
    {
        int boardSize = 10;
        int[,] board = new int[boardSize, boardSize];
        int shipRow = 0;
        int shipCol = 0;

        // Place the ship randomly on the board
        Random rand = new Random();
        shipRow = rand.Next(0, boardSize);
        shipCol = rand.Next(0, boardSize);
        board[shipRow, shipCol] = 1;

        // Main game loop
        while (true)
        {
            // Print the board
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    if (board[row, col] == 2)
                    {
                        Console.Write("X ");
                    }
                    else if (board[row, col] == 3)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }

            // Ask the user for a guess
            Console.Write("Enter a row: ");
            int guessRow = int.Parse(Console.ReadLine());
            Console.Write("Enter a column: ");
            int guessCol = int.Parse(Console.ReadLine());

            // Check if the guess is a hit or a miss
            if (guessRow == shipRow && guessCol == shipCol)
            {
                Console.WriteLine("Hit!");
                board[guessRow, guessCol] = 2;
                break;
            }
            else
            {
                Console.WriteLine("Miss!");
                board[guessRow, guessCol] = 3;
            }
        }

        Console.WriteLine("Game over!");
        Console.ReadLine();
    }
}
