using System;

namespace Lab2NumAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab 2: Number Analyzer

            bool numAnalyze = true;

            Console.WriteLine("Welcome to the Number Analyzer 3000. Please enter your name. ");
            string name = Console.ReadLine();

            while (numAnalyze)
            {
               
                Console.WriteLine($"Hey there, {name}. Now enter a number between 1 and 100.");
                int number = int.Parse(Console.ReadLine());

                /*while (number < 1 || number > 100 )
                {
                    Console.WriteLine($"C'mon {name}, I said between 1 and 100. Try again");
                    Console.ReadLine();
                    break;
                }*/
                
                if (number % 2 == 1)
                {
                    if (number % 2 == 1)
                    {
                        Console.WriteLine($"{number} is odd, {name}.");
                    }
                    else if (number % 2 == 1 && number > 60)
                    {
                        Console.WriteLine($"{number} is odd, {name}.");
                    }

                }

                else if (number % 2 == 0)
                {
                    if (number >= 2 && number <= 25)
                    {
                        Console.WriteLine($"{number} is even and less than 25, {name}");
                    }
                    if (number >= 26 && number <= 60)
                    {
                        Console.WriteLine($"{number} is even, {name}.");
                    }
                    if (number > 60)
                    {
                        Console.WriteLine($"{number} is even, {name}");
                    }


                }

                Console.WriteLine("Analyze another number? Y/N");
                string askAgain = Console.ReadLine();

                if (askAgain == "y")
                {
                    numAnalyze = true;
                }

                else
                {
                    numAnalyze = false;
                    Console.WriteLine($"Goodbye, {name}.");
                }
                

            }

        }
    }
}
