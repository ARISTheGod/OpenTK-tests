using System;
namespace OpenGL
{

    /*
    INFO: Create objects
        C# is an object-oriented programming language (Object oriented) which means that it is based on special
        variables we call objects. We use the objects to reuse it
        our code, to separate and build a structure in our program. To create an object
        we need to create a new class that describes it.
    */

    /*
    Here we have created a class named Car which describes a car with various attributes.
    */
    public class Car
    {
        int doors; //how many doors does the car have?
        string color; //what color is the car
        double topspeed; //the top speed of the car
    }

    class Program
    {
        static void Main() // this is the main method declaration for the project
        {

            /*
            By using the Car class we group the variables while allowing us
             to create multiple cars.
            Finally we name an object (mycar) so that we can reuse it in our code.
            */
            Car mycar = new Car(); // mycar is the name of the car
            
        }
    }

}
