using System;

class HelloGoodbye
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            switch (i)
            {
                case int n when n % 3 == 0 && n % 5 == 0:
                    Console.WriteLine("Hello Goodbye");
                    break;
                case int n when n % 3 == 0:
                    Console.WriteLine("Hello");
                    break;
                case int n when n % 5 == 0:
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine(i);
                    break;
            }
        }
    }
}
