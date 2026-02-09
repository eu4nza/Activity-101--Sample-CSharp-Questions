namespace Question1
{        
    public static class Program1
    {
        public static void Program1Main()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Activity Question One");
            Console.WriteLine("Provide 4 numbers to compute its average.");
            Console.WriteLine("---------------------------------------\n");
            
            double number, sum = 0, average;

            string[] ordinals = ["first", "second", "third", "fourth"];
            double[] numbers = new double[4];

            for (int index = 0; index < 4; index++)
            {
                Input:
                Console.Write("Enter " + ordinals[0 + index] + " number: ");

                var numberInput = Console.ReadLine();

                if (!double.TryParse(numberInput, out _))
                {
                    Console.Clear();
                    Console.WriteLine("\x1b[3J");
                    Console.Write("\nNot a number. Press any key to continue");
                    Console.ReadKey();
                    goto Input;
                } else
                {
                    double parsedNumberInput = Convert.ToDouble(numberInput);
                    numbers[index] = parsedNumberInput;
                    number = parsedNumberInput;
                    sum += number;
                }
            }

            average = sum / 4;

            Console.WriteLine("\nThe total average of " + string.Join(", ", numbers) + " is: {0}", average);
        }
    }
}