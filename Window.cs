using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace _3dRender
{
    internal class Window : GameWindow
    {
        Object obj = new Object();
        private int r, g, b;
        private float ratio = 0.001f;

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        // Load the frame data
        protected override void OnLoad()
        {
            base.OnLoad();
            obj.load();
            GL.ClearColor(1.0f, 0.0f, 0.0f, 1.0f);
            
        }

        // Update the logic screen
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
            r++; g++ ; b++;
            GL.ClearColor((float)Math.Sin(r * ratio), (float)Math.Cos(g * ratio), (float)Math.Tan(b * ratio), 1.0f);
        }

        // draw the objects on screen
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            obj.draw();
            // double buffer
            SwapBuffers();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
