using System;
namespace OpenGL
{

    /*
    INFO: The Constructor
        As we see the cars in Car have no values in their variables, the car mycar has no doors.
        Could we declare int doors = 4 inside the Car class? But that way we would only have cars with 4 doors.
        To pass the values we want we use a Constructor.
        We declare the constructor inside the hooks of the class of the object,
        writing public <class name> () { }
        The same Car class with the addition of Constructor:
    */
    public class Car
    {
        int doors; //how many doors does the car have?
        string color; //what color is the car
        double topspeed; //the top speed of the car

        /*
        The Constructor
        As we see the cars in Car have no values in their variables, the car mycar has no doors.
        Could we declare int doors = 4 inside the Car class? But that way we would only have cars with 4 doors.
        To pass the values we want we use a Constructor.
        We declare the constructor inside the hooks of the class of the object, writing public <class name> () { }
        The same Car class with the addition of Constructor:
        */
        public Car (int d, string c, double t) 
        { 
            doors = d;
            color = c;
            topspeed = t;
        }
    }

    class Program
    {
        static void Main() // this is the main method declaration for the project
        {

            /*
            Inside the parenthesis we give all the input variables,
             then between the brackets we set the variables
             of the object equal to the variables in parentheses.
            Caution:
                Variables in parentheses must be of the same type as the object.
                So we can have many different cars, without rewriting their code and without
                 create new variables
            */
            Car mycar = new Car(4, "white", 300); // car with 4 doors, white color, 300 km top speed

            Car mycar2 = new Car(2, "red", 500); //car with 2 doors, red color, 500 km top speed

        }
    }

}

/*
An object can have multiple constructors, as long as they have different parameters in parentheses. In
in this case we say we have an overload, for example:
    public Car (int d)
    {
    doors = d;
    }

In this Constructor we are only interested in how many doors the car has. And we declare it as before but
in parentheses we only give the number from the doors:
    Car mydoor = new Car(4);
*/