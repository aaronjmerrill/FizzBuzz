using System;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            int limit = GetLimit();
            if (limit == int.MinValue)
                Console.WriteLine("Invalid limit");
            else
            {
                for (int i = 0; i <= limit; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        if (i % 3 == 0)
                            Console.Write("Fizz");
                        if (i % 5 == 0)
                            Console.Write("Buzz");
                    }
                    else
                    {
                        Console.Write(i.ToString());
                    }
                    Console.Write("\r\n");
                }
            }
            Console.ReadLine();
        }
        private static int GetLimit()
        {
            Console.Write("Limit: ");
            string sLimit = Console.ReadLine();
            int nLimit;
            if (!int.TryParse(sLimit, out nLimit) || nLimit < 0)
                nLimit = int.MinValue;
            return nLimit;
        }
    }
}