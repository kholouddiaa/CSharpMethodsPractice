namespace sesion1
{
    internal class Program
    {
        class MyClass
        {
            public int Number;
        }

        static void Main(string[] args)
        {
            #region 1:4
            // 1 - Console Input / Output
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            Console.WriteLine("You entered: " + input);

            // 2 - Type Conversion (Exception Example)
            string str = "123abc";
            // int number = Convert.ToInt32(str); // Will throw exception
            // Console.WriteLine(number);

            // 3 - Float Addition
            float a = 5.3f;
            float b = 3.3f;
            float result = a + b;
            Console.WriteLine("Result: " + result);

            // 4 - Value Type Example
            int x = 10;
            int y = x;
            y = 20;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            #endregion

            // 5 - Reference Type Example
            MyClass obj1 = new MyClass();
            obj1.Number = 10;

            MyClass obj2 = obj1;
            obj2.Number = 20;

            Console.WriteLine("obj1.Number = " + obj1.Number);
            Console.WriteLine("obj2.Number = " + obj2.Number);

            // 6 - String Concatenation
            string firstName = "Kholoud";
            string lastName = "Diaa";
            string fullText = firstName + " " + lastName;
            Console.WriteLine(fullText);
        }
    }
}
