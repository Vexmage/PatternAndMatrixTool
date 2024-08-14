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
            Console.WriteLine("Pattern Generation (To be implemented)");
            // Placeholder for pattern generation logic
            Console.ReadLine();
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
