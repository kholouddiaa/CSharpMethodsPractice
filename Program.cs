using System;
using basic_1.Methods;

namespace basic_1
{
    internal class Program
    {

        static void SayHello()
        {

            Console.WriteLine("hello ");

        }
        static void PrintName(string name)
        {

            Console.WriteLine($"Hello {name}");
        }

        static void Main(string[] args)
        {
            #region  Add Two Numbers
            //int x = ValidationMethods.ReadValidInt("Enter first number");
            //int y = ValidationMethods.ReadValidInt("Enter second number");
            //int result = x + y;
            //Console.WriteLine($"add {x} + {y} = {result}");
            #endregion
            //Console.WriteLine("Hello, World!");
            #region Simple Calculator 
            //int x  = ValidationMethods.ReadValidInt("Enter first number");
            //int y = ValidationMethods.ReadValidInt("Enter second number"); 
            //Console.WriteLine("enter operator (+ - * /)");
            //string n = Console.ReadLine();

            //switch (n)
            //{
            //    case "+":
            //        Console.WriteLine($"add {x} + {y} = {x + y}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"subb {x} - {y} = {x - y}");
            //        break;
            //    case "*":
            //        Console.WriteLine($" mull {x} * {y} = {x * y}");
            //        break;
            //    case "/":

            //        if (y != 0)
            //            Console.WriteLine($" div  {x} / {y} = {x / y}");
            //        else
            //            Console.WriteLine("Cannot divide by zero");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //}
            #endregion
            #region   Calcuolator using loop 
            //int x = ValidationMethods.ReadValidInt("Enter first number");
            //int y = ValidationMethods.ReadValidInt("Enter second number");

            //Console.WriteLine("Enter operator (+ - * /): ");
            //string op = Console.ReadLine()!.Trim();


            //switch (op)
            //{
            //    case "+":
            //        Console.WriteLine($"add {x} + {y} = {x + y}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"subb {x} - {y} = {x - y}");
            //        break;
            //    case "*":
            //        Console.WriteLine($" mull {x} * {y} = {x * y}");
            //        break;
            //    case "/":

            //        if (y != 0)
            //            Console.WriteLine($" div  {x} / {y} = {x / y}");
            //        else
            //            Console.WriteLine("Cannot divide by zero");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //        Console.WriteLine("Goodbye!");
            //}

            #endregion
            #region methods 



            // Practice methods (not used in main flow)
            //SayHello();
            //PrintName("khokha");
            #region using functin Add
            int num1 = ValidationMethods.ReadValidInt("Enter first number\n");
            int num2 = ValidationMethods.ReadValidInt("Enter second number\n");


            int result = MathMethods.Add(num1, num2);
            Console.WriteLine($"add {num1} + {num2} = {result}");
            #endregion
            #region  Using IsEven Method
            int num = ValidationMethods.ReadValidInt("Enter number to check\n");
            if (MathMethods.IsEven(num))
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} : is an odd number ");
              
            }
            #endregion
            #endregion
        }
    }
}