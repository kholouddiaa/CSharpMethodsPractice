using System;

namespace basic_1.Methods
{
    internal static class ValidationMethods
    {
        public static int ReadValidInt(string message)
        {
            int number;
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out number))
                    return number;

                Console.WriteLine("Invalid number, try again.\n");
            }
        }
    }
}
