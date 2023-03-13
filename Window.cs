using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;

namespace HelloWindow
{
    internal class Window : GameWindow
    {
        Object obj = new Object();

        Shader shader;
        // Fields
        private int r = 0, g = 0, b = 0;
        private float ratio = 0.0003f;

        public Window(
            GameWindowSettings gameWindowSettings,
            NativeWindowSettings nativeWindowSettings) :
            base(gameWindowSettings, nativeWindowSettings) // Chamando o construtor da classe base
        {
            // Construtor por enquanto ficará vazio
        }

        // Load the frame data
        protected override void OnLoad()
        {
            base.OnLoad();
            obj.load();
            shader = new Shader("Shaders/base.vert", "Shaders/base.frag");
            /*GL.Enable(EnableCap.Multisample);
            GL.Hint(HintTarget.MultisampleFilterHintNv, HintMode.Nicest);*/
            // Set the background color to red
            GL.ClearColor(0.0f, 0.0f, 0.0f, 1.0f);
        }

        // Draw the objects on screen
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            // Clear the screen with a predefined color
            GL.Clear(ClearBufferMask.ColorBufferBit);
            // Set the correct shader to use
            shader.Use();
            // Draws the objects list
            obj.draw();
            // Swap the exibiting buffer & the drawing buffer (double buffering)
            SwapBuffers();
        }

        // Updates the program logic
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
            r++; g++; b++;
            GL.ClearColor(
                (float)Math.Sin(r * ratio),
                (float)Math.Cos(g * ratio),
                (float)Math.Tan(b * ratio),
                1.0f);
        }
    }
}
