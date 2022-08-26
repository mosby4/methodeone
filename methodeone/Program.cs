using System;

namespace MethodeOne
{
    class Program
    {
        public static int sum(int num1, int num2)
        {

            var answer = num1 + num2;
            return answer;

        }

        public static int subtract(int num1, int num2)
        {
            var remainder = num1 - num2;
            return remainder;
        }

        public static int divide(int num1, int num2)
        {
             var dividend = num1 / num2;
             return dividend;
        }

        public static int multiply(int num1, int num2)
        {
            var multi = num1 * num2;
            return multi;
        }

        static void Main(String[] args)
        {

        var amountOfcars = sum(2, 6);
            Console.WriteLine(amountOfcars);
            Console.WriteLine();

        var whatsLeft = subtract(100,30);
            Console.WriteLine(whatsLeft );
            Console.WriteLine();

        var times = multiply(12, 30);
            Console.WriteLine(times);
            Console.WriteLine();

            var splitCheck = divide(65, 2);
            Console.WriteLine(splitCheck);

            //----------------exercise 1
            // Name: Michael
            // Favorite Color: Blue
            // Favorite Animal: Walrus
            // Favorite Band: The Beatles

            Console.WriteLine($"Hello - Waht is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}. What is your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine($"{userName} what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Ok {userName} what is your favorite band");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}, here is your profiel.");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine($"Name {userName}");
            Console.WriteLine($"Favorite color {favColor}");
            Console.WriteLine($"Favorite animal {animal}");
            Console.WriteLine($"Favorite band {band}");

            //-----------------Exercise 2---------------------------------//



            

        }
    }
}

