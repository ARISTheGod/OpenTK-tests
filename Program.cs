using System; // this is the using statement used to import System library
namespace OpenGL // this is the namespace declaration for the project
{
    class Program // this is the class declaration for the project
    {
        static void Main(string[] args) // this is the main method declaration for the project
        {

            /*
            We can print the limits of the int variable using the MaxValue and MinValue variables, which
            are variables. With the dot (.) we have access to the methods and also to the variables of the object. The
            methods such as Trim() above are followed by parentheses while the variable is not.
            */

            // this is the declaration of the max variable
            int max = int.MaxValue;
            
            // this is the declaration of the min variable
            int min = int.MinValue;
            
            // this is the print of the min and max variables
            Console.WriteLine($"The range of integers is {min} to {max}");

        } // this is the end of the main method declaration for the project
    } // this is the end of the class declaration for the project
} // this is the end of the namespace declaration for the project
