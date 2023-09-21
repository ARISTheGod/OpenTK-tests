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
        public void Start() // Start is a method of the Car class
        {
            // example of a method for starting a car
            Console.WriteLine("The car is starting");
        }
        public string GetColor() // color is of type string
        {
            return color; // the word return indicates that GetColor will return the color
        }
    }
    /*

    Heredity
        By inheritance we mean that an object type (child)
        can simultaneously be a type of one of another object (parent)
        
        In the car example, let's say we have a class named Sportscar, which will declare a different one
        type of car
    */
    public class SportsCar : Car
    //We use the colon to indicate that Sportscar is also Car.
    {
        //SportsCar has a new variable called model (the model of the car)
        String model;
        
        // The car constructor is as follows: public Car (int d, string c, double t)
        public SportsCar(int d, string c, double t, string m):base(d, c, t)

        // We write a colon and then the word base to call the constructor of the "parent" of the SportsCar
        // i.e. the Car
        {
            model=m;
        }
    }

    class Program
    {
        static void Main() // this is the main method declaration for the project
        {

            // So a SportsCar variable can access Car variables and methods
            SportsCar SC = new SportsCar(2, "white", 500, "Ferrari");
            /// the first 3 parameters are for Car, and one for SportsCar
            
            SC.Start(); //run the Start method of Car

        }
    }

}