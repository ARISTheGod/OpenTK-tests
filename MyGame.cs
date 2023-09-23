using OpenTK;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;
using System.Drawing;

namespace OpenGL1
{
    // This is the main type for your game.
    public class MyGame : GameWindow
    {
        private int vertexBufferHandle; // this will store the handle for our vertex buffer on the GPU
        private int shaderProgramHandle; // this will store the handle for our shader program on the GPU
        private int vertexArrayHandle; // this will store the handle for our vertex array on the GPU

        // This is called when your window is first created.
        public MyGame(
            int width = 1280, // the width of the window
            int height = 768, // the height of the window
            string title = "My Game" // the title of the window if not passed in it will be "My Game"
            )
            : base(
                GameWindowSettings.Default, // this is the default game window settings

                // this is the native window settings (we can override the default game window settings here)
                new NativeWindowSettings(){
                    Title = title, /*
                        this is the title of the window
                        if you don't pass in a title, it will be "My Game"
                    */
                    Size = new Vector2i(width, height), /*
                        this is the size of the window
                        if you don't pass in a size, it will be 1280x768
                    */
                    WindowBorder = WindowBorder.Fixed, // this is the border of the window
                    StartVisible = false, /*
                        this is whether the window will be visible when it is first created
                        if you don't pass in a value, it will be true
                        INFO: in this case, we don't want the window to be visible when it is first created
                         because we want to set the window's position before it is visible
                    */
                    StartFocused = true, /*
                        this is whether the window will be focused when it is first created
                    */
                    API = ContextAPI.OpenGL, // this is the API that the window will use
                    Profile = ContextProfile.Core, // this is the profile that the window will use
                    APIVersion = new Version(3, 3), // this is the version of the API that the window will use
                }
            )
        {
            this.CenterWindow(); // center the window on the screen
        }

        // This is called when your window is first created.
        protected override void OnLoad()
        {
            this.IsVisible = true; // set the window to be visible only after it has been created

            GL.ClearColor(new Color4(0.3f, 0.4f, 0.5f, 1.0f)); // set background color to black

            float[] vertices = new float[] {
                0.0f, 0.5f, 0.0f, 1.0f, 0.0f, 0.0f, 1.0f,       // top vertex0
                -0.5f, -0.5f, 0.0f, 0.0f, 0.0f, 1.0f, 1.0f,     // left vertex1
                0.5f, -0.5f, 0.0f, 0.0f, 1.0f, 0.0f, 1.0f,       // right vertex2
                /*
                how this works:
                this has 7 values per vertex (3 for position, 4 for color) (x, y, z, r, g, b, a)
                x, y, z are the position of the vertex
                r, g, b, a are the color of the vertex (red, green, blue, alpha) alpha is the transparency
                it's like this:
                vertex0: x, y, z, r, g, b, a
                vertex1: x, y, z, r, g, b, a
                vertex2: x, y, z, r, g, b, a
                */
            };

            // move vertices to the GPU
            this.vertexBufferHandle = GL.GenBuffer(); // generate a handle for our vertex buffer
            // bind the vertex buffer to the GPU
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.vertexBufferHandle);
            // copy the vertices to the GPU
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);
            // unbind the vertex buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            this.vertexArrayHandle = GL.GenVertexArray(); // generate a handle for our vertex array
            GL.BindVertexArray(this.vertexArrayHandle); // bind the vertex array to the GPU

