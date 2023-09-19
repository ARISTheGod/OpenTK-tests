using System; // this is the using statement used to import System library
namespace OpenGL // this is the namespace declaration for the project
{
    class Program // this is the class declaration for the project
    {
        static void Main(string[] args) // this is the main method declaration for the project
        {
            /*
            let's also see the replace method which replaces one part of text with another.
            */

            // declare a string variable and assign it a value of "Hello World!"
            string sayHello = "Hello World!";

            // print the value of the variable sayHello to the console
            Console.WriteLine(sayHello); // this should print "Hello World!" to the console

            /*
            this code will do the following:
                1. find the word "Hello" in the string
                2. replace the word "Hello" with the word "Greetings"
                3. change the value of the variable sayHello to "Greetings World!"
            */
            sayHello = sayHello.Replace("Hello", "Greetings");

            // print the value of the variable sayHello to the console after the replacement
            Console.WriteLine(sayHello); // this should print "Greetings World!" to the console
        } // this is the end of the main method declaration for the project
    } // this is the end of the class declaration for the project
} // this is the end of the namespace declaration for the project
