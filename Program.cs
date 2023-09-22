namespace OpenGL1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGame game = new MyGame();
            game.Run();
        }
    }
}

/*
Normalized Device Coordinates
 
In 3D graphics, normalized values mean values between 0 and 1. Normalized Device Coordinates are
coordinates that have values from 0 to 1. Instead of working with resolution in pixels, we work with normalized
values so that the application runs regardless of screen resolution and hardware.
Below we will see the coordinates for the 3 vertices that create a triangle in a normalized device
coordinates.

[IMG URL: ""]

To draw a shape we have to color the vertices. To have access to a variety
colors we can use the namespace Drawing which are subclasses of System. When
we write using in the main namespace we don't have access to its sub-Namespaces so we have to
declare separately, writing using System.Drawing;
We start the painting by writing GL.Begin which as a parameter we give it what kind of shape we will draw. Here
we want to draw a simple triangle so we write PrimitveTypes.Triangles because the triangle is Primitive
(basic shape).
Then we give the coordinates of the three vertices and a color for each (see the figure)
We close the drawing by writing GL.End(); Which has no parameters.
Finally we write the command this.SwapBuffers(); to draw our shape.
Double Buffering
OpenGL uses two buffers, the Back Buffer and the Front Buffer. The buffer is space in the memory that it holds
data, in the Back Buffer the graphics card writes the data of the last frame, as soon as it finishes rendering
frame then moves it to the Front Buffer from which the screen reads. While the monitor reads the Front Buffer, the VGA
it fills the Back Buffer, and then they change again. Double buffering was implemented to speed up the process
rendering, because a space in memory cannot be read and written simultaneously by two different ones
processes or devices (vga and monitor)
 
Without double buffering, the vga would have to wait for the monitor to read the space before starting to make it
next frame, creating significant delays.
 
This process of sending data from the Back Buffer to the Front Buffer is done by the SwapBuffers command. Without
this command we would see nothing
*/