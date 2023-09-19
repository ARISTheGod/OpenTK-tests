using System; // this is the using statement used to import System library
/*
Using:
    The word using is followed by the name of a namespace,
     a collection of methods and variables, and us allows us to use them in our application.
    We add our using entries to the top of our program In the example above,
     we use the System namespace to access the variable
     Console system with the help of which we write to the console.
    Alternatively we could write System.Console.WriteLine("Hello World!");
     and would perform the same function,
    but this assumes that the namespace we are looking for (System) is known on our computer
*/

namespace OpenGL // this is the namespace declaration for the project
/*
Namespace:
    The classes we write for our program, we place them inside a namespace,
     the word namespace – empty – a name of our own – and we surround them with hooks.
    This helps us organize our programs, they work like folders in a file system.
    Classes located in the same namespace "see" each other without using the keyword using.
*/
{
    class Program // this is the class declaration for the project
    {
        static void Main(string[] args) // this is the main method declaration for the project
        {

            /*
            this is using the System namespace to access the variable
            Console system with the help of which we write to the console.
            WriteLine is a method that writes a line to the console.
            */
            System.Console.WriteLine("Hello World!");

            /*
            this is not using the System namespace to access the variable
            as we have already imported the System namespace at the top of the file
            by adding the using statement "using System;" to import the System library
            */
            Console.WriteLine("Hello World!");

            /*
            conclusion:
                we can use the System namespace to access the variable
                so that we can write to the console without having to write the System
                this is best practice as it makes the code more readable
                but sometimes we may want to write the System to make it clear
                e.g. if we have a variable called Console in our code
            */

        } // this is the end of the main method declaration for the project
    } // this is the end of the class declaration for the project
} // this is the end of the namespace declaration for the project
