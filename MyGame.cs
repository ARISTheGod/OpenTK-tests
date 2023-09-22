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
        public MyGame() : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {
            this.CenterWindow(
                new Vector2i(1280, 768) // set the window size to 1280x768
            );
        }

        // This is called when your window is first created.
        protected override void OnLoad()
        {
            GL.ClearColor(new Color4(0.3f, 0.4f, 0.5f, 1.0f)); // set background color to black

            float[] vertices = new float[] {
                0.0f, 0.5f, 0.0f, // top vertex0
                -0.5f, -0.5f, 0.0f, // left vertex1
                0.5f, -0.5f, 0.0f // right vertex2
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
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0); // set the vertex attribute pointer
            GL.EnableVertexAttribArray(0); // enable the vertex attribute

            GL.BindVertexArray(0); // unbind the vertex array

            // vertex shader
            string vertexShaderCode =
                @"
                #version 330 core // use version 330 of OpenGL

                layout (location = 0) in vec3 aPosition; // this is the input position

                void main()
                {
                    // pass out the position
                    gl_Position = vec4(aPosition, 1.0f);
                }
                ";

            // pixel shader
            string pixelShaderCode =
                @"
                #version 330 core // use version 330 of OpenGL

                out vec4 pixelColor; // this is the output color

                void main()
                {
                    pixelColor = vec4(0.8f, 0.8f, 0.1f, 1.0f); // set the pixel color to yellow (RGBA)
                }
                ";

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
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0); // unbind the vertex buffer
            GL.DeleteBuffer(this.vertexBufferHandle); // delete the vertex buffer

            GL.UseProgram(0); // unbind the shader program
            GL.DeleteProgram(this.shaderProgramHandle); // delete the shader program

            base.OnUnload(); // call the base class' OnUnload method
        }

        // This is called when it is time to render the next frame. Add your game logic here.
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            // clear the screen
            GL.Clear(ClearBufferMask.ColorBufferBit); // clear the color buffer (sets everything to black)

            GL.UseProgram(this.shaderProgramHandle); // use the shader program

            GL.BindVertexArray(this.vertexArrayHandle); // bind the vertex array

            GL.DrawArrays(PrimitiveType.Triangles, 0, 3); // draw the triangle

            // swap the back buffer with the front buffer
            this.Context.SwapBuffers(); // swap the front and back buffers of the window Context is used for OpenGL 3.0+ only

            base.OnRenderFrame(e); // call the base class' OnRenderFrame method
        }

        // This is called when the window is resized. You should set your viewport here.
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e); // call the base class' OnUpdateFrame method
        }

    }
}
