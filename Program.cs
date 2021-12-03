using System;


namespace tp1
{
    class exo1
    {
        static void Main(string[] args)
        {
            int a, b;
            for (a = 1; a <= 12; a++)
            {
                Console.Write("\n la table de " + a + " est : ");
                for (b = 1; b <= 10; b++)
                {
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b); ;
                }
            }
            Console.Read();
        }
    }
}



    class exo2_prime
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }

class exo2_fibo
{
    static int Fibonacci(int n)
    {
        int w;
        if (n <= 0) return 0;
        if (n == 1) return 1;
        int u = 0;
        int v = 1;
        for (int i = 2; i <= n; i++)
        {
            w = u + v;
            u = v;
            v = w;
        };
        return v;
    }

    static void Main(string[] args)
    {
        for (int I = 0; I <= 10; I++)
        {
            Console.WriteLine("Fibonacci(" + I + ")=" + Fibonacci(I));
        }
    }
}
class exo2_factoriel
{
    public static void Main(string[] args)
    {
        int i, fact = 1, number;
        Console.Write("Enter any Number: ");
        number = int.Parse(Console.ReadLine());
        for (i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.Write("Factorial of " + number + " is: " + fact);
    }
}


class ChristmasTree
{
    static void Main()
    {
        int spaces = 10;
        int asterix = 1;
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < asterix; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            asterix++;
            spaces--;
        }
    }
}




