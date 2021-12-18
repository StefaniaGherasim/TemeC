using System;

namespace TemeC
{
    class Program
    {
        public static void Main(String[] args)
        {
            calculator(args);
            sumFirst100();
            isPolindrom();
            printPrime(20);
        }

        public static void calculator(String[] args)
        {
            if (args.Length == 3)
            {
                float a = float.Parse(args[0]);
                float b = float.Parse(args[2]);
                string op = args[1];
                float result = 0;
                Boolean invalidOp = false;
                if (op == "+")
                {
                    result = a + b;
                }
                else if (op == "-")
                {
                    result = a - b;
                }
                else if (op == "*")
                {
                    result = a * b;
                }
                else if (op == "/")
                {
                    result = a / b;
                }
                else
                {
                    invalidOp = true;
                }
                if (invalidOp == true)
                    Console.WriteLine("Operator invalid");
                else
                    Console.WriteLine("Result is: " + result);
            }
            else
            {
                Console.WriteLine("3 args are needed!");
            }
        }

        public static void sumFirst100()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Suma primelor 100 numere este: " + sum);
        }

        public static void isPolindrom()
        {
            int num, temp, reversenum = 0, originalnum;
            Console.Write("Introduceti un numar: ");
            num = Convert.ToInt32(Console.ReadLine());
            originalnum = num;
            while (num > 0)
            {
                temp = num % 10;
                num = num / 10;
                reversenum = reversenum * 10 + temp;
            }
            if (originalnum == reversenum)
            {
                Console.WriteLine("Numarul este palindrom.");
            }
            else
            {
                Console.WriteLine("Numarul nu este palindrom.");
            }
            Console.ReadLine();

        }

        public static bool isPrime(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }


        public static void printPrime(int n)
        {
            Console.WriteLine("Numerele prime sunt: ");
            for (int i = 2; i <= n; i++)
            {
                if (isPrime(i))
                    Console.Write(i + " ");
            }
            


        }
    }
}
