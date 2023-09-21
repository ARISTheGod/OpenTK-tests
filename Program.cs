namespace OpenGL1
{
    class Program
    {
        /* 2. Program.cs
        In the Program.cs file is the Main method which is the first method executed when we run it
        our program. Its only task is to create an object (named game here) of type MyGame and
        then execute the Run method of that object.
        */
        static void Main(string[] args)
        {
            /* 1. Introduction
            OpenGL
            OpenGL is an API (Application Programming Interface) a set of functions and methods that
            they help to display 2D and 3D graphics on the screen.
            While we call OpenGL a programming language, we cannot actually program
            directly in OpenGL but we need another programming language (like C#)
            Actually OpenGL is a specification, it defines what effect the functions should have
            her. However, the graphics card manufacturers are responsible for implementing these functions,
            AMD, INTEL, NVIDIA. In other words, OpenGL itself does not offer the content of the functions but only the ones
            names, parameters and gives information about exactly what these functions are supposed to do.

            OpenTK
            There are many libraries that allow us to use OpenGL functions, the library that
            is more compatible with C# and is in constant development (others have been stopped for years) is OpenTK
            The first step when starting an OpenGL application is to open a window. I will
            make a class, which can be in the same file or in a different one, but always in the same namespace.
            */


            /* 3. MyGame 
            The game is a copy of the MyGame class that is loaded into memory with some default values, which
            we can change. We can have many different objects of the same type even if we change
            values in one, will not change in the others.
            MyGame.cs file

            After the name, the colon indicates that the MyGame class will inherit from the GameWindow class.
            Notice that the Run method we call on the game object has not been implemented by us (the
            MyGame.cs is practically empty) the Run method is part of GameWindow, and since MyGame is
            at the same time GameWindow you have all the methods and variables of GameWindow.
            All windows in OpenGL, after the creation of the object, are started with the Run() method which like
            parameter accepts the frame rate (frames per second) i.e. how fast the application will refresh (such as
            we'll see below, whenever OnUpdateFrame will run), if we leave it blank then our program will run
            as fast as our hardware can handle it.
            The 3 main methods we need to implement in an OpenGL application are:
            OnLoad
            OnRenderFrame
            OnUpdateFrame
            There are other methods but these 3 are the main ones that are present in almost every program/application.
            These methods are in the GameWindow class, to use them we need to change them
            their contents to do the tasks we want. We achieve this by writing the word override, where
            will tell the compiler that we don't want GameWindow's OnLoad but our own.
            */
            MyGame game = new MyGame();
            game.Run();
        }
    }
}