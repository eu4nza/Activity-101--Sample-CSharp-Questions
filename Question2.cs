namespace Question2
{
    public static class Program2
    {
        public static void Program2Main()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Activity Question Two");
            Console.WriteLine("Find persons with age lower than the input age.");
            Console.WriteLine("---------------------------------------\n");

            var persons = new List<(string Name, int Age)>
            {
                ("Kurt", 15),
                ("Carl", 23),
                ("JK", 45),
                ("James", 60),
                ("Kelvin", 39),
                ("Haze", 18),
                ("Gaze", 10),
                ("Soap", 20),
                ("Price", 23),
                ("McQueen", 80),
                ("Bascreveil", 50)
            };

            Console.WriteLine("Person List:");
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
            }

            Input:
            Console.Write("\nEnter an Age: ");
            var ageInput = Console.ReadLine();

            if (!int.TryParse(ageInput, out int inputAge))
            {
                Console.Clear();
                Console.WriteLine("\x1b[3J");
                Console.Write("\nNot a number. Press any key to continue");
                Console.ReadKey();
                goto Input;
            }

            var lowerAgePersons = persons.Where(p => p.Age < inputAge).ToList();

            Console.WriteLine($"\nPerson with the lower age than {inputAge}");
            if (lowerAgePersons.Count == 0)
            {
                Console.WriteLine("No persons found.");
            }
            else
            {
                foreach (var person in lowerAgePersons)
                {
                    Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
                }
            }
        }
    }
}
