namespace Set1Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 23;
            int b = 7;
            Console.WriteLine("Initially values of a and b are " + a + " and " + b);
            Console.WriteLine();
            int c = problemAddition(a++, --b);
            Console.WriteLine("Value of a+b = " + c);
            Console.WriteLine();
            c = problemMultiply(a++, --b);
            Console.WriteLine("Value of a*b = " + c);
            Console.WriteLine();
            c = problemSubstraction(a++, --b);
            Console.WriteLine("Value of a-b = " + c);
            Console.WriteLine();
            c = problemDivision(a++, --b);
            Console.WriteLine("Value of a/b = " + c);
        }

        public static int problemAddition(int a, int b)
        {
            Console.WriteLine("After increment and decrement values of a and b are  " + a + " and " + b);
            return a + b;
        }

        public static int problemMultiply(int a, int b)
        {
            Console.WriteLine("After increment and decrement values of a and b are  " + a + " and " + b);
            return a * b;
        }

        public static int problemSubstraction(int a, int b)
        {
            Console.WriteLine("After increment and decrement values of a and b are  " + a + " and " + b);
            return a - b;
        }
        public static int problemDivision(int a, int b)
        {
            Console.WriteLine("After increment and decrement values of a and b are  " + a + " and " + b);
            return a / b;
        }
    }
}