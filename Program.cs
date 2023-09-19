using System; // this is the using statement used to import System library
namespace OpenGL // this is the namespace declaration for the project
{
    class Program // this is the class declaration for the project
    {
        static void Main(string[] args) // this is the main method declaration for the project
        {

            /*
            Floating Point Numbers

            Info:
                The default data type when giving floating point numbers is double.

            More Infos:
                For money, always decimal. It's why it was created.
                If numbers must add up correctly or balance, use decimal. This includes any financial storage or calculations, scores, or other numbers that people might do by hand.
                If the exact value of numbers is not important, use double for speed. This includes graphics, physics or other physical sciences computations where there is already a "number of significant digits".
            */

            // Double: Variable of type double, or double-precision floating-point number
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);
            // Result: 0.333333333333333

            // Decimal: type variables have more precision than double variables.
            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
            // Result: 0.3333333333333333333333333333

            // Float: Single precision floating point variables, which we use a lot in 3D graphics.
            float f = 1.0f;
            float g = 3.0f;
            Console.WriteLine(f / g);
            // Result: 0.3333333

        } // this is the end of the main method declaration for the project
    } // this is the end of the class declaration for the project
} // this is the end of the namespace declaration for the project
