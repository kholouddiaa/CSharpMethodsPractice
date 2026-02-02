namespace session2_iti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Session 2 - Basic Control Structures Practice

            #region 1 - Check divisibility by 3 and 4
            /*
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            */
            #endregion

            #region 2 - Positive or Negative
            /*
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Positive");
            */
            #endregion

            #region 3 - Find Max and Min in Array
            /*
            Console.Write("Enter the length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
            */
            #endregion

            #region 4 - Even or Odd
            /*
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            */
            #endregion

            #region 5 - Vowel or Consonant
            /*
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadLine()[0]);

            if ("aeiou".Contains(ch))
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
            */
            #endregion

            #region 6 - Print numbers from 1 to N
            /*
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
                Console.Write(i + " ");
            */
            #endregion

            #region 7 - Multiplication Table
            /*
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
                Console.Write(num * i + " ");
            */
            #endregion

            #region 8 - Even numbers from 1 to N
            /*
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            */
            #endregion

            #region 9 - Power Calculation
            /*
            Console.Write("Enter base number: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.Write("Enter exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            int result = 1;
            for (int i = 1; i <= exponent; i++)
                result *= baseNum;

            Console.WriteLine("Result = " + result);
            */
            #endregion

            #region 10 - Total, Average, Percentage
            /*
            Console.WriteLine("Enter marks of five subjects:");
            int total = 0;

            for (int i = 1; i <= 5; i++)
                total += int.Parse(Console.ReadLine());

            double average = total / 5.0;

            Console.WriteLine("Total = " + total);
            Console.WriteLine("Average = " + average);
            Console.WriteLine("Percentage = " + average);
            */
            #endregion

            #region 11 - Simple Calculator
            /*
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine(num1 + num2); break;
                case '-': Console.WriteLine(num1 - num2); break;
                case '*': Console.WriteLine(num1 * num2); break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine(num1 / num2);
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            */
            #endregion

            #region 12 - Sum of Even Numbers in Array
            /*
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] % 2 == 0)
                    sum += arr[i];
            }

            Console.WriteLine("Sum of even numbers = " + sum);
            */
            #endregion
        }
    }
}
