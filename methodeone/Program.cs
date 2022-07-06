using System;

namespace MethodeOne
{
    class Program
    {
        static void Main(String[] args)
        {
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
            

        }
    }
}

