using System;

namespace LoopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here are some random numbers:");
            Random rand = new Random();
            for (int val = 0; val < 3; val++)
            {
                Console.WriteLine(rand.Next(1, 200));
            }
            // Create a Loop that prints all values from 1-255
            Console.WriteLine("Numbers from 1 to 255:");
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            Console.WriteLine("Numbers from 1 to 100:");
            for (int i = 1; i <= 101; i++)
            if (i % 3 != 0 && i % 5 != 0) 
            {
                Console.WriteLine(i);
            }
            //Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            Console.WriteLine("Numbers from 1 to 100:");
            for (int num = 1; num <= 101; num++){
                if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            {
                Console.WriteLine(num);
            }
            }

        }
    }
}
