using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int num1;
            num1 = 13;
            int num2 = 23;
            int sum = num1 + num2;
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " = " + sum);

            Console.WriteLine();

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 = " + dDiv);

            // Float rounds it up
            float f1 = 3.1415F;
            float f2 = 5.1F;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 = " + fDiv);

            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1 = " + dIDiv);

            Console.WriteLine("HELLO WORLD"); // prints the text and jumps to a new line
            Console.Write("HELLO"); // prints the text in the same line
            Console.Write("WORLD"); // as this one
                                    // .WriteLine() => Hello World
                                    // .Write() =>     HelloWorld

            Console.WriteLine("Enter a string and press enter: "); 
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}: ",readInput);

            Console.WriteLine("Enter a string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}: ",asciiValue);

            Console.WriteLine("<=============================================>");
           
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello Israel Sanchez");
            Console.WriteLine("C# is cool!");

            Console.Read();

        }
    }
}
