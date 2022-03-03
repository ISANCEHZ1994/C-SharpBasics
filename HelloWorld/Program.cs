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

            // ============= [ CONVERSTION ] ======================
             
            // IMPLICT Conversion => just does it 
            int num = 123456789;
            long bigNum = num;
            Console.WriteLine("INT turned to LONG: ", bigNum);
            float myFloat = 13.37F;
            double myNewDouble = myFloat;
            Console.WriteLine("FLOAT turned to DOUBLE: ", myNewDouble);

            // EXPLICIT Converstion => you explain the conversion 
            // cast double to int
            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;
            Console.WriteLine(myInt);    
            
            // TYPE Converstion 
            string myString = myDouble.ToString(); // "13.37"
            string myFloatString = myFloat.ToString(); 
            bool sunIsShinning = false;
            string myBoolString = sunIsShinning.ToString();

            string myOtherString = "15";
            string myOtherSecondString = "13";
            int num3 = Int32.Parse(myOtherString);
            int num4 = Int32.Parse(myOtherSecondString);
            int resultInt = num3 + num4;
            string result = myOtherString + myOtherSecondString;

            Console.WriteLine(resultInt);

            // Console.WriteLine("HELLO WORLD"); // prints the text and jumps to a new line
            // Console.Write("HELLO"); // prints the text in the same line
            // Console.Write("WORLD"); // as this one
                                    // .WriteLine() => Hello World
                                    // .Write() =>     HelloWorld

            //Console.WriteLine("Enter a string and press enter: "); 
            //string readInput = Console.ReadLine();
            //Console.WriteLine("You have entered {0}: ",readInput);

            //Console.WriteLine("Enter a string and press enter: ");
            //int asciiValue = Console.Read();
            //Console.WriteLine("ASCII value is {0}: ",asciiValue); // more on {0} BELOW
            //Console.WriteLine("");

            // ============= [ String Manipulation TWO WAYS ] ======================
            // 1. String Concatenation
            int age = 27;
            string name = "Israel Sanchez";
            string job = "full stack developer";
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old" );

            // 2. String Formatting - string formatting uses index ==> THIS IS NEW TOO ME COOL!
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old. I work as a {2}", name, age, job);

            // 3. String Interpolation - A NEW WAY only uses ONE $
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is still {name}, I am STILL {age}, and I STILL work as {job}");

            // 4. Verbatim Strings - start with @ and tells compiler to take the string LITERALLY and ignore any spaces
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Muwahahahaha \n you have no POWER here!!");
            Console.WriteLine("Muwahahahaha \n NANI??!");

            Console.WriteLine("");

            string myName;
            Console.Write("Please enter your name and press enter: ");
            myName = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper case: {0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower case: {0}", myName.ToLower());
            string myNameTrimmed = String.Format("Trimmed value: {0}", myName.Trim());
            string myNameSubstring = String.Format("Substring value: {0}", myName.ToUpper());
            Console.WriteLine(myNameUpperCase);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello Israel Sanchez");
            Console.WriteLine("C# is cool!");

            Console.Read();

        }
    }
}
