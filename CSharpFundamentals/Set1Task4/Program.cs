namespace Set1Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 23;
            int b = 7;
            var program = new Program();
            int c1 = program.problemAddition(a, b);
            Console.WriteLine("Value of (a++)+(--b) = " + c1);
            int c2 = program.problemMultiply(a, b);
            Console.WriteLine("Value of (++a)*(++b) = " + c2);
            int c3 = program.problemSubstraction(a, b);
            Console.WriteLine("Value of (a++)-(--b) = " + c3);
            int c4 = program.problemDivision(a, b);
            Console.WriteLine("Value of (++a)/(++b) = " + c4);
        }

        public int problemAddition(int a, int b)
        {
            int a1 = a++;
            int b1 = --b;
            return a1 + b1;
        }

        public int problemMultiply(int a, int b)
        {
            int a1 = ++a;
            int b1 = ++b;
            return a1 * b1;
        }

        public int problemSubstraction(int a, int b)
        {
            int a1 = a++;
            int b1 = --b;
            return a1 - b1;
        }
        public int problemDivision(int a, int b)
        {
            int a1 = ++a;
            int b1 = ++b;
            return a1 / b1;
        }
    }
}