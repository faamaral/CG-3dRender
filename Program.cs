using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace HelloWindow
{
    public class Program
    {
        // Entry point (starts here)
        public static void Main()
        {
            // Cfg the window
            NativeWindowSettings cfg = new NativeWindowSettings()
            {
                Title = "Hello Window",
                Size = new Vector2i(640, 480),
                WindowBorder = WindowBorder.Fixed,
            };


            // Creating a window
            Window _window = new Window(GameWindowSettings.Default, cfg);
            _window.Run();
        }
    }
}