            GL.BindBuffer(BufferTarget.ArrayBuffer, this.vertexBufferHandle); // bind the vertex buffer
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 7 * sizeof(float), 0); // set the vertex attribute pointer
            GL.VertexAttribPointer(1, 4, VertexAttribPointerType.Float, false, 7 * sizeof(float), 3 * sizeof(float)); // set the vertex attribute pointer
            GL.EnableVertexAttribArray(0); // enable the vertex attribute 0 is the index of the vertex attribute
            GL.EnableVertexAttribArray(1); // enable the vertex attribute 1 is the index of the vertex attribute

            GL.BindVertexArray(0); // unbind the vertex array (this is not necessary, but it is good practice)

            // vertex shader
            string vertexShaderCode =
                @"
                #version 330 core // use version 330 of OpenGL

                layout (location = 0) in vec3 aPosition; // this is the input position
                layout (location = 1) in vec4 aColor; // this is the input color

                out vec4 vColor; // this is the output color

                void main()
                {
                    // pass out the color
                    vColor = aColor;

                    // pass out the position
                    gl_Position = vec4(aPosition, 1.0f);
                }
                "; /*
                how this works:
                this has 2 inputs (aPosition, aColor)
                 the input aPosition is a vec3 (x, y, z)
                 the input aColor is a vec4 (r, g, b, a)
                 we use a as a prefix for the inputs because they are attributes
                the position is a vec3 (x, y, z)
                the color is a vec4 (r, g, b, a)
                the position is passed out as gl_Position
                the color is passed out as vColor

                INFO: the vertex shader is called for every vertex
                */

            // pixel shader
            string pixelShaderCode =
                @"
                #version 330 core // use version 330 of OpenGL

                in vec4 vColor;

                out vec4 pixelColor; // this is the output color

                void main()
                {
                    pixelColor = vColor;
                }
                "; /*
                how this works:
                this has 1 input (vColor)
                 the input vColor is a vec4 (r, g, b, a)
                 we use v as a prefix for the input because it is a varying
                the color is a vec4 (r, g, b, a)
                the color is passed out as pixelColor

                INFO: the pixel shader is called for every pixel on the screen
                */

            int vertexShaderHandle = GL.CreateShader(ShaderType.VertexShader); // create a handle for the vertex shader
            GL.ShaderSource(vertexShaderHandle, vertexShaderCode); // set the vertex shader source code
            GL.CompileShader(vertexShaderHandle); // compile the vertex shader

            int pixelShaderHandle = GL.CreateShader(ShaderType.FragmentShader); // create a handle for the pixel shader
            GL.ShaderSource(pixelShaderHandle, pixelShaderCode); // set the pixel shader source code
            GL.CompileShader(pixelShaderHandle); // compile the pixel shader

            this.shaderProgramHandle = GL.CreateProgram(); // create a handle for the shader program

            GL.AttachShader(this.shaderProgramHandle, vertexShaderHandle); // attach the vertex shader to the shader program
            GL.AttachShader(this.shaderProgramHandle, pixelShaderHandle); // attach the pixel shader to the shader program

            GL.LinkProgram(this.shaderProgramHandle); // link the shader program

            GL.DetachShader(this.shaderProgramHandle, vertexShaderHandle); // detach the vertex shader from the shader program
            GL.DetachShader(this.shaderProgramHandle, pixelShaderHandle); // detach the pixel shader from the shader program

            GL.DeleteShader(vertexShaderHandle); // delete the vertex shader
            GL.DeleteShader(pixelShaderHandle); // delete the pixel shader

            base.OnLoad(); // call the base class' OnLoad method
        }

        // This is called when the window is resized. You should set your viewport here.
        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, e.Width, e.Height); // set the OpenGL viewport (drawable area)
            base.OnResize(e); // call the base class' OnResize method
        }

        // This is called when the window is closed.
        protected override void OnUnload()
        {
            GL.BindVertexArray(0); // unbind the vertex array
            GL.DeleteVertexArray(this.vertexArrayHandle); // delete the vertex array

            GL.BindBuffer(BufferTarget.ArrayBuffer, 0); // unbind the vertex buffer
            GL.DeleteBuffer(this.vertexBufferHandle); // delete the vertex buffer

            GL.UseProgram(0); // unbind the shader program
            GL.DeleteProgram(this.shaderProgramHandle); // delete the shader program

            base.OnUnload(); // call the base class' OnUnload method
        }

        // This is called when it is time to render the next frame. Add your game logic here.
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            // clear the screen
            GL.Clear(ClearBufferMask.ColorBufferBit); // clear the color buffer (sets everything to black)

            GL.UseProgram(this.shaderProgramHandle); // use the shader program

            GL.BindVertexArray(this.vertexArrayHandle); // bind the vertex array

            GL.DrawArrays(PrimitiveType.Triangles, 0, 3); // draw the triangle

            // swap the back buffer with the front buffer
            this.Context.SwapBuffers(); // swap the front and back buffers of the window Context is used for OpenGL 3.0+ only

            base.OnRenderFrame(args); // call the base class' OnRenderFrame method
        }

        // This is called when the window is resized. You should set your viewport here.
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args); // call the base class' OnUpdateFrame method
        }

    }
}
