using System;

namespace OpenGL
{

    class Program
    {
        static void Main() // this is the main method declaration for the project
        {
        
        /*
        Random numbers
            As a practice on objects and variables, we will make random numbers
        */

        int selection; // Create variable (integer)

        /*
        The Random class is used to create random numbers
        */
        Random rand = new Random(); // Create an object of type Random

        /*
        The Next method returns a random number between the two parameters we specified, 
         in this case it will be a is a number between 1 and 7.
        */
        selection = rand.Next(1, 7); // call the Next method giving 1.7 as parameters

        // Print the random number
        Console.WriteLine("You rolled a " + selection);

        /*
        conclusion: the Next method of the Random class is used to generate random numbers
        it's important to note that the Next method is overloaded, meaning that it can be called
        with different parameters to generate different types of random numbers

        Info:
            but it's not secure, it's not cryptographically secure, meaning that it's not secure enough
            to be used in cryptography, for example, to generate passwords or to generate keys for encryption.
        */

        }
    }

}
