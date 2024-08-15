using System;

namespace PatternAndMatrixTool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Pattern and Matrix Manipulation Tool");
                Console.WriteLine("1. Generate Patterns");
                Console.WriteLine("2. Matrix Operations");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GeneratePatterns();
                        break;
                    case "2":
                        MatrixOperations();
                        break;
                    case "3":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void GeneratePatterns()
        {
            Console.Clear();
            Console.WriteLine("Choose a pattern to generate:");
            Console.WriteLine("1. Pyramid");
            Console.WriteLine("2. Diamond");
            Console.WriteLine("3. Checkerboard");
            Console.Write("Choose a pattern: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GeneratePyramid();
                    break;
                case "2":
                    GenerateDiamond();
                    break;
                case "3":
                    GenerateCheckerboard();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.ReadLine(); // Pause before returning to the main menu
        }

        static void GeneratePyramid()
        {
            Console.Write("Enter the number of rows for the pyramid: ");
            if (int.TryParse(Console.ReadLine(), out int rows))
            {
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= (2 * i) - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        static void GenerateDiamond()
        {
            Console.Write("Enter the number of rows for the diamond (half): ");
            if (int.TryParse(Console.ReadLine(), out int rows))
            {
                // Upper part of the diamond
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= (2 * i) - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                // Lower part of the diamond
                for (int i = rows - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= rows - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= (2 * i) - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        static void GenerateCheckerboard()
        {
            Console.Write("Enter the size of the checkerboard (NxN): ");
            if (int.TryParse(Console.ReadLine(), out int size))
            {
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 1; j <= size; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("O");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");

            }

        }
        static void MatrixOperations()
        {
            Console.Clear();
            Console.WriteLine("Matrix Operations:");
            Console.WriteLine("1. Matrix Addition");
            Console.Write("Choose an operation: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    MatrixAddition();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        }

        static void MatrixAddition()
        {
            Console.Clear();
            Console.WriteLine("Matrix Addition:");

            // Get the dimensions of the matrices
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            // Initialize matrices
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] resultMatrix = new int[rows, cols];

            // Input values for the first matrix
            Console.WriteLine("Enter values for the first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Matrix1[{i},{j}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Input values for the second matrix
            Console.WriteLine("Enter values for the second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Matrix2[{i},{j}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Perform addition
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Display the result
            Console.WriteLine("Resultant Matrix after Addition:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Pause the console so the user can see the output
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();

        }


    }
}

