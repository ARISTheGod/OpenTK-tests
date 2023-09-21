using OpenTK;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace OpenGL1
{
    public class MyGame : GameWindow
    {

        /*
        The main body of an OpenGL application, except for the namespace name, which changes, the other parts will
        we use in each of our applications:
        */

        public MyGame() : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {
            
        }

        // /*
        // OnLoad
        //     In OnLoad we write code that loads audio, image files and 3D models into memory, it runs
        //     once at the beginning of the program
        // */
        // protected override void OnLoad(EventArgs e)
        // {

        // }

        /*
        OnRenderFrame:
            This method is responsible for displaying the graphics of the application on the screen
        */
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            /*
            this is the method that draws the graphics on the screen, it is called every time
            that the application window is updated, that is, every time OnUpdateFrame is called.

            difference between OnRenderFrame and OnUpdateFrame:
            OnRenderFrame is called every time the application window is updated, that is, every time
            that OnUpdateFrame is called, but OnUpdateFrame is called only when we want to update the application window,
            that is, every time the application window is updated, that is, every time OnUpdateFrame is called.
            in simple words, OnRenderFrame is called every time OnUpdateFrame is called, but OnUpdateFrame is called only when we want to update the application window.
            */
            base.OnRenderFrame(e); /*
                This line is necessary to run the application
                as the default OnRenderFrame method of GameWindow is empty, we need to call the base method
            */
        }

        /*
        OnUpdateFrame:
            This method runs when we want to update the application window, the one we placed as
            parameter in the Run method or as long as the hardware can withstand if we didn't put something. Update is where we put the logic
            and movement in the application.
        */
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            /*
            this is the method that updates the application window, it is called every time
             that the application window is updated, that is, every time OnUpdateFrame is called.

            difference between OnRenderFrame and OnUpdateFrame:
            OnRenderFrame is called every time the application window is updated, that is, every time
            that OnUpdateFrame is called, but OnUpdateFrame is called only when we want to update the application window,
            that is, every time the application window is updated, that is, every time OnUpdateFrame is called.
            in simple words, OnRenderFrame is called every time OnUpdateFrame is called, but OnUpdateFrame is called only when we want to update the application window.
            */

            base.OnUpdateFrame(e); /*
                this line is necessary to run the application
                as the default OnUpdateFrame method of GameWindow is empty, we need to call the base method
            */
        }

    }
}