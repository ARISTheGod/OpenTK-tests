using System;

namespace OpenGL
{

    class Program
    {
        static void Main() // this is the main method declaration for the project
        {

            /*
            Program flow
                To change the flow of the program we use the structure if(condition1)...else if(condition2)...else
            */

            int selection; // Create variable (integer)
            Random rand = new Random(); // Create an object of type Random

            /*
            The Next method returns a random number between the two parameters we specified,
             in this case it will is a number between 1 and 7.
            */
            selection = rand.Next(1, 7); // call the Next method giving 1.7 as parameters

            /*
            In the random number example above,
             to print the day of the week that corresponds to number we can use the if structure as follows:
            */
            if (selection == 1) /*
                    in the condition we use double = because single is for entering value.
                    Here we ask "is selection equal to 1?" If YES then execution proceeds inside the brackets,
                    otherwise it goes to else if
                */
            {
                Console.WriteLine("Monday");
            }
            else if (selection == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (selection == 7)
            {
                Console.WriteLine("Sunday");
            }

            /*
            Once all the else ifs are finished the execution ends.
            If we want something to be done if the number does not exist in any condition
             then we finish by writing plain else. For example, if for a random number we wrote:
            selection = rand.Next(1, 10); It would return numbers from 1 to 10. We would write the code as above and be done
            writing:
            } else { Console.WriteLine(“Does not match day!”); } because numbers over 7 do not correspond to a day week
            */

        }
    }

}
