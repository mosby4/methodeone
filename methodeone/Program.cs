using System;

namespace MethodeOne
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        static void Main(String[] args)
        {

            var amountOfcars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

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

