using System; // this is the using statement used to import System library
namespace OpenGL // this is the namespace declaration for the project
{
    class Program // this is the class declaration for the project
    {
        static void Main(string[] args) // this is the main method declaration for the project
        {
            /*
            this will show how to use trim to remove white space from a string
            */

            // declare a string variable and assign it a value of "      Hello World!       "
            string greeting = "      Hello World!       ";

            // print to the console the value of the string variable with square brackets around it
            Console.WriteLine($"[{greeting}]"); // this will print [      Hello World!       ]

            /*
            this will do the following:
                1. declare a string variable
                2. assign it the value of the string variable greeting with the trim method called on it
            */
            string trimmedGreeting = greeting.Trim(); // value of trimmedGreeting is "Hello World!"
            
            Console.WriteLine($"[{trimmedGreeting}]"); // this will print [Hello World!]
        } // this is the end of the main method declaration for the project
    } // this is the end of the class declaration for the project
} // this is the end of the namespace declaration for the project
