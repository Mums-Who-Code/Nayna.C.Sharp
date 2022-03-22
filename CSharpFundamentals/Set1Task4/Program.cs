namespace Set1Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 23;
            int b = 7;
            Program program = new Program();
            int c1 = program.problem1(a, b);
            Console.WriteLine("Value of a+++--b = " + c1);
            int c2 = program.problem2(a, b);
            Console.WriteLine("Value of ++a*(++b) = " + c2);
        }

        public int problem1(int a, int b)
        {
            int a1 = a++;
            int b1 = --b;
            return a1 + b1;
        }

        public int problem2(int a, int b)
        {
            int a1 = ++a;
            int b1 = ++b;
            return a1 * b1;
        }
    }
}