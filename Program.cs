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
            Console.WriteLine("2. Diamond (Coming Soon)");
            Console.WriteLine("3. Checkerboard (Coming Soon)");
            Console.Write("Choose a pattern: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GeneratePyramid();
                    break;
                // Additional patterns can be added here
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


        static void MatrixOperations()
        {
            Console.Clear();
            Console.WriteLine("Matrix Operations (To be implemented)");
            // Placeholder for matrix operations logic
            Console.ReadLine();
        }
    }
}
