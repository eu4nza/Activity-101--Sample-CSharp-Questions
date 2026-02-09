using System;
namespace MenuProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Main Menu");
                Console.WriteLine("1 - Activity Question One");
                Console.WriteLine("2 - Activity Question Two");
                Console.WriteLine("3 - Activity Question Three");
                Console.WriteLine("---------------------------------------\n");

                Console.Write("Enter an option: ");
                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.Write("\nNot a number. Press any key to continue");
                    Console.ReadKey();
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Question1.Program1.Program1Main();
                        break;
                    case 2:
                        Question2.Program2.Program2Main();
                        break;
                    case 3:
                        Question3.Program3.Program3Main();
                        break;
                    default:
                        Console.Write("\nProvided option not available, only choose from 1-3. Press any key to continue");
                        Console.ReadKey();
                        continue;
                }
            }
        }
    }
}