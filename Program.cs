using System; // this is the using statement used to import System library
namespace OpenGL // this is the namespace declaration for the project
{
    class Program // this is the class declaration for the project
    {
        static void Main(string[] args) // this is the main method declaration for the project
        {
            /*
            this code is doing the following:
                1. declaring a variable called name and assigning it a value of "Chris"
                2. declaring a variable called name2 and assigning it a value of "Bill"
            */
            string name = "Chris"; // this will declare a variable called name and assign it a value of "Chris"
            string name2 = "Bill"; // just a second variable called name2 and assign it a value of "Bill"

            /*
            this is a example of string concatenation in C#
                the + operator is used to concatenate strings together
                it's not recommended to use it because it's not as efficient
                as the string interpolation method
            */
            Console.WriteLine("Hello "+ name +" and " + name2); // prints "Hello Chris and Bill" to the console

            /*
            this is a example of string interpolation in C#
                the $ operator is used to interpolate strings together
                it's recommended to use it because it's more efficient
                than the string concatenation method
            */
            Console.WriteLine($"Hello {name} and {name2}"); // prints "Hello Chris and Bill" to the console
            
        } // this is the end of the main method declaration for the project
    } // this is the end of the class declaration for the project
} // this is the end of the namespace declaration for the project
