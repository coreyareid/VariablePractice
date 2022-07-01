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

            bool ofAge = true;
            if (myAge > 18)
            {
                ofAge = true;
            } else
            {
                ofAge = false;
            }

            char letter = 'a';

            double number1 = 20;

            decimal number2 = 5.5M;

            Console.WriteLine($" Your name is {myName}, and you are {myAge} years old");
            if (ofAge)
            {
                Console.WriteLine($" Are you of age? {ofAge}");
            } else
            {
                Console.WriteLine($" Are you of age? {ofAge}");
            }

            Console.WriteLine($" you\'re in line {letter} and in position {number1}");
            Console.WriteLine($"Your time in line is {number2}");
            
        }
    }
}

