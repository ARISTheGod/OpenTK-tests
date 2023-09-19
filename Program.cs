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
        2.
            We can declare color public: public string color; and printing will succeed.
            But the best case for variables is to make set/get methods to change/read them respectively.
            
            Then we write: Console.WriteLine(mycar.GetColor()); //pay attention to parentheses.
        */
        public string GetColor() // color is of type string
        {
            return color; // the word return indicates that GetColor will return the color
        }
    }

    class Program
    {
        static void Main() // this is the main method declaration for the project
        {

            // is the car mycar with 4 doors, white color and top speed 300
            Car mycar = new Car(4, "white", 300);

            /*
            1.
            Variable / method visibility:
                Which variables are visible when we use the dot depends on whether we have declared them public or private.
                THE word public indicates visibility, word private hides variables and methods.
                Variables by default are private that is, they are hidden.
                For example if we write: Console.WriteLine(mycar.color);
                Printing will fail because with the dot we will not have access to the color variable because it is private.
            */
            // you can try it out by uncommenting the line below the printing will fail
            // Console.WriteLine(mycar.color);

            /*
            3.
            testing the GetColor method
            */
            Console.WriteLine(mycar.GetColor());

            // conclusion: we can access the color variable through the GetColor method
        }
    }

}
