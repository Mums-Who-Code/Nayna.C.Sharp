﻿namespace Set1Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 23;
            int b = 7;
            int c1 = problemAddition(a, b);
            Console.WriteLine("Value of (a++)+(--b) = " + c1);
            Console.WriteLine();
            int c2 = problemMultiply(a, b);
            Console.WriteLine("Value of (++a)*(++b) = " + c2);
            Console.WriteLine();
            int c3 = problemSubstraction(a, b);
            Console.WriteLine("Value of (a++)-(--b) = " + c3);
            Console.WriteLine();
            int c4 = problemDivision(a, b);
            Console.WriteLine("Value of (++a)/(++b) = " + c4);
        }

        public static int problemAddition(int a, int b)
        {
            int a1 = a++;
            int b1 = --b;
            Console.WriteLine("Values of a++ and --b are " + a1 +" and " + b1);
            return a1 + b1;
        }

        public static int problemMultiply(int a, int b)
        {
            int a1 = ++a;
            int b1 = ++b;
            Console.WriteLine("Values of ++a and ++b are " + a1 + " and " + b1);
            return a1 * b1;
        }

        public static int problemSubstraction(int a, int b)
        {
            int a1 = a++;
            int b1 = b++;
            Console.WriteLine("Values of a++ and b++ are " + a1 + " and " + b1);
            return a1 - b1;
        }
        public static int problemDivision(int a, int b)
        {
            int a1 = ++a;
            int b1 = b--;
            Console.WriteLine("Values of ++a and b-- are " + a1 + " and " + b1);
            return a1 / b1;
        }
    }
}