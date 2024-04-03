using System;

class HelloGoodbye
{
    static void Main(string[] args)
    {
        int number = 1;

        while (number <= 100)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Hello Goodbye");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Hello");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine(number);
            }

            number++;
        }
    }
}
