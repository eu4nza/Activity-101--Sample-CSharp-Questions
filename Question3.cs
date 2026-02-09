namespace Question3
{
    public static class Program3
    {
        public static void Program3Main()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Activity Question Three");
            Console.WriteLine("Find the same numbers on both lists.");
            Console.WriteLine("---------------------------------------\n");

            int[] listOne = [1, 20, 3, 6, 8, 9, 10, 7, 12, 21, 18];
            int[] listTwo = [10, 2, 30, 15, 8, 21, 13, 18, 28, 25, 16];

            Console.WriteLine("List One: [" + string.Join(", ", listOne) + "]");
            Console.WriteLine("List Two: [" + string.Join(", ", listTwo) + "]");

            var commonNumbers = listOne.Where(n => listTwo.Contains(n)).ToList();

            Console.WriteLine("\nAll same numbers on both List: " + string.Join(", ", commonNumbers));
        }
    }
}
