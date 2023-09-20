using System;

namespace OpenGL
{

    class Program
    {
        static void Main() // this is the main method declaration for the project
        {

            /*
            Program flow
                Another way to do the same is by using the Switch structure
            */

            /*
            are random number generator to select a number between 1 and 7
            */
            int selection; // we declare the variable selection as an integer
            Random rand = new Random(); // we declare the variable rand as a random number generator object
            selection = rand.Next(1,7); /*
            we use the method Next of the object rand to select a number between 1 and 7
            */

            switch (selection) // we start by putting in parentheses the variable we will check
            {
            case 1: // with the word case we state what the selection will be equal to
                Console.WriteLine("Monday"); 
                break; /*
                at the end we write break to stop the execution.
                Without it the code will continue below (in Case 2)
                and so on until it finds a break or the end of the switch.
                most of the times we use break to avoid errors and to make the code more readable
                */
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
            Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday ");
                break;
            }

        }
    }

}
