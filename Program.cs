using System; // this is the using statement used to import System library
namespace OpenGL // this is the namespace declaration for the project
{
    class Program // this is the class declaration for the project
    {
        static void Main(string[] args) // this is the main method declaration for the project
        {
            /*
            this code is doing the following:
                1. declaring a variable called myname and assigning it a value of "Chris"
                2. printing "Hello " and the value of myname to the console
            */
            string myname = "Chris"; // this is the code that declares a variable called myname and assigns it a value of "Chris"

            /*
            this is a other example of string interpolation in C#:
                use + to concatenate strings in C# but it is not recommended
                use the $ and {variable} syntax instead
                remember that the $ and {variable} syntax is called string interpolation
                and with the + syntax it's called string concatenation
            */
            Console.WriteLine($"Hello {myname}");
            
        } // this is the end of the main method declaration for the project
    } // this is the end of the class declaration for the project
} // this is the end of the namespace declaration for the project
