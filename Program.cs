using System;
namespace OpenGL
{

    public class Car
    {
        int doors; //how many doors does the car have?
        string color; //what color is the car
        double topspeed; //the top speed of the car

        public Car (int d, string c, double t) 
        { 
            doors = d;
            color = c;
            topspeed = t;
        }

        /*
        Functions (Methods):
            In addition to variables, objects also have functions (methods),
             i.e. code that executes a specific function work.
            Constructor is one such special method which initializes the object
             as we have seen but we can have different types of methods.
            Only the constructor must have the name of the object,
             the other methods must have different names.

            Each method when we declare it needs, in addition to name,
             to write the access method (public/private will
            we'll see what they mean later) as well as the data type it returns.
            If we don't want it to return anything then we write the word void.
            Constructor is always public and has no return type because it "returns" the same the object.

            Inside the Car class we write a Start method that will "start" the car.
        */
        public void Start()
        {
            // code that states the car is starting
            // example for testing purposes
            Console.WriteLine("The car is starting");
        }
    }

    class Program
    {
        static void Main() // this is the main method declaration for the project
        {

            // is the car mycar with 4 doors, white color and top speed 300
            Car mycar = new Car(4, "white", 300);

            /*
            To call the method we use the "dot", in a sophisticated IDE (Code Generation Program)
             pressing the dot will automatically output all the visible methods and variables of the object.
            For example if Console and we press dot it will get us all the methods of the console,
             like WriteLine which prints something to the console.
            */
            mycar.Start(); // will start the car mycar

            /*
            In the parentheses we can give values, and as with the Constructor we can have many times the
             same method (overload) as long as we have different parameters in parentheses.
            */

        }
    }

}
