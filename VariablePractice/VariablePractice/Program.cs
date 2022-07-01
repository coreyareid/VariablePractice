using System;

namespace VariablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int myAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now, what is your name?");
                string myName = Console.ReadLine();

            Console.WriteLine($" Your name is {myName}, and you are {myAge} years old");

            if (myAge > 18)
            {
                Console.WriteLine("You are of age to use this website");
            } else if (myAge < 18)
            {
                Console.WriteLine("Sorry, you cannot use this system.");
            } else
            {
                Console.WriteLine("You did not enter your age.");
            }
        }
    }
}

