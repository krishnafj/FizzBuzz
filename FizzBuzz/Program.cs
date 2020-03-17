using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int intFrom = 1;
            int intoTo = 100;
            const string constFizz = "Fizz";
            const string constBuzz = "Buzz";


            //Loop from 1 - 100
            for (int i = intFrom; i <= intoTo; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine($"{constFizz}{constBuzz}");
                else if(i % 3 == 0)
                    Console.WriteLine(constFizz);
                else if(i % 5 == 0)
                    Console.WriteLine(constBuzz);
                else
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
